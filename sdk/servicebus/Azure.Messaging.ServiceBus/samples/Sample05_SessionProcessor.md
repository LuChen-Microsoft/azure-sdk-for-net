# Using the session processor

This sample demonstrates how to use the session processor. The session processor offers automatic completion of processed session messages, automatic session lock renewal, and concurrent execution of user specified event handlers.

## Processing messages from a session-enabled queue

Processing session messages is performed with a `ServiceBusSessionProcessor`. This type derives from `ServiceBusProcessor` and exposes session-related functionality.

```C# Snippet:ServiceBusProcessSessionMessages
string connectionString = "<connection_string>";
string queueName = "<queue_name>";
// since ServiceBusClient implements IAsyncDisposable we create it with "await using"
await using var client = new ServiceBusClient(connectionString);

// create the sender
ServiceBusSender sender = client.CreateSender(queueName);

// create a message batch that we can send
ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();
messageBatch.TryAddMessage(
    new ServiceBusMessage("First")
    {
        SessionId = "Session1"
    });
messageBatch.TryAddMessage(
    new ServiceBusMessage("Second")
    {
        SessionId = "Session2"
    });

// send the message batch
await sender.SendMessagesAsync(messageBatch);

// create the options to use for configuring the processor
var options = new ServiceBusSessionProcessorOptions
{
    // By default after the message handler returns, the processor will complete the message
    // If I want more fine-grained control over settlement, I can set this to false.
    AutoCompleteMessages = false,

    // I can also allow for processing multiple sessions
    MaxConcurrentSessions = 5,

    // By default or when AutoCompleteMessages is set to true, the processor will complete the message after executing the message handler
    // Set AutoCompleteMessages to false to [settle messages](https://docs.microsoft.com/en-us/azure/service-bus-messaging/message-transfers-locks-settlement#peeklock) on your own.
    // In both cases, if the message handler throws an exception without settling the message, the processor will abandon the message.
    MaxConcurrentCallsPerSession = 2,

    // Processing can be optionally limited to a subset of session Ids.
    SessionIds = { "my-session", "your-session" },
};

// create a session processor that we can use to process the messages
await using ServiceBusSessionProcessor processor = client.CreateSessionProcessor(queueName, options);

// configure the message and error handler to use
processor.ProcessMessageAsync += MessageHandler;
processor.ProcessErrorAsync += ErrorHandler;

async Task MessageHandler(ProcessSessionMessageEventArgs args)
{
    var body = args.Message.Body.ToString();

    // we can evaluate application logic and use that to determine how to settle the message.
    await args.CompleteMessageAsync(args.Message);

    // we can also set arbitrary session state using this receiver
    // the state is specific to the session, and not any particular message
    await args.SetSessionStateAsync(new BinaryData("some state"));
}

Task ErrorHandler(ProcessErrorEventArgs args)
{
    // the error source tells me at what point in the processing an error occurred
    Console.WriteLine(args.ErrorSource);
    // the fully qualified namespace is available
    Console.WriteLine(args.FullyQualifiedNamespace);
    // as well as the entity path
    Console.WriteLine(args.EntityPath);
    Console.WriteLine(args.Exception.ToString());
    return Task.CompletedTask;
}

// start processing
await processor.StartProcessingAsync();

// since the processing happens in the background, we add a Conole.ReadKey to allow the processing to continue until a key is pressed.
Console.ReadKey();
```

## Source

To see the full example source, see:

* [Sample05_SessionProcessor.cs](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/servicebus/Azure.Messaging.ServiceBus/tests/Samples/Sample05_SessionProcessor.cs)
