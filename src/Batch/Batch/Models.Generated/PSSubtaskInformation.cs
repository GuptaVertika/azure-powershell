﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:5.0.17
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public partial class PSSubtaskInformation
    {
        
        internal Microsoft.Azure.Batch.SubtaskInformation omObject;
        
        private PSComputeNodeInformation computeNodeInformation;
        
        private PSTaskContainerExecutionInformation containerInformation;
        
        private PSTaskFailureInformation failureInformation;
        
        internal PSSubtaskInformation(Microsoft.Azure.Batch.SubtaskInformation omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public PSComputeNodeInformation ComputeNodeInformation
        {
            get
            {
                if (((this.computeNodeInformation == null) 
                            && (this.omObject.ComputeNodeInformation != null)))
                {
                    this.computeNodeInformation = new PSComputeNodeInformation(this.omObject.ComputeNodeInformation);
                }
                return this.computeNodeInformation;
            }
        }
        
        public PSTaskContainerExecutionInformation ContainerInformation
        {
            get
            {
                if (((this.containerInformation == null) 
                            && (this.omObject.ContainerInformation != null)))
                {
                    this.containerInformation = new PSTaskContainerExecutionInformation(this.omObject.ContainerInformation);
                }
                return this.containerInformation;
            }
        }
        
        public System.DateTime? EndTime
        {
            get
            {
                return this.omObject.EndTime;
            }
        }
        
        public System.Int32? ExitCode
        {
            get
            {
                return this.omObject.ExitCode;
            }
        }
        
        public PSTaskFailureInformation FailureInformation
        {
            get
            {
                if (((this.failureInformation == null) 
                            && (this.omObject.FailureInformation != null)))
                {
                    this.failureInformation = new PSTaskFailureInformation(this.omObject.FailureInformation);
                }
                return this.failureInformation;
            }
        }
        
        public System.Int32? Id
        {
            get
            {
                return this.omObject.Id;
            }
        }
        
        public Microsoft.Azure.Batch.Common.SubtaskState? PreviousState
        {
            get
            {
                return this.omObject.PreviousState;
            }
        }
        
        public System.DateTime? PreviousStateTransitionTime
        {
            get
            {
                return this.omObject.PreviousStateTransitionTime;
            }
        }
        
        public Microsoft.Azure.Batch.Common.TaskExecutionResult? Result
        {
            get
            {
                return this.omObject.Result;
            }
        }
        
        public System.DateTime? StartTime
        {
            get
            {
                return this.omObject.StartTime;
            }
        }
        
        public Microsoft.Azure.Batch.Common.SubtaskState? State
        {
            get
            {
                return this.omObject.State;
            }
        }
        
        public System.DateTime? StateTransitionTime
        {
            get
            {
                return this.omObject.StateTransitionTime;
            }
        }
    }
}
