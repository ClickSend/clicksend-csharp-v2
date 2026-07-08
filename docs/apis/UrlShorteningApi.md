# ClickSend.Api.UrlShorteningApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ShortUrlGetStatistics**](UrlShorteningApi.md#shorturlgetstatistics) | **GET** /v3/short-url/statistics/{source}/{source_id} | Get Statistics |
| [**ShortUrlGetTracking**](UrlShorteningApi.md#shorturlgettracking) | **GET** /v3/short-url/tracking/{long_url_id} | Get Tracking |

<a id="shorturlgetstatistics"></a>
# **ShortUrlGetStatistics**
> GetStatistics ShortUrlGetStatistics (string source, string sourceId, string contentType = null)

Get Statistics

Use this endpoint to get the aggregated statistics for a shortened URL. This allows you to track the total number of clicks on the link. You can gather details such as the device type and where it was opened from as well.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **source** | **string** | Source of the request. |  |
| **sourceId** | **string** | ID of the source (e.g. message ID). |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**GetStatistics**](GetStatistics.md)

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

<a id="shorturlgettracking"></a>
# **ShortUrlGetTracking**
> GetTracking ShortUrlGetTracking (string longUrlId, string contentType = null)

Get Tracking

Use this endpoint to track how individual recipients interact with the link.  It returns data from the most recent click, including statistics such as how many times they’ve visited the link and when it was last opened. To use this endpoint, reference the _long_url_id_ provided in the [GET /short-url/statistics](/messaging/url-shortening/other/short-url-get-statistics) endpoint.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **longUrlId** | **string** | ID of the long URL (uniquely defined by the source, source ID, and long URL). Obtained from the GET statistics endpoint. |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**GetTracking**](GetTracking.md)

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

