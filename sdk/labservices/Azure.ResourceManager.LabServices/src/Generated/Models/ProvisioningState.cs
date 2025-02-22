// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Resource provisioning state. </summary>
    public enum ProvisioningState
    {
        /// <summary> Resource is in the process of being created. </summary>
        Creating,
        /// <summary> New property values are being applied to the resource. </summary>
        Updating,
        /// <summary> Resource is in the process of being deleted. </summary>
        Deleting,
        /// <summary> Resource is in healthy state after creation or update operation. </summary>
        Succeeded,
        /// <summary> Previous operation on the resource has failed leaving resource in unhealthy state. </summary>
        Failed,
        /// <summary> The resource is locked and changes are currently blocked. This could be due to maintenance or a scheduled operation. The state will go back to succeeded once the locking operation has finished. </summary>
        Locked
    }
}
