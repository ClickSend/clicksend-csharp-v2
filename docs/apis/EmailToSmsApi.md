# ClickSend.Api.EmailToSmsApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddAllowedEmail**](EmailToSmsApi.md#addallowedemail) | **POST** /v3/sms/email-sms | Add Allowed Email |
| [**CreateStrippedStringRule**](EmailToSmsApi.md#createstrippedstringrule) | **POST** /v3/sms/email-sms-stripped-strings | Create Stripped String Rule |
| [**DeleteStrippedStringRule**](EmailToSmsApi.md#deletestrippedstringrule) | **DELETE** /v3/sms/email-sms-stripped-strings/{rule_id} | Delete Stripped String Rule |
| [**UpdateStrippedStringRule**](EmailToSmsApi.md#updatestrippedstringrule) | **PUT** /v3/sms/email-sms-stripped-strings/{rule_id} | Update Stripped String Rule |
| [**ViewAllowedEmails**](EmailToSmsApi.md#viewallowedemails) | **GET** /v3/sms/email-sms | View Allowed Emails |
| [**ViewStrippedStringRule**](EmailToSmsApi.md#viewstrippedstringrule) | **GET** /v3/sms/email-sms-stripped-strings/{rule_id} | View Stripped String Rule |
| [**ViewStrippedStringRules**](EmailToSmsApi.md#viewstrippedstringrules) | **GET** /v3/sms/email-sms-stripped-strings | View Stripped String Rules |

<a id="addallowedemail"></a>
# **AddAllowedEmail**
> AddAllowedEmail AddAllowedEmail (string contentType = null, AddAllowedEmailRequest addAllowedEmailRequest = null)

Add Allowed Email

_Create email to sms allowed address_  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | email_address | string | true | none | Your email address | | from | string | false | [yes](http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number) | Your sender id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **addAllowedEmailRequest** | [**AddAllowedEmailRequest**](AddAllowedEmailRequest.md) |  | [optional]  |

### Return type

[**AddAllowedEmail**](AddAllowedEmail.md)

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

<a id="createstrippedstringrule"></a>
# **CreateStrippedStringRule**
> CreateStrippedStringRule CreateStrippedStringRule (string contentType = null, CreateStrippedStringRuleRequest createStrippedStringRuleRequest = null)

Create Stripped String Rule

_Create email to sms stripped string rule_  Create email to sms stripped string rules  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | stripped-string | body | string | true | String to be stripped. |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createStrippedStringRuleRequest** | [**CreateStrippedStringRuleRequest**](CreateStrippedStringRuleRequest.md) |  | [optional]  |

### Return type

[**CreateStrippedStringRule**](CreateStrippedStringRule.md)

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

<a id="deletestrippedstringrule"></a>
# **DeleteStrippedStringRule**
> DeleteStrippedStringRule DeleteStrippedStringRule (string ruleId, string contentType = null)

Delete Stripped String Rule

_Delete email to sms stripped string rule_  Delete email to sms stripped string rule  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | rule_id | path | integer(int32) | true | Your rule id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ruleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**DeleteStrippedStringRule**](DeleteStrippedStringRule.md)

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

<a id="updatestrippedstringrule"></a>
# **UpdateStrippedStringRule**
> UpdateStrippedStringRule UpdateStrippedStringRule (string ruleId, string contentType = null, CreateStrippedStringRuleRequest createStrippedStringRuleRequest = null)

Update Stripped String Rule

_Update email to sms stripped string rule_  Update email to sms stripped string rule  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | rule_id | path | integer(int32) | true | Your rule id | | stripped-string | body | string | true | String to be stripped. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ruleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **createStrippedStringRuleRequest** | [**CreateStrippedStringRuleRequest**](CreateStrippedStringRuleRequest.md) |  | [optional]  |

### Return type

[**UpdateStrippedStringRule**](UpdateStrippedStringRule.md)

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

<a id="viewallowedemails"></a>
# **ViewAllowedEmails**
> ViewAllowedEmails ViewAllowedEmails (string contentType = null)

View Allowed Emails

_Get list of email to sms allowed addresses_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewAllowedEmails**](ViewAllowedEmails.md)

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

<a id="viewstrippedstringrule"></a>
# **ViewStrippedStringRule**
> ViewStrippedStringRule ViewStrippedStringRule (string ruleId, string contentType = null)

View Stripped String Rule

_Get email to sms stripped string rule_  Get email to sms stripped string rule  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | rule_id | path | integer(int32) | true | Your rule id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ruleId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewStrippedStringRule**](ViewStrippedStringRule.md)

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

<a id="viewstrippedstringrules"></a>
# **ViewStrippedStringRules**
> ViewStrippedStringRules ViewStrippedStringRules (string contentType = null)

View Stripped String Rules

_Get list of email to sms stripped string rules_  Get list of email to sms stripped string rules  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | Page number | | limit | query | integer(int32) | false | Number of records per page |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewStrippedStringRules**](ViewStrippedStringRules.md)

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

