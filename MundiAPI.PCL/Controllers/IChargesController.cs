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
    public partial interface IChargesController
    {
        /// <summary>
        /// Updates the card from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating a charge's card</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Models.GetChargeResponse UpdateChargeCard(string chargeId, Models.UpdateChargeCardRequest request, string idempotencyKey = null);

        /// <summary>
        /// Updates the card from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating a charge's card</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<Models.GetChargeResponse> UpdateChargeCardAsync(string chargeId, Models.UpdateChargeCardRequest request, string idempotencyKey = null);

        /// <summary>
        /// Updates a charge's payment method
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating the payment method from a charge</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Models.GetChargeResponse UpdateChargePaymentMethod(string chargeId, Models.UpdateChargePaymentMethodRequest request, string idempotencyKey = null);

        /// <summary>
        /// Updates a charge's payment method
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Required parameter: Request for updating the payment method from a charge</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<Models.GetChargeResponse> UpdateChargePaymentMethodAsync(string chargeId, Models.UpdateChargePaymentMethodRequest request, string idempotencyKey = null);

        /// <summary>
        /// Creates a new charge
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a charge</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Models.GetChargeResponse CreateCharge(Models.CreateChargeRequest request, string idempotencyKey = null);

        /// <summary>
        /// Creates a new charge
        /// </summary>
        /// <param name="request">Required parameter: Request for creating a charge</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<Models.GetChargeResponse> CreateChargeAsync(Models.CreateChargeRequest request, string idempotencyKey = null);

        /// <summary>
        /// Get a charge from its id
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Models.GetChargeResponse GetCharge(string chargeId);

        /// <summary>
        /// Get a charge from its id
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<Models.GetChargeResponse> GetChargeAsync(string chargeId);

        /// <summary>
        /// Retries a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Models.GetChargeResponse RetryCharge(string chargeId, string idempotencyKey = null);

        /// <summary>
        /// Retries a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<Models.GetChargeResponse> RetryChargeAsync(string chargeId, string idempotencyKey = null);

        /// <summary>
        /// Lists all charges
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for charge's code</param>
        /// <param name="status">Optional parameter: Filter for charge's status</param>
        /// <param name="paymentMethod">Optional parameter: Filter for charge's payment method</param>
        /// <param name="customerId">Optional parameter: Filter for charge's customer id</param>
        /// <param name="orderId">Optional parameter: Filter for charge's order id</param>
        /// <param name="createdSince">Optional parameter: Filter for the beginning of the range for charge's creation</param>
        /// <param name="createdUntil">Optional parameter: Filter for the end of the range for charge's creation</param>
        /// <return>Returns the Models.ListChargesResponse response from the API call</return>
        Models.ListChargesResponse GetCharges(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                string paymentMethod = null,
                string customerId = null,
                string orderId = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// Lists all charges
        /// </summary>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <param name="code">Optional parameter: Filter for charge's code</param>
        /// <param name="status">Optional parameter: Filter for charge's status</param>
        /// <param name="paymentMethod">Optional parameter: Filter for charge's payment method</param>
        /// <param name="customerId">Optional parameter: Filter for charge's customer id</param>
        /// <param name="orderId">Optional parameter: Filter for charge's order id</param>
        /// <param name="createdSince">Optional parameter: Filter for the beginning of the range for charge's creation</param>
        /// <param name="createdUntil">Optional parameter: Filter for the end of the range for charge's creation</param>
        /// <return>Returns the Models.ListChargesResponse response from the API call</return>
        Task<Models.ListChargesResponse> GetChargesAsync(
                int? page = null,
                int? size = null,
                string code = null,
                string status = null,
                string paymentMethod = null,
                string customerId = null,
                string orderId = null,
                DateTime? createdSince = null,
                DateTime? createdUntil = null);

        /// <summary>
        /// Updates the metadata from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: The charge id</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Models.GetChargeResponse UpdateChargeMetadata(string chargeId, Models.UpdateMetadataRequest request, string idempotencyKey = null);

        /// <summary>
        /// Updates the metadata from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: The charge id</param>
        /// <param name="request">Required parameter: Request for updating the charge metadata</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<Models.GetChargeResponse> UpdateChargeMetadataAsync(string chargeId, Models.UpdateMetadataRequest request, string idempotencyKey = null);

        /// <summary>
        /// Cancel a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for cancelling a charge</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Models.GetChargeResponse CancelCharge(string chargeId, Models.CreateCancelChargeRequest request = null, string idempotencyKey = null);

        /// <summary>
        /// Cancel a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for cancelling a charge</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<Models.GetChargeResponse> CancelChargeAsync(string chargeId, Models.CreateCancelChargeRequest request = null, string idempotencyKey = null);

        /// <summary>
        /// Captures a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for capturing a charge</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Models.GetChargeResponse CaptureCharge(string chargeId, Models.CreateCaptureChargeRequest request = null, string idempotencyKey = null);

        /// <summary>
        /// Captures a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge id</param>
        /// <param name="request">Optional parameter: Request for capturing a charge</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<Models.GetChargeResponse> CaptureChargeAsync(string chargeId, Models.CreateCaptureChargeRequest request = null, string idempotencyKey = null);

        /// <summary>
        /// Updates the due date from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="request">Required parameter: Request for updating the due date</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Models.GetChargeResponse UpdateChargeDueDate(string chargeId, Models.UpdateChargeDueDateRequest request, string idempotencyKey = null);

        /// <summary>
        /// Updates the due date from a charge
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="request">Required parameter: Request for updating the due date</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<Models.GetChargeResponse> UpdateChargeDueDateAsync(string chargeId, Models.UpdateChargeDueDateRequest request, string idempotencyKey = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="chargeId">Required parameter: Example: </param>
        /// <param name="request">Optional parameter: Request for confirm payment</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Models.GetChargeResponse ConfirmPayment(string chargeId, Models.CreateConfirmPaymentRequest request = null, string idempotencyKey = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="chargeId">Required parameter: Example: </param>
        /// <param name="request">Optional parameter: Request for confirm payment</param>
        /// <param name="idempotencyKey">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargeResponse response from the API call</return>
        Task<Models.GetChargeResponse> ConfirmPaymentAsync(string chargeId, Models.CreateConfirmPaymentRequest request = null, string idempotencyKey = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <return>Returns the Models.ListChargeTransactionsResponse response from the API call</return>
        Models.ListChargeTransactionsResponse GetChargeTransactions(string chargeId, int? page = null, int? size = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="chargeId">Required parameter: Charge Id</param>
        /// <param name="page">Optional parameter: Page number</param>
        /// <param name="size">Optional parameter: Page size</param>
        /// <return>Returns the Models.ListChargeTransactionsResponse response from the API call</return>
        Task<Models.ListChargeTransactionsResponse> GetChargeTransactionsAsync(string chargeId, int? page = null, int? size = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="status">Required parameter: Example: </param>
        /// <param name="createdSince">Optional parameter: Example: </param>
        /// <param name="createdUntil">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargesSummaryResponse response from the API call</return>
        Models.GetChargesSummaryResponse GetChargesSummary(string status, DateTime? createdSince = null, DateTime? createdUntil = null);

        /// <summary>
        /// TODO: type endpoint description here
        /// </summary>
        /// <param name="status">Required parameter: Example: </param>
        /// <param name="createdSince">Optional parameter: Example: </param>
        /// <param name="createdUntil">Optional parameter: Example: </param>
        /// <return>Returns the Models.GetChargesSummaryResponse response from the API call</return>
        Task<Models.GetChargesSummaryResponse> GetChargesSummaryAsync(string status, DateTime? createdSince = null, DateTime? createdUntil = null);

    }
} 