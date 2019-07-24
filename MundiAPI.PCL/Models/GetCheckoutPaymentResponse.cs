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
    public class GetCheckoutPaymentResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string id;
        private int? amount;
        private string defaultPaymentMethod;
        private string successUrl;
        private string paymentUrl;
        private string gatewayAffiliationId;
        private List<string> acceptedPaymentMethods;
        private string status;
        private bool skipCheckoutSuccessPage;
        private DateTime createdAt;
        private DateTime updatedAt;
        private DateTime? canceledAt;
        private bool customerEditable;
        private Models.GetCustomerResponse customer;
        private Models.GetAddressResponse billingaddress;
        private Models.GetCheckoutCreditCardPaymentResponse creditCard;
        private Models.GetCheckoutBoletoPaymentResponse boleto;
        private bool billingAddressEditable;
        private Models.GetShippingResponse shipping;
        private bool shippable;
        private DateTime? closedAt;
        private DateTime? expiresAt;
        private string currency;
        private Models.GetCheckoutDebitCardPaymentResponse debitCard;
        private Models.GetCheckoutBankTransferPaymentResponse bankTransfer;

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
        /// Valor em centavos
        /// </summary>
        [JsonProperty("amount")]
        public int? Amount 
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

        /// <summary>
        /// Meio de pagamento padrão no checkout
        /// </summary>
        [JsonProperty("default_payment_method")]
        public string DefaultPaymentMethod 
        { 
            get 
            {
                return this.defaultPaymentMethod; 
            } 
            set 
            {
                this.defaultPaymentMethod = value;
                onPropertyChanged("DefaultPaymentMethod");
            }
        }

        /// <summary>
        /// Url de redirecionamento de sucesso após o checkou
        /// </summary>
        [JsonProperty("success_url")]
        public string SuccessUrl 
        { 
            get 
            {
                return this.successUrl; 
            } 
            set 
            {
                this.successUrl = value;
                onPropertyChanged("SuccessUrl");
            }
        }

        /// <summary>
        /// Url para pagamento usando o checkout
        /// </summary>
        [JsonProperty("payment_url")]
        public string PaymentUrl 
        { 
            get 
            {
                return this.paymentUrl; 
            } 
            set 
            {
                this.paymentUrl = value;
                onPropertyChanged("PaymentUrl");
            }
        }

        /// <summary>
        /// Código da afiliação onde o pagamento será processado no gateway
        /// </summary>
        [JsonProperty("gateway_affiliation_id")]
        public string GatewayAffiliationId 
        { 
            get 
            {
                return this.gatewayAffiliationId; 
            } 
            set 
            {
                this.gatewayAffiliationId = value;
                onPropertyChanged("GatewayAffiliationId");
            }
        }

        /// <summary>
        /// Meios de pagamento aceitos no checkout
        /// </summary>
        [JsonProperty("accepted_payment_methods")]
        public List<string> AcceptedPaymentMethods 
        { 
            get 
            {
                return this.acceptedPaymentMethods; 
            } 
            set 
            {
                this.acceptedPaymentMethods = value;
                onPropertyChanged("AcceptedPaymentMethods");
            }
        }

        /// <summary>
        /// Status do checkout
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
        /// Pular tela de sucesso pós-pagamento?
        /// </summary>
        [JsonProperty("skip_checkout_success_page")]
        public bool SkipCheckoutSuccessPage 
        { 
            get 
            {
                return this.skipCheckoutSuccessPage; 
            } 
            set 
            {
                this.skipCheckoutSuccessPage = value;
                onPropertyChanged("SkipCheckoutSuccessPage");
            }
        }

        /// <summary>
        /// Data de criação
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
        /// Data de atualização
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
        /// Data de cancelamento
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("canceled_at")]
        public DateTime? CanceledAt 
        { 
            get 
            {
                return this.canceledAt; 
            } 
            set 
            {
                this.canceledAt = value;
                onPropertyChanged("CanceledAt");
            }
        }

        /// <summary>
        /// Torna o objeto customer editável
        /// </summary>
        [JsonProperty("customer_editable")]
        public bool CustomerEditable 
        { 
            get 
            {
                return this.customerEditable; 
            } 
            set 
            {
                this.customerEditable = value;
                onPropertyChanged("CustomerEditable");
            }
        }

        /// <summary>
        /// Dados do comprador
        /// </summary>
        [JsonProperty("customer")]
        public Models.GetCustomerResponse Customer 
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
        /// Dados do endereço de cobrança
        /// </summary>
        [JsonProperty("billingaddress")]
        public Models.GetAddressResponse Billingaddress 
        { 
            get 
            {
                return this.billingaddress; 
            } 
            set 
            {
                this.billingaddress = value;
                onPropertyChanged("Billingaddress");
            }
        }

        /// <summary>
        /// Configurações de cartão de crédito
        /// </summary>
        [JsonProperty("credit_card")]
        public Models.GetCheckoutCreditCardPaymentResponse CreditCard 
        { 
            get 
            {
                return this.creditCard; 
            } 
            set 
            {
                this.creditCard = value;
                onPropertyChanged("CreditCard");
            }
        }

        /// <summary>
        /// Configurações de boleto
        /// </summary>
        [JsonProperty("boleto")]
        public Models.GetCheckoutBoletoPaymentResponse Boleto 
        { 
            get 
            {
                return this.boleto; 
            } 
            set 
            {
                this.boleto = value;
                onPropertyChanged("Boleto");
            }
        }

        /// <summary>
        /// Indica se o billing address poderá ser editado
        /// </summary>
        [JsonProperty("billing_address_editable")]
        public bool BillingAddressEditable 
        { 
            get 
            {
                return this.billingAddressEditable; 
            } 
            set 
            {
                this.billingAddressEditable = value;
                onPropertyChanged("BillingAddressEditable");
            }
        }

        /// <summary>
        /// Configurações  de entrega
        /// </summary>
        [JsonProperty("shipping")]
        public Models.GetShippingResponse Shipping 
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
        /// Indica se possui entrega
        /// </summary>
        [JsonProperty("shippable")]
        public bool Shippable 
        { 
            get 
            {
                return this.shippable; 
            } 
            set 
            {
                this.shippable = value;
                onPropertyChanged("Shippable");
            }
        }

        /// <summary>
        /// Data de fechamento
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("closed_at")]
        public DateTime? ClosedAt 
        { 
            get 
            {
                return this.closedAt; 
            } 
            set 
            {
                this.closedAt = value;
                onPropertyChanged("ClosedAt");
            }
        }

        /// <summary>
        /// Data de expiração
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at")]
        public DateTime? ExpiresAt 
        { 
            get 
            {
                return this.expiresAt; 
            } 
            set 
            {
                this.expiresAt = value;
                onPropertyChanged("ExpiresAt");
            }
        }

        /// <summary>
        /// Moeda
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
        /// Configurações de cartão de débito
        /// </summary>
        [JsonProperty("debit_card")]
        public Models.GetCheckoutDebitCardPaymentResponse DebitCard 
        { 
            get 
            {
                return this.debitCard; 
            } 
            set 
            {
                this.debitCard = value;
                onPropertyChanged("DebitCard");
            }
        }

        /// <summary>
        /// Bank transfer payment response
        /// </summary>
        [JsonProperty("bank_transfer")]
        public Models.GetCheckoutBankTransferPaymentResponse BankTransfer 
        { 
            get 
            {
                return this.bankTransfer; 
            } 
            set 
            {
                this.bankTransfer = value;
                onPropertyChanged("BankTransfer");
            }
        }
    }
} 