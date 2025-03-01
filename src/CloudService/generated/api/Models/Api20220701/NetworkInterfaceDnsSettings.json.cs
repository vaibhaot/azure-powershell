// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Extensions;

    /// <summary>DNS settings of a network interface.</summary>
    public partial class NetworkInterfaceDnsSettings
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterfaceDnsSettings.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterfaceDnsSettings.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.CloudService.Models.Api20220701.INetworkInterfaceDnsSettings FromJson(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject json ? new NetworkInterfaceDnsSettings(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject into a new instance of <see cref="NetworkInterfaceDnsSettings" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal NetworkInterfaceDnsSettings(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_dnsServer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonArray>("dnsServers"), out var __jsonDnsServers) ? If( __jsonDnsServers as Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : DnsServer;}
            {_appliedDnsServer = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonArray>("appliedDnsServers"), out var __jsonAppliedDnsServers) ? If( __jsonAppliedDnsServers as Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(string) (__p is Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString __o ? (string)(__o.ToString()) : null)) ))() : null : AppliedDnsServer;}
            {_internalDnsNameLabel = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString>("internalDnsNameLabel"), out var __jsonInternalDnsNameLabel) ? (string)__jsonInternalDnsNameLabel : (string)InternalDnsNameLabel;}
            {_internalFqdn = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString>("internalFqdn"), out var __jsonInternalFqdn) ? (string)__jsonInternalFqdn : (string)InternalFqdn;}
            {_internalDomainNameSuffix = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString>("internalDomainNameSuffix"), out var __jsonInternalDomainNameSuffix) ? (string)__jsonInternalDomainNameSuffix : (string)InternalDomainNameSuffix;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="NetworkInterfaceDnsSettings" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="NetworkInterfaceDnsSettings" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (null != this._dnsServer)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.XNodeArray();
                foreach( var __x in this._dnsServer )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("dnsServers",__w);
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.SerializationMode.IncludeReadOnly))
            {
                if (null != this._appliedDnsServer)
                {
                    var __r = new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.XNodeArray();
                    foreach( var __s in this._appliedDnsServer )
                    {
                        AddIf(null != (((object)__s)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString(__s.ToString()) : null ,__r.Add);
                    }
                    container.Add("appliedDnsServers",__r);
                }
            }
            AddIf( null != (((object)this._internalDnsNameLabel)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString(this._internalDnsNameLabel.ToString()) : null, "internalDnsNameLabel" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._internalFqdn)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString(this._internalFqdn.ToString()) : null, "internalFqdn" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._internalDomainNameSuffix)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.CloudService.Runtime.Json.JsonString(this._internalDomainNameSuffix.ToString()) : null, "internalDomainNameSuffix" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}