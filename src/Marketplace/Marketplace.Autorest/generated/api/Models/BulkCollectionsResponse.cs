// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Extensions;

    /// <summary>
    /// The bulk collections response. The response contains two lists that indicate for each collection whether the operation
    /// succeeded or failed
    /// </summary>
    public partial class BulkCollectionsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IBulkCollectionsResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.IBulkCollectionsResponseInternal
    {

        /// <summary>Backing field for <see cref="Failed" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionsDetails> _failed;

        /// <summary>Failed collections</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionsDetails> Failed { get => this._failed; set => this._failed = value; }

        /// <summary>Backing field for <see cref="Succeeded" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionsDetails> _succeeded;

        /// <summary>Succeeded collections</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionsDetails> Succeeded { get => this._succeeded; set => this._succeeded = value; }

        /// <summary>Creates an new <see cref="BulkCollectionsResponse" /> instance.</summary>
        public BulkCollectionsResponse()
        {

        }
    }
    /// The bulk collections response. The response contains two lists that indicate for each collection whether the operation
    /// succeeded or failed
    public partial interface IBulkCollectionsResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.IJsonSerializable
    {
        /// <summary>Failed collections</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Failed collections",
        SerializedName = @"failed",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionsDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionsDetails> Failed { get; set; }
        /// <summary>Succeeded collections</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Succeeded collections",
        SerializedName = @"succeeded",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionsDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionsDetails> Succeeded { get; set; }

    }
    /// The bulk collections response. The response contains two lists that indicate for each collection whether the operation
    /// succeeded or failed
    internal partial interface IBulkCollectionsResponseInternal

    {
        /// <summary>Failed collections</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionsDetails> Failed { get; set; }
        /// <summary>Succeeded collections</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Marketplace.Models.ICollectionsDetails> Succeeded { get; set; }

    }
}