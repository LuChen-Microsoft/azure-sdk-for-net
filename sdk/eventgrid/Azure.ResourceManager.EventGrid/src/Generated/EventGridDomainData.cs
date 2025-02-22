// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    /// <summary> A class representing the EventGridDomain data model. </summary>
    public partial class EventGridDomainData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of EventGridDomainData. </summary>
        /// <param name="location"> The location. </param>
        public EventGridDomainData(AzureLocation location) : base(location)
        {
            PrivateEndpointConnections = new ChangeTrackingList<EventGridPrivateEndpointConnectionData>();
            InboundIPRules = new ChangeTrackingList<EventGridInboundIPRule>();
        }

        /// <summary> Initializes a new instance of EventGridDomainData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity information for the Event Grid Domain resource. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections. </param>
        /// <param name="provisioningState"> Provisioning state of the Event Grid Domain Resource. </param>
        /// <param name="endpointUri"> Endpoint for the Event Grid Domain Resource which is used for publishing the events. </param>
        /// <param name="inputSchema"> This determines the format that Event Grid should expect for incoming events published to the Event Grid Domain Resource. </param>
        /// <param name="inputSchemaMapping">
        /// Information about the InputSchemaMapping which specified the info about mapping event payload.
        /// Please note <see cref="EventGridInputSchemaMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EventGridJsonInputSchemaMapping"/>.
        /// </param>
        /// <param name="metricResourceId"> Metric resource id for the Event Grid Domain Resource. </param>
        /// <param name="publicNetworkAccess">
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso cref=&quot;P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.DomainProperties.InboundIpRules&quot; /&gt;
        /// </param>
        /// <param name="inboundIPRules"> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </param>
        /// <param name="isLocalAuthDisabled"> This boolean is used to enable or disable local auth. Default value is false. When the property is set to true, only AAD token will be used to authenticate if user is allowed to publish to the domain. </param>
        /// <param name="autoCreateTopicWithFirstSubscription">
        /// This Boolean is used to specify the creation mechanism for &apos;all&apos; the Event Grid Domain Topics associated with this Event Grid Domain resource.
        /// In this context, creation of domain topic can be auto-managed (when true) or self-managed (when false). The default value for this property is true.
        /// When this property is null or set to true, Event Grid is responsible of automatically creating the domain topic when the first event subscription is
        /// created at the scope of the domain topic. If this property is set to false, then creating the first event subscription will require creating a domain topic
        /// by the user. The self-management mode can be used if the user wants full control of when the domain topic is created, while auto-managed mode provides the
        /// flexibility to perform less operations and manage fewer resources by the user. Also, note that in auto-managed creation mode, user is allowed to create the
        /// domain topic on demand if needed.
        /// </param>
        /// <param name="autoDeleteTopicWithLastSubscription">
        /// This Boolean is used to specify the deletion mechanism for &apos;all&apos; the Event Grid Domain Topics associated with this Event Grid Domain resource.
        /// In this context, deletion of domain topic can be auto-managed (when true) or self-managed (when false). The default value for this property is true.
        /// When this property is set to true, Event Grid is responsible of automatically deleting the domain topic when the last event subscription at the scope
        /// of the domain topic is deleted. If this property is set to false, then the user needs to manually delete the domain topic when it is no longer needed
        /// (e.g., when last event subscription is deleted and the resource needs to be cleaned up). The self-management mode can be used if the user wants full
        /// control of when the domain topic needs to be deleted, while auto-managed mode provides the flexibility to perform less operations and manage fewer
        /// resources by the user.
        /// </param>
        /// <param name="dataResidencyBoundary"> Data Residency Boundary of the resource. </param>
        internal EventGridDomainData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, IReadOnlyList<EventGridPrivateEndpointConnectionData> privateEndpointConnections, EventGridDomainProvisioningState? provisioningState, Uri endpointUri, EventGridInputSchema? inputSchema, EventGridInputSchemaMapping inputSchemaMapping, string metricResourceId, EventGridPublicNetworkAccess? publicNetworkAccess, IList<EventGridInboundIPRule> inboundIPRules, bool? isLocalAuthDisabled, bool? autoCreateTopicWithFirstSubscription, bool? autoDeleteTopicWithLastSubscription, DataResidencyBoundary? dataResidencyBoundary) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            PrivateEndpointConnections = privateEndpointConnections;
            ProvisioningState = provisioningState;
            EndpointUri = endpointUri;
            InputSchema = inputSchema;
            InputSchemaMapping = inputSchemaMapping;
            MetricResourceId = metricResourceId;
            PublicNetworkAccess = publicNetworkAccess;
            InboundIPRules = inboundIPRules;
            IsLocalAuthDisabled = isLocalAuthDisabled;
            AutoCreateTopicWithFirstSubscription = autoCreateTopicWithFirstSubscription;
            AutoDeleteTopicWithLastSubscription = autoDeleteTopicWithLastSubscription;
            DataResidencyBoundary = dataResidencyBoundary;
        }

        /// <summary> Identity information for the Event Grid Domain resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> List of private endpoint connections. </summary>
        public IReadOnlyList<EventGridPrivateEndpointConnectionData> PrivateEndpointConnections { get; }
        /// <summary> Provisioning state of the Event Grid Domain Resource. </summary>
        public EventGridDomainProvisioningState? ProvisioningState { get; }
        /// <summary> Endpoint for the Event Grid Domain Resource which is used for publishing the events. </summary>
        public Uri EndpointUri { get; }
        /// <summary> This determines the format that Event Grid should expect for incoming events published to the Event Grid Domain Resource. </summary>
        public EventGridInputSchema? InputSchema { get; set; }
        /// <summary>
        /// Information about the InputSchemaMapping which specified the info about mapping event payload.
        /// Please note <see cref="EventGridInputSchemaMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EventGridJsonInputSchemaMapping"/>.
        /// </summary>
        public EventGridInputSchemaMapping InputSchemaMapping { get; set; }
        /// <summary> Metric resource id for the Event Grid Domain Resource. </summary>
        public string MetricResourceId { get; }
        /// <summary>
        /// This determines if traffic is allowed over public network. By default it is enabled.
        /// You can further restrict to specific IPs by configuring &lt;seealso cref=&quot;P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.DomainProperties.InboundIpRules&quot; /&gt;
        /// </summary>
        public EventGridPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> This can be used to restrict traffic from specific IPs instead of all IPs. Note: These are considered only if PublicNetworkAccess is enabled. </summary>
        public IList<EventGridInboundIPRule> InboundIPRules { get; }
        /// <summary> This boolean is used to enable or disable local auth. Default value is false. When the property is set to true, only AAD token will be used to authenticate if user is allowed to publish to the domain. </summary>
        public bool? IsLocalAuthDisabled { get; set; }
        /// <summary>
        /// This Boolean is used to specify the creation mechanism for &apos;all&apos; the Event Grid Domain Topics associated with this Event Grid Domain resource.
        /// In this context, creation of domain topic can be auto-managed (when true) or self-managed (when false). The default value for this property is true.
        /// When this property is null or set to true, Event Grid is responsible of automatically creating the domain topic when the first event subscription is
        /// created at the scope of the domain topic. If this property is set to false, then creating the first event subscription will require creating a domain topic
        /// by the user. The self-management mode can be used if the user wants full control of when the domain topic is created, while auto-managed mode provides the
        /// flexibility to perform less operations and manage fewer resources by the user. Also, note that in auto-managed creation mode, user is allowed to create the
        /// domain topic on demand if needed.
        /// </summary>
        public bool? AutoCreateTopicWithFirstSubscription { get; set; }
        /// <summary>
        /// This Boolean is used to specify the deletion mechanism for &apos;all&apos; the Event Grid Domain Topics associated with this Event Grid Domain resource.
        /// In this context, deletion of domain topic can be auto-managed (when true) or self-managed (when false). The default value for this property is true.
        /// When this property is set to true, Event Grid is responsible of automatically deleting the domain topic when the last event subscription at the scope
        /// of the domain topic is deleted. If this property is set to false, then the user needs to manually delete the domain topic when it is no longer needed
        /// (e.g., when last event subscription is deleted and the resource needs to be cleaned up). The self-management mode can be used if the user wants full
        /// control of when the domain topic needs to be deleted, while auto-managed mode provides the flexibility to perform less operations and manage fewer
        /// resources by the user.
        /// </summary>
        public bool? AutoDeleteTopicWithLastSubscription { get; set; }
        /// <summary> Data Residency Boundary of the resource. </summary>
        public DataResidencyBoundary? DataResidencyBoundary { get; set; }
    }
}
