# Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (MundiAPIPCL.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPIPCL&projectName=MundiAPI.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the MundiAPIPCL library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPIPCL&projectName=MundiAPI.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPIPCL&projectName=MundiAPI.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPIPCL&projectName=MundiAPI.PCL)

### 3. Add reference of the library project

In order to use the MundiAPIPCL library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPIPCL&projectName=MundiAPI.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` MundiAPI.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```MundiAPI.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPIPCL&projectName=MundiAPI.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=MundiAPI-CSharp&workspaceName=MundiAPIPCL&projectName=MundiAPI.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| basicAuthUserName | The username to use with basic authentication |
| basicAuthPassword | The password to use with basic authentication |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

MundiAPIPCLClient client = new MundiAPIPCLClient(basicAuthUserName, basicAuthPassword);
```

## Class Reference

### <a name="list_of_controllers"></a>List of Controllers

* [ChargesController](#charges_controller)
* [CustomersController](#customers_controller)
* [SubscriptionsController](#subscriptions_controller)
* [PlansController](#plans_controller)
* [InvoicesController](#invoices_controller)
* [OrdersController](#orders_controller)

### <a name="charges_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.PCL.Controllers.ChargesController") ChargesController

#### Get singleton instance

The singleton instance of the ``` ChargesController ``` class can be accessed from the API Client.

```csharp
IChargesController charges = client.Charges;
```

#### <a name="get_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.ChargesController.GetCharge") GetCharge

> Get a charge from its id


```csharp
Task<Models.GetChargeResponse> GetCharge(string chargeId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |


#### Example Usage

```csharp
string chargeId = "charge_id";

Models.GetChargeResponse result = await charges.GetCharge(chargeId);

```


#### <a name="retry_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.ChargesController.RetryCharge") RetryCharge

> Retries a charge


```csharp
Task<Models.GetChargeResponse> RetryCharge(string chargeId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |


#### Example Usage

```csharp
string chargeId = "charge_id";

Models.GetChargeResponse result = await charges.RetryCharge(chargeId);

```


#### <a name="get_charges"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.ChargesController.GetCharges") GetCharges

> Lists all charges


```csharp
Task<Models.ListChargesResponse> GetCharges()
```

#### Example Usage

```csharp

Models.ListChargesResponse result = await charges.GetCharges();

```


#### <a name="create_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.ChargesController.CreateCharge") CreateCharge

> Creates a new charge


```csharp
Task<Models.GetChargeResponse> CreateCharge(Models.CreateChargeRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a charge |


#### Example Usage

```csharp
var body = new Models.CreateChargeRequest();

Models.GetChargeResponse result = await charges.CreateCharge(body);

```


#### <a name="update_charge_credit_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.ChargesController.UpdateChargeCreditCard") UpdateChargeCreditCard

> Updates the credit card from a charge


```csharp
Task<Models.GetChargeResponse> UpdateChargeCreditCard(Models.UpdateChargeCreditCardRequest body, string chargeId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for updating a charge's credit card |
| chargeId |  ``` Required ```  | Charge id |


#### Example Usage

```csharp
var body = new Models.UpdateChargeCreditCardRequest();
string chargeId = "charge_id";

Models.GetChargeResponse result = await charges.UpdateChargeCreditCard(body, chargeId);

```


#### <a name="update_charge_payment_method"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.ChargesController.UpdateChargePaymentMethod") UpdateChargePaymentMethod

> Updates a charge's payment method


```csharp
Task<Models.GetChargeResponse> UpdateChargePaymentMethod(Models.UpdateChargePaymentMethodRequest body, string chargeId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for updating the payment method from a charge |
| chargeId |  ``` Required ```  | Charge id |


#### Example Usage

```csharp
var body = new Models.UpdateChargePaymentMethodRequest();
string chargeId = "charge_id";

Models.GetChargeResponse result = await charges.UpdateChargePaymentMethod(body, chargeId);

```


#### <a name="cancel_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.ChargesController.CancelCharge") CancelCharge

> Cancel a charge


```csharp
Task<Models.GetChargeResponse> CancelCharge(string chargeId, Models.CreateCancelChargeRequest body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| body |  ``` Optional ```  | Request for cancelling a charge |


#### Example Usage

```csharp
string chargeId = "charge_id";
var body = new Models.CreateCancelChargeRequest();

Models.GetChargeResponse result = await charges.CancelCharge(chargeId, body);

```


#### <a name="capture_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.ChargesController.CaptureCharge") CaptureCharge

> Captures a charge


```csharp
Task<Models.GetChargeResponse> CaptureCharge(string chargeId, Models.CreateCaptureChargeRequest body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| chargeId |  ``` Required ```  | Charge id |
| body |  ``` Optional ```  | Request for capturing a charge |


#### Example Usage

```csharp
string chargeId = "charge_id";
var body = new Models.CreateCaptureChargeRequest();

Models.GetChargeResponse result = await charges.CaptureCharge(chargeId, body);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="customers_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.PCL.Controllers.CustomersController") CustomersController

#### Get singleton instance

The singleton instance of the ``` CustomersController ``` class can be accessed from the API Client.

```csharp
ICustomersController customers = client.Customers;
```

#### <a name="get_addresses"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.CustomersController.GetAddresses") GetAddresses

> Gets all adressess from a customer


```csharp
Task<Models.ListAddressesResponse> GetAddresses(string customerId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |


#### Example Usage

```csharp
string customerId = "customer_id";

Models.ListAddressesResponse result = await customers.GetAddresses(customerId);

```


#### <a name="get_customer_credit_cards"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.CustomersController.GetCustomerCreditCards") GetCustomerCreditCards

> Get all credit cards from a customer


```csharp
Task<Models.ListCardsResponse> GetCustomerCreditCards(string customerId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |


#### Example Usage

```csharp
string customerId = "customer_id";

Models.ListCardsResponse result = await customers.GetCustomerCreditCards(customerId);

```


#### <a name="get_customers"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.CustomersController.GetCustomers") GetCustomers

> Get all Customers


```csharp
Task<Models.ListCustomersResponse> GetCustomers()
```

#### Example Usage

```csharp

Models.ListCustomersResponse result = await customers.GetCustomers();

```


#### <a name="create_customer"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.CustomersController.CreateCustomer") CreateCustomer

> Creates a new customer


```csharp
Task<Models.GetCustomerResponse> CreateCustomer(Models.CreateCustomerRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a customer |


#### Example Usage

```csharp
var body = new Models.CreateCustomerRequest();

Models.GetCustomerResponse result = await customers.CreateCustomer(body);

```


#### <a name="get_customer"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.CustomersController.GetCustomer") GetCustomer

> Get a customer


```csharp
Task<Models.GetCustomerResponse> GetCustomer(string customerId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |


#### Example Usage

```csharp
string customerId = "customer_id";

Models.GetCustomerResponse result = await customers.GetCustomer(customerId);

```


#### <a name="update_address"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.CustomersController.UpdateAddress") UpdateAddress

> Updates an address


```csharp
Task<Models.GetAddressResponse> UpdateAddress(string customerId, string addressId, Models.UpdateAddressRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| addressId |  ``` Required ```  | Address Id |
| body |  ``` Required ```  | Request for updating an address |


#### Example Usage

```csharp
string customerId = "customer_id";
string addressId = "address_id";
var body = new Models.UpdateAddressRequest();

Models.GetAddressResponse result = await customers.UpdateAddress(customerId, addressId, body);

```


#### <a name="update_credit_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.CustomersController.UpdateCreditCard") UpdateCreditCard

> Updates a credit card


```csharp
Task<Models.GetCreditCardResponse> UpdateCreditCard(string customerId, string cardId, Models.UpdateCreditCardRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| cardId |  ``` Required ```  | Credit card id |
| body |  ``` Required ```  | Request for updating a credit card |


#### Example Usage

```csharp
string customerId = "customer_id";
string cardId = "card_id";
var body = new Models.UpdateCreditCardRequest();

Models.GetCreditCardResponse result = await customers.UpdateCreditCard(customerId, cardId, body);

```


#### <a name="get_address"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.CustomersController.GetAddress") GetAddress

> Get a customer's address


```csharp
Task<Models.GetAddressResponse> GetAddress(string customerId, string addressId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| addressId |  ``` Required ```  | Address Id |


#### Example Usage

```csharp
string customerId = "customer_id";
string addressId = "address_id";

Models.GetAddressResponse result = await customers.GetAddress(customerId, addressId);

```


#### <a name="delete_address"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.CustomersController.DeleteAddress") DeleteAddress

> Delete a Customer's address


```csharp
Task<Models.GetAddressResponse> DeleteAddress(string customerId, string addressId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| addressId |  ``` Required ```  | Address Id |


#### Example Usage

```csharp
string customerId = "customer_id";
string addressId = "address_id";

Models.GetAddressResponse result = await customers.DeleteAddress(customerId, addressId);

```


#### <a name="delete_credit_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.CustomersController.DeleteCreditCard") DeleteCreditCard

> Delete a customer's credit card


```csharp
Task<Models.GetCreditCardResponse> DeleteCreditCard(string customerId, string cardId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| cardId |  ``` Required ```  | Card Id |


#### Example Usage

```csharp
string customerId = "customer_id";
string cardId = "card_id";

Models.GetCreditCardResponse result = await customers.DeleteCreditCard(customerId, cardId);

```


#### <a name="create_address"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.CustomersController.CreateAddress") CreateAddress

> Creates a new address for a customer


```csharp
Task<Models.GetAddressResponse> CreateAddress(string customerId, Models.CreateAddressRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer Id |
| body |  ``` Required ```  | Request for creating an address |


#### Example Usage

```csharp
string customerId = "customer_id";
var body = new Models.CreateAddressRequest();

Models.GetAddressResponse result = await customers.CreateAddress(customerId, body);

```


#### <a name="get_credit_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.CustomersController.GetCreditCard") GetCreditCard

> Get a customer's credit card


```csharp
Task<Models.GetCreditCardResponse> GetCreditCard(string customerId, string cardId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| cardId |  ``` Required ```  | Card id |


#### Example Usage

```csharp
string customerId = "customer_id";
string cardId = "card_id";

Models.GetCreditCardResponse result = await customers.GetCreditCard(customerId, cardId);

```


#### <a name="create_credit_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.CustomersController.CreateCreditCard") CreateCreditCard

> Creates a new credit card for a customer


```csharp
Task<Models.GetCreditCardResponse> CreateCreditCard(Models.CreateCreditCardRequest body, string customerId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a credit card |
| customerId |  ``` Required ```  | Customer id |


#### Example Usage

```csharp
var body = new Models.CreateCreditCardRequest();
string customerId = "customer_id";

Models.GetCreditCardResponse result = await customers.CreateCreditCard(body, customerId);

```


#### <a name="update_customer"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.CustomersController.UpdateCustomer") UpdateCustomer

> Updates a customer


```csharp
Task<Models.GetCustomerResponse> UpdateCustomer(string customerId, Models.UpdateCustomerRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| customerId |  ``` Required ```  | Customer id |
| body |  ``` Required ```  | Request for updating a customer |


#### Example Usage

```csharp
string customerId = "customer_id";
var body = new Models.UpdateCustomerRequest();

Models.GetCustomerResponse result = await customers.UpdateCustomer(customerId, body);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="subscriptions_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.PCL.Controllers.SubscriptionsController") SubscriptionsController

#### Get singleton instance

The singleton instance of the ``` SubscriptionsController ``` class can be accessed from the API Client.

```csharp
ISubscriptionsController subscriptions = client.Subscriptions;
```

#### <a name="get_last_subscription_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.GetLastSubscriptionCharge") GetLastSubscriptionCharge

> Gets the last charge from a subscription


```csharp
Task<Models.GetChargeResponse> GetLastSubscriptionCharge(string subscriptionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";

Models.GetChargeResponse result = await subscriptions.GetLastSubscriptionCharge(subscriptionId);

```


#### <a name="get_subscription_invoices"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.GetSubscriptionInvoices") GetSubscriptionInvoices

> Gets all invoices from a subscription


```csharp
Task<Models.ListInvoicesResponse> GetSubscriptionInvoices(string subscriptionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";

Models.ListInvoicesResponse result = await subscriptions.GetSubscriptionInvoices(subscriptionId);

```


#### <a name="get_subscription_cycles"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.GetSubscriptionCycles") GetSubscriptionCycles

> Gets all cycles from a subscription


```csharp
Task<dynamic> GetSubscriptionCycles(string subscriptionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";

dynamic result = await subscriptions.GetSubscriptionCycles(subscriptionId);

```


#### <a name="get_usage"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.GetUsage") GetUsage

> Gets a usage


```csharp
Task<Models.GetUsageResponse> GetUsage(string subscriptionId, string itemId, string usageId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| itemId |  ``` Required ```  | item id |
| usageId |  ``` Required ```  | Usage id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";
string usageId = "usage_id";

Models.GetUsageResponse result = await subscriptions.GetUsage(subscriptionId, itemId, usageId);

```


#### <a name="create_usage"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.CreateUsage") CreateUsage

> Creates a usage


```csharp
Task<Models.GetUsageResponse> CreateUsage(string subscriptionId, string itemId, Models.CreateUsageRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| itemId |  ``` Required ```  | Item id |
| body |  ``` Required ```  | Request for creating a usage |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";
var body = new Models.CreateUsageRequest();

Models.GetUsageResponse result = await subscriptions.CreateUsage(subscriptionId, itemId, body);

```


#### <a name="update_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.UpdateSubscriptionItem") UpdateSubscriptionItem

> Updates a subscription item


```csharp
Task<Models.GetSubscriptionItemResponse> UpdateSubscriptionItem(string subscriptionId, string itemId, Models.UpdateSubscriptionItemRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription Id |
| itemId |  ``` Required ```  | Item id |
| body |  ``` Required ```  | Request for updating a subscription item |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";
var body = new Models.UpdateSubscriptionItemRequest();

Models.GetSubscriptionItemResponse result = await subscriptions.UpdateSubscriptionItem(subscriptionId, itemId, body);

```


#### <a name="get_subscriptions"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.GetSubscriptions") GetSubscriptions

> Gets all subscriptions


```csharp
Task<Models.ListSubscriptionsResponse> GetSubscriptions()
```

#### Example Usage

```csharp

Models.ListSubscriptionsResponse result = await subscriptions.GetSubscriptions();

```


#### <a name="update_subscription_credit_card"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.UpdateSubscriptionCreditCard") UpdateSubscriptionCreditCard

> Updates the credit card from a subscription


```csharp
Task<Models.GetSubscriptionResponse> UpdateSubscriptionCreditCard(Models.UpdateSubscriptionCreditCardRequest body, string subscriptionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for updating a credit card |
| subscriptionId |  ``` Required ```  | Subscription id |


#### Example Usage

```csharp
var body = new Models.UpdateSubscriptionCreditCardRequest();
string subscriptionId = "subscription_id";

Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionCreditCard(body, subscriptionId);

```


#### <a name="create_subscription"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.CreateSubscription") CreateSubscription

> Creates a new subscription


```csharp
Task<Models.GetSubscriptionResponse> CreateSubscription(Models.CreateSubscriptionRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a subscription |


#### Example Usage

```csharp
var body = new Models.CreateSubscriptionRequest();

Models.GetSubscriptionResponse result = await subscriptions.CreateSubscription(body);

```


#### <a name="create_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.CreateSubscriptionItem") CreateSubscriptionItem

> Creates a new Subscription item


```csharp
Task<Models.GetSubscriptionItemResponse> CreateSubscriptionItem(Models.CreateSubscriptionItemRequest body, string subscriptionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a subscription item |
| subscriptionId |  ``` Required ```  | Subscription id |


#### Example Usage

```csharp
var body = new Models.CreateSubscriptionItemRequest();
string subscriptionId = "subscription_id";

Models.GetSubscriptionItemResponse result = await subscriptions.CreateSubscriptionItem(body, subscriptionId);

```


#### <a name="create_discount"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.CreateDiscount") CreateDiscount

> Creates a discount


```csharp
Task<Models.GetDiscountResponse> CreateDiscount(Models.CreateDiscountRequest body, string subscriptionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a discount |
| subscriptionId |  ``` Required ```  | Subscription id |


#### Example Usage

```csharp
var body = new Models.CreateDiscountRequest();
string subscriptionId = "subscription_id";

Models.GetDiscountResponse result = await subscriptions.CreateDiscount(body, subscriptionId);

```


#### <a name="get_subscription"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.GetSubscription") GetSubscription

> Gets a subscription


```csharp
Task<Models.GetSubscriptionResponse> GetSubscription(string subscriptionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";

Models.GetSubscriptionResponse result = await subscriptions.GetSubscription(subscriptionId);

```


#### <a name="update_subscription_payment_method"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.UpdateSubscriptionPaymentMethod") UpdateSubscriptionPaymentMethod

> Updates the payment method from a subscription


```csharp
Task<Models.GetSubscriptionResponse> UpdateSubscriptionPaymentMethod(Models.UpdateSubscriptionPaymentMethodRequest body, string subscriptionId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for updating the payment method from a subscription |
| subscriptionId |  ``` Required ```  | Subscription id |


#### Example Usage

```csharp
var body = new Models.UpdateSubscriptionPaymentMethodRequest();
string subscriptionId = "subscription_id";

Models.GetSubscriptionResponse result = await subscriptions.UpdateSubscriptionPaymentMethod(body, subscriptionId);

```


#### <a name="get_cycle"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.GetCycle") GetCycle

> Gets a cycle from a subscription


```csharp
Task<Models.GetPeriodResponse> GetCycle(string subscriptionId, string cycleId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| cycleId |  ``` Required ```  | Cycle id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string cycleId = "cycle_id";

Models.GetPeriodResponse result = await subscriptions.GetCycle(subscriptionId, cycleId);

```


#### <a name="get_discount"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.GetDiscount") GetDiscount

> Gets a discount


```csharp
Task<Models.GetDiscountResponse> GetDiscount(string subscriptionId, string discountId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| discountId |  ``` Required ```  | Discount id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string discountId = "discount_id";

Models.GetDiscountResponse result = await subscriptions.GetDiscount(subscriptionId, discountId);

```


#### <a name="delete_discount"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.DeleteDiscount") DeleteDiscount

> Deletes a discount


```csharp
Task<Models.GetDiscountResponse> DeleteDiscount(string subscriptionId, string discountId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| discountId |  ``` Required ```  | Discount Id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string discountId = "discount_id";

Models.GetDiscountResponse result = await subscriptions.DeleteDiscount(subscriptionId, discountId);

```


#### <a name="get_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.GetSubscriptionItem") GetSubscriptionItem

> Gets a subscription item


```csharp
Task<Models.GetSubscriptionItemResponse> GetSubscriptionItem(string subscriptionId, string itemId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| itemId |  ``` Required ```  | Subscription item id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string itemId = "item_id";

Models.GetSubscriptionItemResponse result = await subscriptions.GetSubscriptionItem(subscriptionId, itemId);

```


#### <a name="reschedule_subscription"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.RescheduleSubscription") RescheduleSubscription

> Changes a subscription billing date


```csharp
Task<Models.GetSubscriptionResponse> RescheduleSubscription(string subscriptionId, Models.CreateRescheduleSubscriptionRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| body |  ``` Required ```  | Request for updating the billing day of a subscription |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new Models.CreateRescheduleSubscriptionRequest();

Models.GetSubscriptionResponse result = await subscriptions.RescheduleSubscription(subscriptionId, body);

```


#### <a name="cancel_subscription"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.CancelSubscription") CancelSubscription

> Cancels a subscription


```csharp
Task<Models.GetSubscriptionResponse> CancelSubscription(string subscriptionId, Models.CreateCancelSubscriptionRequest body = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| body |  ``` Optional ```  | Request for cancelling a subscription |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
var body = new Models.CreateCancelSubscriptionRequest();

Models.GetSubscriptionResponse result = await subscriptions.CancelSubscription(subscriptionId, body);

```


#### <a name="delete_subscription_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.SubscriptionsController.DeleteSubscriptionItem") DeleteSubscriptionItem

> Deletes a subscription item


```csharp
Task<Models.GetSubscriptionItemResponse> DeleteSubscriptionItem(string subscriptionId, string subscriptionItemId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| subscriptionId |  ``` Required ```  | Subscription id |
| subscriptionItemId |  ``` Required ```  | Subscription item id |


#### Example Usage

```csharp
string subscriptionId = "subscription_id";
string subscriptionItemId = "subscription_item_id";

Models.GetSubscriptionItemResponse result = await subscriptions.DeleteSubscriptionItem(subscriptionId, subscriptionItemId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="plans_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.PCL.Controllers.PlansController") PlansController

#### Get singleton instance

The singleton instance of the ``` PlansController ``` class can be accessed from the API Client.

```csharp
IPlansController plans = client.Plans;
```

#### <a name="get_plan_items"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.PlansController.GetPlanItems") GetPlanItems

> Gets all items from a plan


```csharp
Task<Models.ListPlanItemsResponse> GetPlanItems(string planId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |


#### Example Usage

```csharp
string planId = "plan_id";

Models.ListPlanItemsResponse result = await plans.GetPlanItems(planId);

```


#### <a name="update_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.PlansController.UpdatePlanItem") UpdatePlanItem

> Updates a plan item


```csharp
Task<Models.GetPlanItemResponse> UpdatePlanItem(string planId, string planItemId, Models.UpdatePlanItemRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| planItemId |  ``` Required ```  | Plan item id |
| body |  ``` Required ```  | Request for updating the plan item |


#### Example Usage

```csharp
string planId = "plan_id";
string planItemId = "plan_item_id";
var body = new Models.UpdatePlanItemRequest();

Models.GetPlanItemResponse result = await plans.UpdatePlanItem(planId, planItemId, body);

```


#### <a name="get_plan_subscriptions"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.PlansController.GetPlanSubscriptions") GetPlanSubscriptions

> Get all subscriptions from a plan


```csharp
Task<dynamic> GetPlanSubscriptions(string planId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |


#### Example Usage

```csharp
string planId = "plan_id";

dynamic result = await plans.GetPlanSubscriptions(planId);

```


#### <a name="get_plan"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.PlansController.GetPlan") GetPlan

> Gets a plan


```csharp
Task<Models.GetPlanResponse> GetPlan(string planId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |


#### Example Usage

```csharp
string planId = "plan_id";

Models.GetPlanResponse result = await plans.GetPlan(planId);

```


#### <a name="create_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.PlansController.CreatePlanItem") CreatePlanItem

> Adds a new item to a plan


```csharp
Task<Models.GetPlanItemResponse> CreatePlanItem(Models.CreatePlanItemRequest body, string planId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a plan item |
| planId |  ``` Required ```  | Plan id |


#### Example Usage

```csharp
var body = new Models.CreatePlanItemRequest();
string planId = "plan_id";

Models.GetPlanItemResponse result = await plans.CreatePlanItem(body, planId);

```


#### <a name="update_plan"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.PlansController.UpdatePlan") UpdatePlan

> Updates a plan


```csharp
Task<Models.GetPlanResponse> UpdatePlan(Models.UpdatePlanRequest body, string planId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for updating a plan |
| planId |  ``` Required ```  | Plan id |


#### Example Usage

```csharp
var body = new Models.UpdatePlanRequest();
string planId = "plan_id";

Models.GetPlanResponse result = await plans.UpdatePlan(body, planId);

```


#### <a name="create_plan"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.PlansController.CreatePlan") CreatePlan

> Creates a new plan


```csharp
Task<Models.GetPlanResponse> CreatePlan(Models.CreatePlanRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating a plan |


#### Example Usage

```csharp
var body = new Models.CreatePlanRequest();

Models.GetPlanResponse result = await plans.CreatePlan(body);

```


#### <a name="get_plans"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.PlansController.GetPlans") GetPlans

> Gets all plans


```csharp
Task<Models.ListPlansResponse> GetPlans()
```

#### Example Usage

```csharp

Models.ListPlansResponse result = await plans.GetPlans();

```


#### <a name="delete_plan"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.PlansController.DeletePlan") DeletePlan

> Deletes a plan


```csharp
Task<Models.GetPlanResponse> DeletePlan(string planId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |


#### Example Usage

```csharp
string planId = "plan_id";

Models.GetPlanResponse result = await plans.DeletePlan(planId);

```


#### <a name="get_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.PlansController.GetPlanItem") GetPlanItem

> Gets a plan item


```csharp
Task<Models.GetPlanItemResponse> GetPlanItem(string planId, string planItemId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| planItemId |  ``` Required ```  | Plan item id |


#### Example Usage

```csharp
string planId = "plan_id";
string planItemId = "plan_item_id";

Models.GetPlanItemResponse result = await plans.GetPlanItem(planId, planItemId);

```


#### <a name="delete_plan_item"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.PlansController.DeletePlanItem") DeletePlanItem

> Removes an item from a plan


```csharp
Task<Models.GetPlanItemResponse> DeletePlanItem(string planId, string planItemId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| planId |  ``` Required ```  | Plan id |
| planItemId |  ``` Required ```  | Plan item id |


#### Example Usage

```csharp
string planId = "plan_id";
string planItemId = "plan_item_id";

Models.GetPlanItemResponse result = await plans.DeletePlanItem(planId, planItemId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="invoices_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.PCL.Controllers.InvoicesController") InvoicesController

#### Get singleton instance

The singleton instance of the ``` InvoicesController ``` class can be accessed from the API Client.

```csharp
IInvoicesController invoices = client.Invoices;
```

#### <a name="cancel_invoice"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.InvoicesController.CancelInvoice") CancelInvoice

> Cancels an invoice


```csharp
Task<Models.GetInvoiceResponse> CancelInvoice(string invoiceId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| invoiceId |  ``` Required ```  | Invoice id |


#### Example Usage

```csharp
string invoiceId = "invoice_id";

Models.GetInvoiceResponse result = await invoices.CancelInvoice(invoiceId);

```


#### <a name="get_last_invoice_charge"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.InvoicesController.GetLastInvoiceCharge") GetLastInvoiceCharge

> Gets the last charge from an invoice


```csharp
Task<Models.GetChargeResponse> GetLastInvoiceCharge(string invoiceId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| invoiceId |  ``` Required ```  | Invoice id |


#### Example Usage

```csharp
string invoiceId = "invoice_id";

Models.GetChargeResponse result = await invoices.GetLastInvoiceCharge(invoiceId);

```


#### <a name="get_invoices"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.InvoicesController.GetInvoices") GetInvoices

> Gets all invoices


```csharp
Task<Models.ListInvoicesResponse> GetInvoices()
```

#### Example Usage

```csharp

Models.ListInvoicesResponse result = await invoices.GetInvoices();

```


#### <a name="get_invoice"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.InvoicesController.GetInvoice") GetInvoice

> Gets an invoice


```csharp
Task<Models.GetInvoiceResponse> GetInvoice(string invoiceId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| invoiceId |  ``` Required ```  | Invoice Id |


#### Example Usage

```csharp
string invoiceId = "invoice_id";

Models.GetInvoiceResponse result = await invoices.GetInvoice(invoiceId);

```


[Back to List of Controllers](#list_of_controllers)

### <a name="orders_controller"></a>![Class: ](https://apidocs.io/img/class.png "MundiAPI.PCL.Controllers.OrdersController") OrdersController

#### Get singleton instance

The singleton instance of the ``` OrdersController ``` class can be accessed from the API Client.

```csharp
IOrdersController orders = client.Orders;
```

#### <a name="get_order"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.OrdersController.GetOrder") GetOrder

> Gets an order


```csharp
Task<Models.GetOrdersResponse> GetOrder(string orderId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| orderId |  ``` Required ```  | Order id |


#### Example Usage

```csharp
string orderId = "order_id";

Models.GetOrdersResponse result = await orders.GetOrder(orderId);

```


#### <a name="get_orders"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.OrdersController.GetOrders") GetOrders

> Gets all orders


```csharp
Task<Models.ListOrderResponse> GetOrders()
```

#### Example Usage

```csharp

Models.ListOrderResponse result = await orders.GetOrders();

```


#### <a name="create_order"></a>![Method: ](https://apidocs.io/img/method.png "MundiAPI.PCL.Controllers.OrdersController.CreateOrder") CreateOrder

> Creates a new Order


```csharp
Task<Models.GetOrdersResponse> CreateOrder(Models.CreateOrderRequest body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Request for creating an order |


#### Example Usage

```csharp
var body = new Models.CreateOrderRequest();

Models.GetOrdersResponse result = await orders.CreateOrder(body);

```


[Back to List of Controllers](#list_of_controllers)



