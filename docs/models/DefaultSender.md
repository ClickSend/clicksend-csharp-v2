# ClickSend.Model.DefaultSender

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | ID of the default sender. | 
**UserId** | **int** | User ID from the version 3 system. | 
**SubaccountId** | **int** | Subaccount ID from version 3. | 
**CountryCode** | **string** | ISO 3166-1 alpha-2 formatted country code. | 
**ProductType** | **string** | Type of product for which the setting is applied. | 
**DefaultSenderStrategies** | [**List&lt;DefaultSenderDefaultSenderStrategiesInner&gt;**](DefaultSenderDefaultSenderStrategiesInner.md) | Default sender strategies. Must contain 1 or more objects. | 
**Status** | **string** | Overall status of the default sender. | 
**CreatedTimestamp** | **string** | Timestamp of when the default sender was created. Must be in ISO 8601 format. | 
**UpdatedTimestamp** | **string** | Timestamp of the last update to the default sender. Must be in ISO 8601 format. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

