// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>Result of the List partner configurations operation</summary>
    public partial class PartnerConfigurationsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerConfigurationsListResult,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerConfigurationsListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>A link for the next page of partner configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerConfiguration> _value;

        /// <summary>A collection of partner configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerConfiguration> Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="PartnerConfigurationsListResult" /> instance.</summary>
        public PartnerConfigurationsListResult()
        {

        }
    }
    /// Result of the List partner configurations operation
    public partial interface IPartnerConfigurationsListResult :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable
    {
        /// <summary>A link for the next page of partner configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A link for the next page of partner configurations.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>A collection of partner configurations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A collection of partner configurations.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerConfiguration) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerConfiguration> Value { get; set; }

    }
    /// Result of the List partner configurations operation
    internal partial interface IPartnerConfigurationsListResultInternal

    {
        /// <summary>A link for the next page of partner configurations.</summary>
        string NextLink { get; set; }
        /// <summary>A collection of partner configurations.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IPartnerConfiguration> Value { get; set; }

    }
}