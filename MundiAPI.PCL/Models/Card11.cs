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
    public class Card11 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string number;
        private string holderName;
        private int expMonth;
        private int expYear;
        private string cvv;
        private string brand;
        private string label;

        /// <summary>
        /// Credit card number
        /// </summary>
        [JsonProperty("number")]
        public string Number 
        { 
            get 
            {
                return this.number; 
            } 
            set 
            {
                this.number = value;
                onPropertyChanged("Number");
            }
        }

        /// <summary>
        /// Holder name, as written on the card
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
        /// The expiration month
        /// </summary>
        [JsonProperty("exp_month")]
        public int ExpMonth 
        { 
            get 
            {
                return this.expMonth; 
            } 
            set 
            {
                this.expMonth = value;
                onPropertyChanged("ExpMonth");
            }
        }

        /// <summary>
        /// The expiration year, that can be informed with 2 or 4 digits
        /// </summary>
        [JsonProperty("exp_year")]
        public int ExpYear 
        { 
            get 
            {
                return this.expYear; 
            } 
            set 
            {
                this.expYear = value;
                onPropertyChanged("ExpYear");
            }
        }

        /// <summary>
        /// The card's security code
        /// </summary>
        [JsonProperty("cvv")]
        public string Cvv 
        { 
            get 
            {
                return this.cvv; 
            } 
            set 
            {
                this.cvv = value;
                onPropertyChanged("Cvv");
            }
        }

        /// <summary>
        /// Card brand
        /// </summary>
        [JsonProperty("brand")]
        public string Brand 
        { 
            get 
            {
                return this.brand; 
            } 
            set 
            {
                this.brand = value;
                onPropertyChanged("Brand");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("label")]
        public string Label 
        { 
            get 
            {
                return this.label; 
            } 
            set 
            {
                this.label = value;
                onPropertyChanged("Label");
            }
        }
    }
} 