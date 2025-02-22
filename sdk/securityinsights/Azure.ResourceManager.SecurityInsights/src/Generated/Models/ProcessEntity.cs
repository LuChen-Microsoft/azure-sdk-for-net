// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Represents a process entity. </summary>
    public partial class ProcessEntity : EntityData
    {
        /// <summary> Initializes a new instance of ProcessEntity. </summary>
        public ProcessEntity()
        {
            AdditionalData = new ChangeTrackingDictionary<string, BinaryData>();
            Kind = EntityKind.Process;
        }

        /// <summary> Initializes a new instance of ProcessEntity. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="additionalData"> A bag of custom fields that should be part of the entity and will be presented to the user. </param>
        /// <param name="friendlyName"> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </param>
        /// <param name="accountEntityId"> The account entity id running the processes. </param>
        /// <param name="commandLine"> The command line used to create the process. </param>
        /// <param name="creationTimeUtc"> The time when the process started to run. </param>
        /// <param name="elevationToken"> The elevation token associated with the process. </param>
        /// <param name="hostEntityId"> The host entity id on which the process was running. </param>
        /// <param name="hostLogonSessionEntityId"> The session entity id in which the process was running. </param>
        /// <param name="imageFileEntityId"> Image file entity id. </param>
        /// <param name="parentProcessEntityId"> The parent process entity id. </param>
        /// <param name="processId"> The process ID. </param>
        internal ProcessEntity(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, EntityKind kind, IReadOnlyDictionary<string, BinaryData> additionalData, string friendlyName, string accountEntityId, string commandLine, DateTimeOffset? creationTimeUtc, ElevationToken? elevationToken, string hostEntityId, string hostLogonSessionEntityId, string imageFileEntityId, string parentProcessEntityId, string processId) : base(id, name, resourceType, systemData, kind)
        {
            AdditionalData = additionalData;
            FriendlyName = friendlyName;
            AccountEntityId = accountEntityId;
            CommandLine = commandLine;
            CreationTimeUtc = creationTimeUtc;
            ElevationToken = elevationToken;
            HostEntityId = hostEntityId;
            HostLogonSessionEntityId = hostLogonSessionEntityId;
            ImageFileEntityId = imageFileEntityId;
            ParentProcessEntityId = parentProcessEntityId;
            ProcessId = processId;
            Kind = kind;
        }

        /// <summary> A bag of custom fields that should be part of the entity and will be presented to the user. </summary>
        public IReadOnlyDictionary<string, BinaryData> AdditionalData { get; }
        /// <summary> The graph item display name which is a short humanly readable description of the graph item instance. This property is optional and might be system generated. </summary>
        public string FriendlyName { get; }
        /// <summary> The account entity id running the processes. </summary>
        public string AccountEntityId { get; }
        /// <summary> The command line used to create the process. </summary>
        public string CommandLine { get; }
        /// <summary> The time when the process started to run. </summary>
        public DateTimeOffset? CreationTimeUtc { get; }
        /// <summary> The elevation token associated with the process. </summary>
        public ElevationToken? ElevationToken { get; set; }
        /// <summary> The host entity id on which the process was running. </summary>
        public string HostEntityId { get; }
        /// <summary> The session entity id in which the process was running. </summary>
        public string HostLogonSessionEntityId { get; }
        /// <summary> Image file entity id. </summary>
        public string ImageFileEntityId { get; }
        /// <summary> The parent process entity id. </summary>
        public string ParentProcessEntityId { get; }
        /// <summary> The process ID. </summary>
        public string ProcessId { get; }
    }
}
