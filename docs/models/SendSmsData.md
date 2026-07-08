# ClickSend.Model.SendSmsData
The parameters related to messages.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalPrice** | **decimal** | The total price of sending the messages. Visit [this page](/#status-codes) for more information. | [optional] 
**TotalCount** | **int** | The total number of messages sent from the request. | [optional] 
**QueuedCount** | **int** | The messages will be put in a queue if it goes through the validation process. The validation process checks whether the **Sender ID** is registered or not. Some countries don&#39;t require messages to go through the validation process.  Messages scheduled to be sent right away will be sent immediately. If not, it will be queued. | [optional] 
**Messages** | [**List&lt;SmsSendSms&gt;**](SmsSendSms.md) | The parameters related to messages. | [optional] 
**Currency** | [**Currency**](Currency.md) |  | [optional] 
**BlockedCount** | **int** | The number of messages unable to be sent. This is often caused by:  - Receipient’s country not enabled for &lt;a href&#x3D;\&quot;https://help.clicksend.com/article/qdavyt16qs-global-sending\&quot;&gt;global sending&lt;/a&gt;.      - **Sender ID** resitriction.      - Number registration restrcition. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

