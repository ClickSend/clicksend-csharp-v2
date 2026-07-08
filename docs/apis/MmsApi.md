# ClickSend.Api.MmsApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculateMmsPrice**](MmsApi.md#calculatemmsprice) | **POST** /v3/mms/price | Calculate MMS Price |
| [**ExportMmsHistory**](MmsApi.md#exportmmshistory) | **GET** /v3/mms/history/export | Export MMS History |
| [**SendMms**](MmsApi.md#sendmms) | **POST** /v3/mms/send | Send MMS |
| [**ViewMmsHistory**](MmsApi.md#viewmmshistory) | **GET** /v3/mms/history | View MMS History |

<a id="calculatemmsprice"></a>
# **CalculateMmsPrice**
> CalculateMmsPrice CalculateMmsPrice (string contentType = null, CalculateMmsPriceRequest calculateMmsPriceRequest = null)

Calculate MMS Price

_Get Price for MMS sent_  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | media_file | string | true | none | Media file you want to send | | to | string | true | none | Recipient phone number in [E.164](https://en.wikipedia.org/wiki/E.164) format | | body | string | true | none | Your message | | subject | string | true | none | Subject line (max 20 characters) | | from | string | true | [yes](http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number) | Your sender id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **calculateMmsPriceRequest** | [**CalculateMmsPriceRequest**](CalculateMmsPriceRequest.md) |  | [optional]  |

### Return type

[**CalculateMmsPrice**](CalculateMmsPrice.md)

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

<a id="exportmmshistory"></a>
# **ExportMmsHistory**
> ExportMmsHistory ExportMmsHistory (string contentType = null, string filename = null, string q = null, string orderBy = null, string dateFrom = null, string dateTo = null, int limit = null)

Export MMS History

_Export all mms history_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | filename | query | string | true | Filename to download history as |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **filename** | **string** |  | [optional]  |
| **q** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |
| **dateFrom** | **string** |  | [optional]  |
| **dateTo** | **string** |  | [optional]  |
| **limit** | **int** |  | [optional]  |

### Return type

[**ExportMmsHistory**](ExportMmsHistory.md)

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

<a id="sendmms"></a>
# **SendMms**
> SendMms SendMms (string contentType = null, SendMmsRequest sendMmsRequest = null)

Send MMS

_Send MMS_  You can post **up to 1000 messages** with each API call. You can send to a mix of contacts and contact lists, as long as the total number of recipients is up to 1000. The response contains a status and details for each recipient.  Refer to [<b>Application Status Codes</b>](/#application-status-codes) for the possible response message status strings.  ### **How many characters can I send in a message?**  ### Standard MMS Message  1500 characters  ### Unicode MMS Message  500 characters  If a message is longer the allowed number of characters it will be truncated. If a message contains any characters that aren't in the GSM 03.38 character set, the message type will be treated as unicode. ([https://en.wikipedia.org/wiki/GSM_03.38](https://en.wikipedia.org/wiki/GSM_03.38))  ### Maximum File Size  You can send a single attachment with a size of up to 250 kB. Some older devices can only accept attachments with up to 30 kB.  ### Supported File Types  - Supported file types are listed below. If you need to convert a file to a supported format, it can be first passed to our uploads endpoint: `/uploads?convert=mms` - This will return a URL to the converted image file that can be used in the /mms/send endpoint. - Contact us to add support for any other file type.       ### Images  | File type | Required to be passed to uploads endpoint first? | | - -- | - -- | | `jpg` | No | | `gif` | No | | `jpeg` | Yes | | `png` | Yes | | `bmp` | Yes |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | media_file | string | true | none | Media file you want to send | | to | string | true | none | Recipient phone number in [E.164](https://en.wikipedia.org/wiki/E.164) format | | body | string | true | none | Your message | | subject | string | true | none | Subject line (max 20 characters) | | from | string | true | [yes](http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number) | Your sender id |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **sendMmsRequest** | [**SendMmsRequest**](SendMmsRequest.md) |  | [optional]  |

### Return type

[**SendMms**](SendMms.md)

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

<a id="viewmmshistory"></a>
# **ViewMmsHistory**
> ViewMmsHistory ViewMmsHistory (string contentType = null, int limit = null)

View MMS History

_Get all mms history_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | date_from | query | integer(int32) | false | Start date (Unix Timestamp e.g. 1436849372) | | date_to | query | integer(int32) | false | End date (Unix Timestamp e.g. 1436879372) | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **limit** | **int** |  | [optional]  |

### Return type

[**ViewMmsHistory**](ViewMmsHistory.md)

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

