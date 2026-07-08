# ClickSend.Api.InternationalMessagingApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AgreeToRulesAndRegulation**](InternationalMessagingApi.md#agreetorulesandregulation) | **POST** /v3/user-countries/agree | Agree to rules and regulation |
| [**GetCountriesForGlobalSending**](InternationalMessagingApi.md#getcountriesforglobalsending) | **GET** /v3/user-countries | Get Countries for Global Sending |
| [**ListCountries**](InternationalMessagingApi.md#listcountries) | **GET** /v3/country-list | International Messaging |
| [**SelectCountriesForGlobalSending**](InternationalMessagingApi.md#selectcountriesforglobalsending) | **POST** /v3/user-countries | Select Countries for Global Sending |
| [**Timezones**](InternationalMessagingApi.md#timezones) | **GET** /v3/timezones | Timezones |
| [**ViewCountries**](InternationalMessagingApi.md#viewcountries) | **GET** /v3/countries | View Countries |

<a id="agreetorulesandregulation"></a>
# **AgreeToRulesAndRegulation**
> AgreeToRulesAndRegulation AgreeToRulesAndRegulation ()

Agree to rules and regulation

_Update Country Rule_  To agree on rules and regulations of selected countries and confirm selection.  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | country_list_ids | number | true | none | Country list ID's |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters
This endpoint does not need any parameter.
### Return type

[**AgreeToRulesAndRegulation**](AgreeToRulesAndRegulation.md)

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

<a id="getcountriesforglobalsending"></a>
# **GetCountriesForGlobalSending**
> GetCountriesForGlobalSending GetCountriesForGlobalSending ()

Get Countries for Global Sending

_Get Countries for global sending_  Get the list of selected countries.  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters
This endpoint does not need any parameter.
### Return type

[**GetCountriesForGlobalSending**](GetCountriesForGlobalSending.md)

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

<a id="listcountries"></a>
# **ListCountries**
> ListCountries ListCountries ()

International Messaging

_List of countries_  List of countries with IDs that can be used in selecting countries for Global sending.  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters
This endpoint does not need any parameter.
### Return type

[**ListCountries**](ListCountries.md)

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

<a id="selectcountriesforglobalsending"></a>
# **SelectCountriesForGlobalSending**
> SelectCountriesForGlobalSending SelectCountriesForGlobalSending (SelectCountriesForGlobalSendingRequest selectCountriesForGlobalSendingRequest = null)

Select Countries for Global Sending

_Select Countries_  Use this endpoint to select countries that you intend to send sms / mms to. To remove / unselect a country, just remove the country id from the array in the payload.  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | country_list_ids | number | true | none | Country list ID's |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **selectCountriesForGlobalSendingRequest** | [**SelectCountriesForGlobalSendingRequest**](SelectCountriesForGlobalSendingRequest.md) |  | [optional]  |

### Return type

[**SelectCountriesForGlobalSending**](SelectCountriesForGlobalSending.md)

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

<a id="timezones"></a>
# **Timezones**
> Timezones Timezones (string contentType = null)

Timezones

_Get supported list of timezones._  Get supported list of timezones.  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | Page number | | limit | query | integer(int32) | false | Number of records per page |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**Timezones**](Timezones.md)

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

<a id="viewcountries"></a>
# **ViewCountries**
> ViewCountries ViewCountries ()

View Countries

_Get all country codes_  Get all countries   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #6BBD5B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint does not require authentication</span>  </div>


### Parameters
This endpoint does not need any parameter.
### Return type

[**ViewCountries**](ViewCountries.md)

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

