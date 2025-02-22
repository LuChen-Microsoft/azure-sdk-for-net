// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a WebSiteSlotTriggeredWebJob along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WebSiteSlotTriggeredWebJobResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWebSiteSlotTriggeredWebJobResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource" /> using the GetWebSiteSlotTriggeredWebJob method.
    /// </summary>
    public partial class WebSiteSlotTriggeredWebJobResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebSiteSlotTriggeredWebJobResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string webJobName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteSlotTriggeredWebJobWebAppsRestClient;
        private readonly TriggeredWebJobData _data;

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotTriggeredWebJobResource"/> class for mocking. </summary>
        protected WebSiteSlotTriggeredWebJobResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WebSiteSlotTriggeredWebJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebSiteSlotTriggeredWebJobResource(ArmClient client, TriggeredWebJobData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotTriggeredWebJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebSiteSlotTriggeredWebJobResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteSlotTriggeredWebJobWebAppsApiVersion);
            _webSiteSlotTriggeredWebJobWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotTriggeredWebJobWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/triggeredwebjobs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TriggeredWebJobData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of WebSiteSlotTriggeredWebJobHistoryResources in the WebSiteSlotTriggeredWebJob. </summary>
        /// <returns> An object representing collection of WebSiteSlotTriggeredWebJobHistoryResources and their operations over a WebSiteSlotTriggeredWebJobHistoryResource. </returns>
        public virtual WebSiteSlotTriggeredWebJobHistoryCollection GetWebSiteSlotTriggeredWebJobHistories()
        {
            return GetCachedClient(Client => new WebSiteSlotTriggeredWebJobHistoryCollection(Client, Id));
        }

        /// <summary>
        /// Description for Gets a triggered web job&apos;s history by its ID for an app, , or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistory
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<WebSiteSlotTriggeredWebJobHistoryResource>> GetWebSiteSlotTriggeredWebJobHistoryAsync(string id, CancellationToken cancellationToken = default)
        {
            return await GetWebSiteSlotTriggeredWebJobHistories().GetAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Gets a triggered web job&apos;s history by its ID for an app, , or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}
        /// Operation Id: WebApps_GetTriggeredWebJobHistory
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<WebSiteSlotTriggeredWebJobHistoryResource> GetWebSiteSlotTriggeredWebJobHistory(string id, CancellationToken cancellationToken = default)
        {
            return GetWebSiteSlotTriggeredWebJobHistories().Get(id, cancellationToken);
        }

        /// <summary>
        /// Description for Gets a triggered web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}
        /// Operation Id: WebApps_GetTriggeredWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WebSiteSlotTriggeredWebJobResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobResource.Get");
            scope.Start();
            try
            {
                var response = await _webSiteSlotTriggeredWebJobWebAppsRestClient.GetTriggeredWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotTriggeredWebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a triggered web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}
        /// Operation Id: WebApps_GetTriggeredWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WebSiteSlotTriggeredWebJobResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobResource.Get");
            scope.Start();
            try
            {
                var response = _webSiteSlotTriggeredWebJobWebAppsRestClient.GetTriggeredWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteSlotTriggeredWebJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Delete a triggered web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}
        /// Operation Id: WebApps_DeleteTriggeredWebJob
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobResource.Delete");
            scope.Start();
            try
            {
                var response = await _webSiteSlotTriggeredWebJobWebAppsRestClient.DeleteTriggeredWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Delete a triggered web job by its ID for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}
        /// Operation Id: WebApps_DeleteTriggeredWebJob
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobResource.Delete");
            scope.Start();
            try
            {
                var response = _webSiteSlotTriggeredWebJobWebAppsRestClient.DeleteTriggeredWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Run a triggered web job for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/run
        /// Operation Id: WebApps_RunTriggeredWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> RunAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobResource.Run");
            scope.Start();
            try
            {
                var response = await _webSiteSlotTriggeredWebJobWebAppsRestClient.RunTriggeredWebJobAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Run a triggered web job for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/run
        /// Operation Id: WebApps_RunTriggeredWebJob
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Run(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotTriggeredWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotTriggeredWebJobResource.Run");
            scope.Start();
            try
            {
                var response = _webSiteSlotTriggeredWebJobWebAppsRestClient.RunTriggeredWebJob(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
