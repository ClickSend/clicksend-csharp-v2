# ClickSend.Api.ResellerApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateResellerAccount**](ResellerApi.md#createreselleraccount) | **POST** /v3/reseller/accounts | Create Reseller Account |
| [**ResellerTransferCredit**](ResellerApi.md#resellertransfercredit) | **PUT** /v3/reseller/transfer-credit | Reseller Transfer Credit |
| [**UpdateClientAccount**](ResellerApi.md#updateclientaccount) | **PUT** /v3/reseller/accounts/{client_user_id} | Update Client Account |
| [**ViewClientAccounts**](ResellerApi.md#viewclientaccounts) | **GET** /v3/reseller/accounts | View Client Accounts |
| [**ViewSpecificClientAccount**](ResellerApi.md#viewspecificclientaccount) | **GET** /v3/reseller/accounts/{client_user_id} | View Specific Client Account |

<a id="createreselleraccount"></a>
# **CreateResellerAccount**
> CreateResellerAccount CreateResellerAccount (string contentType = null, CreateResellerAccountRequest createResellerAccountRequest = null)

Create Reseller Account

_Create reseller account_  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | username | string | true | none | Account username | | password | string | true | none | Account password (unhashed) | | user_email | string | true | none | Account email | | user_phone | string | true | none | Account phone number | | user_first_name | string | true | none | Account owner first name | | user_last_name | string | true | none | Account owner last name | | account_name | string | true | none | Account name (usually company name) | | country | string | true | none | Country of account holder |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createResellerAccountRequest** | [**CreateResellerAccountRequest**](CreateResellerAccountRequest.md) |  | [optional]  |

### Return type

[**CreateResellerAccount**](CreateResellerAccount.md)

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

<a id="resellertransfercredit"></a>
# **ResellerTransferCredit**
> ResellerTransferCredit ResellerTransferCredit (string contentType = null, UpdatePaymentInfoRequest updatePaymentInfoRequest = null)

Reseller Transfer Credit

_Transfer Credit_  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | client_user_id | integer(int32) | true | none | User ID of client | | balance | integer(int32) | true | none | Balance to transfer | | currency | string | true | none | Currency of balance to transfer |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **updatePaymentInfoRequest** | [**UpdatePaymentInfoRequest**](UpdatePaymentInfoRequest.md) |  | [optional]  |

### Return type

[**ResellerTransferCredit**](ResellerTransferCredit.md)

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

<a id="updateclientaccount"></a>
# **UpdateClientAccount**
> UpdateClientAccount UpdateClientAccount (string clientUserId, string contentType = null, UpdatePaymentInfoRequest updatePaymentInfoRequest = null)

Update Client Account

_Update Reseller clients Account_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | client_user_id | path | integer(int32) | true | User ID of client |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | username | string | true | none | Account username | | password | string | true | none | Account password (unhashed) | | user_email | string | true | none | Account email | | user_phone | string | true | none | Account phone number | | user_first_name | string | true | none | Account owner first name | | user_last_name | string | true | none | Account owner last name | | account_name | string | true | none | Account name (usually company name) | | country | string | true | none | Country of account holder |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientUserId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **updatePaymentInfoRequest** | [**UpdatePaymentInfoRequest**](UpdatePaymentInfoRequest.md) |  | [optional]  |

### Return type

[**UpdateClientAccount**](UpdateClientAccount.md)

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

<a id="viewclientaccounts"></a>
# **ViewClientAccounts**
> ViewClientAccounts ViewClientAccounts (string contentType = null)

View Client Accounts

_Get list of reseller accounts_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewClientAccounts**](ViewClientAccounts.md)

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

<a id="viewspecificclientaccount"></a>
# **ViewSpecificClientAccount**
> ViewSpecificClientAccount ViewSpecificClientAccount (string clientUserId, string contentType = null)

View Specific Client Account

_Get Reseller clients Account_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | client_user_id | path | integer(int32) | true | User ID of client |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientUserId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewSpecificClientAccount**](ViewSpecificClientAccount.md)

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

