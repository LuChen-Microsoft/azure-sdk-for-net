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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a DiscoveredSecuritySolution along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="DiscoveredSecuritySolutionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetDiscoveredSecuritySolutionResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetDiscoveredSecuritySolution method.
    /// </summary>
    public partial class DiscoveredSecuritySolutionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="DiscoveredSecuritySolutionResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string ascLocation, string discoveredSecuritySolutionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/discoveredSecuritySolutions/{discoveredSecuritySolutionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _discoveredSecuritySolutionClientDiagnostics;
        private readonly DiscoveredSecuritySolutionsRestOperations _discoveredSecuritySolutionRestClient;
        private readonly DiscoveredSecuritySolutionData _data;

        /// <summary> Initializes a new instance of the <see cref="DiscoveredSecuritySolutionResource"/> class for mocking. </summary>
        protected DiscoveredSecuritySolutionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "DiscoveredSecuritySolutionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal DiscoveredSecuritySolutionResource(ArmClient client, DiscoveredSecuritySolutionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="DiscoveredSecuritySolutionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal DiscoveredSecuritySolutionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _discoveredSecuritySolutionClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string discoveredSecuritySolutionApiVersion);
            _discoveredSecuritySolutionRestClient = new DiscoveredSecuritySolutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, discoveredSecuritySolutionApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/locations/discoveredSecuritySolutions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DiscoveredSecuritySolutionData Data
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

        /// <summary>
        /// Gets a specific discovered Security Solution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/discoveredSecuritySolutions/{discoveredSecuritySolutionName}
        /// Operation Id: DiscoveredSecuritySolutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DiscoveredSecuritySolutionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _discoveredSecuritySolutionClientDiagnostics.CreateScope("DiscoveredSecuritySolutionResource.Get");
            scope.Start();
            try
            {
                var response = await _discoveredSecuritySolutionRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiscoveredSecuritySolutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a specific discovered Security Solution.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Security/locations/{ascLocation}/discoveredSecuritySolutions/{discoveredSecuritySolutionName}
        /// Operation Id: DiscoveredSecuritySolutions_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DiscoveredSecuritySolutionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _discoveredSecuritySolutionClientDiagnostics.CreateScope("DiscoveredSecuritySolutionResource.Get");
            scope.Start();
            try
            {
                var response = _discoveredSecuritySolutionRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiscoveredSecuritySolutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
