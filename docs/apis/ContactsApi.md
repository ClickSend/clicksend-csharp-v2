# ClickSend.Api.ContactsApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteContact**](ContactsApi.md#deletecontact) | **DELETE** /v3/lists/{list_id}/contacts/{contact_id} | Delete Contact |
| [**GetSpecificContact**](ContactsApi.md#getspecificcontact) | **GET** /v3/lists/{list_id}/contacts/{contact_id} | Get Specific Contact |
| [**UpdateContact**](ContactsApi.md#updatecontact) | **PUT** /v3/lists/{list_id}/contacts/{contact_id} | Update Contact |

<a id="deletecontact"></a>
# **DeleteContact**
> DeleteContact DeleteContact (string listId, string contactId, string contentType = null)

Delete Contact

_Delete a contact_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | path | integer(int32) | true | List ID | | contact_id | path | integer(int32) | true | Contact ID |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
| **contactId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**DeleteContact**](DeleteContact.md)

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

<a id="getspecificcontact"></a>
# **GetSpecificContact**
> GetSpecificContact GetSpecificContact (string listId, string contactId, string contentType = null)

Get Specific Contact

_Get a specific contact_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | path | integer(int32) | true | Your contact list id you want to access. | | contact_id | path | integer(int32) | true | Your contact id you want to access. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
| **contactId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**GetSpecificContact**](GetSpecificContact.md)

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

<a id="updatecontact"></a>
# **UpdateContact**
> UpdateContact UpdateContact (string listId, string contactId, string contentType = null, CreateNewContactRequest createNewContactRequest = null)

Update Contact

_Update specific contact_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | path | integer(int32) | true | Contact list id | | contact_id | path | integer(int32) | true | Contact ID |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | phone_number | string | true | none | Your phone number in [E.164](https://en.wikipedia.org/wiki/E.164) format. Must be provided if no fax number or email. | | email | string | false | none | Your email. Must be provided if no phone number or fax number. | | fax_number | string | false | none | Your fax number. Must be provided if no phone number or email. | | first_name | string | false | none | Your first name. | | address_line_1 | string | false | none | Your street address | | address_line_2 | string | false | none | none | | address_city | string | false | none | Your nearest city | | address_state | string | false | none | Your current state | | address_postal_code | string | false | none | Your current postcode | | address_country | string | false | none | Your current country | | organization_name | string | false | none | Your organisation name | | custom_1 | string | true | none | none | | custom_2 | string | false | none | none | | custom_3 | string | false | none | none | | custom_4 | string | false | none | none | | last_name | string | false | none | Your last name |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
| **contactId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **createNewContactRequest** | [**CreateNewContactRequest**](CreateNewContactRequest.md) |  | [optional]  |

### Return type

[**UpdateContact**](UpdateContact.md)

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

