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
    public class Split : BaseModel 
    {
        // These fields hold the values for the public properties.
        private bool enabled;
        private List<Models.GetSplitResponse> rules;

        /// <summary>
        /// Defines if the split is enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled 
        { 
            get 
            {
                return this.enabled; 
            } 
            set 
            {
                this.enabled = value;
                onPropertyChanged("Enabled");
            }
        }

        /// <summary>
        /// Split
        /// </summary>
        [JsonProperty("rules")]
        public List<Models.GetSplitResponse> Rules 
        { 
            get 
            {
                return this.rules; 
            } 
            set 
            {
                this.rules = value;
                onPropertyChanged("Rules");
            }
        }
    }
} 