﻿/*
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

using Synapse.Integration.Models;

namespace Synapse.Dashboard.CloudEvents
{

    /// <summary>
    /// Defines the fundamentals of a <see cref="V1Event"/> subscription
    /// </summary>
    public interface ICloudEventSubscription
    {

        /// <summary>
        /// Attempts to filter the specified <see cref="V1Event"/>
        /// </summary>
        /// <param name="e">The <see cref="V1Event"/> to attempt to filter</param>
        /// <returns>A boolean indicating whether or not the specified <see cref="V1Event"/> has been filtered</returns>
        bool Filters(V1Event e);

        /// <summary>
        /// Handles the specified <see cref="V1Event"/>
        /// </summary>
        /// <param name="e">The <see cref="V1Event"/> to handle</param>
        void Handle(V1Event e);
        
    }

}
