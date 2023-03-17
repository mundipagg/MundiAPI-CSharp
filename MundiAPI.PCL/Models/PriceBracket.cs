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
    public class PriceBracket : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int startQuantity;
        private int price;
        private int? endQuantity;
        private int? overagePrice;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("start_quantity")]
        public int StartQuantity 
        { 
            get 
            {
                return this.startQuantity; 
            } 
            set 
            {
                this.startQuantity = value;
                onPropertyChanged("StartQuantity");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("price")]
        public int Price 
        { 
            get 
            {
                return this.price; 
            } 
            set 
            {
                this.price = value;
                onPropertyChanged("Price");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("end_quantity")]
        public int? EndQuantity 
        { 
            get 
            {
                return this.endQuantity; 
            } 
            set 
            {
                this.endQuantity = value;
                onPropertyChanged("EndQuantity");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("overage_price")]
        public int? OveragePrice 
        { 
            get 
            {
                return this.overagePrice; 
            } 
            set 
            {
                this.overagePrice = value;
                onPropertyChanged("OveragePrice");
            }
        }
    }
} 