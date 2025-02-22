// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class IotSecuritySolutionAnalyticsModelList
    {
        internal static IotSecuritySolutionAnalyticsModelList DeserializeIotSecuritySolutionAnalyticsModelList(JsonElement element)
        {
            IReadOnlyList<IotSecuritySolutionAnalyticsModelData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<IotSecuritySolutionAnalyticsModelData> array = new List<IotSecuritySolutionAnalyticsModelData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotSecuritySolutionAnalyticsModelData.DeserializeIotSecuritySolutionAnalyticsModelData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new IotSecuritySolutionAnalyticsModelList(value, nextLink.Value);
        }
    }
}
