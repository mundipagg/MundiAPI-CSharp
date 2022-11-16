/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities;
using MundiAPI.PCL.Http.Request;
using MundiAPI.PCL.Http.Response;
using MundiAPI.PCL.Http.Client;

namespace MundiAPI.PCL.Controllers
{
    public partial interface IRecipientsController
    {
        /// <summary>
        /// Updates recipient metadata
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="request">Required parameter: Metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Models.GetRecipientResponse UpdateRecipientMetadata(string recipientId, Models.UpdateMetadataRequest request, string idempotencyKey = null);

        /// <summary>
        /// Updates recipient metadata
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="request">Required parameter: Metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Task<Models.GetRecipientResponse> UpdateRecipientMetadataAsync(string recipientId, Models.UpdateMetadataRequest request, string idempotencyKey = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Identificator</param>
        /// <param name="request">Required parameter: Example: </param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Models.GetRecipientResponse UpdateRecipientTransferSettings(string recipientId, Models.UpdateTransferSettingsRequest request, string idempotencyKey = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Identificator</param>
        /// <param name="request">Required parameter: Example: </param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Task<Models.GetRecipientResponse> UpdateRecipientTransferSettingsAsync(string recipientId, Models.UpdateTransferSettingsRequest request, string idempotencyKey = null);

        /// <summary>
        /// Gets an anticipation
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="anticipationId">Required parameter: Anticipation id</param>
        /// <return>Returns the Models.GetAnticipationResponse response from the API call</return>
        Models.GetAnticipationResponse GetAnticipation(string recipientId, string anticipationId);

        /// <summary>
        /// Gets an anticipation
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="anticipationId">Required parameter: Anticipation id</param>
        /// <return>Returns the Models.GetAnticipationResponse response from the API call</return>
        Task<Models.GetAnticipationResponse> GetAnticipationAsync(string recipientId, string anticipationId);

        /// <summary>
        /// Retrieves paginated recipients information
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <return>Returns the Models.ListRecipientResponse response from the API call</return>
        Models.ListRecipientResponse GetRecipients(int? page = null, int? size = null);

        /// <summary>
        /// Retrieves paginated recipients information
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <return>Returns the Models.ListRecipientResponse response from the API call</return>
        Task<Models.ListRecipientResponse> GetRecipientsAsync(int? page = null, int? size = null);

        /// <summary>
        /// Get balance information for a recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <return>Returns the Models.GetBalanceResponse response from the API call</return>
        Models.GetBalanceResponse GetBalance(string recipientId);

        /// <summary>
        /// Get balance information for a recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <return>Returns the Models.GetBalanceResponse response from the API call</return>
        Task<Models.GetBalanceResponse> GetBalanceAsync(string recipientId);

        /// <summary>
        /// Retrieves a paginated list of anticipations from a recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="status">Optional parameter: Filter for anticipation status</param>
        /// <param name="timeframe">Optional parameter: Filter for anticipation timeframe</param>
        /// <param name="paymentDateSince">Optional parameter: Filter for start range for anticipation payment date</param>
        /// <param name="paymentDateUntil">Optional parameter: Filter for end range for anticipation payment date</param>
        /// <param name="createdSince">Optional parameter: Filter for start range for anticipation creation date</param>
        /// <param name="createdUntil">Optional parameter: Filter for end range for anticipation creation date</param>
        /// <return>Returns the Models.ListAnticipationResponse response from the API call</return>
        Models.ListAnticipationResponse GetAnticipations(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                string timeframe = null,
                DateTime? paymentDateSince = null,
                DateTime? paymentDateUntil = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// Retrieves a paginated list of anticipations from a recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="status">Optional parameter: Filter for anticipation status</param>
        /// <param name="timeframe">Optional parameter: Filter for anticipation timeframe</param>
        /// <param name="paymentDateSince">Optional parameter: Filter for start range for anticipation payment date</param>
        /// <param name="paymentDateUntil">Optional parameter: Filter for end range for anticipation payment date</param>
        /// <param name="createdSince">Optional parameter: Filter for start range for anticipation creation date</param>
        /// <param name="createdUntil">Optional parameter: Filter for end range for anticipation creation date</param>
        /// <return>Returns the Models.ListAnticipationResponse response from the API call</return>
        Task<Models.ListAnticipationResponse> GetAnticipationsAsync(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                string timeframe = null,
                DateTime? paymentDateSince = null,
                DateTime? paymentDateUntil = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// Creates an anticipation
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="request">Required parameter: Anticipation data</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetAnticipationResponse response from the API call</return>
        Models.GetAnticipationResponse CreateAnticipation(string recipientId, Models.CreateAnticipationRequest request, string idempotencyKey = null);

        /// <summary>
        /// Creates an anticipation
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="request">Required parameter: Anticipation data</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetAnticipationResponse response from the API call</return>
        Task<Models.GetAnticipationResponse> CreateAnticipationAsync(string recipientId, Models.CreateAnticipationRequest request, string idempotencyKey = null);

        /// <summary>
        /// Updates the default bank account from a recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="request">Required parameter: Bank account data</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Models.GetRecipientResponse UpdateRecipientDefaultBankAccount(string recipientId, Models.UpdateRecipientBankAccountRequest request, string idempotencyKey = null);

        /// <summary>
        /// Updates the default bank account from a recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="request">Required parameter: Bank account data</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Task<Models.GetRecipientResponse> UpdateRecipientDefaultBankAccountAsync(string recipientId, Models.UpdateRecipientBankAccountRequest request, string idempotencyKey = null);

        /// <summary>
        /// Retrieves recipient information
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipiend id</param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Models.GetRecipientResponse GetRecipient(string recipientId);

        /// <summary>
        /// Retrieves recipient information
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipiend id</param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Task<Models.GetRecipientResponse> GetRecipientAsync(string recipientId);

        /// <summary>
        /// Gets the anticipation limits for a recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="timeframe">Required parameter: Timeframe</param>
        /// <param name="paymentDate">Required parameter: Anticipation payment date</param>
        /// <return>Returns the Models.GetAnticipationLimitResponse response from the API call</return>
        Models.GetAnticipationLimitResponse GetAnticipationLimits(string recipientId, string timeframe, DateTime paymentDate);

        /// <summary>
        /// Gets the anticipation limits for a recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="timeframe">Required parameter: Timeframe</param>
        /// <param name="paymentDate">Required parameter: Anticipation payment date</param>
        /// <return>Returns the Models.GetAnticipationLimitResponse response from the API call</return>
        Task<Models.GetAnticipationLimitResponse> GetAnticipationLimitsAsync(string recipientId, string timeframe, DateTime paymentDate);

        /// <summary>
        /// Gets a transfer
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="transferId">Required parameter: Transfer id</param>
        /// <return>Returns the Models.GetTransferResponse response from the API call</return>
        Models.GetTransferResponse GetTransfer(string recipientId, string transferId);

        /// <summary>
        /// Gets a transfer
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="transferId">Required parameter: Transfer id</param>
        /// <return>Returns the Models.GetTransferResponse response from the API call</return>
        Task<Models.GetTransferResponse> GetTransferAsync(string recipientId, string transferId);

        /// <summary>
        /// Gets a paginated list of transfers for the recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="status">Optional parameter: Filter for transfer status</param>
        /// <param name="createdSince">Optional parameter: Filter for start range of transfer creation date</param>
        /// <param name="createdUntil">Optional parameter: Filter for end range of transfer creation date</param>
        /// <return>Returns the Models.ListTransferResponse response from the API call</return>
        Models.ListTransferResponse GetTransfers(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// Gets a paginated list of transfers for the recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="status">Optional parameter: Filter for transfer status</param>
        /// <param name="createdSince">Optional parameter: Filter for start range of transfer creation date</param>
        /// <param name="createdUntil">Optional parameter: Filter for end range of transfer creation date</param>
        /// <return>Returns the Models.ListTransferResponse response from the API call</return>
        Task<Models.ListTransferResponse> GetTransfersAsync(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// Updates a recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="request">Required parameter: Recipient data</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Models.GetRecipientResponse UpdateRecipient(string recipientId, Models.UpdateRecipientRequest request, string idempotencyKey = null);

        /// <summary>
        /// Updates a recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="request">Required parameter: Recipient data</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Task<Models.GetRecipientResponse> UpdateRecipientAsync(string recipientId, Models.UpdateRecipientRequest request, string idempotencyKey = null);

        /// <summary>
        /// Creates a new recipient
        /// </summary>
        /// <param name="request">Required parameter: Recipient data</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Models.GetRecipientResponse CreateRecipient(Models.CreateRecipientRequest request, string idempotencyKey = null);

        /// <summary>
        /// Creates a new recipient
        /// </summary>
        /// <param name="request">Required parameter: Recipient data</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Task<Models.GetRecipientResponse> CreateRecipientAsync(Models.CreateRecipientRequest request, string idempotencyKey = null);

        /// <summary>
        /// Creates a transfer for a recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Id</param>
        /// <param name="request">Required parameter: Transfer data</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetTransferResponse response from the API call</return>
        Models.GetTransferResponse CreateTransfer(string recipientId, Models.CreateTransferRequest request, string idempotencyKey = null);

        /// <summary>
        /// Creates a transfer for a recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient Id</param>
        /// <param name="request">Required parameter: Transfer data</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetTransferResponse response from the API call</return>
        Task<Models.GetTransferResponse> CreateTransferAsync(string recipientId, Models.CreateTransferRequest request, string idempotencyKey = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: </param>
        /// <param name="request">Required parameter: Example: </param>
        /// <return>Returns the Models.GetWithdrawResponse response from the API call</return>
        Models.GetWithdrawResponse CreateWithdraw(string recipientId, Models.CreateWithdrawRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: </param>
        /// <param name="request">Required parameter: Example: </param>
        /// <return>Returns the Models.GetWithdrawResponse response from the API call</return>
        Task<Models.GetWithdrawResponse> CreateWithdrawAsync(string recipientId, Models.CreateWithdrawRequest request);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: </param>
        /// <param name="withdrawalId">Required parameter: Example: </param>
        /// <return>Returns the Models.GetWithdrawResponse response from the API call</return>
        Models.GetWithdrawResponse GetWithdrawById(string recipientId, string withdrawalId);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: </param>
        /// <param name="withdrawalId">Required parameter: Example: </param>
        /// <return>Returns the Models.GetWithdrawResponse response from the API call</return>
        Task<Models.GetWithdrawResponse> GetWithdrawByIdAsync(string recipientId, string withdrawalId);

        /// <summary>
        /// Gets a paginated list of transfers for the recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: </param>
        /// <param name="page">Optional parameter: Example: </param>
        /// <param name="size">Optional parameter: Example: </param>
        /// <param name="status">Optional parameter: Example: </param>
        /// <param name="createdSince">Optional parameter: Example: </param>
        /// <param name="createdUntil">Optional parameter: Example: </param>
        /// <return>Returns the Models.ListWithdrawals response from the API call</return>
        Models.ListWithdrawals GetWithdrawals(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// Gets a paginated list of transfers for the recipient
        /// </summary>
        /// <param name="recipientId">Required parameter: Example: </param>
        /// <param name="page">Optional parameter: Example: </param>
        /// <param name="size">Optional parameter: Example: </param>
        /// <param name="status">Optional parameter: Example: </param>
        /// <param name="createdSince">Optional parameter: Example: </param>
        /// <param name="createdUntil">Optional parameter: Example: </param>
        /// <return>Returns the Models.ListWithdrawals response from the API call</return>
        Task<Models.ListWithdrawals> GetWithdrawalsAsync(
                string recipientId,
                int? page = null,
                int? size = null,
                string status = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// Updates recipient metadata
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="request">Required parameter: Metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Models.GetRecipientResponse UpdateAutomaticAnticipationSettings(string recipientId, Models.UpdateAutomaticAnticipationSettingsRequest request, string idempotencyKey = null);

        /// <summary>
        /// Updates recipient metadata
        /// </summary>
        /// <param name="recipientId">Required parameter: Recipient id</param>
        /// <param name="request">Required parameter: Metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Task<Models.GetRecipientResponse> UpdateAutomaticAnticipationSettingsAsync(string recipientId, Models.UpdateAutomaticAnticipationSettingsRequest request, string idempotencyKey = null);

        /// <summary>
        /// Retrieves recipient information
        /// </summary>
        /// <param name="code">Required parameter: Recipient code</param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Models.GetRecipientResponse GetRecipientByCode(string code);

        /// <summary>
        /// Retrieves recipient information
        /// </summary>
        /// <param name="code">Required parameter: Recipient code</param>
        /// <return>Returns the Models.GetRecipientResponse response from the API call</return>
        Task<Models.GetRecipientResponse> GetRecipientByCodeAsync(string code);

    }
} 