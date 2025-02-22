// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.DataShare.Models;

namespace Azure.ResourceManager.DataShare
{
    internal partial class ConsumerInvitationsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ConsumerInvitationsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ConsumerInvitationsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-08-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListInvitationsRequest(string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.DataShare/listInvitations", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skipToken != null)
            {
                uri.AppendQuery("$skipToken", skipToken, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists invitations. </summary>
        /// <param name="skipToken"> The continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ConsumerInvitationList>> ListInvitationsAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListInvitationsRequest(skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumerInvitationList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConsumerInvitationList.DeserializeConsumerInvitationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists invitations. </summary>
        /// <param name="skipToken"> The continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ConsumerInvitationList> ListInvitations(string skipToken = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateListInvitationsRequest(skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumerInvitationList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConsumerInvitationList.DeserializeConsumerInvitationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(AzureLocation location, string invitationId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.DataShare/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/consumerInvitations/", false);
            uri.AppendPath(invitationId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get an invitation. </summary>
        /// <param name="location"> Location of the invitation. </param>
        /// <param name="invitationId"> An invitation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="invitationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="invitationId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ConsumerInvitationData>> GetAsync(AzureLocation location, string invitationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(invitationId, nameof(invitationId));

            using var message = CreateGetRequest(location, invitationId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumerInvitationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConsumerInvitationData.DeserializeConsumerInvitationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ConsumerInvitationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get an invitation. </summary>
        /// <param name="location"> Location of the invitation. </param>
        /// <param name="invitationId"> An invitation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="invitationId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="invitationId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ConsumerInvitationData> Get(AzureLocation location, string invitationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(invitationId, nameof(invitationId));

            using var message = CreateGetRequest(location, invitationId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumerInvitationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConsumerInvitationData.DeserializeConsumerInvitationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ConsumerInvitationData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateRejectInvitationRequest(AzureLocation location, ConsumerInvitationData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.DataShare/locations/", false);
            uri.AppendPath(location, true);
            uri.AppendPath("/rejectInvitation", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Reject an invitation. </summary>
        /// <param name="location"> Location of the invitation. </param>
        /// <param name="data"> An invitation payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public async Task<Response<ConsumerInvitationData>> RejectInvitationAsync(AzureLocation location, ConsumerInvitationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateRejectInvitationRequest(location, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumerInvitationData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConsumerInvitationData.DeserializeConsumerInvitationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Reject an invitation. </summary>
        /// <param name="location"> Location of the invitation. </param>
        /// <param name="data"> An invitation payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public Response<ConsumerInvitationData> RejectInvitation(AzureLocation location, ConsumerInvitationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateRejectInvitationRequest(location, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumerInvitationData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConsumerInvitationData.DeserializeConsumerInvitationData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListInvitationsNextPageRequest(string nextLink, string skipToken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists invitations. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="skipToken"> The continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<ConsumerInvitationList>> ListInvitationsNextPageAsync(string nextLink, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListInvitationsNextPageRequest(nextLink, skipToken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumerInvitationList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ConsumerInvitationList.DeserializeConsumerInvitationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists invitations. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="skipToken"> The continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<ConsumerInvitationList> ListInvitationsNextPage(string nextLink, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));

            using var message = CreateListInvitationsNextPageRequest(nextLink, skipToken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ConsumerInvitationList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ConsumerInvitationList.DeserializeConsumerInvitationList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
