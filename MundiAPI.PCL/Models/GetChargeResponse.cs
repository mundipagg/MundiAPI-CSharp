/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities;

namespace MundiAPI.PCL.Models
{
    public class GetChargeResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string id;
        private string code;
        private string gatewayId;
        private int amount;
        private string status;
        private string currency;
        private string paymentMethod;
        private DateTime dueAt;
        private DateTime createdAt;
        private DateTime updatedAt;
        private Models.GetTransactionResponse lastTransaction;
        private Models.GetInvoiceResponse invoice;
        private Models.GetOrderResponse order;
        private Models.GetCustomerResponse customer;
        private Dictionary<string, string> metadata;
        private DateTime? paidAt;
        private DateTime? canceledAt;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("code")]
        public string Code 
        { 
            get 
            {
                return this.code; 
            } 
            set 
            {
                this.code = value;
                onPropertyChanged("Code");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("gateway_id")]
        public string GatewayId 
        { 
            get 
            {
                return this.gatewayId; 
            } 
            set 
            {
                this.gatewayId = value;
                onPropertyChanged("GatewayId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("amount")]
        public int Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("currency")]
        public string Currency 
        { 
            get 
            {
                return this.currency; 
            } 
            set 
            {
                this.currency = value;
                onPropertyChanged("Currency");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("payment_method")]
        public string PaymentMethod 
        { 
            get 
            {
                return this.paymentMethod; 
            } 
            set 
            {
                this.paymentMethod = value;
                onPropertyChanged("PaymentMethod");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("due_at")]
        public DateTime DueAt 
        { 
            get 
            {
                return this.dueAt; 
            } 
            set 
            {
                this.dueAt = value;
                onPropertyChanged("DueAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt 
        { 
            get 
            {
                return this.createdAt; 
            } 
            set 
            {
                this.createdAt = value;
                onPropertyChanged("CreatedAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt 
        { 
            get 
            {
                return this.updatedAt; 
            } 
            set 
            {
                this.updatedAt = value;
                onPropertyChanged("UpdatedAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("last_transaction")]
        public Models.GetTransactionResponse LastTransaction 
        { 
            get 
            {
                return this.lastTransaction; 
            } 
            set 
            {
                this.lastTransaction = value;
                onPropertyChanged("LastTransaction");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("invoice")]
        public Models.GetInvoiceResponse Invoice 
        { 
            get 
            {
                return this.invoice; 
            } 
            set 
            {
                this.invoice = value;
                onPropertyChanged("Invoice");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("order")]
        public Models.GetOrderResponse Order 
        { 
            get 
            {
                return this.order; 
            } 
            set 
            {
                this.order = value;
                onPropertyChanged("Order");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("customer")]
        public Models.GetCustomerResponse Customer 
        { 
            get 
            {
                return this.customer; 
            } 
            set 
            {
                this.customer = value;
                onPropertyChanged("Customer");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata 
        { 
            get 
            {
                return this.metadata; 
            } 
            set 
            {
                this.metadata = value;
                onPropertyChanged("Metadata");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("paid_at")]
        public DateTime? PaidAt 
        { 
            get 
            {
                return this.paidAt; 
            } 
            set 
            {
                this.paidAt = value;
                onPropertyChanged("PaidAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("canceled_at")]
        public DateTime? CanceledAt 
        { 
            get 
            {
                return this.canceledAt; 
            } 
            set 
            {
                this.canceledAt = value;
                onPropertyChanged("CanceledAt");
            }
        }
    }
} 