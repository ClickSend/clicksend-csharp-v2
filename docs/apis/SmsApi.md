# ClickSend.Api.SmsApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculateSmsPrice**](SmsApi.md#calculatesmsprice) | **POST** /v3/sms/price | Calculate SMS Price |
| [**CancelAllSms**](SmsApi.md#cancelallsms) | **PUT** /v3/sms/cancel-all | Cancel All SMS |
| [**CancelSms**](SmsApi.md#cancelsms) | **PUT** /v3/sms/{message_id}/cancel | Cancel SMS |
| [**CreateSmsDeliveryReceiptRule**](SmsApi.md#createsmsdeliveryreceiptrule) | **POST** /v3/automations/sms/receipts | Create SMS Delivery Receipt Rule |
| [**CreateSmsInboundAutomation**](SmsApi.md#createsmsinboundautomation) | **POST** /v3/automations/sms/inbound | Create SMS Inbound Automation |
| [**CreateSmsTemplate**](SmsApi.md#createsmstemplate) | **POST** /v3/sms/templates | Create SMS Template |
| [**CreateTestInboundSms**](SmsApi.md#createtestinboundsms) | **POST** /v3/sms/inbound | Create Test Inbound SMS |
| [**CreateTestSmsReceipt**](SmsApi.md#createtestsmsreceipt) | **POST** /v3/sms/receipts | Create Test SMS Receipt |
| [**DeleteSmsDeliveryReceiptRule**](SmsApi.md#deletesmsdeliveryreceiptrule) | **DELETE** /v3/automations/sms/receipts/{receipt_rule_id} | Delete SMS Delivery Receipt Rule |
| [**DeleteSmsInboundAutomation**](SmsApi.md#deletesmsinboundautomation) | **DELETE** /v3/automations/sms/inbound/{inbound_rule_id} | Delete SMS Inbound Automation |
| [**DeleteSmsTemplate**](SmsApi.md#deletesmstemplate) | **DELETE** /v3/sms/templates/{template_id} | Delete SMS Template |
| [**ExportSmsHistory**](SmsApi.md#exportsmshistory) | **GET** /v3/sms/history/export | Export SMS History |
| [**MarkInboundSmsAsRead**](SmsApi.md#markinboundsmsasread) | **PUT** /v3/sms/inbound-read | Mark Inbound SMS as Read |
| [**MarkSmsReceiptAsRead**](SmsApi.md#marksmsreceiptasread) | **PUT** /v3/sms/receipts-read | Mark SMS Receipt As Read |
| [**MarkSpecificInboundSmsMessageAsRead**](SmsApi.md#markspecificinboundsmsmessageasread) | **PUT** /v3/sms/inbound-read/{message_id} | Mark Specific Inbound SMS Message As Read |
| [**SendSms**](SmsApi.md#sendsms) | **POST** /v3/sms/send | Send SMS |
| [**UpdateSmsDeliveryReceiptRule**](SmsApi.md#updatesmsdeliveryreceiptrule) | **PUT** /v3/automations/sms/receipts/{receipt_rule_id} | Update SMS Delivery Receipt Rule |
| [**UpdateSmsInboundAutomation**](SmsApi.md#updatesmsinboundautomation) | **PUT** /v3/automations/sms/inbound/{inbound_rule_id} | Update SMS Inbound Automation |
| [**UpdateSmsTemplate**](SmsApi.md#updatesmstemplate) | **PUT** /v3/sms/templates/{template_id} | Update SMS Template |
| [**ViewASpecificInboundSmsMessage**](SmsApi.md#viewaspecificinboundsmsmessage) | **GET** /v3/sms/inbound/{original_message_id} | View a specific inbound SMS message |
| [**ViewASpecificSmsTemplate**](SmsApi.md#viewaspecificsmstemplate) | **GET** /v3/sms/templates/{template_id} | View a Specific SMS Template |
| [**ViewInboundSms**](SmsApi.md#viewinboundsms) | **GET** /v3/sms/inbound | View Inbound SMS |
| [**ViewSmsDeliveryReceiptRule**](SmsApi.md#viewsmsdeliveryreceiptrule) | **GET** /v3/automations/sms/receipts/{receipt_rule_id} | View SMS Delivery Receipt Rule |
| [**ViewSmsDeliveryReceiptRules**](SmsApi.md#viewsmsdeliveryreceiptrules) | **GET** /v3/automations/sms/receipts | View SMS Delivery Receipt Rules |
| [**ViewSmsHistory**](SmsApi.md#viewsmshistory) | **GET** /v3/sms/history | View SMS History |
| [**ViewSmsInboundAutomation**](SmsApi.md#viewsmsinboundautomation) | **GET** /v3/automations/sms/inbound/{inbound_rule_id} | View SMS Inbound Automation |
| [**ViewSmsInboundAutomations**](SmsApi.md#viewsmsinboundautomations) | **GET** /v3/automations/sms/inbound | View SMS Inbound Automations |
| [**ViewSmsReceipts**](SmsApi.md#viewsmsreceipts) | **GET** /v3/sms/receipts | View SMS Receipts |
| [**ViewSmsTemplates**](SmsApi.md#viewsmstemplates) | **GET** /v3/sms/templates | View SMS Templates |
| [**ViewSpecificSmsReceipt**](SmsApi.md#viewspecificsmsreceipt) | **GET** /v3/sms/receipts/{message_id} | View Specific SMS Receipt |

<a id="calculatesmsprice"></a>
# **CalculateSmsPrice**
> CalculateSmsPrice CalculateSmsPrice (string contentType = null, CalculateSmsPriceRequest calculateSmsPriceRequest = null)

Calculate SMS Price

Use this endpoint to calculate the price of sending messages. The cost of sending messages varies based on the <a href=\"https://help.clicksend.com/article/h474eseq3a-how-many-characters-can-i-send-in-an-sms\" target=\"_blank\">type</a> and length of the message.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **calculateSmsPriceRequest** | [**CalculateSmsPriceRequest**](CalculateSmsPriceRequest.md) |  | [optional]  |

### Return type

[**CalculateSmsPrice**](CalculateSmsPrice.md)

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

<a id="cancelallsms"></a>
# **CancelAllSms**
> CancelAllSms CancelAllSms (string contentType = null, CancelAllSmsRequest cancelAllSmsRequest = null)

Cancel All SMS

Use this endpoint to cancel all scheduled SMS. To cancel only one scheduled SMS, use the **Cancel SMS** endpoint.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **cancelAllSmsRequest** | [**CancelAllSmsRequest**](CancelAllSmsRequest.md) |  | [optional]  |

### Return type

[**CancelAllSms**](CancelAllSms.md)

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

<a id="cancelsms"></a>
# **CancelSms**
> CancelSms CancelSms (string messageId, string contentType = null)

Cancel SMS

Use this endpoint to cancel a specific scheduled SMS. Unlike the **Cancel All SMS** endpoint, which cancels all scheduled SMS, this endpoint only cancels one specified scheduled SMS.  Specify the scheduled SMS to cancel by providing its _message_id_.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** | The _message_id_ of the scheduled SMS to cancel. |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**CancelSms**](CancelSms.md)

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

<a id="createsmsdeliveryreceiptrule"></a>
# **CreateSmsDeliveryReceiptRule**
> CreateSmsDeliveryReceiptRule CreateSmsDeliveryReceiptRule (string contentType = null, CreateSmsDeliveryReceiptRuleRequest createSmsDeliveryReceiptRuleRequest = null)

Create SMS Delivery Receipt Rule

_Create sms delivery receipt automations_  Create sms delivery receipt automations  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | rule_name | string | true | none | Rule Name. | | match_type | number | true | none | Match Type. 0=All reports. | | action | string | true | none | Action to be taken (AUTO_REPLY, EMAIL_USER, EMAIL_FIXED, URL, SMS, POLL, GROUP_SMS, MOVE_CONTACT, CREATE_CONTACT, CREATE_CONTACT_PLUS_EMAIL, CREATE_CONTACT_PLUS_NAME_EMAIL CREATE_CONTACT_PLUS_NAME, SMPP, NONE). | | action_address | string | true | none | Action address. | | enabled | number | true | none | Enabled: Disabled=0 or Enabled=1. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createSmsDeliveryReceiptRuleRequest** | [**CreateSmsDeliveryReceiptRuleRequest**](CreateSmsDeliveryReceiptRuleRequest.md) |  | [optional]  |

### Return type

[**CreateSmsDeliveryReceiptRule**](CreateSmsDeliveryReceiptRule.md)

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

<a id="createsmsinboundautomation"></a>
# **CreateSmsInboundAutomation**
> CreateSmsInboundAutomation CreateSmsInboundAutomation (string contentType = null, CreateSmsInboundAutomationRequest createSmsInboundAutomationRequest = null)

Create SMS Inbound Automation

_Create new inbound sms automation_  Create new inbound sms automation  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | dedicated_number | string | true | none | Decicated Number. Can be '\\*' to apply to all numbers. | | rule_name | string | true | none | Rule Name. | | message_search_type | number | true | none | Message Search Type: 0=Any message, 1=starts with, 2=contains, 3=does not contain. | | message_search_term | string | true | none | Message search term. | | action | string | true | none | Action to be taken (AUTO_REPLY, EMAIL_USER, EMAIL_FIXED, URL, SMS, POLL, GROUP_SMS, MOVE_CONTACT, CREATE_CONTACT, CREATE_CONTACT_PLUS_EMAIL, CREATE_CONTACT_PLUS_NAME_EMAIL CREATE_CONTACT_PLUS_NAME, SMPP, NONE). | | action_address | string | true | none | Action address. | | enabled | number | true | none | Enabled: Disabled=0 or Enabled=1. | | webhook_type | string | false | Required when action = URL only | Set as post, get, or json to change the format of the request sent. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createSmsInboundAutomationRequest** | [**CreateSmsInboundAutomationRequest**](CreateSmsInboundAutomationRequest.md) |  | [optional]  |

### Return type

[**CreateSmsInboundAutomation**](CreateSmsInboundAutomation.md)

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

<a id="createsmstemplate"></a>
# **CreateSmsTemplate**
> CreateSmsTemplate CreateSmsTemplate (string contentType = null, CreateSmsTemplateRequest createSmsTemplateRequest = null)

Create SMS Template

Use this endpoint to create a SMS template that you can use for sending SMS.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createSmsTemplateRequest** | [**CreateSmsTemplateRequest**](CreateSmsTemplateRequest.md) |  | [optional]  |

### Return type

[**CreateSmsTemplate**](CreateSmsTemplate.md)

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

<a id="createtestinboundsms"></a>
# **CreateTestInboundSms**
> CreateTestInboundSms CreateTestInboundSms (string contentType = null, CreateTestInboundSmsRequest createTestInboundSmsRequest = null)

Create Test Inbound SMS

Use this endpoint to generate and send a test <a href=\"https://help.clicksend.com/article/ik4hw5xu35-can-i-receive-inbound-sms-to-my-url\" target=\"_blank\">inbound SMS</a> to your webhook URL. Inbound SMS are messages sent by your recipient to you.  This test endpoint allows you to verify that the inbound SMS is correctly sent to your webhook URL.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createTestInboundSmsRequest** | [**CreateTestInboundSmsRequest**](CreateTestInboundSmsRequest.md) |  | [optional]  |

### Return type

[**CreateTestInboundSms**](CreateTestInboundSms.md)

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

<a id="createtestsmsreceipt"></a>
# **CreateTestSmsReceipt**
> CreateTestSmsReceipt CreateTestSmsReceipt (string contentType = null, CreateTestSmsReceiptRequest createTestSmsReceiptRequest = null)

Create Test SMS Receipt

Use this endpoint to generate and send a test <a href=\"https://help.clicksend.com/article/49eq1qdcui-how-do-i-receive-sms-delivery-receipts-delivery-status-updates\" target=\"_blank\">SMS delivery receipt</a> to your webhook URL. When you send an SMS, a delivery receipt is generated and can be received at your webhook URL. This test endpoint allows you to verify that the receipt is correctly sent to your webhook URL.  Additionally, you can obtain SMS receipts by setting the webhook URL to **poll** and periodically calling the **View SMS Receipt** endpoint to check for new receipts. This process is known as _polling_.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createTestSmsReceiptRequest** | [**CreateTestSmsReceiptRequest**](CreateTestSmsReceiptRequest.md) |  | [optional]  |

### Return type

[**CreateTestSmsReceipt**](CreateTestSmsReceipt.md)

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

<a id="deletesmsdeliveryreceiptrule"></a>
# **DeleteSmsDeliveryReceiptRule**
> DeleteSmsDeliveryReceiptRule DeleteSmsDeliveryReceiptRule (string receiptRuleId, string contentType = null)

Delete SMS Delivery Receipt Rule

_Delete sms delivery receipt automation_  Delete sms delivery receipt automation  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | receipt_rule_id | path | integer(int32) | true | Receipt rule id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **receiptRuleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**DeleteSmsDeliveryReceiptRule**](DeleteSmsDeliveryReceiptRule.md)

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

<a id="deletesmsinboundautomation"></a>
# **DeleteSmsInboundAutomation**
> DeleteSmsInboundAutomation DeleteSmsInboundAutomation (string inboundRuleId, string contentType = null)

Delete SMS Inbound Automation

_Delete inbound sms automation_  Delete inbound sms automation  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | inbound_rule_id | path | integer(int32) | true | Inbound rule id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboundRuleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**DeleteSmsInboundAutomation**](DeleteSmsInboundAutomation.md)

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

<a id="deletesmstemplate"></a>
# **DeleteSmsTemplate**
> DeleteSmsTemplate DeleteSmsTemplate (string templateId, string contentType = null)

Delete SMS Template

Use this endpoint to delete a <a href=\"https://help.clicksend.com/article/9z9uloaz8y-sms-templates-for-different-industries\" target=\"_blank\">SMS template</a>. Specify the SMS template to delete by providing its _template_id_.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The ID of the template to delete. |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**DeleteSmsTemplate**](DeleteSmsTemplate.md)

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

<a id="exportsmshistory"></a>
# **ExportSmsHistory**
> ExportSmsHistory ExportSmsHistory (string contentType = null, string filename = null, int page = null, int limit = null, string q = null, string orderBy = null, int dateFrom = null, int dateTo = null)

Export SMS History

Use this endpoint to create a download link of your SMS history. You can filter the SMS history result using the query parameters.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **filename** | **string** | The filename of the result. It should be in the .csv format. | [optional] [default to &quot;export.csv&quot;] |
| **page** | **int** | The page number to retrieve. Use this parameter to navigate through the [pagination](/#pagination) results. The default value is 1. | [optional] [default to 1] |
| **limit** | **int** | The number of items to return per page. This parameter controls the size of each page of results. The default value is 15. | [optional] [default to 15] |
| **q** | **string** | Allows filtering of results based on your search criteria. The query should be in the format &#x60;field_name:value&#x60;.  1. **Field Name**: The field within the SMS history you want to filter by. You can use the following fields:          - _Status_: The status of the SMS. Available values for status are: Queued, Completed, Scheduled, WaitApproval, Failed, Cancelled, CancelledAfterReview, Received, Sent.              - _To_: The recipient of the SMS.              - _from_: The sender of the SMS.              - _subaccount_id_: The sub-account identifier.              - _message_id_: The ID of your SMS.          2. **Value**: The text or keyword you&#39;re searching for within the specified field. If left empty after the colon, the filter will look for all templates with any value in the **Field Name**.             For example, if you are searching for a SMS with the status of _Scheduled_, the final query would look like this:    &#x60;q&#x3D;status:Scheduled&#x60;  &lt;div class&#x3D;\&quot;info-box\&quot;&gt;   &lt;h4&gt;&lt;i class&#x3D;\&quot;fas fa-info-circle\&quot;&gt;&lt;/i&gt; Note:&lt;/h4&gt;   &lt;div&gt;   &lt;p&gt;Some characters have to be encoded. For example, if you are searching for SMS sent from the phone number +61437085284, your search query q would be:&lt;br/&gt;&lt;/p&gt;     &lt;ul&gt;       &lt;li&gt;q&#x3D;from:%2B61437085284&lt;/li&gt;     &lt;/ul&gt;     &lt;p&gt;You can use the &lt;a href&#x3D;\&quot;https://www.urlencoder.org/\&quot; target&#x3D;\&quot;_blank\&quot;&gt;URL encoder&lt;/a&gt; to encode the text. If a character is not an alphanumeric character (A-Z, a-z, 0-9), it is typically either reserved or unsafe and should be encoded.&lt;/p&gt;   &lt;/div&gt; &lt;/div&gt; | [optional] [default to &quot;field_name&quot;] |
| **orderBy** | **string** | Specifies the field and order to sort the results by. The value is composed of the field name followed by a colon and the sort direction (asc for ascending or desc for descending).  The default sort order is by date in ascending order. You can use the following fields:    - _date_    - _username_   - _from_    - _to_   - _status_    - _body_  For example, if you want to order by the most recently sent SMS, you should sort by date in descending order. The query would look like this:    &#x60;order_by&#x3D;date:desc&#x60; | [optional] [default to &quot;date:asc&quot;] |
| **dateFrom** | **int** | Start date to filter results. It should be in &lt;a href&#x3D;\&quot;http://help.clicksend.com/what-is-a-unix-timestamp\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Unix format&lt;/a&gt;. | [optional]  |
| **dateTo** | **int** | End date to filter results. It should be in &lt;a href&#x3D;\&quot;http://help.clicksend.com/what-is-a-unix-timestamp\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Unix format&lt;/a&gt;. | [optional]  |

### Return type

[**ExportSmsHistory**](ExportSmsHistory.md)

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

<a id="markinboundsmsasread"></a>
# **MarkInboundSmsAsRead**
> MarkInboundSmsAsRead MarkInboundSmsAsRead (string contentType = null, MarkSmsReceiptAsReadRequest markSmsReceiptAsReadRequest = null)

Mark Inbound SMS as Read

Use this endpoint to mark all <a href=\"https://help.clicksend.com/article/ik4hw5xu35-can-i-receive-inbound-sms-to-my-url\" target=\"_blank\">inbound SMS</a> as read. Inbound SMS that has been marked as read won’t be shown in the **View Inbound SMS** endpoint. You can still use the **View Specific Inbound SMS** endpoint to view inbound SMS marked as read.  In the request, you can optionally add a _date_before_ parameter to only mark inbound SMS sent before that date as read.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **markSmsReceiptAsReadRequest** | [**MarkSmsReceiptAsReadRequest**](MarkSmsReceiptAsReadRequest.md) |  | [optional]  |

### Return type

[**MarkInboundSmsAsRead**](MarkInboundSmsAsRead.md)

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

<a id="marksmsreceiptasread"></a>
# **MarkSmsReceiptAsRead**
> MarkSmsReceiptAsRead MarkSmsReceiptAsRead (string contentType = null, MarkSmsReceiptAsReadRequest markSmsReceiptAsReadRequest = null)

Mark SMS Receipt As Read

Use this endpoint to mark all <a target=\"_blank\" href=\"https://help.clicksend.com/article/49eq1qdcui-how-do-i-receive-sms-delivery-receipts-delivery-status-updates\">SMS delivery receipts</a> as read. Delivery receipts that have been marked as read won’t be shown in the **View SMS Receipts** endpoint.  You can still use the **View Specific SMS Receipt** endpoint to view delivery receipts marked as read. In the request, you can optionally add a _date_before_ parameter to only mark receipts sent before that date as read


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **markSmsReceiptAsReadRequest** | [**MarkSmsReceiptAsReadRequest**](MarkSmsReceiptAsReadRequest.md) |  | [optional]  |

### Return type

[**MarkSmsReceiptAsRead**](MarkSmsReceiptAsRead.md)

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

<a id="markspecificinboundsmsmessageasread"></a>
# **MarkSpecificInboundSmsMessageAsRead**
> MarkSpecificInboundSmsMessageAsRead MarkSpecificInboundSmsMessageAsRead (string messageId, string contentType = null)

Mark Specific Inbound SMS Message As Read

Use this endpoint to mark a specific <a href=\"https://help.clicksend.com/article/ik4hw5xu35-can-i-receive-inbound-sms-to-my-url\" target=\"_blank\">inbound SMS</a> as read. Unlike the **View Inbound SMS** endpoint, which marks all inbound SMS as read,  this endpoint only marks one specified inbound SMS. Specify the SMS to be marked as read by providing its _message_id_.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** | The message_id of the inbound SMS to mark as read.  &lt;div class&#x3D;\&quot;info-box\&quot;&gt;   &lt;h4&gt;&lt;i class&#x3D;\&quot;fas fa-info-circle\&quot;&gt;&lt;/i&gt; Note:&lt;/h4&gt;   &lt;p&gt;     When you receive an inbound message, you will get two parameters: &lt;em&gt;original_message_id&lt;/em&gt; and &lt;em&gt;message_id&lt;/em&gt;:   &lt;/p&gt;   &lt;ul&gt;     &lt;li&gt;&lt;em&gt;original_message_id&lt;/em&gt;: This is the ID of the outbound message sent to the recipient&lt;/li&gt;     &lt;li&gt;&lt;em&gt;message_id&lt;/em&gt;: This is the ID of the inbound message sent by the recipient.&lt;/li&gt;   &lt;/ul&gt; &lt;/div&gt; |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**MarkSpecificInboundSmsMessageAsRead**](MarkSpecificInboundSmsMessageAsRead.md)

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

<a id="sendsms"></a>
# **SendSms**
> SendSms SendSms (string contentType = null, SendSmsRequest sendSmsRequest = null)

Send SMS

Use this endpoint to send messages to your recipients, either as phone numbers or contacts from your contact list.  The sender of the message (<a href=\"https://help.clicksend.com/article/4kgj7krx00-what-is-a-sender-id-or-sender-number\" target=\"_blank\"><strong>Sender ID</strong></a>) can be a shared number, a dedicated number, alpha tag (business name), or your own number.  You can send messages both locally and globally, subject to the country restrictions. The cost of sending messages varies based on the <a href=\"https://help.clicksend.com/article/h474eseq3a-how-many-characters-can-i-send-in-an-sms\" target=\"_blank\">type</a> and length of the message.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **sendSmsRequest** | [**SendSmsRequest**](SendSmsRequest.md) |  | [optional]  |

### Return type

[**SendSms**](SendSms.md)

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

<a id="updatesmsdeliveryreceiptrule"></a>
# **UpdateSmsDeliveryReceiptRule**
> UpdateSmsDeliveryReceiptRule UpdateSmsDeliveryReceiptRule (string receiptRuleId, string contentType = null, CreateSmsDeliveryReceiptRuleRequest createSmsDeliveryReceiptRuleRequest = null)

Update SMS Delivery Receipt Rule

_Update sms delivery receipt automation_  Update sms delivery receipt automation  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | receipt_rule_id | path | integer(int32) | true | Receipt rule id |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | rule_name | string | true | none | Rule Name. | | match_type | number | true | none | Match Type. 0=All reports. | | action | string | true | none | Action to be taken (AUTO_REPLY, EMAIL_USER, EMAIL_FIXED, URL, SMS, POLL, GROUP_SMS, MOVE_CONTACT, CREATE_CONTACT, CREATE_CONTACT_PLUS_EMAIL, CREATE_CONTACT_PLUS_NAME_EMAIL CREATE_CONTACT_PLUS_NAME, SMPP, NONE). | | action_address | string | true | none | Action address. | | enabled | number | true | none | Enabled: Disabled=0 or Enabled=1. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **receiptRuleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **createSmsDeliveryReceiptRuleRequest** | [**CreateSmsDeliveryReceiptRuleRequest**](CreateSmsDeliveryReceiptRuleRequest.md) |  | [optional]  |

### Return type

[**UpdateSmsDeliveryReceiptRule**](UpdateSmsDeliveryReceiptRule.md)

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

<a id="updatesmsinboundautomation"></a>
# **UpdateSmsInboundAutomation**
> UpdateSmsInboundAutomation UpdateSmsInboundAutomation (string inboundRuleId, string contentType = null, UpdateSmsInboundAutomationRequest updateSmsInboundAutomationRequest = null)

Update SMS Inbound Automation

_Update inbound sms automation_  Update inbound sms automation  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | inbound_rule_id | path | integer(int32) | true | Inbound rule id |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | dedicated_number | string | true | none | Dedicated Number. Can be '\\*' to apply to all numbers. | | rule_name | string | true | none | Rule Name. | | message_search_type | number | true | none | Message Search Type: 0=Any message, 1=starts with, 2=contains, 3=does not contain. | | message_search_term | string | true | none | Message search term. | | action | string | true | none | Action to be taken (AUTO_REPLY, EMAIL_USER, EMAIL_FIXED, URL, SMS, POLL, GROUP_SMS, MOVE_CONTACT, CREATE_CONTACT, CREATE_CONTACT_PLUS_EMAIL, CREATE_CONTACT_PLUS_NAME_EMAIL CREATE_CONTACT_PLUS_NAME, SMPP, NONE). | | action_address | string | true | none | Action address. | | enabled | number | true | none | Enabled: Disabled=0 or Enabled=1. | | webhook_type | string | false | Required when action = URL only | Set as post, get, or json to change the format of the request sent. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboundRuleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **updateSmsInboundAutomationRequest** | [**UpdateSmsInboundAutomationRequest**](UpdateSmsInboundAutomationRequest.md) |  | [optional]  |

### Return type

[**UpdateSmsInboundAutomation**](UpdateSmsInboundAutomation.md)

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

<a id="updatesmstemplate"></a>
# **UpdateSmsTemplate**
> UpdateSmsTemplate UpdateSmsTemplate (string templateId, string contentType = null, CreateSmsTemplateRequest createSmsTemplateRequest = null)

Update SMS Template

Use this endpoint to update a <a href=\"https://help.clicksend.com/article/9z9uloaz8y-sms-templates-for-different-industries\" target=\"_blank\">SMS template</a>.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The ID of the template to update. |  |
| **contentType** | **string** |  | [optional]  |
| **createSmsTemplateRequest** | [**CreateSmsTemplateRequest**](CreateSmsTemplateRequest.md) |  | [optional]  |

### Return type

[**UpdateSmsTemplate**](UpdateSmsTemplate.md)

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

<a id="viewaspecificinboundsmsmessage"></a>
# **ViewASpecificInboundSmsMessage**
> ViewASpecificInboundSmsMessage ViewASpecificInboundSmsMessage (string originalMessageId, string contentType = null)

View a specific inbound SMS message

Use this endpoint to retrieve a specific inbound SMS, including those that have been marked as read.  Inbound SMS are messages sent by your recipient to you. This endpoint enables you to retrieve those inbound SMS.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **originalMessageId** | **string** | The _original_message_id_ of the inbound SMS to view. If the recipient replied with multiple messages, this endpoint returns the first inbound SMS received.  &lt;div class&#x3D;\&quot;info-box\&quot;&gt;   &lt;h4&gt;&lt;i class&#x3D;\&quot;fas fa-info-circle\&quot;&gt;&lt;/i&gt; Note:&lt;/h4&gt;   &lt;p&gt;     When you receive an inbound message, you will get two parameters: &lt;em&gt;original_message_id&lt;/em&gt; and &lt;em&gt;message_id&lt;/em&gt;:   &lt;/p&gt;   &lt;ul&gt;     &lt;li&gt;&lt;em&gt;original_message_id&lt;/em&gt;: This is the ID of the outbound message sent to the recipient&lt;/li&gt;     &lt;li&gt;&lt;em&gt;message_id&lt;/em&gt;: This is the ID of the inbound message sent by the recipient.&lt;/li&gt;   &lt;/ul&gt; &lt;/div&gt; |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewASpecificInboundSmsMessage**](ViewASpecificInboundSmsMessage.md)

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

<a id="viewaspecificsmstemplate"></a>
# **ViewASpecificSmsTemplate**
> ViewASpecificSmsTemplate ViewASpecificSmsTemplate (string templateId, string contentType = null)

View a Specific SMS Template

Use this endpoint to retrieve a <a href=\"https://help.clicksend.com/article/9z9uloaz8y-sms-templates-for-different-industries\" target=\"_blank\">SMS template</a>. Specify which template to retrieve using the template ID.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** | The ID of the template to retrieve |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewASpecificSmsTemplate**](ViewASpecificSmsTemplate.md)

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

<a id="viewinboundsms"></a>
# **ViewInboundSms**
> ViewInboundSms ViewInboundSms (string contentType = null, int page = null, int limit = null)

View Inbound SMS

Use this endpoint to retrieve <a href=\"https://help.clicksend.com/article/49eq1qdcui-how-do-i-receive-sms-delivery-receipts-delivery-status-updates\" target=\"_blank\">SMS delivery receipts</a> sent by your recipient.  To be able to view receipts, add a <a href=\"https://help.clicksend.com/article/ut4ttdrrai-incoming-reply-sms-options\">inbound rule</a> with the Action set to **POLL** in the Dashboard, or use the [**Create SMS Inbound Automation**](/automations/sms/other/create-sms-inbound-automation) endpoint.  Control [pagination](/#pagination) with the _page_ and _limit_ query parameters to specify the page of results and the number of items returned.  <div class=\"info-box\">   <h4><i class=\"fas fa-info-circle\"></i> Note:</h4>   <p>If you have multiple inbound rules set to <strong>POLL</strong>, you will receive the inbound message multiple times.</p> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **page** | **int** | The page number to retrieve. Use this parameter to navigate through the [pagination](/#pagination) results. The default value is 1. | [optional] [default to 1] |
| **limit** | **int** | The number of items to return per page. This parameter controls the size of each page of results. The default value is 15. | [optional] [default to 15] |

### Return type

[**ViewInboundSms**](ViewInboundSms.md)

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

<a id="viewsmsdeliveryreceiptrule"></a>
# **ViewSmsDeliveryReceiptRule**
> ViewSmsDeliveryReceiptRule ViewSmsDeliveryReceiptRule (string receiptRuleId, string contentType = null)

View SMS Delivery Receipt Rule

_Get specific sms delivery receipt automation_  Get specific sms delivery receipt automation  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | receipt_rule_id | path | integer(int32) | true | Receipt rule id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **receiptRuleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewSmsDeliveryReceiptRule**](ViewSmsDeliveryReceiptRule.md)

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

<a id="viewsmsdeliveryreceiptrules"></a>
# **ViewSmsDeliveryReceiptRules**
> ViewSmsDeliveryReceiptRules ViewSmsDeliveryReceiptRules (string contentType = null)

View SMS Delivery Receipt Rules

_Get all sms delivery receipt automations_  Get all sms delivery receipt automations  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | Page number | | limit | query | integer(int32) | false | Number of records per page |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewSmsDeliveryReceiptRules**](ViewSmsDeliveryReceiptRules.md)

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

<a id="viewsmshistory"></a>
# **ViewSmsHistory**
> ViewSmsHistory ViewSmsHistory (string contentType = null, int page = null, int limit = null, string q = null, string orderBy = null, int dateFrom = null, int dateTo = null)

View SMS History

Use this endpoint to view previously sent SMS. You can filter the SMS history result using the query parameters.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **page** | **int** | The page number to retrieve. Use this parameter to navigate through the [pagination](/#pagination) results. The default value is 1. | [optional] [default to 1] |
| **limit** | **int** | The number of items to return per page. This parameter controls the size of each page of results. The default value is 15. | [optional] [default to 15] |
| **q** | **string** | Allows filtering of results based on your search criteria. The query should be in the format &#x60;field_name:value&#x60;.  1. **Field Name**: The field within the SMS history you want to filter by. You can use the following fields:          - _Status_: The status of the SMS. Available values for status are: Queued, Completed, Scheduled, WaitApproval, Failed, Cancelled, CancelledAfterReview, Received, Sent.              - _To_: The recipient of the SMS.              - _from_: The sender of the SMS.              - _subaccount_id_: The sub-account identifier.              - _message_id_: The ID of your SMS.          2. **Value**: The text or keyword you&#39;re searching for within the specified field. If left empty after the colon, the filter will look for all templates with any value in the **Field Name**.             For example, if you are searching for a SMS with the status of Scheduled, the final query would look like this:    &#x60;q&#x3D;status:Scheduled&#x60;  &lt;div class&#x3D;\&quot;info-box\&quot;&gt;   &lt;h4&gt;&lt;i class&#x3D;\&quot;fas fa-info-circle\&quot;&gt;&lt;/i&gt; Note:&lt;/h4&gt;   &lt;div&gt;    &lt;p&gt;Some characters have to be encoded. For example, if you are searching for SMS sent from the phone number +61437085284, your search query q would be:&lt;br/&gt;&lt;/p&gt;     &lt;ul&gt;       &lt;li&gt;q&#x3D;from:%2B61437085284&lt;/li&gt;     &lt;/ul&gt;     &lt;p&gt;You can use the &lt;a href&#x3D;\&quot;https://www.urlencoder.org/\&quot; target&#x3D;\&quot;_blank\&quot;&gt;URL encoder&lt;/a&gt; to encode the text. If a character is not an alphanumeric character (A-Z, a-z, 0-9), it is typically either reserved or unsafe and should be encoded.&lt;/p&gt;   &lt;/div&gt; &lt;/div&gt; | [optional] [default to &quot;field_name&quot;] |
| **orderBy** | **string** | Specifies the field and order to sort the results by. The value is composed of the field name followed by a colon and the sort direction (_asc_ for ascending or _desc_ for descending).  The default sort order is by _date_ in ascending order. You can use the following fields:    - _date_   - _username_   - _from_    - _to_   - _status_   - _body_  For example, if you want to order by the most recently sent SMS, you should sort by date in descending order. The query would look like this:    &#x60;order_by&#x3D;date:desc&#x60; | [optional] [default to &quot;date:asc&quot;] |
| **dateFrom** | **int** | Start date to filter results. It should be in &lt;a href&#x3D;\&quot;http://help.clicksend.com/what-is-a-unix-timestamp\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Unix format&lt;/a&gt;. | [optional]  |
| **dateTo** | **int** | End date to filter results. It should be in &lt;a href&#x3D;\&quot;http://help.clicksend.com/what-is-a-unix-timestamp\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Unix format&lt;/a&gt;. | [optional]  |

### Return type

[**ViewSmsHistory**](ViewSmsHistory.md)

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

<a id="viewsmsinboundautomation"></a>
# **ViewSmsInboundAutomation**
> ViewSmsInboundAutomation ViewSmsInboundAutomation (string inboundRuleId, string contentType = null)

View SMS Inbound Automation

_Get specific inbound sms automation_  Get specific inbound sms automation  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | inbound_rule_id | path | integer(int32) | true | Inbound rule id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboundRuleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewSmsInboundAutomation**](ViewSmsInboundAutomation.md)

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

<a id="viewsmsinboundautomations"></a>
# **ViewSmsInboundAutomations**
> ViewSmsInboundAutomations ViewSmsInboundAutomations (string contentType = null)

View SMS Inbound Automations

_Get all inbound sms automations_  Get all inbound sms automations  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | Page number | | limit | query | integer(int32) | false | Number of records per page |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewSmsInboundAutomations**](ViewSmsInboundAutomations.md)

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

<a id="viewsmsreceipts"></a>
# **ViewSmsReceipts**
> ViewSmsReceipts ViewSmsReceipts (string contentType = null, int page = null, int limit = null)

View SMS Receipts

Use this endpoint to retrieve <a href=\"https://help.clicksend.com/article/49eq1qdcui-how-do-i-receive-sms-delivery-receipts-delivery-status-updates\" target=\"_blank\">SMS delivery receipts</a> sent by your recipient.  To be able to view receipts, add a <a href=\"https://help.clicksend.com/en/articles/42317-delivery-notifications-reports\" target=\"_blank\">delivery report</a> rule with the Action set to **POLL** in the Dashboard, or use the [**Create SMS Delivery Receipt Rule**](/automations/sms/other/create-sms-delivery-receipt-rule) endpoint.  Control [pagination](/#pagination) with the _page_ and _limit_ query parameters to specify the page of results and the number of items returned.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **page** | **int** | The page number to retrieve. Use this parameter to navigate through the [pagination](/#pagination) results. The default value is 1. | [optional] [default to 1] |
| **limit** | **int** | The number of items to return per page. This parameter controls the size of each page of results. The default value is 15. | [optional] [default to 15] |

### Return type

[**ViewSmsReceipts**](ViewSmsReceipts.md)

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

<a id="viewsmstemplates"></a>
# **ViewSmsTemplates**
> ViewSmsTemplates ViewSmsTemplates (string contentType = null, int page = null, int limit = null, string q = null, string orderBy = null)

View SMS Templates

Use this endpoint to retrieve <a href=\"https://help.clicksend.com/article/9z9uloaz8y-sms-templates-for-different-industries\" target=\"_blank\">SMS templates</a>. You can filter the SMS templates result using the query parameters.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **page** | **int** | The page number to retrieve. Use this parameter to navigate through the [pagination](/#pagination) results. The default value is 1. | [optional] [default to 1] |
| **limit** | **int** | The number of items to return per page. This parameter controls the size of each page of results. The default value is 15. | [optional] [default to 15] |
| **q** | **string** | Allows filtering of results based on your search criteria. The query should be in the format &#x60;field_name:value&#x60;.  1. **Field Name**: The field within the SMS history you want to filter by. You can use the following fields:    - _template_id_ : The ID of the template   - _template_name_ : The name of the template   - _body_ : The body content of the template.          2. **Value**: The text or keyword you&#39;re searching for within the specified field. If left empty after the colon, the filter will look for all templates with any value in the **Field Name**.      For example, if you are searching for the template with the name of _sample_name_, the final query would look like this:     &#x60;q&#x3D;template_name:sample_name&#x60;  &lt;div class&#x3D;\&quot;info-box\&quot;&gt;   &lt;h4&gt;&lt;i class&#x3D;\&quot;fas fa-info-circle\&quot;&gt;&lt;/i&gt; Note:&lt;/h4&gt;   &lt;div&gt;    &lt;p&gt;Some characters have to be encoded. For example, if you are searching for SMS sent from the phone number +61437085284, your search query q would be:&lt;br/&gt;&lt;/p&gt;     &lt;ul&gt;       &lt;li&gt;q&#x3D;from:%2B61437085284&lt;/li&gt;     &lt;/ul&gt;     &lt;p&gt;You can use the &lt;a href&#x3D;\&quot;https://www.urlencoder.org/\&quot; target&#x3D;\&quot;_blank\&quot;&gt;URL encoder&lt;/a&gt; to encode the text. If a character is not an alphanumeric character (A-Z, a-z, 0-9), it is typically either reserved or unsafe and should be encoded.&lt;/p&gt;   &lt;/div&gt; &lt;/div&gt; | [optional] [default to &quot;field_name&quot;] |
| **orderBy** | **string** | Specifies the field and order to sort the results by.  The value is composed of the field name followed by a colon and the sort direction (_asc_ for ascending or _desc_ for descending).  The default sort order is by _template_id_ in ascending order. You can use the following fields:      - _template_id_ : The ID of the Template - _template_name_ : The name of the Template - _body_ : The body content of the Template  For example, if you want to order by the _template_id_ in descending order, the query would look like this:    &#x60;order_by&#x3D;template_id:desc&#x60; | [optional] [default to &quot;template_id:asc&quot;] |

### Return type

[**ViewSmsTemplates**](ViewSmsTemplates.md)

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

<a id="viewspecificsmsreceipt"></a>
# **ViewSpecificSmsReceipt**
> ViewSpecificSmsReceipt ViewSpecificSmsReceipt (string messageId, string contentType = null)

View Specific SMS Receipt

Use this endpoint to retrieve a specific <a href=\"https://help.clicksend.com/article/49eq1qdcui-how-do-i-receive-sms-delivery-receipts-delivery-status-updates\" target=\"_blank\">SMS delivery receipt</a>, including those that have been marked as read. When you send an SMS, a delivery receipt is generated and can be received.  This endpoint enables you to retrieve those receipts.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** | The _message_id_ of the SMS delivery receipt to retrieve |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewSpecificSmsReceipt**](ViewSpecificSmsReceipt.md)

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

