# ClickSend.Api.FaxApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculateFaxPrice**](FaxApi.md#calculatefaxprice) | **POST** /v3/fax/price | Calculate Fax Price |
| [**CreateFaxDeliveryReceiptRule**](FaxApi.md#createfaxdeliveryreceiptrule) | **POST** /v3/automations/fax/receipts | Create FAX Delivery Receipt Rule |
| [**CreateFaxInboundRule**](FaxApi.md#createfaxinboundrule) | **POST** /v3/automations/fax/inbound | Create Fax Inbound Rule |
| [**DeleteFaxDeliveryReceiptRule**](FaxApi.md#deletefaxdeliveryreceiptrule) | **DELETE** /v3/automations/fax/receipts/{receipt_rule_id} | Delete FAX Delivery Receipt Rule |
| [**DeleteFaxInboundRule**](FaxApi.md#deletefaxinboundrule) | **DELETE** /v3/automations/fax/inbound/{inbound_rule_id} | Delete Fax Inbound Rule |
| [**SendFax**](FaxApi.md#sendfax) | **POST** /v3/fax/send | Send Fax |
| [**UpdateFaxDeliveryReceiptRule**](FaxApi.md#updatefaxdeliveryreceiptrule) | **PUT** /v3/automations/fax/receipts/{receipt_rule_id} | Update FAX Delivery Receipt Rule |
| [**UpdateFaxInboundRule**](FaxApi.md#updatefaxinboundrule) | **PUT** /v3/automations/fax/inbound/{inbound_rule_id} | Update Fax Inbound Rule |
| [**ViewFaxDeliveryReceiptRule**](FaxApi.md#viewfaxdeliveryreceiptrule) | **GET** /v3/automations/fax/receipts/{receipt_rule_id} | View FAX Delivery Receipt Rule |
| [**ViewFaxDeliveryReceiptRules**](FaxApi.md#viewfaxdeliveryreceiptrules) | **GET** /v3/automations/fax/receipts | View FAX Delivery Receipt Rules |
| [**ViewFaxHistory**](FaxApi.md#viewfaxhistory) | **GET** /v3/fax/history | View Fax History |
| [**ViewFaxInboundRule**](FaxApi.md#viewfaxinboundrule) | **GET** /v3/automations/fax/inbound/{inbound_rule_id} | View Fax Inbound Rule |
| [**ViewFaxInboundRules**](FaxApi.md#viewfaxinboundrules) | **GET** /v3/automations/fax/inbound | View Fax Inbound Rules |
| [**ViewFaxReceipts**](FaxApi.md#viewfaxreceipts) | **GET** /v3/fax/receipts | View Fax Receipts |
| [**ViewSpecificFaxReceipt**](FaxApi.md#viewspecificfaxreceipt) | **GET** /v3/fax/receipts/{message_id} | View Specific Fax Receipt |

<a id="calculatefaxprice"></a>
# **CalculateFaxPrice**
> CalculateFaxPrice CalculateFaxPrice (string contentType = null, CalculateFaxPriceRequest calculateFaxPriceRequest = null)

Calculate Fax Price

_Calculate Total Price for Fax Messages sent_  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | file_url | string | true | none | URL of file to send | | source | string | true | none | Your method of sending e.g. 'wordpress', 'php', 'c#'. | | to | string | true | none | Recipient fax number in [E.164](https://en.wikipedia.org/wiki/E.164) format. | | list_id | integer(int32) | false | none | Your list ID if sending to a whole list. Can be used instead of 'to'. | | from | string | true | [yes](http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number) | Your sender id. Must be a valid fax number. | | schedule | integer(int32) | false | none | Leave blank for immediate delivery. Your schedule time in unix format [http://help.clicksend.com/what-is-a-unix-timestamp](http://help.clicksend.com/what-is-a-unix-timestamp) | | custom_string | string | false | none | Your reference. Will be passed back with all replies and delivery reports. | | country | string | false | none | ISO alpha-2 character country code e.g. 'US', we use this to format the recipient number if it's not in international format. | | from_email | string | false | none | An email address where the reply should be emailed to. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **calculateFaxPriceRequest** | [**CalculateFaxPriceRequest**](CalculateFaxPriceRequest.md) |  | [optional]  |

### Return type

[**CalculateFaxPrice**](CalculateFaxPrice.md)

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

<a id="createfaxdeliveryreceiptrule"></a>
# **CreateFaxDeliveryReceiptRule**
> CreateFaxDeliveryReceiptRule CreateFaxDeliveryReceiptRule (string contentType = null, CreateFaxDeliveryReceiptRuleRequest createFaxDeliveryReceiptRuleRequest = null)

Create FAX Delivery Receipt Rule

_Create fax delivery receipt automations_  Create fax delivery receipt automations  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | rule_name | string | true | none | Rule Name. | | match_type | number | true | none | Match Type. 0=All reports. | | action | string | true | none | Action to be taken (AUTO_REPLY, EMAIL_USER, EMAIL_FIXED, URL, SMS, POLL, GROUP_SMS, MOVE_CONTACT, CREATE_CONTACT, CREATE_CONTACT_PLUS_EMAIL, CREATE_CONTACT_PLUS_NAME_EMAIL CREATE_CONTACT_PLUS_NAME, SMPP, NONE). | | action_address | string | true | none | Action address. | | enabled | number | true | none | Enabled: Disabled=0 or Enabled=1. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createFaxDeliveryReceiptRuleRequest** | [**CreateFaxDeliveryReceiptRuleRequest**](CreateFaxDeliveryReceiptRuleRequest.md) |  | [optional]  |

### Return type

[**CreateFaxDeliveryReceiptRule**](CreateFaxDeliveryReceiptRule.md)

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

<a id="createfaxinboundrule"></a>
# **CreateFaxInboundRule**
> CreateFaxInboundRule CreateFaxInboundRule (string contentType = null, CreateFaxInboundRuleRequest createFaxInboundRuleRequest = null)

Create Fax Inbound Rule

_Create new inbound fax automation_  Create new inbound fax automation  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | dedicated_number | string | true | none | Dedicated Number. Can be '\\*' to apply to all numbers. | | rule_name | string | true | none | Rule Name. | | action | string | true | none | Action to be taken (AUTO_REPLY, EMAIL_USER, EMAIL_FIXED, URL, SMS, POLL, GROUP_SMS, MOVE_CONTACT, CREATE_CONTACT, CREATE_CONTACT_PLUS_EMAIL, CREATE_CONTACT_PLUS_NAME_EMAIL CREATE_CONTACT_PLUS_NAME, SMPP, NONE). | | action_address | string | true | none | Action address. | | enabled | number | true | none | Enabled: Disabled=0 or Enabled=1. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createFaxInboundRuleRequest** | [**CreateFaxInboundRuleRequest**](CreateFaxInboundRuleRequest.md) |  | [optional]  |

### Return type

[**CreateFaxInboundRule**](CreateFaxInboundRule.md)

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

<a id="deletefaxdeliveryreceiptrule"></a>
# **DeleteFaxDeliveryReceiptRule**
> DeleteFaxDeliveryReceiptRule DeleteFaxDeliveryReceiptRule (string receiptRuleId, string contentType = null)

Delete FAX Delivery Receipt Rule

_Delete fax delivery receipt automation_  Delete fax delivery receipt automation  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | receipt_rule_id | path | integer(int32) | true | Receipt rule id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **receiptRuleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**DeleteFaxDeliveryReceiptRule**](DeleteFaxDeliveryReceiptRule.md)

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

<a id="deletefaxinboundrule"></a>
# **DeleteFaxInboundRule**
> DeleteFaxInboundRule DeleteFaxInboundRule (string inboundRuleId, string contentType = null)

Delete Fax Inbound Rule

_Delete inbound fax automation_  Delete inbound fax automation  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | inbound_rule_id | path | integer(int32) | true | Inbound rule id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboundRuleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**DeleteFaxInboundRule**](DeleteFaxInboundRule.md)

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

<a id="sendfax"></a>
# **SendFax**
> SendFax SendFax (string contentType = null, SendFaxRequest sendFaxRequest = null)

Send Fax

### **Supported File Types**  - Supported file types are listed below. If you need to convert a file to a supported format, it can be first passed to our uploads endpoint: `/uploads?convert=fax` - This will return a URL to the converted pdf file that can be used in the /fax/send endpoint. - Contact us to add support for any other file type.       ### Documents  | File type | Required to be passed to uploads endpoint first? | | - -- | - -- | | pdf | No | | docx | Yes | | doc | Yes | | rtf | Yes |  _Send a fax using supplied supported file-types._  ### **Letter File Options**  ### Use existing URL  With this option, you can use an existing URL to a `pdf` document. For example, you might generate the `pdf` on your server.  When using an existing url make sure that it is publicly accessible as it will not work if it is private.  ### Upload File to Our Server  With this option, you can use the [/uploads](/#upload-media-file) endpoint to upload the document. The `/uploads` endpoint returns a URL that can be used in the `/fax/send` endpoint.  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | file_url | string | true | none | URL of file to send | | source | string | true | none | Your method of sending e.g. 'wordpress', 'php', 'c#'. | | to | string | true | none | Recipient fax number in [E.164](https://en.wikipedia.org/wiki/E.164) format. | | list_id | integer(int32) | false | none | Your list ID if sending to a whole list. Can be used instead of 'to'. | | from | string | true | [yes](http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number) | Your sender id. Must be a valid fax number. | | schedule | integer(int32) | false | none | Leave blank for immediate delivery. Your schedule time in unix format [http://help.clicksend.com/what-is-a-unix-timestamp](http://help.clicksend.com/what-is-a-unix-timestamp) | | custom_string | string | false | none | Your reference. Will be passed back with all replies and delivery reports. | | country | string | false | none | ISO alpha-2 character country code e.g. 'US', we use this to format the recipient number if it's not in international format. | | from_email | string | false | none | An email address where the reply should be emailed to. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **sendFaxRequest** | [**SendFaxRequest**](SendFaxRequest.md) |  | [optional]  |

### Return type

[**SendFax**](SendFax.md)

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

<a id="updatefaxdeliveryreceiptrule"></a>
# **UpdateFaxDeliveryReceiptRule**
> UpdateFaxDeliveryReceiptRule UpdateFaxDeliveryReceiptRule (string receiptRuleId, string contentType = null, UpdateFaxDeliveryReceiptRuleRequest updateFaxDeliveryReceiptRuleRequest = null)

Update FAX Delivery Receipt Rule

_Update fax delivery receipt automation_  Update fax delivery receipt automation  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | receipt_rule_id | path | integer(int32) | true | Receipt rule id |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | rule_name | string | true | none | Rule Name. | | match_type | number | true | none | Match Type. 0=All reports. | | action | string | true | none | Action to be taken (AUTO_REPLY, EMAIL_USER, EMAIL_FIXED, URL, SMS, POLL, GROUP_SMS, MOVE_CONTACT, CREATE_CONTACT, CREATE_CONTACT_PLUS_EMAIL, CREATE_CONTACT_PLUS_NAME_EMAIL CREATE_CONTACT_PLUS_NAME, SMPP, NONE). | | action_address | string | true | none | Action address. | | enabled | number | true | none | Enabled: Disabled=0 or Enabled=1. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **receiptRuleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **updateFaxDeliveryReceiptRuleRequest** | [**UpdateFaxDeliveryReceiptRuleRequest**](UpdateFaxDeliveryReceiptRuleRequest.md) |  | [optional]  |

### Return type

[**UpdateFaxDeliveryReceiptRule**](UpdateFaxDeliveryReceiptRule.md)

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

<a id="updatefaxinboundrule"></a>
# **UpdateFaxInboundRule**
> UpdateFaxInboundRule UpdateFaxInboundRule (string inboundRuleId, string contentType = null, CreateFaxInboundRuleRequest createFaxInboundRuleRequest = null)

Update Fax Inbound Rule

_Update inbound fax automation_  Update inbound fax automation  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | inbound_rule_id | path | integer(int32) | true | Inbound rule id |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | dedicated_number | string | true | none | Dedicated Number. Can be '\\*' to apply to all numbers. | | rule_name | string | true | none | Rule Name. | | action | string | true | none | Action to be taken (AUTO_REPLY, EMAIL_USER, EMAIL_FIXED, URL, SMS, POLL, GROUP_SMS, MOVE_CONTACT, CREATE_CONTACT, CREATE_CONTACT_PLUS_EMAIL, CREATE_CONTACT_PLUS_NAME_EMAIL CREATE_CONTACT_PLUS_NAME, SMPP, NONE). | | action_address | string | true | none | Action address. | | enabled | number | true | none | Enabled: Disabled=0 or Enabled=1. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboundRuleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **createFaxInboundRuleRequest** | [**CreateFaxInboundRuleRequest**](CreateFaxInboundRuleRequest.md) |  | [optional]  |

### Return type

[**UpdateFaxInboundRule**](UpdateFaxInboundRule.md)

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

<a id="viewfaxdeliveryreceiptrule"></a>
# **ViewFaxDeliveryReceiptRule**
> ViewFaxDeliveryReceiptRule ViewFaxDeliveryReceiptRule (string receiptRuleId, string contentType = null)

View FAX Delivery Receipt Rule

_Get specific fax delivery receipt automation_  Get specific fax delivery receipt automation  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | receipt_rule_id | path | integer(int32) | true | Receipt rule id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **receiptRuleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewFaxDeliveryReceiptRule**](ViewFaxDeliveryReceiptRule.md)

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

<a id="viewfaxdeliveryreceiptrules"></a>
# **ViewFaxDeliveryReceiptRules**
> ViewFaxDeliveryReceiptRules ViewFaxDeliveryReceiptRules (string contentType = null)

View FAX Delivery Receipt Rules

_Get all fax delivery receipt automations_  Get all fax delivery receipt automations  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | Page number | | limit | query | integer(int32) | false | Number of records per page |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewFaxDeliveryReceiptRules**](ViewFaxDeliveryReceiptRules.md)

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

<a id="viewfaxhistory"></a>
# **ViewFaxHistory**
> ViewFaxHistory ViewFaxHistory (string contentType = null)

View Fax History

_Get a list of Fax History._  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | date_from | query | integer(int32) | false | Start date (Unix Timestamp e.g. 1436849372) | | date_to | query | integer(int32) | false | End date (Unix Timestamp e.g. 1436879372) | | q | query | string | false | Custom query Example: status:Sent,status_code:201. | | order | query | string | false | Order result by Example: date_added:desc,list_id:desc. | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  This endpoint requires authentication, [more info...](/#authentication)   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewFaxHistory**](ViewFaxHistory.md)

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

<a id="viewfaxinboundrule"></a>
# **ViewFaxInboundRule**
> ViewFaxInboundRule ViewFaxInboundRule (string inboundRuleId, string contentType = null)

View Fax Inbound Rule

_Get specific inbound fax automation_  Get specific inbound fax automation  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | inbound_rule_id | path | integer(int32) | true | Inbound rule id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **inboundRuleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewFaxInboundRule**](ViewFaxInboundRule.md)

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

<a id="viewfaxinboundrules"></a>
# **ViewFaxInboundRules**
> ViewFaxInboundRules ViewFaxInboundRules (string contentType = null)

View Fax Inbound Rules

_Get all inbound fax automations_  Get all inbound fax automations  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | Page number | | limit | query | integer(int32) | false | Number of records per page |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewFaxInboundRules**](ViewFaxInboundRules.md)

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

<a id="viewfaxreceipts"></a>
# **ViewFaxReceipts**
> ViewFaxReceipts ViewFaxReceipts (string contentType = null)

View Fax Receipts

_Get List of Fax Receipts_  **Push Delivery Receipts**  If you prefer, we can push message replies to your server as they arrive with us.  1. Log into your account. 2. Click on your profile on the top right. 3. Then click on the Messaging Settings option. 4. Click on Fax then Delivery Reports. 5. Click the 'Add New Rule' button. 6. Select the 'URL' action. 7. Enter the URL and click 'Save'.       The following variables will be posted to the URL specified:  | Variable | Description | | - -- | - -- | | `timestamp_send` | Timestamp of the original send request in UNIX format. e.g 1439173980 | | `timestamp` | Timestamp of delivery report in UNIX format. e.g 1439173981 | | `message_id` | Message ID, returned when originally sending the message. | | `status` | Delivered or Undelivered | | `status_code` | Status code. Refer to 'Fax Delivery Status Codes' in docs. | | `status_text` | Status text. | | `error_code` | Error code. | | `error_text` | Error text. | | `custom_string` | A custom string used when sending the original message. | | `user_id` | The user ID of the user who sent the message. | | `subaccount_id` | The subaccount ID of the user who sent the message. | | `message_type` | 'fax' (constant). |  **Pull Delivery Receipts**  Receive delivery reports by polling. You can poll our server and retrieve delivery reports at a time that suits you.  1. Log into your account. 2. Click on your profile on the top right. 3. Then click on the Messaging Settings option. 4. Click on Fax then Delivery Rules. 5. Click the 'Add New Rule' button. 6. Select the 'Poll' action. 7. Then click 'Save'.       Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewFaxReceipts**](ViewFaxReceipts.md)

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

<a id="viewspecificfaxreceipt"></a>
# **ViewSpecificFaxReceipt**
> ViewSpecificFaxReceipt ViewSpecificFaxReceipt (string messageId, string contentType = null)

View Specific Fax Receipt

_Get a single fax receipt based on message id._  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | message_id | path | string | true | ID of the message receipt to retrieve |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewSpecificFaxReceipt**](ViewSpecificFaxReceipt.md)

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

