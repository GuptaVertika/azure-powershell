// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.AlertsManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Alert processing rule properties defining scopes, conditions and scheduling
    /// logic for alert processing rule.
    /// </summary>
    public partial class AlertProcessingRuleProperties
    {
        /// <summary>
        /// Initializes a new instance of the AlertProcessingRuleProperties class.
        /// </summary>
        public AlertProcessingRuleProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AlertProcessingRuleProperties class.
        /// </summary>

        /// <param name="scopes">Scopes on which alert processing rule will apply.
        /// </param>

        /// <param name="conditions">Conditions on which alerts will be filtered.
        /// </param>

        /// <param name="schedule">Scheduling for alert processing rule.
        /// </param>

        /// <param name="actions">Actions to be applied.
        /// </param>

        /// <param name="description">Description of alert processing rule.
        /// </param>

        /// <param name="enabled">Indicates if the given alert processing rule is enabled or disabled.
        /// </param>
        public AlertProcessingRuleProperties(System.Collections.Generic.IList<string> scopes, System.Collections.Generic.IList<Action> actions, System.Collections.Generic.IList<Condition> conditions = default(System.Collections.Generic.IList<Condition>), Schedule schedule = default(Schedule), string description = default(string), bool? enabled = default(bool?))

        {
            this.Scopes = scopes;
            this.Conditions = conditions;
            this.Schedule = schedule;
            this.Actions = actions;
            this.Description = description;
            this.Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets scopes on which alert processing rule will apply.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "scopes")]
        public System.Collections.Generic.IList<string> Scopes {get; set; }

        /// <summary>
        /// Gets or sets conditions on which alerts will be filtered.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "conditions")]
        public System.Collections.Generic.IList<Condition> Conditions {get; set; }

        /// <summary>
        /// Gets or sets scheduling for alert processing rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "schedule")]
        public Schedule Schedule {get; set; }

        /// <summary>
        /// Gets or sets actions to be applied.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "actions")]
        public System.Collections.Generic.IList<Action> Actions {get; set; }

        /// <summary>
        /// Gets or sets description of alert processing rule.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }

        /// <summary>
        /// Gets or sets indicates if the given alert processing rule is enabled or
        /// disabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "enabled")]
        public bool? Enabled {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Scopes == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Scopes");
            }
            if (this.Actions == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Actions");
            }


            if (this.Schedule != null)
            {
                this.Schedule.Validate();
            }


        }
    }
}