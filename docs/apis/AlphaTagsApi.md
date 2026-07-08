# ClickSend.Api.AlphaTagsApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteAlphaTag**](AlphaTagsApi.md#deletealphatag) | **DELETE** /v3/alpha-tags/{alpha_tag_id} | Delete Alpha Tag |
| [**GetAlphaTag**](AlphaTagsApi.md#getalphatag) | **GET** /v3/alpha-tags/{alpha_tag_id} | Get Alpha Tag |
| [**ListAlphaTags**](AlphaTagsApi.md#listalphatags) | **GET** /v3/alpha-tags | List Alpha Tags |
| [**RequestAlphaTag**](AlphaTagsApi.md#requestalphatag) | **POST** /v3/alpha-tags | Request Alpha Tag |

<a id="deletealphatag"></a>
# **DeleteAlphaTag**
> void DeleteAlphaTag (string alphaTagId, string contentType = null)

Delete Alpha Tag

_Delete a specific alpha tag._  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | alpha_tag_id | path | uuid | true | ID of the alpha tag |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  This endpoint requires authentication, [more info...](/#authentication)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alphaTagId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

void (empty response body)

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

<a id="getalphatag"></a>
# **GetAlphaTag**
> AlphaTag GetAlphaTag (string alphaTagId, string contentType = null)

Get Alpha Tag

_Get a specific alpha tag._  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | alpha_tag_id | path | uuid | true | ID of the alpha tag |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   This endpoint requires authentication, [more info...](/#authentication)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alphaTagId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**AlphaTag**](AlphaTag.md)

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

<a id="listalphatags"></a>
# **ListAlphaTags**
> ListAlphaTags ListAlphaTags (string sortDirection = null, int pageSize = null)

List Alpha Tags


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sortDirection** | **string** | The sort direction for the results. The default value is asc. | [optional] [default to asc] |
| **pageSize** | **int** | The number of items to return per page. This parameter controls the size of each page of results. The default value is 10. | [optional] [default to 10] |

### Return type

[**ListAlphaTags**](ListAlphaTags.md)

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

<a id="requestalphatag"></a>
# **RequestAlphaTag**
> AlphaTag RequestAlphaTag (string contentType = null, RequestAlphaTagRequest requestAlphaTagRequest = null)

Request Alpha Tag

_Request to register an alpha tag. After requested, the alpha tag will be reviewed by ClickSend and either approved or rejected. Some countries (e.g Australia) require you to submit additional fields due to government mandated compliance checks._  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | alpha_tag | string | true | [yes](https://help.clicksend.com/article/1qxfxkcwm2-global-generic-alpha-tags) | The alpha tag name. Length must be between 3 - 11 characters, can only contain a-z A-Z 0-9 + and must contain at least one non numeric. | | reason | string | false | none | Must be one of the following: `Sole Trader Name`, `Company Name`, `Partnership Name`, `Registered Trust Name`, `Co-Operative Name`, `Indigenous Corporation Name`, `Registered Organisation Name`, `Personal Name`, `Trademark`, `Government Agency or Entity`, `Product or Service Name`, `Acronym/Initialism`, `Contraction of Name`, `Third Party`. In case of `Third Party`, we will contact you to collect the relevant information. | | countries | array of strings | false | none | List of country codes (e.g., \"AU\", \"US\") where the alpha tag is requested. Only supported and required for AU. | | businesses | array of objects | false | none | List of business details required for alpha tag registration. Each object contains country, business information, ... Required if `countries` is provided. When `business_relationship` is `ENTITY_ASSOCIATE`, the following partner fields are also **required**: `partner_business_name`, `partner_abn`, `partner_business_info`, `partner_business_address`, `partner_representative`. These fields are **forbidden** for any other `business_relationship` value. |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  _This endpoint requires authentication,_ [more info...](/#authentication) 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **requestAlphaTagRequest** | [**RequestAlphaTagRequest**](RequestAlphaTagRequest.md) |  | [optional]  |

### Return type

[**AlphaTag**](AlphaTag.md)

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

