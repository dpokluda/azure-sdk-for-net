// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ProviderShareSubscriptionsOperations operations.
    /// </summary>
    public partial interface IProviderShareSubscriptionsOperations
    {
        /// <summary>
        /// Adjust the expiration date of a share subscription in a provider
        /// share.
        /// </summary>
        /// <remarks>
        /// Adjust a share subscription's expiration date in a provider share
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share.
        /// </param>
        /// <param name='providerShareSubscriptionId'>
        /// To locate shareSubscription
        /// </param>
        /// <param name='providerShareSubscription'>
        /// The provider share subscription
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProviderShareSubscription>> AdjustWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string providerShareSubscriptionId, ProviderShareSubscription providerShareSubscription, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Reinstate share subscription in a provider share.
        /// </summary>
        /// <remarks>
        /// Reinstate share subscription in a provider share
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share.
        /// </param>
        /// <param name='providerShareSubscriptionId'>
        /// To locate shareSubscription
        /// </param>
        /// <param name='providerShareSubscription'>
        /// The provider share subscription
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProviderShareSubscription>> ReinstateWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string providerShareSubscriptionId, ProviderShareSubscription providerShareSubscription, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Revoke share subscription in a provider share.
        /// </summary>
        /// <remarks>
        /// Revoke share subscription in a provider share
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share.
        /// </param>
        /// <param name='providerShareSubscriptionId'>
        /// To locate shareSubscription
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProviderShareSubscription>> RevokeWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string providerShareSubscriptionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get share subscription in a provider share.
        /// </summary>
        /// <remarks>
        /// Get share subscription in a provider share
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share.
        /// </param>
        /// <param name='providerShareSubscriptionId'>
        /// To locate shareSubscription
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProviderShareSubscription>> GetByShareWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string providerShareSubscriptionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List of available share subscriptions to a provider share.
        /// </summary>
        /// <remarks>
        /// List share subscriptions in a provider share
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share.
        /// </param>
        /// <param name='skipToken'>
        /// Continuation Token
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ProviderShareSubscription>>> ListByShareWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string skipToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Revoke share subscription in a provider share.
        /// </summary>
        /// <remarks>
        /// Revoke share subscription in a provider share
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share.
        /// </param>
        /// <param name='providerShareSubscriptionId'>
        /// To locate shareSubscription
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ProviderShareSubscription>> BeginRevokeWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string providerShareSubscriptionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List of available share subscriptions to a provider share.
        /// </summary>
        /// <remarks>
        /// List share subscriptions in a provider share
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ProviderShareSubscription>>> ListByShareNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
