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
    public class GetInterestResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int days;
        private string type;
        private int amount;

        /// <summary>
        /// Days
        /// </summary>
        [JsonProperty("days")]
        public int Days 
        { 
            get 
            {
                return this.days; 
            } 
            set 
            {
                this.days = value;
                onPropertyChanged("Days");
            }
        }

        /// <summary>
        /// Type
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
        /// Amount
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
    }
} 