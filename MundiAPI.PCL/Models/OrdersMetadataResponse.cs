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
    public class OrdersMetadataResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string id;
        private string code;
        private string currency;
        private List<Models.GetOrderItemResponse> items;
        private Models.Customer customer;
        private string status;
        private DateTime createdAt;
        private DateTime updatedAt;
        private List<Models.GetChargeResponse> charges;
        private string invoiceUrl;
        private Models.Shipping shipping;
        private Dictionary<string, string> metadata;
        private List<Models.GetCheckoutPaymentResponse> checkouts;
        private string ip;
        private string sessionId;
        private Models.Location location;
        private Models.Device device;
        private bool closed;

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
        [JsonProperty("items")]
        public List<Models.GetOrderItemResponse> Items 
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
        public Models.Customer Customer 
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
        [JsonProperty("charges")]
        public List<Models.GetChargeResponse> Charges 
        { 
            get 
            {
                return this.charges; 
            } 
            set 
            {
                this.charges = value;
                onPropertyChanged("Charges");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("invoice_url")]
        public string InvoiceUrl 
        { 
            get 
            {
                return this.invoiceUrl; 
            } 
            set 
            {
                this.invoiceUrl = value;
                onPropertyChanged("InvoiceUrl");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("shipping")]
        public Models.Shipping Shipping 
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
        /// Checkout Payment Settings Response
        /// </summary>
        [JsonProperty("checkouts")]
        public List<Models.GetCheckoutPaymentResponse> Checkouts 
        { 
            get 
            {
                return this.checkouts; 
            } 
            set 
            {
                this.checkouts = value;
                onPropertyChanged("Checkouts");
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
        public Models.Device Device 
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
        /// Indicates whether the order is closed
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
    }
} 