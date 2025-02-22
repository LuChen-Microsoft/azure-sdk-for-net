// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Advisor.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Advisor
{
    /// <summary> A class representing the ResourceRecommendationBase data model. </summary>
    public partial class ResourceRecommendationBaseData : ResourceData
    {
        /// <summary> Initializes a new instance of ResourceRecommendationBaseData. </summary>
        public ResourceRecommendationBaseData()
        {
            Metadata = new ChangeTrackingDictionary<string, BinaryData>();
            SuppressionIds = new ChangeTrackingList<Guid>();
            ExtendedProperties = new ChangeTrackingDictionary<string, string>();
            Actions = new ChangeTrackingList<IDictionary<string, BinaryData>>();
            Remediation = new ChangeTrackingDictionary<string, BinaryData>();
            ExposedMetadataProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of ResourceRecommendationBaseData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="category"> The category of the recommendation. </param>
        /// <param name="impact"> The business impact of the recommendation. </param>
        /// <param name="impactedField"> The resource type identified by Advisor. </param>
        /// <param name="impactedValue"> The resource identified by Advisor. </param>
        /// <param name="lastUpdated"> The most recent time that Advisor checked the validity of the recommendation. </param>
        /// <param name="metadata"> The recommendation metadata. </param>
        /// <param name="recommendationTypeId"> The recommendation-type GUID. </param>
        /// <param name="risk"> The potential risk of not implementing the recommendation. </param>
        /// <param name="shortDescription"> A summary of the recommendation. </param>
        /// <param name="suppressionIds"> The list of snoozed and dismissed rules for the recommendation. </param>
        /// <param name="extendedProperties"> Extended properties. </param>
        /// <param name="resourceMetadata"> Metadata of resource that was assessed. </param>
        /// <param name="description"> The detailed description of recommendation. </param>
        /// <param name="label"> The label of recommendation. </param>
        /// <param name="learnMoreLink"> The link to learn more about recommendation and generation logic. </param>
        /// <param name="potentialBenefits"> The potential benefit of implementing recommendation. </param>
        /// <param name="actions"> The list of recommended actions to implement recommendation. </param>
        /// <param name="remediation"> The automated way to apply recommendation. </param>
        /// <param name="exposedMetadataProperties"> The recommendation metadata properties exposed to customer to provide additional information. </param>
        internal ResourceRecommendationBaseData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Category? category, Impact? impact, string impactedField, string impactedValue, DateTimeOffset? lastUpdated, IDictionary<string, BinaryData> metadata, string recommendationTypeId, Risk? risk, ShortDescription shortDescription, IList<Guid> suppressionIds, IDictionary<string, string> extendedProperties, ResourceMetadata resourceMetadata, string description, string label, string learnMoreLink, string potentialBenefits, IList<IDictionary<string, BinaryData>> actions, IDictionary<string, BinaryData> remediation, IDictionary<string, BinaryData> exposedMetadataProperties) : base(id, name, resourceType, systemData)
        {
            Category = category;
            Impact = impact;
            ImpactedField = impactedField;
            ImpactedValue = impactedValue;
            LastUpdated = lastUpdated;
            Metadata = metadata;
            RecommendationTypeId = recommendationTypeId;
            Risk = risk;
            ShortDescription = shortDescription;
            SuppressionIds = suppressionIds;
            ExtendedProperties = extendedProperties;
            ResourceMetadata = resourceMetadata;
            Description = description;
            Label = label;
            LearnMoreLink = learnMoreLink;
            PotentialBenefits = potentialBenefits;
            Actions = actions;
            Remediation = remediation;
            ExposedMetadataProperties = exposedMetadataProperties;
        }

        /// <summary> The category of the recommendation. </summary>
        public Category? Category { get; set; }
        /// <summary> The business impact of the recommendation. </summary>
        public Impact? Impact { get; set; }
        /// <summary> The resource type identified by Advisor. </summary>
        public string ImpactedField { get; set; }
        /// <summary> The resource identified by Advisor. </summary>
        public string ImpactedValue { get; set; }
        /// <summary> The most recent time that Advisor checked the validity of the recommendation. </summary>
        public DateTimeOffset? LastUpdated { get; set; }
        /// <summary> The recommendation metadata. </summary>
        public IDictionary<string, BinaryData> Metadata { get; }
        /// <summary> The recommendation-type GUID. </summary>
        public string RecommendationTypeId { get; set; }
        /// <summary> The potential risk of not implementing the recommendation. </summary>
        public Risk? Risk { get; set; }
        /// <summary> A summary of the recommendation. </summary>
        public ShortDescription ShortDescription { get; set; }
        /// <summary> The list of snoozed and dismissed rules for the recommendation. </summary>
        public IList<Guid> SuppressionIds { get; }
        /// <summary> Extended properties. </summary>
        public IDictionary<string, string> ExtendedProperties { get; }
        /// <summary> Metadata of resource that was assessed. </summary>
        public ResourceMetadata ResourceMetadata { get; set; }
        /// <summary> The detailed description of recommendation. </summary>
        public string Description { get; set; }
        /// <summary> The label of recommendation. </summary>
        public string Label { get; set; }
        /// <summary> The link to learn more about recommendation and generation logic. </summary>
        public string LearnMoreLink { get; set; }
        /// <summary> The potential benefit of implementing recommendation. </summary>
        public string PotentialBenefits { get; set; }
        /// <summary> The list of recommended actions to implement recommendation. </summary>
        public IList<IDictionary<string, BinaryData>> Actions { get; }
        /// <summary> The automated way to apply recommendation. </summary>
        public IDictionary<string, BinaryData> Remediation { get; }
        /// <summary> The recommendation metadata properties exposed to customer to provide additional information. </summary>
        public IDictionary<string, BinaryData> ExposedMetadataProperties { get; }
    }
}
