// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Metric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Metric.Runtime.Extensions;

    /// <summary>The comma separated list of resource IDs to query metrics for.</summary>
    public partial class ResourceIdList :
        Microsoft.Azure.PowerShell.Cmdlets.Metric.Models.IResourceIdList,
        Microsoft.Azure.PowerShell.Cmdlets.Metric.Models.IResourceIdListInternal
    {

        /// <summary>Backing field for <see cref="Resourceid" /> property.</summary>
        private System.Collections.Generic.List<string> _resourceid;

        /// <summary>The list of resource IDs to query metrics for.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Metric.Origin(Microsoft.Azure.PowerShell.Cmdlets.Metric.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> Resourceid { get => this._resourceid; set => this._resourceid = value; }

        /// <summary>Creates an new <see cref="ResourceIdList" /> instance.</summary>
        public ResourceIdList()
        {

        }
    }
    /// The comma separated list of resource IDs to query metrics for.
    public partial interface IResourceIdList :
        Microsoft.Azure.PowerShell.Cmdlets.Metric.Runtime.IJsonSerializable
    {
        /// <summary>The list of resource IDs to query metrics for.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Metric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of resource IDs to query metrics for.",
        SerializedName = @"resourceids",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Resourceid { get; set; }

    }
    /// The comma separated list of resource IDs to query metrics for.
    internal partial interface IResourceIdListInternal

    {
        /// <summary>The list of resource IDs to query metrics for.</summary>
        System.Collections.Generic.List<string> Resourceid { get; set; }

    }
}