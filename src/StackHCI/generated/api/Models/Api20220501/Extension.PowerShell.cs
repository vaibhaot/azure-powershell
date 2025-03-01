// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501
{
    using Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.PowerShell;

    /// <summary>Details of a particular extension in HCI Cluster.</summary>
    [System.ComponentModel.TypeConverter(typeof(ExtensionTypeConverter))]
    public partial class Extension
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.Extension"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtension" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtension DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new Extension(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.Extension"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtension" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtension DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new Extension(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.Extension"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal Extension(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.ExtensionPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.ExtensionParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("AggregateState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).AggregateState = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState?) content.GetValueForProperty("AggregateState",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).AggregateState, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState.CreateFrom);
            }
            if (content.Contains("PerNodeExtensionDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).PerNodeExtensionDetail = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IPerNodeExtensionState[]) content.GetValueForProperty("PerNodeExtensionDetail",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).PerNodeExtensionDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IPerNodeExtensionState>(__y, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.PerNodeExtensionStateTypeConverter.ConvertFrom));
            }
            if (content.Contains("ParameterPublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterPublisher = (string) content.GetValueForProperty("ParameterPublisher",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterPublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ParameterType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterType = (string) content.GetValueForProperty("ParameterType",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterType, global::System.Convert.ToString);
            }
            if (content.Contains("ParameterSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterSetting = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionParametersSettings) content.GetValueForProperty("ParameterSetting",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterSetting, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.ExtensionParametersSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ParameterProtectedSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionParametersProtectedSettings) content.GetValueForProperty("ParameterProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.ExtensionParametersProtectedSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ParameterForceUpdateTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterForceUpdateTag = (string) content.GetValueForProperty("ParameterForceUpdateTag",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterForceUpdateTag, global::System.Convert.ToString);
            }
            if (content.Contains("ParameterTypeHandlerVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterTypeHandlerVersion = (string) content.GetValueForProperty("ParameterTypeHandlerVersion",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterTypeHandlerVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ParameterAutoUpgradeMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterAutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("ParameterAutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterAutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.Extension"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal Extension(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.ISystemData) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.SystemDataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.ExtensionPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.IResourceInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.IResourceInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.IResourceInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.IResourceInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.IResourceInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20.IResourceInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Parameter"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).Parameter = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionParameters) content.GetValueForProperty("Parameter",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).Parameter, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.ExtensionParametersTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState?) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ProvisioningState.CreateFrom);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataCreatedByType = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.CreatedByType?) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataCreatedByType, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataLastModifiedByType = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.CreatedByType?) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataLastModifiedByType, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.CreatedByType.CreateFrom);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("AggregateState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).AggregateState = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState?) content.GetValueForProperty("AggregateState",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).AggregateState, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Support.ExtensionAggregateState.CreateFrom);
            }
            if (content.Contains("PerNodeExtensionDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).PerNodeExtensionDetail = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IPerNodeExtensionState[]) content.GetValueForProperty("PerNodeExtensionDetail",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).PerNodeExtensionDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IPerNodeExtensionState>(__y, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.PerNodeExtensionStateTypeConverter.ConvertFrom));
            }
            if (content.Contains("ParameterPublisher"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterPublisher = (string) content.GetValueForProperty("ParameterPublisher",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterPublisher, global::System.Convert.ToString);
            }
            if (content.Contains("ParameterType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterType = (string) content.GetValueForProperty("ParameterType",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterType, global::System.Convert.ToString);
            }
            if (content.Contains("ParameterSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterSetting = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionParametersSettings) content.GetValueForProperty("ParameterSetting",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterSetting, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.ExtensionParametersSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ParameterProtectedSetting"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterProtectedSetting = (Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionParametersProtectedSettings) content.GetValueForProperty("ParameterProtectedSetting",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterProtectedSetting, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.ExtensionParametersProtectedSettingsTypeConverter.ConvertFrom);
            }
            if (content.Contains("ParameterForceUpdateTag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterForceUpdateTag = (string) content.GetValueForProperty("ParameterForceUpdateTag",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterForceUpdateTag, global::System.Convert.ToString);
            }
            if (content.Contains("ParameterTypeHandlerVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterTypeHandlerVersion = (string) content.GetValueForProperty("ParameterTypeHandlerVersion",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterTypeHandlerVersion, global::System.Convert.ToString);
            }
            if (content.Contains("ParameterAutoUpgradeMinorVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterAutoUpgradeMinorVersion = (bool?) content.GetValueForProperty("ParameterAutoUpgradeMinorVersion",((Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtensionInternal)this).ParameterAutoUpgradeMinorVersion, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Extension" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="Extension" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20220501.IExtension FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Details of a particular extension in HCI Cluster.
    [System.ComponentModel.TypeConverter(typeof(ExtensionTypeConverter))]
    public partial interface IExtension

    {

    }
}