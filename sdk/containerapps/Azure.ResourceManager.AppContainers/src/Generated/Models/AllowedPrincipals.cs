// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> The configuration settings of the Azure Active Directory allowed principals. </summary>
    public partial class AllowedPrincipals
    {
        /// <summary> Initializes a new instance of AllowedPrincipals. </summary>
        public AllowedPrincipals()
        {
            Groups = new ChangeTrackingList<string>();
            Identities = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of AllowedPrincipals. </summary>
        /// <param name="groups"> The list of the allowed groups. </param>
        /// <param name="identities"> The list of the allowed identities. </param>
        internal AllowedPrincipals(IList<string> groups, IList<string> identities)
        {
            Groups = groups;
            Identities = identities;
        }

        /// <summary> The list of the allowed groups. </summary>
        public IList<string> Groups { get; }
        /// <summary> The list of the allowed identities. </summary>
        public IList<string> Identities { get; }
    }
}
