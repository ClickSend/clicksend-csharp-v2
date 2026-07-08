# ClickSend.Api.PostcardsApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculatePostcardPrice**](PostcardsApi.md#calculatepostcardprice) | **POST** /v3/post/postcards/price | Calculate Postcard Price |
| [**CancelScheduledPostcard**](PostcardsApi.md#cancelscheduledpostcard) | **PUT** /v3/post/postcards/{message_id}/cancel | Cancel Scheduled Postcard |
| [**ExportPostcardHistory**](PostcardsApi.md#exportpostcardhistory) | **GET** /v3/post/postcards/history/export | Export Postcard History |
| [**SendPostcard**](PostcardsApi.md#sendpostcard) | **POST** /v3/post/postcards/send | Send Postcard |
| [**ViewPostcardHistory**](PostcardsApi.md#viewpostcardhistory) | **GET** /v3/post/postcards/history | View Postcard History |

<a id="calculatepostcardprice"></a>
# **CalculatePostcardPrice**
> CalculatePostcardPrice CalculatePostcardPrice (string contentType = null, SendPostcardRequest sendPostcardRequest = null)

Calculate Postcard Price

_Calculate price for sending one or more postcards_  For `file_urls` field. You can attach at least 1 and max of 2 PDF file urls.  - Supply a single pdf with 2 pages (front and back) - Supply 2 urls to seperate PDFs       ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | file_urls | \\[string\\] | true | none | Postcard file URLs | | address_name | string | true | none | Name of address | | address_line_1 | string | true | none | First line of address | | address_line_2 | string | true | none | Second line of address | | address_city | string | true | none | City | | address_state | string | true | none | State | | address_postal_code | string | true | none | Postal code | | address_country | string | true | none | Country | | return_address_id | integer(int32) | true | none | ID of return address to use | | schedule | integer(int32) | false | none | When to send letter (0/null=now) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **sendPostcardRequest** | [**SendPostcardRequest**](SendPostcardRequest.md) |  | [optional]  |

### Return type

[**CalculatePostcardPrice**](CalculatePostcardPrice.md)

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

<a id="cancelscheduledpostcard"></a>
# **CancelScheduledPostcard**
> CancelScheduledPostcard CancelScheduledPostcard (string messageId)

Cancel Scheduled Postcard

_Cancel scheduled postcard_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | message_id | query | string | true | Message ID of the scheduled postcard that is to be cancelled. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** |  |  |

### Return type

[**CancelScheduledPostcard**](CancelScheduledPostcard.md)

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

<a id="exportpostcardhistory"></a>
# **ExportPostcardHistory**
> ExportPostcardHistory ExportPostcardHistory (string contentType = null)

Export Postcard History

_Export postcard history to a CSV file_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | filename | query | string | true | Filename to export to |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ExportPostcardHistory**](ExportPostcardHistory.md)

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

<a id="sendpostcard"></a>
# **SendPostcard**
> SendPostcard SendPostcard (string contentType = null, SendPostcardRequest sendPostcardRequest = null)

Send Postcard

_Send one or more postcards_  ### **Supported File Types**  We support PDF, docx, doc, jpg, gif, png, and bmp. Contact us to add support for any other file type. If you're using docx, doc, jpg, gif, png, or bmp files, you'll need to convert the file first using our uploads endpoint with the querystring parameter ?convert=postcard. e.g. POST /uploads?convert=postcard. This will return a URL to the converted pdf file that can be used in the /post/postcards/send endpoint.  ### **Postcard Specification Guide**  Follow our [Postcard specification guide](https://help.clicksend.com/article/ysyql7bsr1-postcard-template) to ensure correct sending and postcard template information.  ### **Postcard File Options**  ### Use existing URL  With this option, you can use an existing URL to a `pdf` document. For example, you might generate the `pdf` on your server.  When using an existing url make sure that it is publicly accessible as it will not work if it is private.  For `file_urls` field. You can attach at least 1 and max of 2 PDF file urls.  - Supply a single pdf with 2 pages (front and back) - Supply 2 urls to seperate PDFs       ### Upload File to Our Server  With this option, you can use the [/uploads](/#upload-media-file) endpoint to upload the document. The `/uploads` endpoint returns a URL that can be used in the `/post/postcards/send` endpoint.  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | file_urls | \\[string\\] | true | none | Postcard file URLs | | address_name | string | true | none | Name of address | | address_line_1 | string | true | none | First line of address | | address_line_2 | string | true | none | Second line of address | | address_city | string | true | none | City | | address_state | string | true | none | State | | address_postal_code | string | true | none | Postal code | | address_country | string | true | none | Country | | return_address_id | integer(int32) | true | none | ID of return address to use | | schedule | integer(int32) | false | none | When to send letter (0/null=now) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **sendPostcardRequest** | [**SendPostcardRequest**](SendPostcardRequest.md) |  | [optional]  |

### Return type

[**SendPostcard**](SendPostcard.md)

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

<a id="viewpostcardhistory"></a>
# **ViewPostcardHistory**
> ViewPostcardHistory ViewPostcardHistory (string contentType = null)

View Postcard History

_Retrieve the history of postcards sent or scheduled_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewPostcardHistory**](ViewPostcardHistory.md)

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

