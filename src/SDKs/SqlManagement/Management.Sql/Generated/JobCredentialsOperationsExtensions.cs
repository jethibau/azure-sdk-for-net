// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for JobCredentialsOperations.
    /// </summary>
    public static partial class JobCredentialsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of jobs credentials.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            public static IPage<JobCredential> ListByAgent(this IJobCredentialsOperations operations, string resourceGroupName, string serverName, string jobAgentName)
            {
                return operations.ListByAgentAsync(resourceGroupName, serverName, jobAgentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of jobs credentials.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobCredential>> ListByAgentAsync(this IJobCredentialsOperations operations, string resourceGroupName, string serverName, string jobAgentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAgentWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a jobs credential.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='credentialName'>
            /// The name of the credential.
            /// </param>
            public static JobCredential Get(this IJobCredentialsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string credentialName)
            {
                return operations.GetAsync(resourceGroupName, serverName, jobAgentName, credentialName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a jobs credential.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='credentialName'>
            /// The name of the credential.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobCredential> GetAsync(this IJobCredentialsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string credentialName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, credentialName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a job credential.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='credentialName'>
            /// The name of the credential.
            /// </param>
            /// <param name='parameters'>
            /// The requested job credential state.
            /// </param>
            public static JobCredential CreateOrUpdate(this IJobCredentialsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string credentialName, JobCredential parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, jobAgentName, credentialName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a job credential.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='credentialName'>
            /// The name of the credential.
            /// </param>
            /// <param name='parameters'>
            /// The requested job credential state.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobCredential> CreateOrUpdateAsync(this IJobCredentialsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string credentialName, JobCredential parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, credentialName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a job credential.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='credentialName'>
            /// The name of the credential.
            /// </param>
            public static void Delete(this IJobCredentialsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string credentialName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, jobAgentName, credentialName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a job credential.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='credentialName'>
            /// The name of the credential.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IJobCredentialsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string credentialName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, credentialName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a list of jobs credentials.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobCredential> ListByAgentNext(this IJobCredentialsOperations operations, string nextPageLink)
            {
                return operations.ListByAgentNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of jobs credentials.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobCredential>> ListByAgentNextAsync(this IJobCredentialsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAgentNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}