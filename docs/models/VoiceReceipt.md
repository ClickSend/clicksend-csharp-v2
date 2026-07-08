# ClickSend.Model.VoiceReceipt

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimestampSend** | **string** | Timestamp of the original send request in UNIX format. e.g 1439173980 | [optional] 
**Timestamp** | **string** | Timestamp of delivery report in UNIX format. e.g 1439173981 | [optional] 
**MessageId** | **string** | Message ID, returned when originally sending the message. | [optional] 
**StatusCode** | **string** | Status code. Refer to &#39;Voice Delivery Status Codes&#39; in docs. | [optional] 
**StatusText** | **string** | Status text. | [optional] 
**ErrorCode** | **string** | Error code. | [optional] 
**ErrorText** | **string** | Error text. | [optional] 
**CustomString** | **string** | A custom string used when sending the original message. | [optional] 
**MessageType** | **string** | voice (constant). | [optional] 
**Digits** | **string** | Numbers the recipient pressed on their keypad during the call. A blank string will be used if they didn&#39;t provide any input. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

