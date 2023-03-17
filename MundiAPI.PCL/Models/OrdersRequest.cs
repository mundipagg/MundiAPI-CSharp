/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
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
    public class OrdersRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Models.CreateOrderItemRequest> items;
        private Models.Customer8 customer;
        private List<Models.CreatePaymentRequest> payments;
        private string code;
        private string customerId;
        private Models.Shipping3 shipping;
        private Dictionary<string, string> metadata;
        private bool? antifraudEnabled;
        private string ip;
        private string sessionId;
        private Models.Location location;
        private Models.Device1 device;
        private bool closed;
        private string currency;
        private Models.CreateAntifraudRequest antifraud;
        private Models.Submerchant submerchant;

        /// <summary>
        /// Items
        /// </summary>
        [JsonProperty("items")]
        public List<Models.CreateOrderItemRequest> Items 
        { 
            get 
            {
                return this.items; 
            } 
            set 
            {
                this.items = value;
                onPropertyChanged("Items");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("customer")]
        public Models.Customer8 Customer 
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
        /// Payment data
        /// </summary>
        [JsonProperty("payments")]
        public List<Models.CreatePaymentRequest> Payments 
        { 
            get 
            {
                return this.payments; 
            } 
            set 
            {
                this.payments = value;
                onPropertyChanged("Payments");
            }
        }

        /// <summary>
        /// The order code
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
        /// The customer id
        /// </summary>
        [JsonProperty("customer_id")]
        public string CustomerId 
        { 
            get 
            {
                return this.customerId; 
            } 
            set 
            {
                this.customerId = value;
                onPropertyChanged("CustomerId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("shipping")]
        public Models.Shipping3 Shipping 
        { 
            get 
            {
                return this.shipping; 
            } 
            set 
            {
                this.shipping = value;
                onPropertyChanged("Shipping");
            }
        }

        /// <summary>
        /// Metadata
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
        /// Defines whether the order will go through anti-fraud
        /// </summary>
        [JsonProperty("antifraud_enabled")]
        public bool? AntifraudEnabled 
        { 
            get 
            {
                return this.antifraudEnabled; 
            } 
            set 
            {
                this.antifraudEnabled = value;
                onPropertyChanged("AntifraudEnabled");
            }
        }

        /// <summary>
        /// Ip address
        /// </summary>
        [JsonProperty("ip")]
        public string Ip 
        { 
            get 
            {
                return this.ip; 
            } 
            set 
            {
                this.ip = value;
                onPropertyChanged("Ip");
            }
        }

        /// <summary>
        /// Session id
        /// </summary>
        [JsonProperty("session_id")]
        public string SessionId 
        { 
            get 
            {
                return this.sessionId; 
            } 
            set 
            {
                this.sessionId = value;
                onPropertyChanged("SessionId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("location")]
        public Models.Location Location 
        { 
            get 
            {
                return this.location; 
            } 
            set 
            {
                this.location = value;
                onPropertyChanged("Location");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("device")]
        public Models.Device1 Device 
        { 
            get 
            {
                return this.device; 
            } 
            set 
            {
                this.device = value;
                onPropertyChanged("Device");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("closed")]
        public bool Closed 
        { 
            get 
            {
                return this.closed; 
            } 
            set 
            {
                this.closed = value;
                onPropertyChanged("Closed");
            }
        }

        /// <summary>
        /// Currency
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
        [JsonProperty("antifraud")]
        public Models.CreateAntifraudRequest Antifraud 
        { 
            get 
            {
                return this.antifraud; 
            } 
            set 
            {
                this.antifraud = value;
                onPropertyChanged("Antifraud");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("submerchant")]
        public Models.Submerchant Submerchant 
        { 
            get 
            {
                return this.submerchant; 
            } 
            set 
            {
                this.submerchant = value;
                onPropertyChanged("Submerchant");
            }
        }
    }
} 