// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class DataTransferRegionalService
    {
        internal static DataTransferRegionalService DeserializeDataTransferRegionalService(JsonElement element)
        {
            Optional<string> name = default;
            Optional<AzureLocation> location = default;
            Optional<CosmosDBServiceStatus> status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new CosmosDBServiceStatus(property.Value.GetString());
                    continue;
                }
            }
            return new DataTransferRegionalService(name.Value, Optional.ToNullable(location), Optional.ToNullable(status));
        }
    }
}
