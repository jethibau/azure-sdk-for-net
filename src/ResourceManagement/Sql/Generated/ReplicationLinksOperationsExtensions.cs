// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ReplicationLinksOperations.
    /// </summary>
    public static partial class ReplicationLinksOperationsExtensions
    {
            /// <summary>
            /// Deletes a database replication link. Cannot be done during failover.
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
            /// <param name='databaseName'>
            /// The name of the database that has the replication link to be dropped.
            /// </param>
            /// <param name='linkId'>
            /// The ID of the replication link to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IReplicationLinksOperations operations, string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, linkId, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a database replication link.
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
            /// <param name='databaseName'>
            /// The name of the database to get the link for.
            /// </param>
            /// <param name='linkId'>
            /// The replication link ID to be retrieved.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ReplicationLinkInner> GetAsync(this IReplicationLinksOperations operations, string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, linkId, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets which replica database is primary by failing over from the current
            /// primary replica database.
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
            /// <param name='databaseName'>
            /// The name of the database that has the replication link to be failed over.
            /// </param>
            /// <param name='linkId'>
            /// The ID of the replication link to be failed over.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task FailoverAsync(this IReplicationLinksOperations operations, string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.FailoverWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, linkId, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Sets which replica database is primary by failing over from the current
            /// primary replica database. This operation might result in data loss.
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
            /// <param name='databaseName'>
            /// The name of the database that has the replication link to be failed over.
            /// </param>
            /// <param name='linkId'>
            /// The ID of the replication link to be failed over.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task FailoverAllowDataLossAsync(this IReplicationLinksOperations operations, string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.FailoverAllowDataLossWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, linkId, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists a database's replication links.
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
            /// <param name='databaseName'>
            /// The name of the database to retrieve links for.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ReplicationLinkInner>> ListByDatabaseAsync(this IReplicationLinksOperations operations, string resourceGroupName, string serverName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDatabaseWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets which replica database is primary by failing over from the current
            /// primary replica database.
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
            /// <param name='databaseName'>
            /// The name of the database that has the replication link to be failed over.
            /// </param>
            /// <param name='linkId'>
            /// The ID of the replication link to be failed over.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginFailoverAsync(this IReplicationLinksOperations operations, string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginFailoverWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, linkId, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Sets which replica database is primary by failing over from the current
            /// primary replica database. This operation might result in data loss.
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
            /// <param name='databaseName'>
            /// The name of the database that has the replication link to be failed over.
            /// </param>
            /// <param name='linkId'>
            /// The ID of the replication link to be failed over.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginFailoverAllowDataLossAsync(this IReplicationLinksOperations operations, string resourceGroupName, string serverName, string databaseName, string linkId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginFailoverAllowDataLossWithHttpMessagesAsync(resourceGroupName, serverName, databaseName, linkId, SqlManagementClient.SetJsonAcceptHeader(), cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}