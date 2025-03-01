// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Extensions;

    /// <summary>Properties to configure Encryption</summary>
    [Microsoft.Azure.PowerShell.Cmdlets.EventHub.DoNotFormat]
    public partial class Encryption :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IEncryption,
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IEncryptionInternal
    {

        /// <summary>Backing field for <see cref="KeySource" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.KeySource? _keySource;

        /// <summary>Enumerates the possible value of keySource for Encryption</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.KeySource? KeySource { get => this._keySource; set => this._keySource = value; }

        /// <summary>Backing field for <see cref="KeyVaultProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IKeyVaultProperties[] _keyVaultProperty;

        /// <summary>Properties of KeyVault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IKeyVaultProperties[] KeyVaultProperty { get => this._keyVaultProperty; set => this._keyVaultProperty = value; }

        /// <summary>Backing field for <see cref="RequireInfrastructureEncryption" /> property.</summary>
        private bool? _requireInfrastructureEncryption;

        /// <summary>Enable Infrastructure Encryption (Double Encryption)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventHub.PropertyOrigin.Owned)]
        public bool? RequireInfrastructureEncryption { get => this._requireInfrastructureEncryption; set => this._requireInfrastructureEncryption = value; }

        /// <summary>Creates an new <see cref="Encryption" /> instance.</summary>
        public Encryption()
        {

        }
    }
    /// Properties to configure Encryption
    public partial interface IEncryption :
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.IJsonSerializable
    {
        /// <summary>Enumerates the possible value of keySource for Encryption</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enumerates the possible value of keySource for Encryption",
        SerializedName = @"keySource",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.KeySource) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.KeySource? KeySource { get; set; }
        /// <summary>Properties of KeyVault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Properties of KeyVault",
        SerializedName = @"keyVaultProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IKeyVaultProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IKeyVaultProperties[] KeyVaultProperty { get; set; }
        /// <summary>Enable Infrastructure Encryption (Double Encryption)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventHub.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Enable Infrastructure Encryption (Double Encryption)",
        SerializedName = @"requireInfrastructureEncryption",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RequireInfrastructureEncryption { get; set; }

    }
    /// Properties to configure Encryption
    internal partial interface IEncryptionInternal

    {
        /// <summary>Enumerates the possible value of keySource for Encryption</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Support.KeySource? KeySource { get; set; }
        /// <summary>Properties of KeyVault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EventHub.Models.Api20221001Preview.IKeyVaultProperties[] KeyVaultProperty { get; set; }
        /// <summary>Enable Infrastructure Encryption (Double Encryption)</summary>
        bool? RequireInfrastructureEncryption { get; set; }

    }
}