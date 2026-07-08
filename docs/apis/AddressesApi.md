# ClickSend.Api.AddressesApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateReturnAddress**](AddressesApi.md#createreturnaddress) | **POST** /v3/post/return-addresses | Create Return Address |
| [**DeleteReturnAddress**](AddressesApi.md#deletereturnaddress) | **DELETE** /v3/post/return-addresses/{return_address_id} | Delete Return Address |
| [**UpdateReturnAddress**](AddressesApi.md#updatereturnaddress) | **PUT** /v3/post/return-addresses/{return_address_id} | Update Return Address |
| [**ViewSpecificReturnAddress**](AddressesApi.md#viewspecificreturnaddress) | **GET** /v3/post/return-addresses/{return_address_id} | View Specific Return Address |
| [**ViewYourReturnAddresses**](AddressesApi.md#viewyourreturnaddresses) | **GET** /v3/post/return-addresses | View Your Return Addresses |

<a id="createreturnaddress"></a>
# **CreateReturnAddress**
> CreateReturnAddress CreateReturnAddress (string contentType = null, CreateReturnAddressRequest createReturnAddressRequest = null)

Create Return Address

_Create post return address_  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | address_name | string | true | none | Your address name. | | address_line_1 | string | true | none | Your address line 1 | | address_city | string | true | none | Your city | | address_postal_code | string | true | none | Your postal code | | address_country | string | true | none | Your country | | address_line_2 | string | false | none | Your address line 2 | | address_state | string | false | none | Your state |    Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.    <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createReturnAddressRequest** | [**CreateReturnAddressRequest**](CreateReturnAddressRequest.md) |  | [optional]  |

### Return type

[**CreateReturnAddress**](CreateReturnAddress.md)

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

<a id="deletereturnaddress"></a>
# **DeleteReturnAddress**
> DeleteReturnAddress DeleteReturnAddress (string returnAddressId, string contentType = null)

Delete Return Address

_Delete specific post return address_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | return_address_id | path | integer(int32) | true | Return address ID |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **returnAddressId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**DeleteReturnAddress**](DeleteReturnAddress.md)

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

<a id="updatereturnaddress"></a>
# **UpdateReturnAddress**
> UpdateReturnAddress UpdateReturnAddress (string returnAddressId, string contentType = null, UpdateReturnAddressRequest updateReturnAddressRequest = null)

Update Return Address

_Update post return address_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | return_address_id | path | integer(int32) | true | Return address ID |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | address_name | string | true | none | Your address name. | | address_line_1 | string | true | none | Your address line 1 | | address_city | string | true | none | Your city | | address_postal_code | string | true | none | Your postal code | | address_country | string | true | none | Your country | | address_line_2 | string | false | none | Your address line 2 | | address_state | string | false | none | Your state |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **returnAddressId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **updateReturnAddressRequest** | [**UpdateReturnAddressRequest**](UpdateReturnAddressRequest.md) |  | [optional]  |

### Return type

[**UpdateReturnAddress**](UpdateReturnAddress.md)

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

<a id="viewspecificreturnaddress"></a>
# **ViewSpecificReturnAddress**
> ViewSpecificReturnAddress ViewSpecificReturnAddress (string returnAddressId, string contentType = null)

View Specific Return Address

_Get specific post return address_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | return_address_id | path | integer(int32) | true | Return address ID |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **returnAddressId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewSpecificReturnAddress**](ViewSpecificReturnAddress.md)

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

<a id="viewyourreturnaddresses"></a>
# **ViewYourReturnAddresses**
> ViewYourReturnAddresses ViewYourReturnAddresses (string contentType = null)

View Your Return Addresses

_Get list of post return addresses_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewYourReturnAddresses**](ViewYourReturnAddresses.md)

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

