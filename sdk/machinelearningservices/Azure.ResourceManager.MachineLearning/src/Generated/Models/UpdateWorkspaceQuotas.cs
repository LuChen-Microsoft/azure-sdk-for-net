// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The properties for update Quota response. </summary>
    public partial class UpdateWorkspaceQuotas
    {
        /// <summary> Initializes a new instance of UpdateWorkspaceQuotas. </summary>
        internal UpdateWorkspaceQuotas()
        {
        }

        /// <summary> Initializes a new instance of UpdateWorkspaceQuotas. </summary>
        /// <param name="id"> Specifies the resource ID. </param>
        /// <param name="updateWorkspaceQuotasType"> Specifies the resource type. </param>
        /// <param name="limit"> The maximum permitted quota of the resource. </param>
        /// <param name="unit"> An enum describing the unit of quota measurement. </param>
        /// <param name="status"> Status of update workspace quota. </param>
        internal UpdateWorkspaceQuotas(string id, string updateWorkspaceQuotasType, long? limit, QuotaUnit? unit, Status? status)
        {
            Id = id;
            UpdateWorkspaceQuotasType = updateWorkspaceQuotasType;
            Limit = limit;
            Unit = unit;
            Status = status;
        }

        /// <summary> Specifies the resource ID. </summary>
        public string Id { get; }
        /// <summary> Specifies the resource type. </summary>
        public string UpdateWorkspaceQuotasType { get; }
        /// <summary> The maximum permitted quota of the resource. </summary>
        public long? Limit { get; }
        /// <summary> An enum describing the unit of quota measurement. </summary>
        public QuotaUnit? Unit { get; }
        /// <summary> Status of update workspace quota. </summary>
        public Status? Status { get; }
    }
}
