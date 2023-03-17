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
    public class GetBankAccountResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string id;
        private string holderName;
        private string holderType;
        private string bank;
        private string branchNumber;
        private string branchCheckDigit;
        private string accountNumber;
        private string accountCheckDigit;
        private string type;
        private string status;
        private DateTime createdAt;
        private DateTime updatedAt;
        private DateTime deletedAt;
        private Models.Recipient recipient;
        private Dictionary<string, string> metadata;
        private string pixKey;

        /// <summary>
        /// Id
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
        /// Holder name
        /// </summary>
        [JsonProperty("holder_name")]
        public string HolderName 
        { 
            get 
            {
                return this.holderName; 
            } 
            set 
            {
                this.holderName = value;
                onPropertyChanged("HolderName");
            }
        }

        /// <summary>
        /// Holder type
        /// </summary>
        [JsonProperty("holder_type")]
        public string HolderType 
        { 
            get 
            {
                return this.holderType; 
            } 
            set 
            {
                this.holderType = value;
                onPropertyChanged("HolderType");
            }
        }

        /// <summary>
        /// Bank
        /// </summary>
        [JsonProperty("bank")]
        public string Bank 
        { 
            get 
            {
                return this.bank; 
            } 
            set 
            {
                this.bank = value;
                onPropertyChanged("Bank");
            }
        }

        /// <summary>
        /// Branch number
        /// </summary>
        [JsonProperty("branch_number")]
        public string BranchNumber 
        { 
            get 
            {
                return this.branchNumber; 
            } 
            set 
            {
                this.branchNumber = value;
                onPropertyChanged("BranchNumber");
            }
        }

        /// <summary>
        /// Branch check digit
        /// </summary>
        [JsonProperty("branch_check_digit")]
        public string BranchCheckDigit 
        { 
            get 
            {
                return this.branchCheckDigit; 
            } 
            set 
            {
                this.branchCheckDigit = value;
                onPropertyChanged("BranchCheckDigit");
            }
        }

        /// <summary>
        /// Account number
        /// </summary>
        [JsonProperty("account_number")]
        public string AccountNumber 
        { 
            get 
            {
                return this.accountNumber; 
            } 
            set 
            {
                this.accountNumber = value;
                onPropertyChanged("AccountNumber");
            }
        }

        /// <summary>
        /// Account check digit
        /// </summary>
        [JsonProperty("account_check_digit")]
        public string AccountCheckDigit 
        { 
            get 
            {
                return this.accountCheckDigit; 
            } 
            set 
            {
                this.accountCheckDigit = value;
                onPropertyChanged("AccountCheckDigit");
            }
        }

        /// <summary>
        /// Bank account type
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
        /// Bank account status
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
        /// Creation date
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
        /// Last update date
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
        /// Deletion date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("deleted_at")]
        public DateTime DeletedAt 
        { 
            get 
            {
                return this.deletedAt; 
            } 
            set 
            {
                this.deletedAt = value;
                onPropertyChanged("DeletedAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("recipient")]
        public Models.Recipient Recipient 
        { 
            get 
            {
                return this.recipient; 
            } 
            set 
            {
                this.recipient = value;
                onPropertyChanged("Recipient");
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
        /// Pix Key
        /// </summary>
        [JsonProperty("pix_key")]
        public string PixKey 
        { 
            get 
            {
                return this.pixKey; 
            } 
            set 
            {
                this.pixKey = value;
                onPropertyChanged("PixKey");
            }
        }
    }
} 