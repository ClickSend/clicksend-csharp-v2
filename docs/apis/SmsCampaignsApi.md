# ClickSend.Api.SmsCampaignsApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CalculateSmsCampaignPrice**](SmsCampaignsApi.md#calculatesmscampaignprice) | **POST** /v3/sms-campaigns/price | Calculate SMS Campaign Price |
| [**CancelSmsCampaign**](SmsCampaignsApi.md#cancelsmscampaign) | **PUT** /v3/sms-campaigns/{sms_campaign_id}/cancel | Cancel SMS Campaign |
| [**SendSmsCampaign**](SmsCampaignsApi.md#sendsmscampaign) | **POST** /v3/sms-campaigns/send | Send SMS Campaign |
| [**UpdateSmsCampaign**](SmsCampaignsApi.md#updatesmscampaign) | **PUT** /v3/sms-campaigns/{sms_campaign_id} | Update SMS Campaign |
| [**ViewSmsCampaigns**](SmsCampaignsApi.md#viewsmscampaigns) | **GET** /v3/sms-campaigns | View SMS Campaigns |
| [**ViewSpecificSmsCampaign**](SmsCampaignsApi.md#viewspecificsmscampaign) | **GET** /v3/sms-campaigns/{sms_campaign_id} | View Specific SMS Campaign |

<a id="calculatesmscampaignprice"></a>
# **CalculateSmsCampaignPrice**
> CalculateSmsCampaignPrice CalculateSmsCampaignPrice (string contentType = null, CalculateSmsCampaignPriceRequest calculateSmsCampaignPriceRequest = null)

Calculate SMS Campaign Price

_Calculate price for sms campaign_  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | integer(int32) | true | none | Your list id. | | name | string | true | none | Your campaign name. | | body | string | true | none | Your campaign message. | | from | string | true | [yes](http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number) | Your sender id | | schedule | integer(int32) | false | none | Your schedule timestamp. |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **calculateSmsCampaignPriceRequest** | [**CalculateSmsCampaignPriceRequest**](CalculateSmsCampaignPriceRequest.md) |  | [optional]  |

### Return type

[**CalculateSmsCampaignPrice**](CalculateSmsCampaignPrice.md)

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

<a id="cancelsmscampaign"></a>
# **CancelSmsCampaign**
> CancelSmsCampaign CancelSmsCampaign (string smsCampaignId, string contentType = null)

Cancel SMS Campaign

Use this endpoint to cancel a scheduled SMS campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smsCampaignId** | **string** | ID of the scheduled SMS campaign to cancel. |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**CancelSmsCampaign**](CancelSmsCampaign.md)

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

<a id="sendsmscampaign"></a>
# **SendSmsCampaign**
> SendSmsCampaign SendSmsCampaign (string contentType = null, SendSmsCampaignRequest sendSmsCampaignRequest = null)

Send SMS Campaign

### _SMS Campaign Endpoint_  You can post to a list with `up to 20000 recipients` with each API call. You can only send to a single list containing up to 20,000 recipients. The response is far less detailed than the normal Send SMS endpoint. Use the [SMS Send](/#send-sms) endpoint if you would like to send to less than 1000 recipients at once. You are required to add an opt-out message to the end of your message body if you are sending marketing message. This can be in the form of asking users to reply STOP to opt-out or by including `StopMsg.me/xxxxx` which is a placeholder that will add a link that can be clicked to out-out. Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses. <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **sendSmsCampaignRequest** | [**SendSmsCampaignRequest**](SendSmsCampaignRequest.md) |  | [optional]  |

### Return type

[**SendSmsCampaign**](SendSmsCampaign.md)

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

<a id="updatesmscampaign"></a>
# **UpdateSmsCampaign**
> UpdateSmsCampaign UpdateSmsCampaign (string smsCampaignId, string contentType = null, CalculateSmsCampaignPriceRequest calculateSmsCampaignPriceRequest = null)

Update SMS Campaign

_Update sms campaign_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | sms_campaign_id | path | integer(int32) | true | ID of SMS campaign to update |  ### Properties  | Name | Type | Required | Restrictions | Description | | - -- | - -- | - -- | - -- | - -- | | list_id | integer(int32) | true | none | Your list id. | | name | string | true | none | Your campaign name. | | body | string | true | none | Your campaign message. | | from | string | true | [yes](http://help.clicksend.com/SMS/what-is-a-sender-id-or-sender-number) | Your sender id | | schedule | integer(int32) | false | none | Your schedule timestamp. |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smsCampaignId** | **string** |  |  |
| **contentType** | **string** |  | [optional]  |
| **calculateSmsCampaignPriceRequest** | [**CalculateSmsCampaignPriceRequest**](CalculateSmsCampaignPriceRequest.md) |  | [optional]  |

### Return type

[**UpdateSmsCampaign**](UpdateSmsCampaign.md)

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

<a id="viewsmscampaigns"></a>
# **ViewSmsCampaigns**
> ViewSmsCampaigns ViewSmsCampaigns (string contentType = null, int page = null, int limit = null, string q = null, string orderBy = null, int dateFrom = null, int dateTo = null)

View SMS Campaigns

Use this endpoint to view SMS campaigns.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **page** | **int** | The page number to retrieve. Use this parameter to navigate through the [pagination]/#pagination) results. The default value is 1. | [optional] [default to 1] |
| **limit** | **int** | The number of items to return per page. This parameter controls the size of each page of results. The default value is 15. | [optional] [default to 15] |
| **q** | **string** | Allows filtering of results based on your search criteria. The query should be in the format &#x60;field_name:value&#x60;.  1. **Field Name**: The field within the SMS campaign you want to filter by. You can use the following fields:      - sms_campaign_id,name,user_id,subaccount_id,list_id,from,body,schedule,status,date_added,custom_string,url_to_shorten,unsubscribe_link,source   2. **Value**: The text or keyword you&#39;re searching for within the specified field. If left empty after the colon, the filter will look for all templates with any value in the **Field Name**.  For example, if you are searching for a SMS campaign with the status of _Scheduled_, the final query would look like this:    - &#x60;q&#x3D;status:Scheduled&#x60;  &lt;div class&#x3D;\&quot;info-box\&quot;&gt;   &lt;h4&gt;&lt;i class&#x3D;\&quot;fas fa-info-circle\&quot;&gt;&lt;/i&gt; Note:&lt;/h4&gt;   &lt;p&gt;   Some characters have to be encoded. For example, if you are searching for SMS sent from the phone number +61437085284, your search query q would be:&lt;br/&gt;    &lt;ul&gt;     &lt;li&gt;q&#x3D;from:%2B61437085284&lt;/li&gt;   &lt;/ul&gt;    You can use the &lt;a href&#x3D;\&quot;https://www.urlencoder.org/\&quot; target&#x3D;\&quot;_blank\&quot;&gt;URL encoder&lt;/a&gt; to encode the text. If a character is not an alphanumeric character (A-Z, a-z, 0-9), it is typically either reserved or unsafe and should be encoded.      &lt;/p&gt; &lt;/div&gt; | [optional]  |
| **orderBy** | **string** | Specifies the field and order to sort the results by. The value is composed of the field name followed by a colon and the sort direction (_asc_ for ascending or _desc_ for descending).  The default sort order is by _date_added_ in ascending order. You can use the following fields:    - _name_: The name of the SMS campaign.   - _status_: The status of the SMS campaign.   - _schedule_: The schedule send date of the SMS campaign in the &lt;a href&#x3D;\&quot;http://help.clicksend.com/what-is-a-unix-timestamp\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Unix format&lt;/a&gt;.   - _from_: The sender of the SMS campaign.   - _date_added_: This is the date you created or updated the SMS campaign in the &lt;a href&#x3D;\&quot;http://help.clicksend.com/what-is-a-unix-timestamp\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Unix format&lt;/a&gt;.  For example, if you want to order by the most recently sent or scheduled SMS, you should sort by date in descending order. The query would look like this:    - &#x60;order_by&#x3D;schedule:desc&#x60;  &lt;div class&#x3D;\&quot;info-box\&quot;&gt;   &lt;h4&gt;&lt;i class&#x3D;\&quot;fas fa-info-circle\&quot;&gt;&lt;/i&gt; Note:&lt;/h4&gt;   &lt;p&gt;     You can also sort by these fields: &lt;br/&gt;     &lt;ul&gt;     &lt;li&gt;sms_campaign_id,user_id,subaccount_id,list_id,body,custom_string,url_to_shorten,unsubscribe_link, and source.&lt;/li&gt;   &lt;/ul&gt;   &lt;br/&gt;   But this is less common in practice.   &lt;/p&gt; &lt;/div&gt; | [optional]  |
| **dateFrom** | **int** | Start date to filter results. It should be in &lt;a href&#x3D;\&quot;http://help.clicksend.com/what-is-a-unix-timestamp\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Unix format&lt;/a&gt;. | [optional]  |
| **dateTo** | **int** | End date to filter results. It should be in &lt;a href&#x3D;\&quot;http://help.clicksend.com/what-is-a-unix-timestamp\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Unix format&lt;/a&gt;. | [optional]  |

### Return type

[**ViewSmsCampaigns**](ViewSmsCampaigns.md)

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

<a id="viewspecificsmscampaign"></a>
# **ViewSpecificSmsCampaign**
> ViewSpecificSmsCampaign ViewSpecificSmsCampaign (string smsCampaignId, string contentType = null)

View Specific SMS Campaign

Use this endpoint to view a specific SMS campaign.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smsCampaignId** | **string** | ID of SMS campaign to get |  |
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewSpecificSmsCampaign**](ViewSpecificSmsCampaign.md)

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

