// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using System.Linq;

    /// <summary>
    /// The list of OS option properties.
    /// </summary>
    public partial class OSOptionPropertyList
    {
        /// <summary>
        /// Initializes a new instance of the OSOptionPropertyList class.
        /// </summary>
        public OSOptionPropertyList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OSOptionPropertyList class.
        /// </summary>

        /// <param name="osOptionPropertyListProperty">The list of OS options.
        /// </param>
        public OSOptionPropertyList(System.Collections.Generic.IList<OSOptionProperty> osOptionPropertyListProperty)

        {
            this.OSOptionPropertyListProperty = osOptionPropertyListProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the list of OS options.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "osOptionPropertyList")]
        public System.Collections.Generic.IList<OSOptionProperty> OSOptionPropertyListProperty {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.OSOptionPropertyListProperty == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "OSOptionPropertyListProperty");
            }
            if (this.OSOptionPropertyListProperty != null)
            {
                foreach (var element in this.OSOptionPropertyListProperty)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}