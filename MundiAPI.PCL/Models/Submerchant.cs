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
    public class Submerchant : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string paymentFacilitatorCode;
        private string code;
        private string name;
        private string merchantCategoryCode;
        private string document;
        private string type;
        private Models.GetPhoneResponse phone;
        private Models.Address1 address;

        /// <summary>
        /// Payment Facilitator Code
        /// </summary>
        [JsonProperty("payment_facilitator_code")]
        public string PaymentFacilitatorCode 
        { 
            get 
            {
                return this.paymentFacilitatorCode; 
            } 
            set 
            {
                this.paymentFacilitatorCode = value;
                onPropertyChanged("PaymentFacilitatorCode");
            }
        }

        /// <summary>
        /// Code
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
        /// Name
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Merchant Category Code
        /// </summary>
        [JsonProperty("merchant_category_code")]
        public string MerchantCategoryCode 
        { 
            get 
            {
                return this.merchantCategoryCode; 
            } 
            set 
            {
                this.merchantCategoryCode = value;
                onPropertyChanged("MerchantCategoryCode");
            }
        }

        /// <summary>
        /// Document number. Only numbers, no special characters.
        /// </summary>
        [JsonProperty("document")]
        public string Document 
        { 
            get 
            {
                return this.document; 
            } 
            set 
            {
                this.document = value;
                onPropertyChanged("Document");
            }
        }

        /// <summary>
        /// Document type. Can be either 'individual' or 'company'
        /// </summary>
        [JsonProperty("type")]
        public string Type 
        { 
            get 
            {
                return this.type; 
            } 
            set 
            {
                this.type = value;
                onPropertyChanged("Type");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("phone")]
        public Models.GetPhoneResponse Phone 
        { 
            get 
            {
                return this.phone; 
            } 
            set 
            {
                this.phone = value;
                onPropertyChanged("Phone");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("address")]
        public Models.Address1 Address 
        { 
            get 
            {
                return this.address; 
            } 
            set 
            {
                this.address = value;
                onPropertyChanged("Address");
            }
        }
    }
} 