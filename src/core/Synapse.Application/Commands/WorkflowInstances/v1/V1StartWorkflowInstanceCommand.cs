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

namespace Synapse.Application.Commands.WorkflowInstances
{

    /// <summary>
    /// Represents the <see cref="ICommand"/> used to start the execution of an existing <see cref="Domain.Models.V1WorkflowInstance"/>
    /// </summary>
    [DataTransferObjectType(typeof(Integration.Commands.WorkflowInstances.V1StartWorkflowInstanceCommand))]
    public class V1StartWorkflowInstanceCommand
        : Command<Integration.Models.V1WorkflowInstance>
    {

        /// <summary>
        /// Initializes a new <see cref="V1StartWorkflowInstanceCommand"/>
        /// </summary>
        protected V1StartWorkflowInstanceCommand()
        {
            this.Id = null!;
        }

        /// <summary>
        /// Initializes a new <see cref="V1StartWorkflowInstanceCommand"/>
        /// </summary>
        /// <param name="id">The id of the <see cref="Domain.Models.V1WorkflowInstance"/> to start</param>
        public V1StartWorkflowInstanceCommand(string id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Gets the id of the <see cref="Domain.Models.V1WorkflowInstance"/> to start
        /// </summary>
        public virtual string Id { get; protected set; }

    }

    /// <summary>
    /// Represents the service used to handle <see cref="V1StartWorkflowInstanceCommand"/>s
    /// </summary>
    public class V1StartWorkflowInstanceCommandHandler
        : CommandHandlerBase,
        ICommandHandler<V1StartWorkflowInstanceCommand, Integration.Models.V1WorkflowInstance>
    {

        /// <summary>
        /// Initializes a new <see cref="V1StartWorkflowInstanceCommandHandler"/>
        /// </summary>
        /// <param name="loggerFactory">The service used to create <see cref="ILogger"/>s</param>
        /// <param name="mediator">The service used to mediate calls</param>
        /// <param name="mapper">The service used to map objects</param>
        /// <param name="workflowInstances">The <see cref="IRepository"/> used to manage <see cref="Domain.Models.V1WorkflowInstance"/>s</param>
        public V1StartWorkflowInstanceCommandHandler(ILoggerFactory loggerFactory, IMediator mediator, IMapper mapper, IRepository<Domain.Models.V1WorkflowInstance> workflowInstances, IWorkflowRuntimeHost runtimeHost)
            : base(loggerFactory, mediator, mapper)
        {
            this.WorkflowInstances = workflowInstances;
            this.RuntimeHost = runtimeHost;
        }

        /// <summary>
        /// Gets the <see cref="IRepository"/> used to manage <see cref="Domain.Models.V1WorkflowInstance"/>s
        /// </summary>
        protected IRepository<Domain.Models.V1WorkflowInstance> WorkflowInstances { get; }

        /// <summary>
        /// Gets the current <see cref="IWorkflowRuntimeHost"/>
        /// </summary>
        protected IWorkflowRuntimeHost RuntimeHost { get; }

        /// <inheritdoc/>
        public virtual async Task<IOperationResult<Integration.Models.V1WorkflowInstance>> HandleAsync(V1StartWorkflowInstanceCommand command, CancellationToken cancellationToken = default)
        {
            var workflowInstance = await this.WorkflowInstances.FindAsync(command.Id, cancellationToken);
            if (workflowInstance == null)
                throw DomainException.NullReference(typeof(Domain.Models.V1WorkflowInstance), command.Id);
            var runtimeId = await this.RuntimeHost.StartAsync(workflowInstance, cancellationToken); //todo
            workflowInstance.Start();
            workflowInstance = await this.WorkflowInstances.UpdateAsync(workflowInstance, cancellationToken);
            await this.WorkflowInstances.SaveChangesAsync(cancellationToken);
            return this.Ok(this.Mapper.Map<Integration.Models.V1WorkflowInstance>(workflowInstance));
        }

    }

}
