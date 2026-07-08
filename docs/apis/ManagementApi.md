# ClickSend.Api.ManagementApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ViewAccountDetails**](ManagementApi.md#viewaccountdetails) | **GET** /v3/account | View Account Details |
| [**ViewAccountUsage**](ManagementApi.md#viewaccountusage) | **GET** /v3/account/usage/{year}/{month}/subaccount | View Account Usage |

<a id="viewaccountdetails"></a>
# **ViewAccountDetails**
> ViewAccountDetails ViewAccountDetails (string contentType = null)

View Account Details

_Get account information_  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/#pagination\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewAccountDetails**](ViewAccountDetails.md)

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

<a id="viewaccountusage"></a>
# **ViewAccountUsage**
> ViewAccountUsage ViewAccountUsage (string year, string month, string contentType = null)

View Account Usage

_Get account usage_  | **Name** | **Type** | **Required** | **Restrictions** | **Description** | | - -- | - -- | - -- | - -- | - -- | | year | string | true | none | Your account usage year. Example: 2019 | | month | string | true | none | Your account usage month. Example: 4 |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/#pagination\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **year** | **string** |  |  |
| **month** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewAccountUsage**](ViewAccountUsage.md)

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

