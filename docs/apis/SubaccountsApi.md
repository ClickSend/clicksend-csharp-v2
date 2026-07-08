# ClickSend.Api.SubaccountsApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSubaccount**](SubaccountsApi.md#createsubaccount) | **POST** /v3/subaccounts | Create Subaccount |
| [**DeleteSubaccount**](SubaccountsApi.md#deletesubaccount) | **DELETE** /v3/subaccounts/{subaccount_id} | Delete Subaccount |
| [**GenerateNewApiKey**](SubaccountsApi.md#generatenewapikey) | **PUT** /v3/subaccounts/{subaccount_id}/regen-api-key | Generate New API Key |
| [**UpdateSubaccount**](SubaccountsApi.md#updatesubaccount) | **PUT** /v3/subaccounts/{subaccount_id} | Update Subaccount |
| [**ViewSpecificSubaccount**](SubaccountsApi.md#viewspecificsubaccount) | **GET** /v3/subaccounts/{subaccount_id} | View Specific Subaccount |
| [**ViewSubaccounts**](SubaccountsApi.md#viewsubaccounts) | **GET** /v3/subaccounts | View Subaccounts |

<a id="createsubaccount"></a>
# **CreateSubaccount**
> CreateSubaccount CreateSubaccount (string contentType = null, CreateSubaccountRequest createSubaccountRequest = null)

Create Subaccount

_Create new subaccount_  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | api_username | string | true | none | Your new api username. | | password | string | true | none | Your new password | | email | string | true | none | Your new email. | | phone_number | string | true | none | Your phone number in [E.164](https://en.wikipedia.org/wiki/E.164) format. | | first_name | string | true | none | Your firstname | | last_name | string | true | none | Your lastname | | access_users | integer(int1) | false | none | Flag value must be 1 for yes or 0 for no. | | access_billing | integer(int1) | false | none | Flag value must be 1 for yes or 0 for no. | | access_reporting | integer(int1) | false | none | Flag value must be 1 for yes or 0 for no. | | access_contacts | integer(int1) | false | none | Flag value must be 1 for yes or 0 for no. | | access_settings | integer(int1) | false | none | Flag value must be 1 for yes or 0 for no. |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createSubaccountRequest** | [**CreateSubaccountRequest**](CreateSubaccountRequest.md) |  | [optional]  |

### Return type

[**CreateSubaccount**](CreateSubaccount.md)

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

<a id="deletesubaccount"></a>
# **DeleteSubaccount**
> DeleteSubaccount DeleteSubaccount (string subaccountId, string contentType = null)

Delete Subaccount

_Delete a subaccount_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | subaccount_id | path | integer(int32) | true | ID of subaccount to delete |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subaccountId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**DeleteSubaccount**](DeleteSubaccount.md)

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

<a id="generatenewapikey"></a>
# **GenerateNewApiKey**
> GenerateNewApiKey GenerateNewApiKey (string subaccountId, string contentType = null, GenerateNewApiKeyRequest generateNewApiKeyRequest = null)

Generate New API Key

_Regenerate an API Key_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | subaccount_id | path | integer(int32) | true | ID of subaccount to regenerate API key for |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subaccountId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **generateNewApiKeyRequest** | [**GenerateNewApiKeyRequest**](GenerateNewApiKeyRequest.md) |  | [optional]  |

### Return type

[**GenerateNewApiKey**](GenerateNewApiKey.md)

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

<a id="updatesubaccount"></a>
# **UpdateSubaccount**
> UpdateSubaccount UpdateSubaccount (string subaccountId, string contentType = null, UpdateSubaccountRequest updateSubaccountRequest = null)

Update Subaccount

_Update subaccount_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | subaccount_id | path | integer(int32) | true | ID of subaccount to update |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | api_username | string | true | none | Your new api username. | | password | string | true | none | Your new password | | email | string | true | none | Your new email. | | phone_number | string | true | none | Your phone number in [E.164](https://en.wikipedia.org/wiki/E.164) format. | | first_name | string | true | none | Your firstname | | last_name | string | true | none | Your lastname | | access_users | integer(int1) | false | none | Flag value must be 1 for yes or 0 for no. | | access_billing | integer(int1) | false | none | Flag value must be 1 for yes or 0 for no. | | access_reporting | integer(int1) | false | none | Flag value must be 1 for yes or 0 for no. | | access_contacts | integer(int1) | false | none | Flag value must be 1 for yes or 0 for no. | | access_settings | integer(int1) | false | none | Flag value must be 1 for yes or 0 for no. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subaccountId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **updateSubaccountRequest** | [**UpdateSubaccountRequest**](UpdateSubaccountRequest.md) |  | [optional]  |

### Return type

[**UpdateSubaccount**](UpdateSubaccount.md)

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

<a id="viewspecificsubaccount"></a>
# **ViewSpecificSubaccount**
> ViewSpecificSubaccount ViewSpecificSubaccount (string subaccountId, string contentType = null)

View Specific Subaccount

_Get specific subaccount_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | subaccount_id | path | integer(int32) | true | ID of subaccount to get |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subaccountId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewSpecificSubaccount**](ViewSpecificSubaccount.md)

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

<a id="viewsubaccounts"></a>
# **ViewSubaccounts**
> ViewSubaccounts ViewSubaccounts (string contentType = null)

View Subaccounts

_Get all subaccounts_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewSubaccounts**](ViewSubaccounts.md)

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

