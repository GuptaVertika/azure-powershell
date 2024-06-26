// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Extensions;

    /// <summary>The NetworkFabric resource definition.</summary>
    public partial class NetworkTapPatch :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapPatch,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapPatchInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdate"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdate __tagsUpdate = new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.TagsUpdate();

        /// <summary>Switch configuration description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inlined)]
        public string Annotation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)Property).Annotation; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)Property).Annotation = value ?? null; }

        /// <summary>List of destination properties to send the filter traffic.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapPatchableParametersDestinationsItem> Destination { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapPatchableParametersInternal)Property).Destination; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapPatchableParametersInternal)Property).Destination = value ?? null /* arrayOf */; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapPatchableParameters Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapPatchInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.NetworkTapPatchableParameters()); set { {_property = value;} } }

        /// <summary>Polling type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inlined)]
        public string PollingType { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapPatchableParametersInternal)Property).PollingType; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapPatchableParametersInternal)Property).PollingType = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapPatchableParameters _property;

        /// <summary>Resource properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapPatchableParameters Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.NetworkTapPatchableParameters()); set => this._property = value; }

        /// <summary>Resource tags</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdateTags Tag { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdateInternal)__tagsUpdate).Tag; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdateInternal)__tagsUpdate).Tag = value ?? null /* model class */; }

        /// <summary>Creates an new <see cref="NetworkTapPatch" /> instance.</summary>
        public NetworkTapPatch()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__tagsUpdate), __tagsUpdate);
            await eventListener.AssertObjectIsValid(nameof(__tagsUpdate), __tagsUpdate);
        }
    }
    /// The NetworkFabric resource definition.
    public partial interface INetworkTapPatch :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdate
    {
        /// <summary>Switch configuration description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Switch configuration description.",
        SerializedName = @"annotation",
        PossibleTypes = new [] { typeof(string) })]
        string Annotation { get; set; }
        /// <summary>List of destination properties to send the filter traffic.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of destination properties to send the filter traffic.",
        SerializedName = @"destinations",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapPatchableParametersDestinationsItem) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapPatchableParametersDestinationsItem> Destination { get; set; }
        /// <summary>Polling type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Polling type.",
        SerializedName = @"pollingType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Pull", "Push")]
        string PollingType { get; set; }

    }
    /// The NetworkFabric resource definition.
    internal partial interface INetworkTapPatchInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.ITagsUpdateInternal
    {
        /// <summary>Switch configuration description.</summary>
        string Annotation { get; set; }
        /// <summary>List of destination properties to send the filter traffic.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapPatchableParametersDestinationsItem> Destination { get; set; }
        /// <summary>Polling type.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Pull", "Push")]
        string PollingType { get; set; }
        /// <summary>Resource properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkTapPatchableParameters Property { get; set; }

    }
}