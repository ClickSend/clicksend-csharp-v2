# ClickSend.Api.DefaultSendersApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDefaultSender**](DefaultSendersApi.md#createdefaultsender) | **POST** /v3/senders/default-senders | Create Default Sender |
| [**DeleteDefaultSender**](DefaultSendersApi.md#deletedefaultsender) | **DELETE** /v3/senders/default-senders/{default_sender_id} | Delete Default Sender |
| [**GetDefaultSenderDetails**](DefaultSendersApi.md#getdefaultsenderdetails) | **GET** /v3/senders/default-senders/{default_sender_id} | Get Default Sender Details |
| [**GetDefaultSendersList**](DefaultSendersApi.md#getdefaultsenderslist) | **GET** /v3/senders/default-senders | Get List of Default Senders |
| [**ListCompliantSenderTypes**](DefaultSendersApi.md#listcompliantsendertypes) | **GET** /v3/senders/compliant-sender-types | List Compliant Sender Types |
| [**UpdateDefaultSender**](DefaultSendersApi.md#updatedefaultsender) | **PATCH** /v3/senders/default-senders/{default_sender_id} | Update Default Sender |

<a id="createdefaultsender"></a>
# **CreateDefaultSender**
> CreateDefaultSender CreateDefaultSender (string contentType = null, CreateDefaultSenderRequest createDefaultSenderRequest = null)

Create Default Sender

Creates a new default sender configuration to automate the selection of compliant SenderIDs. By configuring a default sender you no longer need to define the `sender_id` string when sending SMS messages. The default sender will be picked up automatically.  For more information on Sender IDs, please refer to [What is a Sender ID or Sender Number?](https://help.clicksend.com/article/4kgj7krx00-what-is-a-sender-id-or-sender-number)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createDefaultSenderRequest** | [**CreateDefaultSenderRequest**](CreateDefaultSenderRequest.md) |  | [optional]  |

### Return type

[**CreateDefaultSender**](CreateDefaultSender.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="deletedefaultsender"></a>
# **DeleteDefaultSender**
> void DeleteDefaultSender (string defaultSenderId, string contentType = null)

Delete Default Sender

Removes a specified default sender setting.  If you don't configure a default sender and leave the `sender_id` string blank when sending an SMS, Smart Assign will pick the best suitable, compliant, available SenderID for you.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **defaultSenderId** | **string** | The ID of the default sender to delete |  |
| **contentType** | **string** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful response (No Content) |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getdefaultsenderdetails"></a>
# **GetDefaultSenderDetails**
> GetDefaultSenderDetails GetDefaultSenderDetails (string defaultSenderId, string contentType = null)

Get Default Sender Details

Retrieve detailed information about a specific default sender configuration


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **defaultSenderId** | **string** | The ID of the default sender to retrieve |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**GetDefaultSenderDetails**](GetDefaultSenderDetails.md)

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

<a id="getdefaultsenderslist"></a>
# **GetDefaultSendersList**
> GetDefaultSendersList GetDefaultSendersList (string contentType = null, string offset = null, int perPage = null, string sortBy = null, string sortDirection = null)

Get List of Default Senders

Retrieve a list of default senders for the current user


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **offset** | **string** | Page (offset) to be used for pagination | [optional]  |
| **perPage** | **int** | Size of the page in pagination | [optional] [default to 10] |
| **sortBy** | **string** | Parameter to sort the results by | [optional] [default to &quot;created_timestamp&quot;] |
| **sortDirection** | **string** | Direction of sorting | [optional] [default to desc] |

### Return type

[**GetDefaultSendersList**](GetDefaultSendersList.md)

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

<a id="listcompliantsendertypes"></a>
# **ListCompliantSenderTypes**
> ListCompliantSenderTypes200Response ListCompliantSenderTypes (string filterProductType, List<string> filterCountryCodeIndex = null)

List Compliant Sender Types

Retrieves the list of compliant sender types for specific countries


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **filterProductType** | **string** | Type of the product |  |
| **filterCountryCodeIndex** | [**List&lt;string&gt;**](string.md) | Array of recipient country codes (ISO 3166-1 alpha-2). If not specified, will get all compliant sender types for all countries. Replace &#x60;{index}&#x60; with the appropriate index value.  &lt;small&gt;Example:&lt;/small&gt; &lt;small&gt;&lt;code style&#x3D;\&quot;color: #424242;\&quot;&gt;filter[country_code][0]&#x3D;US&amp;filter[country_code][1]&#x3D;AU&lt;/code&gt;&lt;/small&gt;  | [optional]  |

### Return type

[**ListCompliantSenderTypes200Response**](ListCompliantSenderTypes200Response.md)

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

<a id="updatedefaultsender"></a>
# **UpdateDefaultSender**
> UpdateDefaultSender UpdateDefaultSender (string defaultSenderId, string contentType = null, UpdateDefaultSenderRequest updateDefaultSenderRequest = null)

Update Default Sender

Updates the details of an existing default sender configuration.  For more information on Sender IDs, please refer to [What is a Sender ID or Sender Number?](https://help.clicksend.com/article/4kgj7krx00-what-is-a-sender-id-or-sender-number)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **defaultSenderId** | **string** | The ID of the default sender to update |  |
| **contentType** | **string** |  | [optional]  |
| **updateDefaultSenderRequest** | [**UpdateDefaultSenderRequest**](UpdateDefaultSenderRequest.md) |  | [optional]  |

### Return type

[**UpdateDefaultSender**](UpdateDefaultSender.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad request |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

