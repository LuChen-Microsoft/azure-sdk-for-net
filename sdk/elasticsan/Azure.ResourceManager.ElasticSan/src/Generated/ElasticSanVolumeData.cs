// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ElasticSan.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ElasticSan
{
    /// <summary> A class representing the ElasticSanVolume data model. </summary>
    public partial class ElasticSanVolumeData : ResourceData
    {
        /// <summary> Initializes a new instance of ElasticSanVolumeData. </summary>
        public ElasticSanVolumeData()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of ElasticSanVolumeData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="elasticSanVolumeId"> Unique Id of the volume in GUID format. </param>
        /// <param name="creationData"> State of the operation on the resource. </param>
        /// <param name="sizeGiB"> Volume size. </param>
        /// <param name="storageTarget"> Storage target information. </param>
        /// <param name="tags"> Azure resource tags. </param>
        internal ElasticSanVolumeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string elasticSanVolumeId, SourceCreationData creationData, long? sizeGiB, IscsiTargetInfo storageTarget, IDictionary<string, string> tags) : base(id, name, resourceType, systemData)
        {
            ElasticSanVolumeId = elasticSanVolumeId;
            CreationData = creationData;
            SizeGiB = sizeGiB;
            StorageTarget = storageTarget;
            Tags = tags;
        }

        /// <summary> Unique Id of the volume in GUID format. </summary>
        public string ElasticSanVolumeId { get; }
        /// <summary> State of the operation on the resource. </summary>
        public SourceCreationData CreationData { get; set; }
        /// <summary> Volume size. </summary>
        public long? SizeGiB { get; set; }
        /// <summary> Storage target information. </summary>
        public IscsiTargetInfo StorageTarget { get; }
        /// <summary> Azure resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
