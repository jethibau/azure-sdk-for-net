// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApplicationInsights.Management
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExportConfigurationsOperations.
    /// </summary>
    public static partial class ExportConfigurationsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of Continuous Export configuration of an Application Insights
            /// component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            public static IList<ApplicationInsightsComponentExportConfiguration> List(this IExportConfigurationsOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.ListAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of Continuous Export configuration of an Application Insights
            /// component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ApplicationInsightsComponentExportConfiguration>> ListAsync(this IExportConfigurationsOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a Continuous Export configuration of an Application Insights
            /// component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='exportProperties'>
            /// Properties that need to be specified to create a Continuous Export
            /// configuration of a Application Insights component.
            /// </param>
            public static IList<ApplicationInsightsComponentExportConfiguration> Create(this IExportConfigurationsOperations operations, string resourceGroupName, string resourceName, ApplicationInsightsComponentExportRequest exportProperties)
            {
                return operations.CreateAsync(resourceGroupName, resourceName, exportProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a Continuous Export configuration of an Application Insights
            /// component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='exportProperties'>
            /// Properties that need to be specified to create a Continuous Export
            /// configuration of a Application Insights component.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ApplicationInsightsComponentExportConfiguration>> CreateAsync(this IExportConfigurationsOperations operations, string resourceGroupName, string resourceName, ApplicationInsightsComponentExportRequest exportProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, resourceName, exportProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a Continuous Export configuration of an Application Insights
            /// component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='exportId'>
            /// The Continuous Export configuration ID. This is unique within a Application
            /// Insights component.
            /// </param>
            public static ApplicationInsightsComponentExportConfiguration Delete(this IExportConfigurationsOperations operations, string resourceGroupName, string resourceName, string exportId)
            {
                return operations.DeleteAsync(resourceGroupName, resourceName, exportId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a Continuous Export configuration of an Application Insights
            /// component.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='exportId'>
            /// The Continuous Export configuration ID. This is unique within a Application
            /// Insights component.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationInsightsComponentExportConfiguration> DeleteAsync(this IExportConfigurationsOperations operations, string resourceGroupName, string resourceName, string exportId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, resourceName, exportId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the Continuous Export configuration for this export id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='exportId'>
            /// The Continuous Export configuration ID. This is unique within a Application
            /// Insights component.
            /// </param>
            public static ApplicationInsightsComponentExportConfiguration Get(this IExportConfigurationsOperations operations, string resourceGroupName, string resourceName, string exportId)
            {
                return operations.GetAsync(resourceGroupName, resourceName, exportId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the Continuous Export configuration for this export id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='exportId'>
            /// The Continuous Export configuration ID. This is unique within a Application
            /// Insights component.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationInsightsComponentExportConfiguration> GetAsync(this IExportConfigurationsOperations operations, string resourceGroupName, string resourceName, string exportId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, exportId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the Continuous Export configuration for this export id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='exportId'>
            /// The Continuous Export configuration ID. This is unique within a Application
            /// Insights component.
            /// </param>
            /// <param name='exportProperties'>
            /// Properties that need to be specified to update the Continuous Export
            /// configuration.
            /// </param>
            public static ApplicationInsightsComponentExportConfiguration Update(this IExportConfigurationsOperations operations, string resourceGroupName, string resourceName, string exportId, ApplicationInsightsComponentExportRequest exportProperties)
            {
                return operations.UpdateAsync(resourceGroupName, resourceName, exportId, exportProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the Continuous Export configuration for this export id.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the Application Insights component resource.
            /// </param>
            /// <param name='exportId'>
            /// The Continuous Export configuration ID. This is unique within a Application
            /// Insights component.
            /// </param>
            /// <param name='exportProperties'>
            /// Properties that need to be specified to update the Continuous Export
            /// configuration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ApplicationInsightsComponentExportConfiguration> UpdateAsync(this IExportConfigurationsOperations operations, string resourceGroupName, string resourceName, string exportId, ApplicationInsightsComponentExportRequest exportProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, resourceName, exportId, exportProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}