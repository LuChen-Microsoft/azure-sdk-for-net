# SetUp

To use these samples, you'll first need to set up resources. See [getting started](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/monitor/Azure.Monitor.Ingestion/README.md#getting-started) for details.

## Verify logs

You can verify that your data has been uploaded correctly by using the [Azure.Monitor.Query](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/monitor/Azure.Monitor.Query/README.md#install-the-package) library. Run the [Upload custom logs](#upload-custom-logs) sample first before verifying the logs. 

```C# Snippet:VerifyLogs
var workspaceId = "...";
var tableName = "...";

TokenCredential credential = new DefaultAzureCredential();

LogsQueryClient logsQueryClient = new(credential);
LogsBatchQuery batch = new();
string query = tableName + " | count;";
string countQueryId = batch.AddWorkspaceQuery(
    workspaceId,
    query,
    new QueryTimeRange(TimeSpan.FromDays(1)));

Response<LogsBatchQueryResultCollection> queryResponse = logsQueryClient.QueryBatch(batch);

Console.WriteLine("Table entry count: " + queryResponse.Value.GetResult<int>(countQueryId).Single());
```

To see the full example source files, see [Query](https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/monitor/Azure.Monitor.Ingestion/tests/Samples/LogDataAndQuery.cs).