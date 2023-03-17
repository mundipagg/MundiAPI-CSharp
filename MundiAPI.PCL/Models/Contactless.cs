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
    public class Contactless : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string type;
        private Models.ApplePay applePay;
        private Models.GooglePay googlePay;
        private Models.CreateEmvDecryptRequest emv;

        /// <summary>
        /// The authentication type
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
        [JsonProperty("apple_pay")]
        public Models.ApplePay ApplePay 
        { 
            get 
            {
                return this.applePay; 
            } 
            set 
            {
                this.applePay = value;
                onPropertyChanged("ApplePay");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("google_pay")]
        public Models.GooglePay GooglePay 
        { 
            get 
            {
                return this.googlePay; 
            } 
            set 
            {
                this.googlePay = value;
                onPropertyChanged("GooglePay");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("emv")]
        public Models.CreateEmvDecryptRequest Emv 
        { 
            get 
            {
                return this.emv; 
            } 
            set 
            {
                this.emv = value;
                onPropertyChanged("Emv");
            }
        }
    }
} 