# ClickSend.Model.GetTracking

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Total** | **decimal** | Total number of short URLs associated with the long URL ID | [optional] 
**PerPage** | **decimal** | The limit of tracking data per page | [optional] 
**CurrentPageSize** | **decimal** | The number of data in the current page | [optional] 
**PrevPageUrl** | **string** | Link to the previous page. This attribute will not be present if there is no previous page. | [optional] 
**NextPageUrl** | **string** | Link to the next page. This attribute will not be present if there is no next page. | [optional] 
**Data** | [**List&lt;GetTrackingDataInner&gt;**](GetTrackingDataInner.md) | Tracking data of the short URLs associated with the specified long URL ID. Note that only the data from the most recent click of the recipient (country, region, device, browser, and os) is recorded. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

