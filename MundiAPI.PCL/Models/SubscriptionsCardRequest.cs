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
    public class SubscriptionsCardRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.Card1 card;
        private string cardId;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("card")]
        public Models.Card1 Card 
        { 
            get 
            {
                return this.card; 
            } 
            set 
            {
                this.card = value;
                onPropertyChanged("Card");
            }
        }

        /// <summary>
        /// Credit card id
        /// </summary>
        [JsonProperty("card_id")]
        public string CardId 
        { 
            get 
            {
                return this.cardId; 
            } 
            set 
            {
                this.cardId = value;
                onPropertyChanged("CardId");
            }
        }
    }
} 