// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeExportPolicyRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RuleIndex))
            {
                writer.WritePropertyName("ruleIndex");
                writer.WriteNumberValue(RuleIndex.Value);
            }
            if (Optional.IsDefined(IsUnixReadOnly))
            {
                writer.WritePropertyName("unixReadOnly");
                writer.WriteBooleanValue(IsUnixReadOnly.Value);
            }
            if (Optional.IsDefined(IsUnixReadWrite))
            {
                writer.WritePropertyName("unixReadWrite");
                writer.WriteBooleanValue(IsUnixReadWrite.Value);
            }
            if (Optional.IsDefined(IsKerberos5ReadOnly))
            {
                writer.WritePropertyName("kerberos5ReadOnly");
                writer.WriteBooleanValue(IsKerberos5ReadOnly.Value);
            }
            if (Optional.IsDefined(IsKerberos5ReadWrite))
            {
                writer.WritePropertyName("kerberos5ReadWrite");
                writer.WriteBooleanValue(IsKerberos5ReadWrite.Value);
            }
            if (Optional.IsDefined(IsKerberos5iReadOnly))
            {
                writer.WritePropertyName("kerberos5iReadOnly");
                writer.WriteBooleanValue(IsKerberos5iReadOnly.Value);
            }
            if (Optional.IsDefined(IsKerberos5iReadWrite))
            {
                writer.WritePropertyName("kerberos5iReadWrite");
                writer.WriteBooleanValue(IsKerberos5iReadWrite.Value);
            }
            if (Optional.IsDefined(IsKerberos5pReadOnly))
            {
                writer.WritePropertyName("kerberos5pReadOnly");
                writer.WriteBooleanValue(IsKerberos5pReadOnly.Value);
            }
            if (Optional.IsDefined(IsKerberos5pReadWrite))
            {
                writer.WritePropertyName("kerberos5pReadWrite");
                writer.WriteBooleanValue(IsKerberos5pReadWrite.Value);
            }
            if (Optional.IsDefined(AllowCifsProtocol))
            {
                writer.WritePropertyName("cifs");
                writer.WriteBooleanValue(AllowCifsProtocol.Value);
            }
            if (Optional.IsDefined(AllowNfsV3Protocol))
            {
                writer.WritePropertyName("nfsv3");
                writer.WriteBooleanValue(AllowNfsV3Protocol.Value);
            }
            if (Optional.IsDefined(AllowNfsV41Protocol))
            {
                writer.WritePropertyName("nfsv41");
                writer.WriteBooleanValue(AllowNfsV41Protocol.Value);
            }
            if (Optional.IsDefined(AllowedClients))
            {
                writer.WritePropertyName("allowedClients");
                writer.WriteStringValue(AllowedClients);
            }
            if (Optional.IsDefined(HasRootAccess))
            {
                writer.WritePropertyName("hasRootAccess");
                writer.WriteBooleanValue(HasRootAccess.Value);
            }
            if (Optional.IsDefined(ChownMode))
            {
                writer.WritePropertyName("chownMode");
                writer.WriteStringValue(ChownMode.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static NetAppVolumeExportPolicyRule DeserializeNetAppVolumeExportPolicyRule(JsonElement element)
        {
            Optional<int> ruleIndex = default;
            Optional<bool> unixReadOnly = default;
            Optional<bool> unixReadWrite = default;
            Optional<bool> kerberos5ReadOnly = default;
            Optional<bool> kerberos5ReadWrite = default;
            Optional<bool> kerberos5iReadOnly = default;
            Optional<bool> kerberos5iReadWrite = default;
            Optional<bool> kerberos5pReadOnly = default;
            Optional<bool> kerberos5pReadWrite = default;
            Optional<bool> cifs = default;
            Optional<bool> nfsv3 = default;
            Optional<bool> nfsv41 = default;
            Optional<string> allowedClients = default;
            Optional<bool> hasRootAccess = default;
            Optional<NetAppChownMode> chownMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    ruleIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unixReadOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unixReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("unixReadWrite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    unixReadWrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5ReadOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kerberos5ReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5ReadWrite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kerberos5ReadWrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5iReadOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kerberos5iReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5iReadWrite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kerberos5iReadWrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5pReadOnly"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kerberos5pReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kerberos5pReadWrite"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    kerberos5pReadWrite = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cifs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cifs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nfsv3"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nfsv3 = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("nfsv41"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nfsv41 = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowedClients"))
                {
                    allowedClients = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hasRootAccess"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hasRootAccess = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("chownMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    chownMode = new NetAppChownMode(property.Value.GetString());
                    continue;
                }
            }
            return new NetAppVolumeExportPolicyRule(Optional.ToNullable(ruleIndex), Optional.ToNullable(unixReadOnly), Optional.ToNullable(unixReadWrite), Optional.ToNullable(kerberos5ReadOnly), Optional.ToNullable(kerberos5ReadWrite), Optional.ToNullable(kerberos5iReadOnly), Optional.ToNullable(kerberos5iReadWrite), Optional.ToNullable(kerberos5pReadOnly), Optional.ToNullable(kerberos5pReadWrite), Optional.ToNullable(cifs), Optional.ToNullable(nfsv3), Optional.ToNullable(nfsv41), allowedClients.Value, Optional.ToNullable(hasRootAccess), Optional.ToNullable(chownMode));
        }
    }
}
