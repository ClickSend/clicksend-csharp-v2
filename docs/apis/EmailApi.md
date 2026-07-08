# ClickSend.Api.EmailApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculateEmailCampaignPrice**](EmailApi.md#calculateemailcampaignprice) | **POST** /v3/email-campaigns/price | Calculate Email Campaign Price |
| [**CalculateEmailPrice**](EmailApi.md#calculateemailprice) | **POST** /v3/email/price | Calculate Email Price |
| [**CancelEmailCampaign**](EmailApi.md#cancelemailcampaign) | **PUT** /v3/email-campaigns/{email_campaign_id}/cancel | Cancel Email Campaign |
| [**CreateAllowedEmailAddress**](EmailApi.md#createallowedemailaddress) | **POST** /v3/email/addresses | Create Allowed Email Address |
| [**CreateEmailDeliveryReceiptRule**](EmailApi.md#createemaildeliveryreceiptrule) | **POST** /v3/automations/email/receipts | Create Email Delivery Receipt Rule |
| [**CreateEmailTemplate**](EmailApi.md#createemailtemplate) | **POST** /v3/email/templates | Create Email Template |
| [**DeleteAllowedEmailAddress**](EmailApi.md#deleteallowedemailaddress) | **DELETE** /v3/email/addresses/{email_address_id} | Delete Allowed Email Address |
| [**DeleteEmailDeliveryReceiptRule**](EmailApi.md#deleteemaildeliveryreceiptrule) | **DELETE** /v3/automations/email/receipts/{receipt_rule_id} | Delete Email Delivery Receipt Rule |
| [**DeleteEmailTemplate**](EmailApi.md#deleteemailtemplate) | **DELETE** /v3/email/templates/{template_id} | Delete Email Template |
| [**ExportEmailCampaignHistory**](EmailApi.md#exportemailcampaignhistory) | **GET** /v3/email-campaigns/{email_campaign_id}/history/export | Export Email Campaign History |
| [**ExportEmailHistory**](EmailApi.md#exportemailhistory) | **GET** /v3/email/history/export | Export Email History |
| [**SendEmail**](EmailApi.md#sendemail) | **POST** /v3/email/send | Send Email |
| [**SendEmailCampaign**](EmailApi.md#sendemailcampaign) | **POST** /v3/email-campaigns/send | Send Email Campaign |
| [**SendEmailVerificationToken**](EmailApi.md#sendemailverificationtoken) | **PUT** /v3/email/address-verify/{email_address_id}/send | Send Email Verification Token |
| [**UpdateEmailCampaign**](EmailApi.md#updateemailcampaign) | **PUT** /v3/email-campaigns/{email_campaign_id} | Update Email Campaign |
| [**UpdateEmailDeliveryReceiptRule**](EmailApi.md#updateemaildeliveryreceiptrule) | **PUT** /v3/automations/email/receipts/{receipt_rule_id} | Update Email Delivery Receipt Rule |
| [**UpdateEmailTemplate**](EmailApi.md#updateemailtemplate) | **PUT** /v3/email/templates/{template_id} | Update Email Template |
| [**VerifyAllowedEmailAddress**](EmailApi.md#verifyallowedemailaddress) | **PUT** /v3/email/address-verify/{email_address_id}/verify/{activation_token} | Verify Allowed Email Address |
| [**ViewAllEmailCampaigns**](EmailApi.md#viewallemailcampaigns) | **GET** /v3/email-campaigns | View All Email Campaigns |
| [**ViewAllowedEmailAddress**](EmailApi.md#viewallowedemailaddress) | **GET** /v3/email/addresses/{email_address_id} | View Allowed Email Address |
| [**ViewAllowedEmailAddresses**](EmailApi.md#viewallowedemailaddresses) | **GET** /v3/email/addresses | View Allowed Email Addresses |
| [**ViewEmailCampaign**](EmailApi.md#viewemailcampaign) | **GET** /v3/email-campaigns/{email_campaign_id} | View Email Campaign |
| [**ViewEmailCampaignHistory**](EmailApi.md#viewemailcampaignhistory) | **GET** /v3/email-campaigns/{email_campaign_id}/history | View Email Campaign History |
| [**ViewEmailDeliveryReceiptRule**](EmailApi.md#viewemaildeliveryreceiptrule) | **GET** /v3/automations/email/receipts/{receipt_rule_id} | View Email Delivery Receipt Rule |
| [**ViewEmailDeliveryReceiptRules**](EmailApi.md#viewemaildeliveryreceiptrules) | **GET** /v3/automations/email/receipts | View Email Delivery Receipt Rules |
| [**ViewEmailHistory**](EmailApi.md#viewemailhistory) | **GET** /v3/email/history | View Email History |
| [**ViewEmailTemplate**](EmailApi.md#viewemailtemplate) | **GET** /v3/email/templates/{template_id} | View Email Template |
| [**ViewEmailTemplates**](EmailApi.md#viewemailtemplates) | **GET** /v3/email/templates | View Email Templates |
| [**ViewMasterEmailTemplate**](EmailApi.md#viewmasteremailtemplate) | **GET** /v3/email/master-templates/{template_id} | View Master Email Template |
| [**ViewMasterEmailTemplates**](EmailApi.md#viewmasteremailtemplates) | **GET** /v3/email/master-templates | View Master Email Templates |
| [**ViewTemplateCategories**](EmailApi.md#viewtemplatecategories) | **GET** /v3/email/master-templates-categories | View Template Categories |
| [**ViewTemplateCategory**](EmailApi.md#viewtemplatecategory) | **GET** /v3/email/master-templates-categories/{category_id} | View Template Category |
| [**ViewTemplatesInCategory**](EmailApi.md#viewtemplatesincategory) | **GET** /v3/email/master-templates-categories/{category_id}/master-templates | View Templates in Category |

<a id="calculateemailcampaignprice"></a>
# **CalculateEmailCampaignPrice**
> CalculateEmailCampaignPrice CalculateEmailCampaignPrice (string contentType = null, CalculateEmailCampaignPriceRequest calculateEmailCampaignPriceRequest = null)

Calculate Email Campaign Price

_Calculate email campaign price_  Calculate email campaign price  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | name | string | true | none | Your campaign name. | | subject | string | true | none | Your campaign subject. | | body | string | true | none | Your campaign message. | | from_email_address_id | number | true | none | The allowed email address id. | | from_name | string | true | none | Your name or business name. | | template_id | number | false | none | Your template id. | | list_id | number | true | none | Your contact list id. | | schedule | integer(int32) | false | none | Your schedule timestamp. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **calculateEmailCampaignPriceRequest** | [**CalculateEmailCampaignPriceRequest**](CalculateEmailCampaignPriceRequest.md) |  | [optional]  |

### Return type

[**CalculateEmailCampaignPrice**](CalculateEmailCampaignPrice.md)

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

<a id="calculateemailprice"></a>
# **CalculateEmailPrice**
> CalculateEmailPrice CalculateEmailPrice (string contentType = null, CalculateEmailPriceRequest calculateEmailPriceRequest = null)

Calculate Email Price

_Get transactional email price_  Get transactional email price  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | to | array | true | none | Array of To Recipient items. (array of names and emails) | | cc | array | false | none | Array of Cc Recipient items. (array of names and emails) | | bcc | array | false | none | Array of Bcc Recipient items. (array of names and emails) | | from | object | true | none | From Email object. (object containing name and email) | | body | string | true | none | Body of the email. | | attachments | array | false | none | Array of Attachment items. | | schedule | number | false | none | Schedule. | | name | string | false | none | Name of person email belongs to | | email | string | true | none | Email to be used. | | content | string | true | none | The base64-encoded contents of the file. | | type | string | true | none | The type of file being attached. | | filename | string | true | none | The name of the file being attached. | | disposition | string | true | none | Inline for content that can be displayed within the email, or attachment for any other files. | | content_id | string | true | none | An ID for the content. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **calculateEmailPriceRequest** | [**CalculateEmailPriceRequest**](CalculateEmailPriceRequest.md) |  | [optional]  |

### Return type

[**CalculateEmailPrice**](CalculateEmailPrice.md)

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

<a id="cancelemailcampaign"></a>
# **CancelEmailCampaign**
> CancelEmailCampaign CancelEmailCampaign (string emailCampaignId, string contentType = null, CancelEmailCampaignRequest cancelEmailCampaignRequest = null)

Cancel Email Campaign

_Cancel email campaign_  Cancel email campaign  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | email_campaign_id | path | integer(int32) | true | Allowed email campaign id | | date_from | query | integer(int32) | false | Start date (Unix Timestamp e.g. 1436849372) | | date_to | query | integer(int32) | false | End date (Unix Timestamp e.g. 1436879372) | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailCampaignId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **cancelEmailCampaignRequest** | [**CancelEmailCampaignRequest**](CancelEmailCampaignRequest.md) |  | [optional]  |

### Return type

[**CancelEmailCampaign**](CancelEmailCampaign.md)

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

<a id="createallowedemailaddress"></a>
# **CreateAllowedEmailAddress**
> CreateAllowedEmailAddress CreateAllowedEmailAddress (string contentType = null, CreateAllowedEmailAddressRequest createAllowedEmailAddressRequest = null)

Create Allowed Email Address

_Create allowed Email Address_  Create allowed Email Address  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | body | body | string | true | Email to be allowed. |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createAllowedEmailAddressRequest** | [**CreateAllowedEmailAddressRequest**](CreateAllowedEmailAddressRequest.md) |  | [optional]  |

### Return type

[**CreateAllowedEmailAddress**](CreateAllowedEmailAddress.md)

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

<a id="createemaildeliveryreceiptrule"></a>
# **CreateEmailDeliveryReceiptRule**
> CreateEmailDeliveryReceiptRule CreateEmailDeliveryReceiptRule (string contentType = null, CreateSmsDeliveryReceiptRuleRequest createSmsDeliveryReceiptRuleRequest = null)

Create Email Delivery Receipt Rule

_Create email delivery receipt automations_  Create email delivery receipt automations  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | rule_name | string | true | none | Rule Name. | | match_type | number | true | none | Match Type. 0=All reports. | | action | string | true | none | Action to be taken (AUTO_REPLY, EMAIL_USER, EMAIL_FIXED, URL, SMS, POLL, GROUP_SMS, MOVE_CONTACT, CREATE_CONTACT, CREATE_CONTACT_PLUS_EMAIL, CREATE_CONTACT_PLUS_NAME_EMAIL CREATE_CONTACT_PLUS_NAME, SMPP, NONE). | | action_address | string | true | none | Action address. | | enabled | number | true | none | Enabled: Disabled=0 or Enabled=1. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createSmsDeliveryReceiptRuleRequest** | [**CreateSmsDeliveryReceiptRuleRequest**](CreateSmsDeliveryReceiptRuleRequest.md) |  | [optional]  |

### Return type

[**CreateEmailDeliveryReceiptRule**](CreateEmailDeliveryReceiptRule.md)

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

<a id="createemailtemplate"></a>
# **CreateEmailTemplate**
> CreateEmailTemplate CreateEmailTemplate (string contentType = null, CreateEmailTemplateRequest createEmailTemplateRequest = null)

Create Email Template

_Create email template_  Create email template  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | template_name | string | true | none | The intended name for the new template. | | template_id_master | number | true | none | The ID of the master template you want to base on. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createEmailTemplateRequest** | [**CreateEmailTemplateRequest**](CreateEmailTemplateRequest.md) |  | [optional]  |

### Return type

[**CreateEmailTemplate**](CreateEmailTemplate.md)

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

<a id="deleteallowedemailaddress"></a>
# **DeleteAllowedEmailAddress**
> DeleteAllowedEmailAddress DeleteAllowedEmailAddress (string emailAddressId, string contentType = null)

Delete Allowed Email Address

_Delete specific email address_  Delete specific email address  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | email_address_id | path | integer(int32) | true | Allowed email address id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailAddressId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**DeleteAllowedEmailAddress**](DeleteAllowedEmailAddress.md)

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

<a id="deleteemaildeliveryreceiptrule"></a>
# **DeleteEmailDeliveryReceiptRule**
> DeleteEmailDeliveryReceiptRule DeleteEmailDeliveryReceiptRule (string receiptRuleId, string contentType = null)

Delete Email Delivery Receipt Rule

_Delete email delivery receipt automation_  Delete email delivery receipt automation  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | receipt_rule_id | path | integer(int32) | true | Receipt rule id |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  This endpoint requires authentication, [more info...](/#authentication)   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **receiptRuleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**DeleteEmailDeliveryReceiptRule**](DeleteEmailDeliveryReceiptRule.md)

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

<a id="deleteemailtemplate"></a>
# **DeleteEmailTemplate**
> DeleteEmailTemplate DeleteEmailTemplate (string templateId, string contentType = null)

Delete Email Template

_Delete user email template_  Delete user email template  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | template_id | path | integer(int32) | true | Email template id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**DeleteEmailTemplate**](DeleteEmailTemplate.md)

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

<a id="exportemailcampaignhistory"></a>
# **ExportEmailCampaignHistory**
> void ExportEmailCampaignHistory (string emailCampaignId, string contentType = null)

Export Email Campaign History

_Export specific email campaign history_  Export specific email campaign history  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | email_campaign_id | path | integer(int32) | true | Allowed email campaign id | | date_from | query | integer(int32) | false | Start date (Unix Timestamp e.g. 1436849372) | | date_to | query | integer(int32) | false | End date (Unix Timestamp e.g. 1436879372) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailCampaignId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

void (empty response body)

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

<a id="exportemailhistory"></a>
# **ExportEmailHistory**
> ExportEmailHistory ExportEmailHistory (string contentType = null)

Export Email History

_Export all Transactional Email history_  Export all Transactional Email history  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | filename | query | string | true | Filename to download history as | | date_from | query | integer(int32) | false | Start date (Unix Timestamp e.g. 1436849372) | | date_to | query | integer(int32) | false | End date (Unix Timestamp e.g. 1436879372) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ExportEmailHistory**](ExportEmailHistory.md)

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

<a id="sendemail"></a>
# **SendEmail**
> SendEmail SendEmail (string contentType = null, SendEmailRequest sendEmailRequest = null)

Send Email

_Send transactional email_  Send transactional email  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | to | array | true | none | Array of To Recipient items. (array of names and emails) | | cc | array | false | none | Array of Cc Recipient items. (array of names and emails) | | bcc | array | false | none | Array of Bcc Recipient items. (array of names and emails) | | from | object | true | none | From Email object. (object containing name and email) | | body | string | true | none | Body of the email. | | attachments | array | false | none | Array of Attachment items. | | schedule | number | false | none | Schedule. | | name | string | false | none | Name of person email belongs to | | email | string | true | none | Email to be used. | | content | string | true | none | The base64-encoded contents of the file. | | type | string | true | none | The type of file being attached. | | filename | string | true | none | The name of the file being attached. | | disposition | string | true | none | Inline for content that can be displayed within the email, or attachment for any other files. | | content_id | string | true | none | An ID for the content. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **sendEmailRequest** | [**SendEmailRequest**](SendEmailRequest.md) |  | [optional]  |

### Return type

[**SendEmail**](SendEmail.md)

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

<a id="sendemailcampaign"></a>
# **SendEmailCampaign**
> SendEmailCampaign SendEmailCampaign (string contentType = null, SendEmailCampaignRequest sendEmailCampaignRequest = null)

Send Email Campaign

_Send email campaign_  Send email campaign  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | name | string | true | none | Your campaign name. | | subject | string | true | none | Your campaign subject. | | body | string | true | none | Your campaign message. | | from_email_address_id | number | true | none | The allowed email address id. | | from_name | string | true | none | Your name or business name. | | template_id | number | false | none | Your template id. | | list_id | number | true | none | Your contact list id. | | schedule | integer(int32) | false | none | Your schedule timestamp. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **sendEmailCampaignRequest** | [**SendEmailCampaignRequest**](SendEmailCampaignRequest.md) |  | [optional]  |

### Return type

[**SendEmailCampaign**](SendEmailCampaign.md)

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

<a id="sendemailverificationtoken"></a>
# **SendEmailVerificationToken**
> SendEmailVerificationToken SendEmailVerificationToken (string emailAddressId, string contentType = null, SendEmailVerificationTokenRequest sendEmailVerificationTokenRequest = null)

Send Email Verification Token

_Send verification token_  Send verification token  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | email_address_id | path | integer(int32) | true | Allowed email address id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailAddressId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **sendEmailVerificationTokenRequest** | [**SendEmailVerificationTokenRequest**](SendEmailVerificationTokenRequest.md) |  | [optional]  |

### Return type

[**SendEmailVerificationToken**](SendEmailVerificationToken.md)

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

<a id="updateemailcampaign"></a>
# **UpdateEmailCampaign**
> UpdateEmailCampaign UpdateEmailCampaign (string emailCampaignId, string contentType = null, UpdateEmailCampaignRequest updateEmailCampaignRequest = null)

Update Email Campaign

_Edit email campaign_  Edit email campaign  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | email_campaign_id | path | integer(int32) | true | Allowed email campaign id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailCampaignId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **updateEmailCampaignRequest** | [**UpdateEmailCampaignRequest**](UpdateEmailCampaignRequest.md) |  | [optional]  |

### Return type

[**UpdateEmailCampaign**](UpdateEmailCampaign.md)

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

<a id="updateemaildeliveryreceiptrule"></a>
# **UpdateEmailDeliveryReceiptRule**
> UpdateEmailDeliveryReceiptRule UpdateEmailDeliveryReceiptRule (string receiptRuleId, string contentType = null, CreateSmsDeliveryReceiptRuleRequest createSmsDeliveryReceiptRuleRequest = null)

Update Email Delivery Receipt Rule

_Update email delivery receipt automation_  Update email delivery receipt automation  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | receipt_rule_id | path | integer(int32) | true | Receipt rule id |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | rule_name | string | true | none | Rule Name. | | match_type | number | true | none | Match Type. 0=All reports. | | action | string | true | none | Action to be taken (AUTO_REPLY, EMAIL_USER, EMAIL_FIXED, URL, SMS, POLL, GROUP_SMS, MOVE_CONTACT, CREATE_CONTACT, CREATE_CONTACT_PLUS_EMAIL, CREATE_CONTACT_PLUS_NAME_EMAIL CREATE_CONTACT_PLUS_NAME, SMPP, NONE). | | action_address | string | true | none | Action address. | | enabled | number | true | none | Enabled: Disabled=0 or Enabled=1. |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **receiptRuleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **createSmsDeliveryReceiptRuleRequest** | [**CreateSmsDeliveryReceiptRuleRequest**](CreateSmsDeliveryReceiptRuleRequest.md) |  | [optional]  |

### Return type

[**UpdateEmailDeliveryReceiptRule**](UpdateEmailDeliveryReceiptRule.md)

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

<a id="updateemailtemplate"></a>
# **UpdateEmailTemplate**
> UpdateEmailTemplate UpdateEmailTemplate (string templateId, string contentType = null, UpdateEmailTemplateRequest updateEmailTemplateRequest = null)

Update Email Template

_Update email template_  Update email template  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | template_id | path | integer(int32) | true | Email template id |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | template_name | string | false | none | The intended name for the template. | | body | string | true | none | Your template body. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **updateEmailTemplateRequest** | [**UpdateEmailTemplateRequest**](UpdateEmailTemplateRequest.md) |  | [optional]  |

### Return type

[**UpdateEmailTemplate**](UpdateEmailTemplate.md)

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

<a id="verifyallowedemailaddress"></a>
# **VerifyAllowedEmailAddress**
> VerifyAllowedEmailAddress VerifyAllowedEmailAddress (string emailAddressId, string activationToken, string contentType = null, VerifyAllowedEmailAddressRequest verifyAllowedEmailAddressRequest = null)

Verify Allowed Email Address

_Verify email address using verification token_  Verify email address using verification token  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | email_address_id | path | integer(int32) | true | Allowed email address id | | activation_token | path | string | true | Your activation token. |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailAddressId** | **string** |  |  |
| **activationToken** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **verifyAllowedEmailAddressRequest** | [**VerifyAllowedEmailAddressRequest**](VerifyAllowedEmailAddressRequest.md) |  | [optional]  |

### Return type

[**VerifyAllowedEmailAddress**](VerifyAllowedEmailAddress.md)

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

<a id="viewallemailcampaigns"></a>
# **ViewAllEmailCampaigns**
> ViewAllEmailCampaigns ViewAllEmailCampaigns (string contentType = null)

View All Email Campaigns

_Get all email campaigns_  Get all email campaigns  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | Page number | | limit | query | integer(int32) | false | Number of records per page |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewAllEmailCampaigns**](ViewAllEmailCampaigns.md)

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

<a id="viewallowedemailaddress"></a>
# **ViewAllowedEmailAddress**
> ViewAllowedEmailAddress ViewAllowedEmailAddress (string emailAddressId, string contentType = null)

View Allowed Email Address

_Get specific email address_  Get specific email address  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | email_address_id | path | integer(int32) | true | Allowed email address id |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailAddressId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewAllowedEmailAddress**](ViewAllowedEmailAddress.md)

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

<a id="viewallowedemailaddresses"></a>
# **ViewAllowedEmailAddresses**
> ViewAllowedEmailAddresses ViewAllowedEmailAddresses (string contentType = null)

View Allowed Email Addresses

_Get all email addresses_  Get all email addresses  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | Page number | | limit | query | integer(int32) | false | Number of records per page |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewAllowedEmailAddresses**](ViewAllowedEmailAddresses.md)

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

<a id="viewemailcampaign"></a>
# **ViewEmailCampaign**
> ViewEmailCampaign ViewEmailCampaign (string emailCampaignId, string contentType = null)

View Email Campaign

_Get specific email campaign_  Get specific email campaign  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailCampaignId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewEmailCampaign**](ViewEmailCampaign.md)

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

<a id="viewemailcampaignhistory"></a>
# **ViewEmailCampaignHistory**
> ViewEmailCampaignHistory ViewEmailCampaignHistory (string emailCampaignId, string contentType = null)

View Email Campaign History

_Get specific email campaign history_  Get specific email campaign history   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **emailCampaignId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewEmailCampaignHistory**](ViewEmailCampaignHistory.md)

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

<a id="viewemaildeliveryreceiptrule"></a>
# **ViewEmailDeliveryReceiptRule**
> ViewEmailDeliveryReceiptRule ViewEmailDeliveryReceiptRule (string receiptRuleId, string contentType = null)

View Email Delivery Receipt Rule

_Get specific email delivery receipt automation_  Get specific email delivery receipt automation  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | receipt_rule_id | path | integer(int32) | true | Receipt rule id |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **receiptRuleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewEmailDeliveryReceiptRule**](ViewEmailDeliveryReceiptRule.md)

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

<a id="viewemaildeliveryreceiptrules"></a>
# **ViewEmailDeliveryReceiptRules**
> ViewEmailDeliveryReceiptRules ViewEmailDeliveryReceiptRules (string contentType = null)

View Email Delivery Receipt Rules

_Get all email delivery receipt automations_  Get all email delivery receipt automations  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | Page number | | limit | query | integer(int32) | false | Number of records per page |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewEmailDeliveryReceiptRules**](ViewEmailDeliveryReceiptRules.md)

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

<a id="viewemailhistory"></a>
# **ViewEmailHistory**
> ViewEmailHistory ViewEmailHistory (string contentType = null)

View Email History

_Get all transactional email history_  Get all transactional email history  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | date_from | query | integer(int32) | false | Start date (Unix Timestamp e.g. 1436849372) | | date_to | query | integer(int32) | false | End date (Unix Timestamp e.g. 1436879372) | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewEmailHistory**](ViewEmailHistory.md)

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

<a id="viewemailtemplate"></a>
# **ViewEmailTemplate**
> ViewEmailTemplate ViewEmailTemplate (string templateId, string contentType = null)

View Email Template

_Get specific user email template_  Get specific user email templates  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | template_id | path | integer(int32) | true | Email template id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewEmailTemplate**](ViewEmailTemplate.md)

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

<a id="viewemailtemplates"></a>
# **ViewEmailTemplates**
> ViewEmailTemplates ViewEmailTemplates (string contentType = null)

View Email Templates

_Get all user email templates_  Get all user email templates  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | Page number | | limit | query | integer(int32) | false | Number of records per page |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewEmailTemplates**](ViewEmailTemplates.md)

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

<a id="viewmasteremailtemplate"></a>
# **ViewMasterEmailTemplate**
> ViewMasterEmailTemplate ViewMasterEmailTemplate (string templateId, string contentType = null)

View Master Email Template

_Get specific master email template_  Get specific master email template  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | template_id | path | integer(int32) | true | Email template id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **templateId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewMasterEmailTemplate**](ViewMasterEmailTemplate.md)

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

<a id="viewmasteremailtemplates"></a>
# **ViewMasterEmailTemplates**
> ViewMasterEmailTemplates ViewMasterEmailTemplates (string contentType = null)

View Master Email Templates

_Get all master email templates._  Get all master email templates.  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | Page number | | limit | query | integer(int32) | false | Number of records per page |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewMasterEmailTemplates**](ViewMasterEmailTemplates.md)

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

<a id="viewtemplatecategories"></a>
# **ViewTemplateCategories**
> ViewTemplateCategories ViewTemplateCategories (string contentType = null)

View Template Categories

_Get all master email template categories_  Get all master email template categories  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | Page number | | limit | query | integer(int32) | false | Number of records per page |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewTemplateCategories**](ViewTemplateCategories.md)

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

<a id="viewtemplatecategory"></a>
# **ViewTemplateCategory**
> ViewTemplateCategory ViewTemplateCategory (string categoryId, string contentType = null)

View Template Category

_Get specific master email template category_  Get specific master email template category  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | category_id | path | integer(int32) | true | Email category id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewTemplateCategory**](ViewTemplateCategory.md)

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

<a id="viewtemplatesincategory"></a>
# **ViewTemplatesInCategory**
> ViewTemplatesInCategory ViewTemplatesInCategory (string categoryId, string contentType = null)

View Templates in Category

_Get all master email templates in a category_  Get all master email templates in a category  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | category_id | path | integer(int32) | true | Email category id | | page | query | integer(int32) | false | Page number | | limit | query | integer(int32) | false | Number of records per page |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **categoryId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewTemplatesInCategory**](ViewTemplatesInCategory.md)

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

