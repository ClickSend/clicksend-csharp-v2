# ClickSend.Api.VoiceMessagingApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculateVoicePrice**](VoiceMessagingApi.md#calculatevoiceprice) | **POST** /v3/voice/price | Calculate Voice Price |
| [**CancelAllVoiceMessages**](VoiceMessagingApi.md#cancelallvoicemessages) | **PUT** /v3/voice/cancel-all | Cancel All Voice Messages |
| [**CancelVoiceMessage**](VoiceMessagingApi.md#cancelvoicemessage) | **PUT** /v3/voice/{message_id}/cancel | Cancel Voice Message |
| [**ExportVoiceHistory**](VoiceMessagingApi.md#exportvoicehistory) | **GET** /v3/voice/history/export | Export Voice History |
| [**GetVoiceHistory**](VoiceMessagingApi.md#getvoicehistory) | **GET** /v3/voice/history | Get Voice History |
| [**SendVoiceMessage**](VoiceMessagingApi.md#sendvoicemessage) | **POST** /v3/voice/send | Send Voice Message |
| [**ViewVoiceLanguages**](VoiceMessagingApi.md#viewvoicelanguages) | **GET** /v3/voice/lang | View Voice Languages |
| [**ViewVoiceReceipts**](VoiceMessagingApi.md#viewvoicereceipts) | **GET** /v3/voice/receipts | View Voice Receipts |

<a id="calculatevoiceprice"></a>
# **CalculateVoicePrice**
> CalculateVoicePrice CalculateVoicePrice (string contentType = null, CalculateVoicePriceRequest calculateVoicePriceRequest = null)

Calculate Voice Price

_Calculate voice price_  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | to | string | true | none | Your phone number in [E.164](https://en.wikipedia.org/wiki/E.164) format. | | body | string | true | none | Biscuit uv3nlCOjRk croissant chocolate lollipop chocolate muffin. | | voice | string | true | none | Either 'female' or 'male'. | | custom_string | string | true | none | Your reference. Will be passed back with all replies and delivery reports. | | country | string | true | none | The country of the recipient. | | source | string | false | none | Your method of sending e.g. 'wordpress', 'php', 'c#'. | | list_id | integer(int32) | false | none | Your list ID if sending to a whole list. Can be used instead of 'to'. | | lang | string | false | none | au (string, required) - See section on available languages. | | schedule | integer(int32) | false | none | Leave blank for immediate delivery. Your schedule time in unix format [http://help.clicksend.com/what-is-a-unix-timestamp](http://help.clicksend.com/what-is-a-unix-timestamp) | | require_input | integer(int1) | false | none | Recieve a keypress from the recipient. Flag value must be 1 for yes or 0 for no. | | machine_detection | integer(int1) | false | none | Detect answering machine or voicemail and leave a message. Flag value must be 1 for yes or 0 for no. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **calculateVoicePriceRequest** | [**CalculateVoicePriceRequest**](CalculateVoicePriceRequest.md) |  | [optional]  |

### Return type

[**CalculateVoicePrice**](CalculateVoicePrice.md)

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

<a id="cancelallvoicemessages"></a>
# **CancelAllVoiceMessages**
> CancelAllVoiceMessages CancelAllVoiceMessages (string contentType = null, Object body = null)

Cancel All Voice Messages

_Update all voice messages as cancelled_  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **body** | **Object** |  | [optional]  |

### Return type

[**CancelAllVoiceMessages**](CancelAllVoiceMessages.md)

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

<a id="cancelvoicemessage"></a>
# **CancelVoiceMessage**
> CancelVoiceMessage CancelVoiceMessage (string messageId, string contentType = null, Object body = null)

Cancel Voice Message

_Update voice message status as cancelled_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | message_id | path | string | true | Your voice message id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **body** | **Object** |  | [optional]  |

### Return type

[**CancelVoiceMessage**](CancelVoiceMessage.md)

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

<a id="exportvoicehistory"></a>
# **ExportVoiceHistory**
> ExportVoiceHistory ExportVoiceHistory (string contentType = null, string filename = null, string q = null, string orderBy = null, string dateFrom = null, string dateTo = null, int limit = null)

Export Voice History

_Export voice history_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | filename | query | string | true | Filename to export to |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


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

[**ExportVoiceHistory**](ExportVoiceHistory.md)

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

<a id="getvoicehistory"></a>
# **GetVoiceHistory**
> GetVoiceHistory GetVoiceHistory (string contentType = null, string dateTo = null, int limit = null, string varOperator = null, string orderBy = null, int page = null)

Get Voice History

_Get all voice history_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | date_from | query | integer(int32) | false | Start date (Unix Timestamp e.g. 1436849372) | | date_to | query | integer(int32) | false | End date (Unix Timestamp e.g. 1436879372) | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **dateTo** | **string** |  | [optional]  |
| **limit** | **int** |  | [optional]  |
| **varOperator** | **string** |  | [optional]  |
| **orderBy** | **string** |  | [optional]  |
| **page** | **int** |  | [optional]  |

### Return type

[**GetVoiceHistory**](GetVoiceHistory.md)

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

<a id="sendvoicemessage"></a>
# **SendVoiceMessage**
> SendVoiceMessage SendVoiceMessage (string contentType = null, SendVoiceMessageRequest sendVoiceMessageRequest = null)

Send Voice Message

_Send voice message(s)_  Send TTS (Text-to-speech) voice calls  ### How many messages can I send?  You can post **up to 1000 messages** with each API call. You can send to a mix of contacts and contact lists, as long as the total number of recipients is up to 1000. The response contains a status and details for each recipient.  ### How many characters can I send in a message?  If a message is longer than 4 message parts, it will be truncated (see below). If a message contains any characters that aren't in the GSM 03.38 character set, the message type will be treated as unicode. (`https://en.wikipedia.org/wiki/GSM_03.38`)  ### _Standard English Characters:_  | Number of Characters | Message Credits | | - -- | - -- | | 1 - 300 | 1 | | 301 - 600 | 2 | | 601 - 900 | 3 | | 901 - 1200 | 4 |  ### _Non-GSM (Unicode) characters:_  | Number of Characters | Message Credits | | - -- | - -- | | 1 - 150 | 1 | | 151 - 300 | 2 | | 301 - 450 | 3 | | 451 - 600 | 4 |  ### _Allowed Languages_  | Language, Locale | lang | voice | | - -- | - -- | - -- | | `English`, US | en-us | female (default) / male | | `English`, Australia | en-au | female (default) / male | | `English`, UK | en-gb | female (default) / male | | `English`, India | en-in | female | | `English`, Wales | en-gb-wls | female (default) / male | | `Celtic`, Wales | cy-gb-wls | female (default) / male | | `German`, Germany | de-de | female (default) / male | | `Spanish`, Spain | es-es | female (default) / male | | `Spanish`, US | es-us | female (default) / male | | `French`, Canada | fr-ca | female | | `French`, France | fr-fr | female (default) / male | | `Icelandic`, Iceland | is-is | female (default) / male | | `Italian`, Italy | it-it | female (default) / male | | `Danish`, Denmark | da-dk | female (default) / male | | `Dutch`, Netherlands | nl-nl | female (default) / male | | `Norwegian`, Norway | nb-no | female | | `Polish`, Poland | pl-pl | female (default) / male | | `Portuguese`, Portugal | pt-pt | male | | `Portuguese`, Brazil | pt-br | female (default) / male | | `Romanian`, Romania | ro-ro | female | | `Russian`, Russia | ru-ru | female (default) / male | | `Swedish`, Sweden | sv-se | female | | `Turkish`, Turkey | tr-tr | female |  _Tips_  To introduce a small delay between words or digits you can use a comma (,).  For example: `Please enter your activation code 9, 0, 9, 0, in the next 20 minutes.`  We support some SSML tags allowing custom breaks or pauses to be entered, and the readout rate to be altered.  [More info...](https://help.clicksend.com/en/articles/42982-customising-text-to-voice-output)  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | to | string | true | none | Your phone number in [E.164](https://en.wikipedia.org/wiki/E.164) format. | | body | string | true | none | Biscuit uv3nlCOjRk croissant chocolate lollipop chocolate muffin. | | voice | string | true | none | Either 'female' or 'male'. | | custom_string | string | true | none | Your reference. Will be passed back with all replies and delivery reports. | | country | string | true | none | The country of the recipient. | | source | string | false | none | Your method of sending e.g. 'wordpress', 'php', 'c#'. | | list_id | integer(int32) | false | none | Your list ID if sending to a whole list. Can be used instead of 'to'. | | lang | string | false | none | au (string, required) - See section on available languages. | | schedule | integer(int32) | false | none | Leave blank for immediate delivery. Your schedule time in unix format [http://help.clicksend.com/what-is-a-unix-timestamp](http://help.clicksend.com/what-is-a-unix-timestamp) | | require_input | integer(int1) | false | none | Recieve a keypress from the recipient. Flag value must be 1 for yes or 0 for no. | | machine_detection | integer(int1) | false | none | Detect answering machine or voicemail and leave a message. Flag value must be 1 for yes or 0 for no. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **sendVoiceMessageRequest** | [**SendVoiceMessageRequest**](SendVoiceMessageRequest.md) |  | [optional]  |

### Return type

[**SendVoiceMessage**](SendVoiceMessage.md)

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

<a id="viewvoicelanguages"></a>
# **ViewVoiceLanguages**
> ViewVoiceLanguages ViewVoiceLanguages (string contentType = null)

View Voice Languages

_Get all voice languages_   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewVoiceLanguages**](ViewVoiceLanguages.md)

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

<a id="viewvoicereceipts"></a>
# **ViewVoiceReceipts**
> ViewVoiceReceipts ViewVoiceReceipts (string contentType = null)

View Voice Receipts

_Get all voice receipts_  **Push Delivery Receipts**  If you prefer, we can push message replies to your server as they arrive with us.  1. Log into your account. 2. Click on your profile on the top right. 3. Then click on the Messaging Settings option. 4. Click on Voice then Delivery Report Rules. 5. Click the 'Add New Rule' button. 6. Select the 'URL' action. 7. Enter the URL and click 'Save'.       The following variables will be posted to the URL specified:  | Variable | Description | | - -- | - -- | | `timestamp_send` | Timestamp of the original send request in UNIX format. e.g 1439173980 | | `timestamp` | Timestamp of delivery report in UNIX format. e.g 1439173981 | | `message_id` | Message ID, returned when originally sending the message. | | `status` | Delivered or Undelivered | | `status_code` | Status code. Refer to 'Voice Delivery Status Codes' in docs. | | `status_text` | Status text. | | `error_code` | Error code. | | `error_text` | Error text. | | `custom_string` | A custom string used when sending the original message. | | `user_id` | The user ID of the user who sent the message. | | `subaccount_id` | The subaccount ID of the user who sent the message. | | `message_type` | 'voice' (constant). | | `digits` | Numbers the recipient pressed on their keypad during the call. A blank string will be used if they didn't provide any input. |  **Pull Delivery Receipts**  Receive delivery reports by polling. You can poll our server and retrieve delivery reports at a time that suits you.  1. Log into your account. 2. Click on your profile on the top right. 3. Then click on the Messaging Settings option. 4. Click on Voice then Delivery Report Rules. 5. Click the 'Add New Rule' button. 6. Select the 'Poll' action. 7. Then click 'Save'.       ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewVoiceReceipts**](ViewVoiceReceipts.md)

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

