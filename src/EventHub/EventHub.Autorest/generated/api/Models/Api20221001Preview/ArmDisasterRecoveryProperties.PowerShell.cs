// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.PowerShell;

    /// <summary>
    /// Properties required to the Create Or Update Alias(Disaster Recovery configurations)
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ArmDisasterRecoveryPropertiesTypeConverter))]
    public partial class ArmDisasterRecoveryProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ArmDisasterRecoveryProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ArmDisasterRecoveryProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.ProvisioningStateDr?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.ProvisioningStateDr.CreateFrom);
            }
            if (content.Contains("PartnerNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).PartnerNamespace = (string) content.GetValueForProperty("PartnerNamespace",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).PartnerNamespace, global::System.Convert.ToString);
            }
            if (content.Contains("AlternateName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).AlternateName = (string) content.GetValueForProperty("AlternateName",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).AlternateName, global::System.Convert.ToString);
            }
            if (content.Contains("Role"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).Role = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.RoleDisasterRecovery?) content.GetValueForProperty("Role",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).Role, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.RoleDisasterRecovery.CreateFrom);
            }
            if (content.Contains("PendingReplicationOperationsCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).PendingReplicationOperationsCount = (long?) content.GetValueForProperty("PendingReplicationOperationsCount",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).PendingReplicationOperationsCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ArmDisasterRecoveryProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ArmDisasterRecoveryProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.ProvisioningStateDr?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.ProvisioningStateDr.CreateFrom);
            }
            if (content.Contains("PartnerNamespace"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).PartnerNamespace = (string) content.GetValueForProperty("PartnerNamespace",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).PartnerNamespace, global::System.Convert.ToString);
            }
            if (content.Contains("AlternateName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).AlternateName = (string) content.GetValueForProperty("AlternateName",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).AlternateName, global::System.Convert.ToString);
            }
            if (content.Contains("Role"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).Role = (Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.RoleDisasterRecovery?) content.GetValueForProperty("Role",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).Role, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.RoleDisasterRecovery.CreateFrom);
            }
            if (content.Contains("PendingReplicationOperationsCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).PendingReplicationOperationsCount = (long?) content.GetValueForProperty("PendingReplicationOperationsCount",((Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryPropertiesInternal)this).PendingReplicationOperationsCount, (__y)=> (long) global::System.Convert.ChangeType(__y, typeof(long)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ArmDisasterRecoveryProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ArmDisasterRecoveryProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.ArmDisasterRecoveryProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ArmDisasterRecoveryProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ArmDisasterRecoveryProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ArmDisasterRecoveryProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IArmDisasterRecoveryProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Properties required to the Create Or Update Alias(Disaster Recovery configurations)
    [System.ComponentModel.TypeConverter(typeof(ArmDisasterRecoveryPropertiesTypeConverter))]
    public partial interface IArmDisasterRecoveryProperties

    {

    }
}