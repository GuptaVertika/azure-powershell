// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using System.Linq;

    /// <summary>
    /// This property defines the creation time based filtering condition. Blob
    /// Inventory schema parameter &#39;Creation-Time&#39; is mandatory with this filter.
    /// </summary>
    public partial class BlobInventoryCreationTime
    {
        /// <summary>
        /// Initializes a new instance of the BlobInventoryCreationTime class.
        /// </summary>
        public BlobInventoryCreationTime()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobInventoryCreationTime class.
        /// </summary>

        /// <param name="lastNDays">When set the policy filters the objects that are created in the last N
        /// days. Where N is an integer value between 1 to 36500.
        /// </param>
        public BlobInventoryCreationTime(int? lastNDays = default(int?))

        {
            this.LastNDays = lastNDays;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets when set the policy filters the objects that are created in
        /// the last N days. Where N is an integer value between 1 to 36500.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastNDays")]
        public int? LastNDays {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.LastNDays != null)
            {
                if (this.LastNDays > 36500)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMaximum, "LastNDays", 36500);
                }
                if (this.LastNDays < 1)
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.InclusiveMinimum, "LastNDays", 1);
                }
            }
        }
    }
}