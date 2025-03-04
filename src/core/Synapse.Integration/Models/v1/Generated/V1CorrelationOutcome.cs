﻿
/*
 * Copyright © 2022-Present The Synapse Authors
 * <p>
 * Licensed under the Apache License, Version 2.0(the "License");
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
 */

/* -----------------------------------------------------------------------
 * This file has been automatically generated by a tool
 * -----------------------------------------------------------------------
 */

namespace Synapse.Integration.Models
{

	/// <summary>
	/// Represents the outcome of an event correlation
	/// </summary>
	[DataContract]
	public partial class V1CorrelationOutcome
	{

		/// <summary>
		/// The V1CorrelationOutcomeType's type
		/// </summary>
		[DataMember(Name = "Type", Order = 1)]
		[Description("The V1CorrelationOutcomeType's type")]
		public virtual V1CorrelationOutcomeType Type { get; set; }

		/// <summary>
		/// The identifier of the V1CorrelationOutcome's target (a V1Workflow or a V1WorkflowInstance)
		/// </summary>
		[DataMember(Name = "Target", Order = 2)]
		[Description("The identifier of the V1CorrelationOutcome's target (a V1Workflow or a V1WorkflowInstance)")]
		public virtual string Target { get; set; }

    }

}
