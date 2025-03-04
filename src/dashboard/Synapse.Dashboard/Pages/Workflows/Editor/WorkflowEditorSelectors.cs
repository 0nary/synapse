﻿using Neuroglia.Data.Flux;
using ServerlessWorkflow.Sdk.Models;
using Synapse.Dashboard.Pages.Workflows.Editor.State;
using System.Reactive.Linq;

namespace Synapse.Dashboard.Pages.Workflows.Editor
{
    public static class WorkflowEditorSelectors
    {
        /// <summary>
        /// Selects the workflow definition
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public static IObservable<WorkflowDefinition?> SelectWorkflowDefinition(IStore store)
        {
            return store.GetFeature<WorkflowEditorState>()
                .Select(featureState => featureState.WorkflowDefinition)
                .DistinctUntilChanged();
        }

        /// <summary>
        /// Selects the workflow definition text
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public static IObservable<string?> SelectWorkflowDefinitionText(IStore store)
        {
            return store.GetFeature<WorkflowEditorState>()
                .Select(featureState => featureState.WorkflowDefinitionText)
                .DistinctUntilChanged();
        }

        /// <summary>
        /// Selects the workflow definition validation messages
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public static IObservable<ICollection<string>?> SelectValidationMessages(IStore store)
        {
            return store.GetFeature<WorkflowEditorState>()
                .Select(featureState => featureState.ValidationMessages)
                .DistinctUntilChanged();
        }

        /// <summary>
        /// Selects the workflow definition diagram visibility state
        /// </summary>
        /// <param name="store"></param>
        /// <returns></returns>
        public static IObservable<bool> SelectIsDiagramVisible(IStore store)
        {
            return store.GetFeature<WorkflowEditorState>()
                .Select(featureState => featureState.IsDiagramVisible)
                .DistinctUntilChanged();
        }
    }
}
