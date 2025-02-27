// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    public partial class DeviceProvisioningServicesPrivateEndpointConnectionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint"u8);
                JsonSerializer.Serialize(writer, PrivateEndpoint);
            }
            writer.WritePropertyName("privateLinkServiceConnectionState"u8);
            writer.WriteObjectValue(ConnectionState);
            writer.WriteEndObject();
        }

        internal static DeviceProvisioningServicesPrivateEndpointConnectionProperties DeserializeDeviceProvisioningServicesPrivateEndpointConnectionProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SubResource> privateEndpoint = default;
            DeviceProvisioningServicesPrivateLinkServiceConnectionState privateLinkServiceConnectionState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpoint = JsonSerializer.Deserialize<SubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnectionState"u8))
                {
                    privateLinkServiceConnectionState = DeviceProvisioningServicesPrivateLinkServiceConnectionState.DeserializeDeviceProvisioningServicesPrivateLinkServiceConnectionState(property.Value);
                    continue;
                }
            }
            return new DeviceProvisioningServicesPrivateEndpointConnectionProperties(privateEndpoint, privateLinkServiceConnectionState);
        }
    }
}
