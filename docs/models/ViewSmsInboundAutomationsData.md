# ClickSend.Model.ViewSmsInboundAutomationsData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Total** | **int** | The total number of items available for viewing. | [optional] 
**PerPage** | **int** | The number of items returned per page. This is specified in the limit parameter. You can have 100 items at maximum, and 15 at minimum. | [optional] 
**CurrentPage** | **int** | The current page number. | [optional] 
**LastPage** | **int** | The last page number. | [optional] 
**NextPageUrl** | **string** | A URL of the next page. It will return **null** if there’s no next page. | [optional] 
**PrevPageUrl** | **string** | A URL of the previous page. It will return **null** if there’s no previous page. | [optional] 
**From** | **int** | The number of the first result in the current page. | [optional] 
**To** | **int** | The number of the last result in the current page. | [optional] 
**FirstPageUrl** | **string** | The URL of the first page of records. | [optional] 
**LastPageUrl** | **string** | The URL of the last page of records. | [optional] 
**Path** | **string** | The base URL path used to build pagination links. | [optional] 
**Links** | [**List&lt;ViewListsDataLinksInner&gt;**](ViewListsDataLinksInner.md) | The list of pagination links. | [optional] 
**Data** | [**List&lt;SmsInboundRule&gt;**](SmsInboundRule.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

