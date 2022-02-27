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

namespace Synapse.Integration.Commands.WorkflowActivities
{

	/// <summary>
	/// Represents the ICommand used to create a new V1WorkflowActivity
	/// </summary>
	[DataContract]
	public partial class V1CreateWorkflowActivityCommandDto
		: CommandDto
	{

		/// <summary>
		/// The id of the V1WorkflowInstance the V1WorkflowActivity to create belongs to
		/// </summary>
		[DataMember(Name = "WorkflowInstanceId", Order = 1)]
		[Description("The id of the V1WorkflowInstance the V1WorkflowActivity to create belongs to")]
		public virtual string WorkflowInstanceId { get; set; }

		/// <summary>
		/// The type of V1WorkflowActivity to create
		/// </summary>
		[DataMember(Name = "Type", Order = 2)]
		[Description("The type of V1WorkflowActivity to create")]
		public virtual V1WorkflowActivityType Type { get; set; }

		/// <summary>
		/// The input data of the V1WorkflowActivity to create
		/// </summary>
		[DataMember(Name = "Input", Order = 3)]
		[Description("The input data of the V1WorkflowActivity to create")]
		public virtual DynamicObject Input { get; set; }

		/// <summary>
		/// The metadata of the V1WorkflowActivity to create
		/// </summary>
		[DataMember(Name = "Metadata", Order = 4)]
		[Description("The metadata of the V1WorkflowActivity to create")]
		public virtual NameValueCollection<string> Metadata { get; set; }

		/// <summary>
		/// The id the parent of the V1WorkflowActivity to create
		/// </summary>
		[DataMember(Name = "ParentId", Order = 5)]
		[Description("The id the parent of the V1WorkflowActivity to create")]
		public virtual string ParentId { get; set; }

    }

}
