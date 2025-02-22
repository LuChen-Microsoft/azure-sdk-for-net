// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Marketplace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Marketplace
{
    public partial class RequestApprovalResourceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(OfferId))
            {
                writer.WritePropertyName("offerId");
                writer.WriteStringValue(OfferId);
            }
            if (Optional.IsDefined(PublisherId))
            {
                writer.WritePropertyName("publisherId");
                writer.WriteStringValue(PublisherId);
            }
            if (Optional.IsCollectionDefined(PlansDetails))
            {
                writer.WritePropertyName("plansDetails");
                writer.WriteStartArray();
                foreach (var item in PlansDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MessageCode))
            {
                writer.WritePropertyName("messageCode");
                writer.WriteNumberValue(MessageCode.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RequestApprovalResourceData DeserializeRequestApprovalResourceData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> offerId = default;
            Optional<string> offerDisplayName = default;
            Optional<string> publisherId = default;
            Optional<IList<PlanDetails>> plansDetails = default;
            Optional<bool> isClosed = default;
            Optional<long> messageCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("offerId"))
                        {
                            offerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("offerDisplayName"))
                        {
                            offerDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherId"))
                        {
                            publisherId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("plansDetails"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<PlanDetails> array = new List<PlanDetails>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PlanDetails.DeserializePlanDetails(item));
                            }
                            plansDetails = array;
                            continue;
                        }
                        if (property0.NameEquals("isClosed"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isClosed = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("messageCode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            messageCode = property0.Value.GetInt64();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RequestApprovalResourceData(id, name, type, systemData.Value, offerId.Value, offerDisplayName.Value, publisherId.Value, Optional.ToList(plansDetails), Optional.ToNullable(isClosed), Optional.ToNullable(messageCode));
        }
    }
}
