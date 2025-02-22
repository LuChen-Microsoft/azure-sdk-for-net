// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Rule to place restrictions on portions of the cache namespace being presented to clients. </summary>
    public partial class NfsAccessRule
    {
        /// <summary> Initializes a new instance of NfsAccessRule. </summary>
        /// <param name="scope"> Scope for this rule. The scope and filter determine which clients match the rule. </param>
        /// <param name="access"> Access allowed by this rule. </param>
        public NfsAccessRule(NfsAccessRuleScope scope, NfsAccessRuleAccess access)
        {
            Scope = scope;
            Access = access;
        }

        /// <summary> Initializes a new instance of NfsAccessRule. </summary>
        /// <param name="scope"> Scope for this rule. The scope and filter determine which clients match the rule. </param>
        /// <param name="filter"> Filter applied to the scope for this rule. The filter&apos;s format depends on its scope. &apos;default&apos; scope matches all clients and has no filter value. &apos;network&apos; scope takes a filter in CIDR format (for example, 10.99.1.0/24). &apos;host&apos; takes an IP address or fully qualified domain name as filter. If a client does not match any filter rule and there is no default rule, access is denied. </param>
        /// <param name="access"> Access allowed by this rule. </param>
        /// <param name="suid"> Allow SUID semantics. </param>
        /// <param name="submountAccess"> For the default policy, allow access to subdirectories under the root export. If this is set to no, clients can only mount the path &apos;/&apos;. If set to yes, clients can mount a deeper path, like &apos;/a/b&apos;. </param>
        /// <param name="rootSquash"> Map root accesses to anonymousUID and anonymousGID. </param>
        /// <param name="anonymousUID"> UID value that replaces 0 when rootSquash is true. 65534 will be used if not provided. </param>
        /// <param name="anonymousGID"> GID value that replaces 0 when rootSquash is true. This will use the value of anonymousUID if not provided. </param>
        internal NfsAccessRule(NfsAccessRuleScope scope, string filter, NfsAccessRuleAccess access, bool? suid, bool? submountAccess, bool? rootSquash, string anonymousUID, string anonymousGID)
        {
            Scope = scope;
            Filter = filter;
            Access = access;
            Suid = suid;
            SubmountAccess = submountAccess;
            RootSquash = rootSquash;
            AnonymousUID = anonymousUID;
            AnonymousGID = anonymousGID;
        }

        /// <summary> Scope for this rule. The scope and filter determine which clients match the rule. </summary>
        public NfsAccessRuleScope Scope { get; set; }
        /// <summary> Filter applied to the scope for this rule. The filter&apos;s format depends on its scope. &apos;default&apos; scope matches all clients and has no filter value. &apos;network&apos; scope takes a filter in CIDR format (for example, 10.99.1.0/24). &apos;host&apos; takes an IP address or fully qualified domain name as filter. If a client does not match any filter rule and there is no default rule, access is denied. </summary>
        public string Filter { get; set; }
        /// <summary> Access allowed by this rule. </summary>
        public NfsAccessRuleAccess Access { get; set; }
        /// <summary> Allow SUID semantics. </summary>
        public bool? Suid { get; set; }
        /// <summary> For the default policy, allow access to subdirectories under the root export. If this is set to no, clients can only mount the path &apos;/&apos;. If set to yes, clients can mount a deeper path, like &apos;/a/b&apos;. </summary>
        public bool? SubmountAccess { get; set; }
        /// <summary> Map root accesses to anonymousUID and anonymousGID. </summary>
        public bool? RootSquash { get; set; }
        /// <summary> UID value that replaces 0 when rootSquash is true. 65534 will be used if not provided. </summary>
        public string AnonymousUID { get; set; }
        /// <summary> GID value that replaces 0 when rootSquash is true. This will use the value of anonymousUID if not provided. </summary>
        public string AnonymousGID { get; set; }
    }
}
