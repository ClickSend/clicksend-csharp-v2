# ClickSend.Api.LettersApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculateLetterPrice**](LettersApi.md#calculateletterprice) | **POST** /v3/post/letters/price | Calculate Letter Price |
| [**CancelScheduledLetter**](LettersApi.md#cancelscheduledletter) | **PUT** /v3/post/letters/{message_id}/cancel | Cancel Scheduled Letter |
| [**DetectAddress**](LettersApi.md#detectaddress) | **POST** /v3/post/letters/detect-address | Detect Address |
| [**ExportLetterHistory**](LettersApi.md#exportletterhistory) | **GET** /v3/post/letters/history/export | Export Letter History |
| [**SendLetter**](LettersApi.md#sendletter) | **POST** /v3/post/letters/send | Send Letter |
| [**ViewLetterHistory**](LettersApi.md#viewletterhistory) | **GET** /v3/post/letters/history | View Letter History |

<a id="calculateletterprice"></a>
# **CalculateLetterPrice**
> CalculateLetterPrice CalculateLetterPrice (string contentType = null, CalculateLetterPriceRequest calculateLetterPriceRequest = null)

Calculate Letter Price

_Calculate letter price_  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | file_url | string | true | none | URL of file to send | | address_name | string | true | none | Name of address | | address_line_1 | string | true | none | First line of address | | address_line_2 | string | true | none | Second line of address | | address_city | string | true | none | City | | address_state | string | true | none | State | | address_postal_code | string | true | none | Postal code | | address_country | string | true | none | Country | | return_address_id | integer(int32) | true | none | ID of return address to use | | schedule | integer(int32) | false | none | When to send letter (0/null=now) | | template_used | integer(int1) | false | none | Whether using our letter template. Flag value must be 1 for yes or 0 for no. | | duplex | integer(int1) | false | none | Whether letter is duplex. Flag value must be 1 for yes or 0 for no. | | colour | integer(int1) | false | none | Whether letter is in colour. Flag value must be 1 for yes or 0 for no. | | priority_post | integer(int1) | false | none | Whether letter is priority. Flag value must be 1 for yes or 0 for no. | | source | string | false | none | Source being sent from |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **calculateLetterPriceRequest** | [**CalculateLetterPriceRequest**](CalculateLetterPriceRequest.md) |  | [optional]  |

### Return type

[**CalculateLetterPrice**](CalculateLetterPrice.md)

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

<a id="cancelscheduledletter"></a>
# **CancelScheduledLetter**
> CancelScheduledLetter CancelScheduledLetter (string messageId)

Cancel Scheduled Letter

_Cancel scheduled letter_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | message_id | query | string | true | Message ID of the scheduled letter that is to be cancelled. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** |  |  |

### Return type

[**CancelScheduledLetter**](CancelScheduledLetter.md)

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

<a id="detectaddress"></a>
# **DetectAddress**
> DetectAddress DetectAddress (string contentType = null, Object body = null)

Detect Address

_Detects address in uploaded file._  The `detect-address` endpoint accepts either a letter in PDF format or an address string and attempts to convert it to a standard address format. Note that the PDF should be in standard address format, having the recipient's name and address listed at the top.  The endpoint accepts two types of data: 1. A PDF file in `base64` encoding. In this case, submit the `base64`\\-encoded PDF file contents in the `content` field of the request body. 2. An address string. In this case, submit the address in a string using the `address` field of the request body.  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | convert | query | string | true | none | | content | body | string | true | Base64-encoded file contents |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **body** | **Object** |  | [optional]  |

### Return type

[**DetectAddress**](DetectAddress.md)

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

<a id="exportletterhistory"></a>
# **ExportLetterHistory**
> ExportLetterHistory ExportLetterHistory (string contentType = null, string filename = null, string q = null, string orderBy = null, string dateFrom = null, string dateTo = null, int limit = null)

Export Letter History

_export letter history_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | filename | query | string | true | Filename to export to |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


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

[**ExportLetterHistory**](ExportLetterHistory.md)

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

<a id="sendletter"></a>
# **SendLetter**
> SendLetter SendLetter (string contentType = null, SendLetterRequest sendLetterRequest = null)

Send Letter

### Send letter  ### **Supported File Types**  We support `pdf`, `docx` and `doc` files. Contact us to add support for any other file type. If you're using `docx` or `doc` files, you'll need to convert the file first using our uploads endpoint with the querystring parameter `convert=post` e.g. `POST https://rest.clicksend.com/v3/uploads?convert=post`. This will return a URL to the converted pdf file that can be used in the `/post/letters/send` endpoint.  ### **Letter Specification Guide**  Follow our [Letter specification guide](https://help.clicksend.com/article/wcpkkoou6c-post-letter-template) to ensure correct sending and letter template information.  ### **Letter File Options**  ### Use existing URL  With this option, you can use an existing URL to a `pdf` document. For example, you might generate the `pdf` on your server.  When using an existing url make sure that it is publicly accessible as it will not work if it is private.  ### Upload File to Our Server  With this option, you can use the [/uploads](/#upload-media-file) endpoint to upload the document. The `/uploads` endpoint returns a URL that can be used in the `/post/letters/send` endpoint.  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | file_url | string | true | none | URL of file to send | | address_name | string | true | none | Name of address | | address_line_1 | string | true | none | First line of address | | address_line_2 | string | true | none | Second line of address | | address_city | string | true | none | City | | address_state | string | true | none | State | | address_postal_code | string | true | none | Postal code | | address_country | string | true | none | Country | | return_address_id | integer(int32) | true | none | ID of return address to use | | schedule | integer(int32) | false | none | When to send letter (0/null=now) | | template_used | integer(int1) | false | none | Whether using our letter template. Flag value must be 1 for yes or 0 for no. | | duplex | integer(int1) | false | none | Whether letter is duplex. Flag value must be 1 for yes or 0 for no. | | colour | integer(int1) | false | none | Whether letter is in colour. Flag value must be 1 for yes or 0 for no. | | priority_post | integer(int1) | false | none | Whether letter is priority, Flag value must be 1 for yes or 0 for no. | | source | string | false | none | Source being sent from |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **sendLetterRequest** | [**SendLetterRequest**](SendLetterRequest.md) |  | [optional]  |

### Return type

[**SendLetter**](SendLetter.md)

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

<a id="viewletterhistory"></a>
# **ViewLetterHistory**
> ViewLetterHistory ViewLetterHistory (string contentType = null)

View Letter History

_Get all letter history_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewLetterHistory**](ViewLetterHistory.md)

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

