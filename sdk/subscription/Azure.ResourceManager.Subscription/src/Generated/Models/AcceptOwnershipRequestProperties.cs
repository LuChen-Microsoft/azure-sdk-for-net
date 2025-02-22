// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary> Accept subscription ownership request properties. </summary>
    public partial class AcceptOwnershipRequestProperties
    {
        /// <summary> Initializes a new instance of AcceptOwnershipRequestProperties. </summary>
        /// <param name="displayName"> The friendly name of the subscription. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="displayName"/> is null. </exception>
        public AcceptOwnershipRequestProperties(string displayName)
        {
            if (displayName == null)
            {
                throw new ArgumentNullException(nameof(displayName));
            }

            DisplayName = displayName;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> The friendly name of the subscription. </summary>
        public string DisplayName { get; }
        /// <summary> Management group Id for the subscription. </summary>
        public string ManagementGroupId { get; set; }
        /// <summary> Tags for the subscription. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
