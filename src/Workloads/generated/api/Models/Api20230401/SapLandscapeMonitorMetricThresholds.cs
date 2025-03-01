// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Extensions;

    /// <summary>Gets or sets the Threshold Values for Top Metrics Health.</summary>
    public partial class SapLandscapeMonitorMetricThresholds :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapLandscapeMonitorMetricThresholds,
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Models.Api20230401.ISapLandscapeMonitorMetricThresholdsInternal
    {

        /// <summary>Backing field for <see cref="Green" /> property.</summary>
        private float? _green;

        /// <summary>Gets or sets the threshold value for Green.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public float? Green { get => this._green; set => this._green = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Gets or sets the name of the threshold.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Red" /> property.</summary>
        private float? _red;

        /// <summary>Gets or sets the threshold value for Red.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public float? Red { get => this._red; set => this._red = value; }

        /// <summary>Backing field for <see cref="Yellow" /> property.</summary>
        private float? _yellow;

        /// <summary>Gets or sets the threshold value for Yellow.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Origin(Microsoft.Azure.PowerShell.Cmdlets.Workloads.PropertyOrigin.Owned)]
        public float? Yellow { get => this._yellow; set => this._yellow = value; }

        /// <summary>Creates an new <see cref="SapLandscapeMonitorMetricThresholds" /> instance.</summary>
        public SapLandscapeMonitorMetricThresholds()
        {

        }
    }
    /// Gets or sets the Threshold Values for Top Metrics Health.
    public partial interface ISapLandscapeMonitorMetricThresholds :
        Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the threshold value for Green.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the threshold value for Green.",
        SerializedName = @"green",
        PossibleTypes = new [] { typeof(float) })]
        float? Green { get; set; }
        /// <summary>Gets or sets the name of the threshold.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the name of the threshold.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Gets or sets the threshold value for Red.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the threshold value for Red.",
        SerializedName = @"red",
        PossibleTypes = new [] { typeof(float) })]
        float? Red { get; set; }
        /// <summary>Gets or sets the threshold value for Yellow.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Workloads.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the threshold value for Yellow.",
        SerializedName = @"yellow",
        PossibleTypes = new [] { typeof(float) })]
        float? Yellow { get; set; }

    }
    /// Gets or sets the Threshold Values for Top Metrics Health.
    internal partial interface ISapLandscapeMonitorMetricThresholdsInternal

    {
        /// <summary>Gets or sets the threshold value for Green.</summary>
        float? Green { get; set; }
        /// <summary>Gets or sets the name of the threshold.</summary>
        string Name { get; set; }
        /// <summary>Gets or sets the threshold value for Red.</summary>
        float? Red { get; set; }
        /// <summary>Gets or sets the threshold value for Yellow.</summary>
        float? Yellow { get; set; }

    }
}