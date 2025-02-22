// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class AddActionGroups : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("actionGroupIds");
            writer.WriteStartArray();
            foreach (var item in ActionGroupIds)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("actionType");
            writer.WriteStringValue(ActionType.ToString());
            writer.WriteEndObject();
        }

        internal static AddActionGroups DeserializeAddActionGroups(JsonElement element)
        {
            IList<ResourceIdentifier> actionGroupIds = default;
            AlertProcessingActionType actionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionGroupIds"))
                {
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ResourceIdentifier(item.GetString()));
                    }
                    actionGroupIds = array;
                    continue;
                }
                if (property.NameEquals("actionType"))
                {
                    actionType = new AlertProcessingActionType(property.Value.GetString());
                    continue;
                }
            }
            return new AddActionGroups(actionType, actionGroupIds);
        }
    }
}
