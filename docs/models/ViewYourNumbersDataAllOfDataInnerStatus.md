# ClickSend.Model.ViewYourNumbersDataAllOfDataInnerStatus
The registration status of the number.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **int** | Numeric status code (0-5): - 0: Your number is ready to go. - 1: Your number is unregistered. You will not be able to send messages to certain countries. - 2: Your number registration is in progress. Email updates will follow. - 3: Action required on your number registration. Please resolve to start using it. - 4: You can send to all countries but may get restricted to some before full registration. - 5: Your number is registered and you can start using it immediately.  | [optional] 
**Label** | **string** | Status label identifier corresponding to the numeric value above, following the same order. | [optional] 
**Description** | **string** | Human readable description of the status. | [optional] 
**Name** | **string** | Display name for the status corresponding to the numeric value above, following the same order. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

