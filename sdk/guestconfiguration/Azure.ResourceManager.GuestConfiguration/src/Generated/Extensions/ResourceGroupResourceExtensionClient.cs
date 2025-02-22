// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.GuestConfiguration
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics;
        private GuestConfigurationAssignmentsRestOperations _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics GuestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics => _guestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.GuestConfiguration", GuestConfigurationVmAssignmentResource.ResourceType.Namespace, Diagnostics);
        private GuestConfigurationAssignmentsRestOperations GuestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient => _guestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient ??= new GuestConfigurationAssignmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(GuestConfigurationVmAssignmentResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of GuestConfigurationVmAssignmentResources in the ResourceGroupResource. </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <returns> An object representing collection of GuestConfigurationVmAssignmentResources and their operations over a GuestConfigurationVmAssignmentResource. </returns>
        public virtual GuestConfigurationVmAssignmentCollection GetGuestConfigurationVmAssignments(string vmName)
        {
            return new GuestConfigurationVmAssignmentCollection(Client, Id, vmName);
        }

        /// <summary> Gets a collection of GuestConfigurationHcrpAssignmentResources in the ResourceGroupResource. </summary>
        /// <param name="machineName"> The name of the ARC machine. </param>
        /// <returns> An object representing collection of GuestConfigurationHcrpAssignmentResources and their operations over a GuestConfigurationHcrpAssignmentResource. </returns>
        public virtual GuestConfigurationHcrpAssignmentCollection GetGuestConfigurationHcrpAssignments(string machineName)
        {
            return new GuestConfigurationHcrpAssignmentCollection(Client, Id, machineName);
        }

        /// <summary> Gets a collection of GuestConfigurationVmssAssignmentResources in the ResourceGroupResource. </summary>
        /// <param name="vmssName"> The name of the virtual machine scale set. </param>
        /// <returns> An object representing collection of GuestConfigurationVmssAssignmentResources and their operations over a GuestConfigurationVmssAssignmentResource. </returns>
        public virtual GuestConfigurationVmssAssignmentCollection GetGuestConfigurationVmssAssignments(string vmssName)
        {
            return new GuestConfigurationVmssAssignmentCollection(Client, Id, vmssName);
        }

        /// <summary>
        /// List all guest configuration assignments for a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments
        /// Operation Id: GuestConfigurationAssignments_RGList
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GuestConfigurationAssignmentData" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GuestConfigurationAssignmentData> GetGuestConfigurationAssignmentsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GuestConfigurationAssignmentData>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = GuestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetGuestConfigurationAssignments");
                scope.Start();
                try
                {
                    var response = await GuestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.RGListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List all guest configuration assignments for a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.GuestConfiguration/guestConfigurationAssignments
        /// Operation Id: GuestConfigurationAssignments_RGList
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GuestConfigurationAssignmentData" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GuestConfigurationAssignmentData> GetGuestConfigurationAssignments(CancellationToken cancellationToken = default)
        {
            Page<GuestConfigurationAssignmentData> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = GuestConfigurationVmAssignmentGuestConfigurationAssignmentsClientDiagnostics.CreateScope("ResourceGroupResourceExtensionClient.GetGuestConfigurationAssignments");
                scope.Start();
                try
                {
                    var response = GuestConfigurationVmAssignmentGuestConfigurationAssignmentsRestClient.RGList(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
