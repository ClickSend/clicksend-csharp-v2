# ClickSend.Model.OwnNumber

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The unique identifier for the record. | [optional] 
**AccountId** | **Guid** | The unique identifier for the account. | [optional] 
**WorkspaceId** | **Guid** | The unique identifier for the workspace. | [optional] 
**UserId** | **Guid** | The unique identifier for the user. | [optional] 
**PhoneNumber** | **string** | The user&#39;s phone number. | [optional] 
**Country** | **string** | The country code of the phone number. | [optional] 
**Label** | **string** | A label for the phone number. | [optional] 
**Status** | **string** | The status of the phone number. | [optional] 
**VerifiedTimestamp** | **DateTime** | The timestamp when the phone number was verified. | [optional] 
**IsNearingExpiration** | **bool** | Indicates whether the phone number verification is nearing its expiration date: - **true:** The verification was completed more than 11 months ago and will expire soon. You should re-verify your phone number to maintain uninterrupted service. - **false:** The verification is still valid and not approaching expiration. | [optional] 
**CreatedTimestamp** | **DateTime** | The timestamp when the record was created. | [optional] 
**UpdatedTimestamp** | **DateTime** | The timestamp when the record was last updated. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

