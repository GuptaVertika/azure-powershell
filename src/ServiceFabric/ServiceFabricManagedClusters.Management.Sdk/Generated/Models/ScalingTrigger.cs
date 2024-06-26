// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ServiceFabricManagedClusters.Models
{
    using System.Linq;

    /// <summary>
    /// Describes the trigger for performing a scaling operation.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ScalingTrigger")]
    public partial class ScalingTrigger
    {
        /// <summary>
        /// Initializes a new instance of the ScalingTrigger class.
        /// </summary>
        public ScalingTrigger()
        {
            CustomInit();
        }


        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}