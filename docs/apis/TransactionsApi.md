# ClickSend.Api.TransactionsApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CurrentPaymentInfo**](TransactionsApi.md#currentpaymentinfo) | **GET** /v3/recharge/credit-card | Current Payment Info |
| [**PurchaseRechargePackage**](TransactionsApi.md#purchaserechargepackage) | **PUT** /v3/recharge/purchase/{package_id} | Purchase Recharge Package |
| [**UpdatePaymentInfo**](TransactionsApi.md#updatepaymentinfo) | **PUT** /v3/recharge/credit-card | Update Payment Info |
| [**ViewAllTransactions**](TransactionsApi.md#viewalltransactions) | **GET** /v3/recharge/transactions | View All Transactions |
| [**ViewRechargePackages**](TransactionsApi.md#viewrechargepackages) | **GET** /v3/recharge/packages | View Recharge Packages |
| [**ViewSpecificTransaction**](TransactionsApi.md#viewspecifictransaction) | **GET** /v3/recharge/transactions/{transaction_id} | View Specific Transaction |

<a id="currentpaymentinfo"></a>
# **CurrentPaymentInfo**
> CurrentPaymentInfo CurrentPaymentInfo (string contentType = null)

Current Payment Info

_Get current payment info_  This endpoint returns your current payment info, we do not store credit card numbers, only a card token for security reasons.  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**CurrentPaymentInfo**](CurrentPaymentInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="purchaserechargepackage"></a>
# **PurchaseRechargePackage**
> PurchaseRechargePackage PurchaseRechargePackage (string packageId, string contentType = null)

Purchase Recharge Package

_Purchase a package_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | package_id | path | integer(int32) | true | ID of package to purchase |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **packageId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**PurchaseRechargePackage**](PurchaseRechargePackage.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="updatepaymentinfo"></a>
# **UpdatePaymentInfo**
> UpdatePaymentInfo UpdatePaymentInfo (string contentType = null, UpdatePaymentInfoRequest updatePaymentInfoRequest = null)

Update Payment Info

_Update credit card info_  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | number | string | true | none | Credit card number | | expiry_month | integer(int32) | true | none | Expiry month of credit card | | expiry_year | integer(int32) | true | none | Expiry year of credit card | | cvc | integer(int32) | true | none | CVC number of credit card | | name | string | true | none | Name printed on credit card | | bank_name | string | true | none | Name of bank that credit card belongs to |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **updatePaymentInfoRequest** | [**UpdatePaymentInfoRequest**](UpdatePaymentInfoRequest.md) |  | [optional]  |

### Return type

[**UpdatePaymentInfo**](UpdatePaymentInfo.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="viewalltransactions"></a>
# **ViewAllTransactions**
> ViewAllTransactions ViewAllTransactions (string contentType = null)

View All Transactions

_Purchase a package_  Get all transactions  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewAllTransactions**](ViewAllTransactions.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="viewrechargepackages"></a>
# **ViewRechargePackages**
> ViewRechargePackages ViewRechargePackages (string contentType = null)

View Recharge Packages

_Get list of all packages_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | country | query | string | false | Two-letter country code ([ISO3166](https://en.wikipedia.org/wiki/ISO_3166)) |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewRechargePackages**](ViewRechargePackages.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="viewspecifictransaction"></a>
# **ViewSpecificTransaction**
> ViewSpecificTransaction ViewSpecificTransaction (string transactionId, string contentType = null)

View Specific Transaction

_Get specific Transaction_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | transaction_id | path | string | true | ID of transaction to retrieve |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewSpecificTransaction**](ViewSpecificTransaction.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

