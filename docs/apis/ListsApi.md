# ClickSend.Api.ListsApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CopyContactToList**](ListsApi.md#copycontacttolist) | **PUT** /v3/lists/{from_list_id}/contacts/{contact_id}/copy/{to_list_id} | Copy Contact to List |
| [**CreateList**](ListsApi.md#createlist) | **POST** /v3/lists | Create List |
| [**CreateNewContact**](ListsApi.md#createnewcontact) | **POST** /v3/lists/{list_id}/contacts | Create New Contact |
| [**DeleteList**](ListsApi.md#deletelist) | **DELETE** /v3/lists/{list_id} | Delete List |
| [**ImportContacts**](ListsApi.md#importcontacts) | **POST** /v3/lists/{list_id}/import | Import Contacts |
| [**RemoveDuplicateContacts**](ListsApi.md#removeduplicatecontacts) | **PUT** /v3/lists/{list_id}/remove-duplicates/ | Remove Duplicate Contacts |
| [**RemoveOptedOutContacts**](ListsApi.md#removeoptedoutcontacts) | **PUT** /v3/lists/{list_id}/remove-opted-out-contacts/{opt_out_list_id} | Remove Opted Out Contacts |
| [**TransferContactToList**](ListsApi.md#transfercontacttolist) | **PUT** /v3/lists/{from_list_id}/contacts/{contact_id}/transfer/{to_list_id} | Transfer Contact to List |
| [**UpdateList**](ListsApi.md#updatelist) | **PUT** /v3/lists/{list_id} | Update List |
| [**ViewContactLists**](ListsApi.md#viewcontactlists) | **GET** /v3/search/contacts-lists | View Contact Lists |
| [**ViewListContacts**](ListsApi.md#viewlistcontacts) | **GET** /v3/lists/{list_id}/contacts | View List Contacts |
| [**ViewLists**](ListsApi.md#viewlists) | **GET** /v3/lists | View Lists |
| [**ViewSpecificList**](ListsApi.md#viewspecificlist) | **GET** /v3/lists/{list_id} | View Specific List |

<a id="copycontacttolist"></a>
# **CopyContactToList**
> CopyContactToList CopyContactToList (string fromListId, string contactId, string toListId, string contentType = null, Object body = null)

Copy Contact to List

_Copy contact to another list_  Copy contact to another list  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | from_list_id | path | integer(int32) | true | List ID for list that contains contact. | | contact_id | path | integer(int32) | true | Contact ID | | to_list_id | path | integer(int32) | true | List ID for list you want to copy contact to. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromListId** | **string** |  |  |
| **contactId** | **string** |  |  |
| **toListId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **body** | **Object** |  | [optional]  |

### Return type

[**CopyContactToList**](CopyContactToList.md)

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

<a id="createlist"></a>
# **CreateList**
> CreateList CreateList (string contentType = null, CreateListRequest createListRequest = null)

Create List

_Create new contact list_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | list_name | body | string | true | Your contact list name |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **createListRequest** | [**CreateListRequest**](CreateListRequest.md) |  | [optional]  |

### Return type

[**CreateList**](CreateList.md)

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

<a id="createnewcontact"></a>
# **CreateNewContact**
> CreateNewContact CreateNewContact (string listId, string contentType = null, CreateNewContactRequest createNewContactRequest = null)

Create New Contact

_Create new contact_  ### parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | path | integer(int32) | true | List id | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |   ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | phone_number | string | true | none | Your phone number in\\_[E.164](https://en.wikipedia.org/wiki/E.164)\\_format. Must be provided if no fax number or email. | | email | string | false | none | Your email. Must be provided if no phone number or fax number. | | fax_number | string | false | none | Your fax number. Must be provided if no phone number or email. | | first_name | string | false | none | Your first name. | | address_line_1 | string | false | none | Your street address | | address_line_2 | string | false | none | none | | address_city | string | false | none | Your nearest city | | address_state | string | false | none | Your current state | | address_postal_code | string | false | none | Your current postcode | | address_country | string | false | none | Your current country | | organization_name | string | false | none | Your organisation name | | custom_1 | string | true | none | none | | custom_2 | string | false | none | none | | custom_3 | string | false | none | none | | custom_4 | string | false | none | none | | last_name | string | false | none | Your last name |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **createNewContactRequest** | [**CreateNewContactRequest**](CreateNewContactRequest.md) |  | [optional]  |

### Return type

[**CreateNewContact**](CreateNewContact.md)

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

<a id="deletelist"></a>
# **DeleteList**
> DeleteList DeleteList (string listId, string contentType = null)

Delete List

_ListsByListIdDelete_  Delete a specific contact list  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | path | integer(int32) | true | List ID |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**DeleteList**](DeleteList.md)

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

<a id="importcontacts"></a>
# **ImportContacts**
> ImportContacts ImportContacts (string listId, string contentType = null, ImportContactsRequest importContactsRequest = null)

Import Contacts

_Import contacts to list_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | path | integer(int32) | true | Your contact list id you want to access. |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | file_url | string | true | none | URL of file to process | | field_order | \\[string\\] | true | none | Order of fields in file |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **importContactsRequest** | [**ImportContactsRequest**](ImportContactsRequest.md) |  | [optional]  |

### Return type

[**ImportContacts**](ImportContacts.md)

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

<a id="removeduplicatecontacts"></a>
# **RemoveDuplicateContacts**
> RemoveDuplicateContacts RemoveDuplicateContacts (string listId, string contentType = null, RemoveDuplicateContactsRequest removeDuplicateContactsRequest = null)

Remove Duplicate Contacts

_Remove duplicate contacts_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | path | integer(int32) | true | Your list id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **removeDuplicateContactsRequest** | [**RemoveDuplicateContactsRequest**](RemoveDuplicateContactsRequest.md) |  | [optional]  |

### Return type

[**RemoveDuplicateContacts**](RemoveDuplicateContacts.md)

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

<a id="removeoptedoutcontacts"></a>
# **RemoveOptedOutContacts**
> RemoveOptedOutContacts RemoveOptedOutContacts (string listId, string optOutListId, string contentType = null, Object body = null)

Remove Opted Out Contacts

_Remove all opted out contacts_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | path | integer(int32) | true | Your list id | | opt_out_list_id | path | integer(int32) | true | Your opt out list id |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
| **optOutListId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **body** | **Object** |  | [optional]  |

### Return type

[**RemoveOptedOutContacts**](RemoveOptedOutContacts.md)

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

<a id="transfercontacttolist"></a>
# **TransferContactToList**
> TransferContactToList TransferContactToList (string fromListId, string contactId, string toListId, string contentType = null, Object body = null)

Transfer Contact to List

_Transfer contact to another list_  Transfer contact to another list  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | from_list_id | path | integer(int32) | true | List ID for list that contains contact. | | contact_id | path | integer(int32) | true | Contact ID | | to_list_id | path | integer(int32) | true | List ID for list you want to transfer contact to. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fromListId** | **string** |  |  |
| **contactId** | **string** |  |  |
| **toListId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **body** | **Object** |  | [optional]  |

### Return type

[**TransferContactToList**](TransferContactToList.md)

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

<a id="updatelist"></a>
# **UpdateList**
> UpdateList UpdateList (string listId, string contentType = null, CreateListRequest createListRequest = null)

Update List

_Update specific contact list_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | path | integer(int32) | true | Your list id | | list_name | body | string | true | Your new list name |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **createListRequest** | [**CreateListRequest**](CreateListRequest.md) |  | [optional]  |

### Return type

[**UpdateList**](UpdateList.md)

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

<a id="viewcontactlists"></a>
# **ViewContactLists**
> void ViewContactLists (string q = null)

View Contact Lists

_Get list of searched contact list_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | q | query | string | true | Your keyword or query. | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  This endpoint requires authentication, [more info...](/#authentication)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **q** | **string** |  | [optional]  |

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

<a id="viewlistcontacts"></a>
# **ViewListContacts**
> ViewListContacts ViewListContacts (string listId, string contentType = null)

View List Contacts

_Get all contacts in a list_  ### parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | path | integer(int32) | true | Contact list ID | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) | | updated_after | query | integer(int32) | false | Get all contacts updated after a given timestamp. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewListContacts**](ViewListContacts.md)

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

<a id="viewlists"></a>
# **ViewLists**
> ViewLists ViewLists (string contentType = null)

View Lists

_Get all contact lists_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewLists**](ViewLists.md)

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

<a id="viewspecificlist"></a>
# **ViewSpecificList**
> ViewSpecificList ViewSpecificList (string listId, string contentType = null)

View Specific List

_Get specific contact list_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | path | integer(int32) | true | List ID |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **listId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewSpecificList**](ViewSpecificList.md)

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

