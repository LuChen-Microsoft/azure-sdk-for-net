// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotCentral.Models
{
    internal partial class IotCentralAppTemplatesResult
    {
        internal static IotCentralAppTemplatesResult DeserializeIotCentralAppTemplatesResult(JsonElement element)
        {
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<IotCentralAppTemplate>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IotCentralAppTemplate> array = new List<IotCentralAppTemplate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotCentralAppTemplate.DeserializeIotCentralAppTemplate(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new IotCentralAppTemplatesResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
