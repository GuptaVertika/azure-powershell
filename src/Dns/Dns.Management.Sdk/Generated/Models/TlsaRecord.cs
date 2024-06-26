// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Dns.Models
{
    using System.Linq;

    /// <summary>
    /// A TLSA record. For more information about the TLSA record format, see RFC
    /// 6698: https://www.rfc-editor.org/rfc/rfc6698
    /// </summary>
    public partial class TlsaRecord
    {
        /// <summary>
        /// Initializes a new instance of the TlsaRecord class.
        /// </summary>
        public TlsaRecord()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TlsaRecord class.
        /// </summary>

        /// <param name="usage">The usage specifies the provided association that will be used to match the
        /// certificate presented in the TLS handshake.
        /// </param>

        /// <param name="selector">The selector specifies which part of the TLS certificate presented by the
        /// server will be matched against the association data.
        /// </param>

        /// <param name="matchingType">The matching type specifies how the certificate association is presented.
        /// </param>

        /// <param name="certAssociationData">This specifies the certificate association data to be matched.
        /// </param>
        public TlsaRecord(int? usage = default(int?), int? selector = default(int?), int? matchingType = default(int?), string certAssociationData = default(string))

        {
            this.Usage = usage;
            this.Selector = selector;
            this.MatchingType = matchingType;
            this.CertAssociationData = certAssociationData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the usage specifies the provided association that will be used
        /// to match the certificate presented in the TLS handshake.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "usage")]
        public int? Usage {get; set; }

        /// <summary>
        /// Gets or sets the selector specifies which part of the TLS certificate
        /// presented by the server will be matched against the association data.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "selector")]
        public int? Selector {get; set; }

        /// <summary>
        /// Gets or sets the matching type specifies how the certificate association is
        /// presented.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "matchingType")]
        public int? MatchingType {get; set; }

        /// <summary>
        /// Gets or sets this specifies the certificate association data to be matched.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "certAssociationData")]
        public string CertAssociationData {get; set; }
    }
}