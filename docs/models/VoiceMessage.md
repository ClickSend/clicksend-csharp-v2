# ClickSend.Model.VoiceMessage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **string** | The date, if applicable. May be null; see also &#x60;date_added&#x60;. | [optional] 
**DateAdded** | **int** | The Unix timestamp when the message was added. | [optional] 
**ListId** | **string** | The ID of the list associated with the message, if applicable. | [optional] 
**To** | **string** | The recipient&#39;s phone number. | [optional] 
**ToType** | **string** | The type of recipient. | [optional] 
**Body** | **string** | The body of the message. | [optional] 
**From** | **string** | The sender&#39;s phone number. | [optional] 
**Lang** | **string** | The language of the message. | [optional] 
**Voice** | **string** | The voice of the message. | [optional] 
**Schedule** | [**VoiceMessageSchedule**](VoiceMessageSchedule.md) |  | [optional] 
**MessageId** | **string** | The ID of the message. | [optional] 
**MessageParts** | **int** | The number of parts in the message. | [optional] 
**MessagePrice** | **string** | The price of the message. | [optional] 
**CustomString** | **string** | The custom string of the message. | [optional] 
**UserId** | **decimal** | The ID of the user. | [optional] 
**SubaccountId** | **decimal** | The ID of the subaccount. | [optional] 
**Country** | **string** | The country code of the message. | [optional] 
**RequireInput** | **decimal** | The require input of the message. | [optional] 
**MachineDetection** | **decimal** | The machine detection of the message. | [optional] 
**MachineDetected** | **decimal** | Flag indicating if an answering machine was detected. | [optional] 
**Digits** | **string** | The digits entered by the recipient, if any input was collected. | [optional] 
**Carrier** | **string** | The carrier of the recipient&#39;s phone number. | [optional] 
**StatusCode** | **string** | The status code of the message. | [optional] 
**StatusText** | **string** | A human-readable description of the status. | [optional] 
**Status** | **string** | The status of the message. | [optional] 
**ApiUsername** | **string** | The API username associated with the message. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

