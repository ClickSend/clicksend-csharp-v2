# ClickSend.Model.GetTrackingDataInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OpenCount** | **decimal** | Number of times the short URL was opened | [optional] 
**DateOpened** | **decimal** | Date in unix seconds when the short URL was first opened. Null if the short URL was never opened. | [optional] 
**UserGeoCountry** | **string** | Country where the recipient is located when the short URL was opened. Null if the short URL was never opened. | [optional] 
**UserGeoRegion** | **string** | Geographical region where the recipient is located when the short URL was opened. Null if the short URL was never opened. | [optional] 
**UserDevice** | **string** | Deviced used by the recipient to open the short URL. Null if the short URL was never opened. | [optional] 
**UserBrowser** | **string** | Browser used by the recipient to open the short URL. Null if the short URL was never opened. | [optional] 
**UserOs** | **string** | Opearating system used by the recipient to open the short URL. Null if the short URL was never opened. | [optional] 
**Contact** | [**GetTrackingDataInnerContact**](GetTrackingDataInnerContact.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

