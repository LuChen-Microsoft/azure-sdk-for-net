// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownJobOutput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description");
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            writer.WritePropertyName("jobOutputType");
            writer.WriteStringValue(JobOutputType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownJobOutput DeserializeUnknownJobOutput(JsonElement element)
        {
            Optional<string> description = default;
            JobOutputType jobOutputType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobOutputType"))
                {
                    jobOutputType = new JobOutputType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownJobOutput(description.Value, jobOutputType);
        }
    }
}
