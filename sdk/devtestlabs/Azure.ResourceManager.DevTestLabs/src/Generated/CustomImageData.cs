// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary> A class representing the CustomImage data model. </summary>
    public partial class CustomImageData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of CustomImageData. </summary>
        /// <param name="location"> The location. </param>
        public CustomImageData(AzureLocation location) : base(location)
        {
            DataDiskStorageInfo = new ChangeTrackingList<DataDiskStorageTypeInfo>();
        }

        /// <summary> Initializes a new instance of CustomImageData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="vm"> The virtual machine from which the image is to be created. </param>
        /// <param name="vhd"> The VHD from which the image is to be created. </param>
        /// <param name="description"> The description of the custom image. </param>
        /// <param name="author"> The author of the custom image. </param>
        /// <param name="createdOn"> The creation date of the custom image. </param>
        /// <param name="managedImageId"> The Managed Image Id backing the custom image. </param>
        /// <param name="managedSnapshotId"> The Managed Snapshot Id backing the custom image. </param>
        /// <param name="dataDiskStorageInfo"> Storage information about the data disks present in the custom image. </param>
        /// <param name="customImagePlan"> Storage information about the plan related to this custom image. </param>
        /// <param name="isPlanAuthorized"> Whether or not the custom images underlying offer/plan has been enabled for programmatic deployment. </param>
        /// <param name="provisioningState"> The provisioning status of the resource. </param>
        /// <param name="uniqueIdentifier"> The unique immutable identifier of a resource (Guid). </param>
        internal CustomImageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, CustomImagePropertiesFromVm vm, CustomImagePropertiesCustom vhd, string description, string author, DateTimeOffset? createdOn, string managedImageId, string managedSnapshotId, IList<DataDiskStorageTypeInfo> dataDiskStorageInfo, CustomImagePropertiesFromPlan customImagePlan, bool? isPlanAuthorized, string provisioningState, string uniqueIdentifier) : base(id, name, resourceType, systemData, tags, location)
        {
            Vm = vm;
            Vhd = vhd;
            Description = description;
            Author = author;
            CreatedOn = createdOn;
            ManagedImageId = managedImageId;
            ManagedSnapshotId = managedSnapshotId;
            DataDiskStorageInfo = dataDiskStorageInfo;
            CustomImagePlan = customImagePlan;
            IsPlanAuthorized = isPlanAuthorized;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
        }

        /// <summary> The virtual machine from which the image is to be created. </summary>
        public CustomImagePropertiesFromVm Vm { get; set; }
        /// <summary> The VHD from which the image is to be created. </summary>
        public CustomImagePropertiesCustom Vhd { get; set; }
        /// <summary> The description of the custom image. </summary>
        public string Description { get; set; }
        /// <summary> The author of the custom image. </summary>
        public string Author { get; set; }
        /// <summary> The creation date of the custom image. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The Managed Image Id backing the custom image. </summary>
        public string ManagedImageId { get; set; }
        /// <summary> The Managed Snapshot Id backing the custom image. </summary>
        public string ManagedSnapshotId { get; set; }
        /// <summary> Storage information about the data disks present in the custom image. </summary>
        public IList<DataDiskStorageTypeInfo> DataDiskStorageInfo { get; }
        /// <summary> Storage information about the plan related to this custom image. </summary>
        public CustomImagePropertiesFromPlan CustomImagePlan { get; set; }
        /// <summary> Whether or not the custom images underlying offer/plan has been enabled for programmatic deployment. </summary>
        public bool? IsPlanAuthorized { get; set; }
        /// <summary> The provisioning status of the resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> The unique immutable identifier of a resource (Guid). </summary>
        public string UniqueIdentifier { get; }
    }
}
