// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Security.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Extensions;

    /// <summary>GitHub Owner properties.</summary>
    public partial class GitHubOwnerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitHubOwnerProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitHubOwnerPropertiesInternal
    {

        /// <summary>Backing field for <see cref="GitHubInternalId" /> property.</summary>
        private string _gitHubInternalId;

        /// <summary>Gets or sets internal GitHub id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public string GitHubInternalId { get => this._gitHubInternalId; }

        /// <summary>Internal Acessors for GitHubInternalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitHubOwnerPropertiesInternal.GitHubInternalId { get => this._gitHubInternalId; set { {_gitHubInternalId = value;} } }

        /// <summary>Internal Acessors for OwnerUrl</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitHubOwnerPropertiesInternal.OwnerUrl { get => this._ownerUrl; set { {_ownerUrl = value;} } }

        /// <summary>Internal Acessors for ProvisioningStatusMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitHubOwnerPropertiesInternal.ProvisioningStatusMessage { get => this._provisioningStatusMessage; set { {_provisioningStatusMessage = value;} } }

        /// <summary>Internal Acessors for ProvisioningStatusUpdateTimeUtc</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IGitHubOwnerPropertiesInternal.ProvisioningStatusUpdateTimeUtc { get => this._provisioningStatusUpdateTimeUtc; set { {_provisioningStatusUpdateTimeUtc = value;} } }

        /// <summary>Backing field for <see cref="OnboardingState" /> property.</summary>
        private string _onboardingState;

        /// <summary>
        /// Details about resource onboarding status across all connectors.
        ///
        /// OnboardedByOtherConnector - this resource has already been onboarded to another connector. This is only applicable to
        /// top-level resources.
        /// Onboarded - this resource has already been onboarded by the specified connector.
        /// NotOnboarded - this resource has not been onboarded to any connector.
        /// NotApplicable - the onboarding state is not applicable to the current endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public string OnboardingState { get => this._onboardingState; set => this._onboardingState = value; }

        /// <summary>Backing field for <see cref="OwnerUrl" /> property.</summary>
        private string _ownerUrl;

        /// <summary>Gets or sets GitHub Owner url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public string OwnerUrl { get => this._ownerUrl; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>
        /// The provisioning state of the resource.
        ///
        /// Pending - Provisioning pending.
        /// Failed - Provisioning failed.
        /// Succeeded - Successful provisioning.
        /// Canceled - Provisioning canceled.
        /// PendingDeletion - Deletion pending.
        /// DeletionSuccess - Deletion successful.
        /// DeletionFailure - Deletion failure.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; set => this._provisioningState = value; }

        /// <summary>Backing field for <see cref="ProvisioningStatusMessage" /> property.</summary>
        private string _provisioningStatusMessage;

        /// <summary>Gets or sets resource status message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public string ProvisioningStatusMessage { get => this._provisioningStatusMessage; }

        /// <summary>Backing field for <see cref="ProvisioningStatusUpdateTimeUtc" /> property.</summary>
        private global::System.DateTime? _provisioningStatusUpdateTimeUtc;

        /// <summary>Gets or sets time when resource was last checked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Origin(Microsoft.Azure.PowerShell.Cmdlets.Security.PropertyOrigin.Owned)]
        public global::System.DateTime? ProvisioningStatusUpdateTimeUtc { get => this._provisioningStatusUpdateTimeUtc; }

        /// <summary>Creates an new <see cref="GitHubOwnerProperties" /> instance.</summary>
        public GitHubOwnerProperties()
        {

        }
    }
    /// GitHub Owner properties.
    public partial interface IGitHubOwnerProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets internal GitHub id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets internal GitHub id.",
        SerializedName = @"gitHubInternalId",
        PossibleTypes = new [] { typeof(string) })]
        string GitHubInternalId { get;  }
        /// <summary>
        /// Details about resource onboarding status across all connectors.
        ///
        /// OnboardedByOtherConnector - this resource has already been onboarded to another connector. This is only applicable to
        /// top-level resources.
        /// Onboarded - this resource has already been onboarded by the specified connector.
        /// NotOnboarded - this resource has not been onboarded to any connector.
        /// NotApplicable - the onboarding state is not applicable to the current endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Details about resource onboarding status across all connectors.

        OnboardedByOtherConnector - this resource has already been onboarded to another connector. This is only applicable to top-level resources.
        Onboarded - this resource has already been onboarded by the specified connector.
        NotOnboarded - this resource has not been onboarded to any connector.
        NotApplicable - the onboarding state is not applicable to the current endpoint.",
        SerializedName = @"onboardingState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Security.PSArgumentCompleterAttribute("NotApplicable", "OnboardedByOtherConnector", "Onboarded", "NotOnboarded")]
        string OnboardingState { get; set; }
        /// <summary>Gets or sets GitHub Owner url.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets GitHub Owner url.",
        SerializedName = @"ownerUrl",
        PossibleTypes = new [] { typeof(string) })]
        string OwnerUrl { get;  }
        /// <summary>
        /// The provisioning state of the resource.
        ///
        /// Pending - Provisioning pending.
        /// Failed - Provisioning failed.
        /// Succeeded - Successful provisioning.
        /// Canceled - Provisioning canceled.
        /// PendingDeletion - Deletion pending.
        /// DeletionSuccess - Deletion successful.
        /// DeletionFailure - Deletion failure.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The provisioning state of the resource.

        Pending - Provisioning pending.
        Failed - Provisioning failed.
        Succeeded - Successful provisioning.
        Canceled - Provisioning canceled.
        PendingDeletion - Deletion pending.
        DeletionSuccess - Deletion successful.
        DeletionFailure - Deletion failure.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Security.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Pending", "PendingDeletion", "DeletionSuccess", "DeletionFailure")]
        string ProvisioningState { get; set; }
        /// <summary>Gets or sets resource status message.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets resource status message.",
        SerializedName = @"provisioningStatusMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningStatusMessage { get;  }
        /// <summary>Gets or sets time when resource was last checked.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets time when resource was last checked.",
        SerializedName = @"provisioningStatusUpdateTimeUtc",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ProvisioningStatusUpdateTimeUtc { get;  }

    }
    /// GitHub Owner properties.
    internal partial interface IGitHubOwnerPropertiesInternal

    {
        /// <summary>Gets or sets internal GitHub id.</summary>
        string GitHubInternalId { get; set; }
        /// <summary>
        /// Details about resource onboarding status across all connectors.
        ///
        /// OnboardedByOtherConnector - this resource has already been onboarded to another connector. This is only applicable to
        /// top-level resources.
        /// Onboarded - this resource has already been onboarded by the specified connector.
        /// NotOnboarded - this resource has not been onboarded to any connector.
        /// NotApplicable - the onboarding state is not applicable to the current endpoint.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Security.PSArgumentCompleterAttribute("NotApplicable", "OnboardedByOtherConnector", "Onboarded", "NotOnboarded")]
        string OnboardingState { get; set; }
        /// <summary>Gets or sets GitHub Owner url.</summary>
        string OwnerUrl { get; set; }
        /// <summary>
        /// The provisioning state of the resource.
        ///
        /// Pending - Provisioning pending.
        /// Failed - Provisioning failed.
        /// Succeeded - Successful provisioning.
        /// Canceled - Provisioning canceled.
        /// PendingDeletion - Deletion pending.
        /// DeletionSuccess - Deletion successful.
        /// DeletionFailure - Deletion failure.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Security.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Pending", "PendingDeletion", "DeletionSuccess", "DeletionFailure")]
        string ProvisioningState { get; set; }
        /// <summary>Gets or sets resource status message.</summary>
        string ProvisioningStatusMessage { get; set; }
        /// <summary>Gets or sets time when resource was last checked.</summary>
        global::System.DateTime? ProvisioningStatusUpdateTimeUtc { get; set; }

    }
}