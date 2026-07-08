# ClickSend.Api.MmsCampaignsApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculateMmsCampaignPrice**](MmsCampaignsApi.md#calculatemmscampaignprice) | **POST** /v3/mms-campaigns/price | Calculate MMS Campaign Price |
| [**CancelMmsCampaign**](MmsCampaignsApi.md#cancelmmscampaign) | **PUT** /v3/mms-campaigns/{mms_campaign_id}/cancel | Cancel MMS Campaign |
| [**SendMmsCampaign**](MmsCampaignsApi.md#sendmmscampaign) | **POST** /v3/mms-campaigns/send | Send MMS Campaign |
| [**UpdateMmsCampaign**](MmsCampaignsApi.md#updatemmscampaign) | **PUT** /v3/mms-campaigns/{mms_campaign_id} | Update MMS Campaign |
| [**ViewAllMmsCampaigns**](MmsCampaignsApi.md#viewallmmscampaigns) | **GET** /v3/mms-campaigns | View All MMS Campaigns |
| [**ViewMmsCampaign**](MmsCampaignsApi.md#viewmmscampaign) | **GET** /v3/mms-campaigns/{mms_campaign_id} | View MMS Campaign |

<a id="calculatemmscampaignprice"></a>
# **CalculateMmsCampaignPrice**
> CalculateMmsCampaignPrice CalculateMmsCampaignPrice (string contentType = null, Object body = null)

Calculate MMS Campaign Price

_Calculate price for mms campaign_  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | integer(int32) | true | none | Your list id. | | name | string | true | none | Your campaign name. | | body | string | true | none | Your campaign message. | | from | string | true | [yes](http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number) | Your sender id | | schedule | integer(int32) | false | none | Your schedule timestamp. | | subject | string | true | none | Subject of MMS campaign. | | media_file | string | true | none | URL pointing to media file. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **body** | **Object** |  | [optional]  |

### Return type

[**CalculateMmsCampaignPrice**](CalculateMmsCampaignPrice.md)

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

<a id="cancelmmscampaign"></a>
# **CancelMmsCampaign**
> CancelMmsCampaign CancelMmsCampaign (string mmsCampaignId, string contentType = null, CalculateSmsCampaignPriceRequest calculateSmsCampaignPriceRequest = null)

Cancel MMS Campaign

_Cancel mms campaign_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | mms_campaign_id | path | integer(int32) | true | ID of MMS Campaign to cancel |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mmsCampaignId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **calculateSmsCampaignPriceRequest** | [**CalculateSmsCampaignPriceRequest**](CalculateSmsCampaignPriceRequest.md) |  | [optional]  |

### Return type

[**CancelMmsCampaign**](CancelMmsCampaign.md)

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

<a id="sendmmscampaign"></a>
# **SendMmsCampaign**
> SendMmsCampaign SendMmsCampaign (string contentType = null, SendMmsCampaignRequest sendMmsCampaignRequest = null)

Send MMS Campaign

_Create mms campaign_  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | integer(int32) | true | none | Your list id. | | name | string | true | none | Your campaign name. | | body | string | true | none | Your campaign message. | | from | string | true | [yes](http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number) | Your sender id | | schedule | integer(int32) | false | none | Your schedule timestamp. | | subject | string | true | none | Subject of MMS campaign. | | media_file | string | true | none | URL pointing to media file. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **sendMmsCampaignRequest** | [**SendMmsCampaignRequest**](SendMmsCampaignRequest.md) |  | [optional]  |

### Return type

[**SendMmsCampaign**](SendMmsCampaign.md)

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

<a id="updatemmscampaign"></a>
# **UpdateMmsCampaign**
> UpdateMmsCampaign UpdateMmsCampaign (string mmsCampaignId, string contentType = null, CalculateSmsCampaignPriceRequest calculateSmsCampaignPriceRequest = null)

Update MMS Campaign

_Update mms campaign_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | mms_campaign_id | path | integer(int32) | true | ID of MMS campaign to update |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | integer(int32) | true | none | Your list id. | | name | string | true | none | Your campaign name. | | body | string | true | none | Your campaign message. | | from | string | true | [yes](http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number) | Your sender id | | schedule | integer(int32) | false | none | Your schedule timestamp. | | subject | string | true | none | Subject of MMS campaign. | | media_file | string | true | none | URL pointing to media file. |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mmsCampaignId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **calculateSmsCampaignPriceRequest** | [**CalculateSmsCampaignPriceRequest**](CalculateSmsCampaignPriceRequest.md) |  | [optional]  |

### Return type

[**UpdateMmsCampaign**](UpdateMmsCampaign.md)

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

<a id="viewallmmscampaigns"></a>
# **ViewAllMmsCampaigns**
> ViewAllMmsCampaigns ViewAllMmsCampaigns (string contentType = null)

View All MMS Campaigns

_Get list of mms campaigns_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewAllMmsCampaigns**](ViewAllMmsCampaigns.md)

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

<a id="viewmmscampaign"></a>
# **ViewMmsCampaign**
> ViewMmsCampaign ViewMmsCampaign (string mmsCampaignId, string contentType = null)

View MMS Campaign

_Get specific mms campaign_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | mms_campaign_id | path | integer(int32) | true | ID of MMS campaign to retrieve |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **mmsCampaignId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewMmsCampaign**](ViewMmsCampaign.md)

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

