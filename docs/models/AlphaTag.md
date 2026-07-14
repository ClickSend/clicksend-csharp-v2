# ClickSend.Model.AlphaTag

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The unique identifier for the record. | [optional] 
**AccountId** | **string** | The unique identifier for the account. | [optional] 
**WorkspaceId** | **string** | The unique identifier for the workspace. | [optional] 
**UserId** | **string** | The unique identifier for the user. | [optional] 
**VarAlphaTag** | **string** | The alpha tag. | [optional] 
**Status** | **string** | The status of the record. | [optional] 
**Reason** | **string** | The reason for the status. | [optional] 
**Countries** | **List&lt;string&gt;** | List of country codes where the alpha tag is requested. If not provided, it means a global alpha tag. | [optional] 
**CreatedTimestamp** | **string** | The timestamp when the record was created. Usually ISO 8601 (e.g. \&quot;2021-05-11T01:00:00.123Z\&quot;), but returned as a plain string rather than a strict date-time since some older records don&#39;t include a UTC offset (e.g. \&quot;2024-01-10T10:55:26.818097\&quot;). | [optional] 
**UpdatedTimestamp** | **string** | The timestamp when the record was last updated. Usually ISO 8601 (e.g. \&quot;2021-05-11T01:05:00.123Z\&quot;), but returned as a plain string rather than a strict date-time since some older records don&#39;t include a UTC offset. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

