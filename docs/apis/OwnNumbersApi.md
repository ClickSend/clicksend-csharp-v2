# ClickSend.Api.OwnNumbersApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteOwnNumber**](OwnNumbersApi.md#deleteownnumber) | **DELETE** /v3/own-numbers/{own_number_id} | Delete Own Number |
| [**GetOwnNumberDetail**](OwnNumbersApi.md#getownnumberdetail) | **GET** /v3/own-numbers/{own_number_id} | Get Own Number Detail |
| [**ListOwnNumbers**](OwnNumbersApi.md#listownnumbers) | **GET** /v3/own-numbers | List Own Numbers |
| [**RequestOwnNumberVerificationOtp**](OwnNumbersApi.md#requestownnumberverificationotp) | **POST** /v3/own-numbers/verifications | Request Own Number Verification OTP |
| [**UpdateOwnNumber**](OwnNumbersApi.md#updateownnumber) | **PATCH** /v3/own-numbers/{own_number_id} | Update Own Number |
| [**VerifyOwnNumberOtp**](OwnNumbersApi.md#verifyownnumberotp) | **POST** /v3/own-numbers/verifications/{verification_id}/verify | Verify Own Number OTP |

<a id="deleteownnumber"></a>
# **DeleteOwnNumber**
> OwnNumber DeleteOwnNumber (string ownNumberId, string contentType = null)

Delete Own Number

_Delete a specific own numbers._  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | own_number_id | path | uuid | true | ID of the own number |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  This endpoint requires authentication, [more info...](/#authentication)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ownNumberId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**OwnNumber**](OwnNumber.md)

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

<a id="getownnumberdetail"></a>
# **GetOwnNumberDetail**
> OwnNumber GetOwnNumberDetail (string ownNumberId, string contentType = null)

Get Own Number Detail

_Get a specific own numbers._  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | own_number_id | path | uuid | true | ID of the own number |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  This endpoint requires authentication, [more info...](/#authentication)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ownNumberId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**OwnNumber**](OwnNumber.md)

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

<a id="listownnumbers"></a>
# **ListOwnNumbers**
> ListOwnNumbers ListOwnNumbers (string contentType = null)

List Own Numbers

_List own numbers._  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | offset | query | uuid | false | Page(offset) to be used for pagination. Example: `offset=f99872cc-11a6-48ba-a9f2-bcfb6dd1e3d4#8fa5ebc2-777b-45db-a448-ec76a40d4384` | | page_size | query | integer | false | Number of records per page. Default: 10. Range \\[1..500\\] | | filter\\[status\\]\\[\\] | query | string | false | Filter by statuses. Value must be in enum \\[`PENDING`, `APPROVED`, `REJECTED`\\]. For example: `filter[status][0]=PENDING&filter[status][1]=APPROVED` . | | sort_by | query | string | false | Sort by parameter. Default: `created_timestamp` | | sort_direction | query | string | false | Direction of sorting. Default: `asc`. Value must be in enum \\[`asc`, `desc`\\]. |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   This endpoint requires authentication, [more info...](/#authentication)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ListOwnNumbers**](ListOwnNumbers.md)

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

<a id="requestownnumberverificationotp"></a>
# **RequestOwnNumberVerificationOtp**
> RequestOwnNumberVerificationOtp RequestOwnNumberVerificationOtp (string contentType = null, RequestOwnNumberVerificationOtpRequest requestOwnNumberVerificationOtpRequest = null)

Request Own Number Verification OTP

_Request to generate own number verification OTP_  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | label | string | false | none | Custom label for phone number. Length must be between 1 - 200 characters. | | phone_number | string | true | none | Phone number. | | country | string | false | none | Country code. |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  This endpoint requires authentication, [more info...](/#authentication)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **requestOwnNumberVerificationOtpRequest** | [**RequestOwnNumberVerificationOtpRequest**](RequestOwnNumberVerificationOtpRequest.md) |  | [optional]  |

### Return type

[**RequestOwnNumberVerificationOtp**](RequestOwnNumberVerificationOtp.md)

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

<a id="updateownnumber"></a>
# **UpdateOwnNumber**
> OwnNumber UpdateOwnNumber (string ownNumberId)

Update Own Number

_Update details of a specific own numbers._  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | own_number_id | path | uuid | true | ID of the own number |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | label | string | false | none | Custom label for phone number. Length must be between 1 - 200 characters. |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  This endpoint requires authentication, [more info...](/#authentication)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ownNumberId** | **string** |  |  |

### Return type

[**OwnNumber**](OwnNumber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="verifyownnumberotp"></a>
# **VerifyOwnNumberOtp**
> VerifyOwnNumberOtp VerifyOwnNumberOtp (string verificationId, string contentType = null, VerifyOwnNumberOtpRequest verifyOwnNumberOtpRequest = null)

Verify Own Number OTP

_Request to verify an OTP for Own Number verification_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | verification_id | path | uuid | true | ID of the Own Number verification |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | code | string | true | none | OTP code. Length must be 6 characters | | phone_number | string | true | none | Phone number. | | country | string | false | none | Country code. |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  This endpoint requires authentication, [more info...](/#authentication)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **verificationId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **verifyOwnNumberOtpRequest** | [**VerifyOwnNumberOtpRequest**](VerifyOwnNumberOtpRequest.md) |  | [optional]  |

### Return type

[**VerifyOwnNumberOtp**](VerifyOwnNumberOtp.md)

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

