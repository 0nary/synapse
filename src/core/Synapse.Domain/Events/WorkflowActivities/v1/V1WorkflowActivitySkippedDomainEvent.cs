﻿/*
 * Copyright © 2022-Present The Synapse Authors
 * <p>
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * <p>
 * http://www.apache.org/licenses/LICENSE-2.0
 * <p>
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

using Synapse.Integration.Events.WorkflowActivities;

namespace Synapse.Domain.Events.WorkflowActivities
{
    /// <summary>
    /// Represents the <see cref="IDomainEvent"/> fired whenever a new <see cref="Integration.Models.V1WorkflowActivity"/> has been skipped
    /// </summary>
    [DataTransferObjectType(typeof(V1WorkflowActivitySkippedIntegrationEvent))]
    public class V1WorkflowActivitySkippedDomainEvent
        : DomainEvent<Models.V1WorkflowActivity, string>
    {

        /// <summary>
        /// Initializes a new <see cref="V1WorkflowActivitySkippedDomainEvent"/>
        /// </summary>
        protected V1WorkflowActivitySkippedDomainEvent()
        {
            
        }

        /// <summary>
        /// Initializes a new <see cref="V1WorkflowActivitySkippedDomainEvent"/>
        /// </summary>
        /// <param name="id">The id of the skipped <see cref="V1WorkflowActivity"/></param>
        public V1WorkflowActivitySkippedDomainEvent(string id)
            : base(id)
        {

        }

    }  

}
