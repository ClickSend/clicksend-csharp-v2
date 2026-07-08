# ClickSend.Model.TransactionalEmail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **int** | The ID of the user. | [optional] 
**SubaccountId** | **int** | The ID of the subaccount. | [optional] 
**FromEmailAddressId** | **int** | The ID of the from email address. | [optional] 
**FromName** | **string** | The name of the sender. | [optional] 
**To** | [**List&lt;SendEmailRequestToInner&gt;**](SendEmailRequestToInner.md) |  | [optional] 
**Cc** | [**List&lt;SendEmailRequestToInner&gt;**](SendEmailRequestToInner.md) |  | [optional] 
**Bcc** | [**List&lt;SendEmailRequestToInner&gt;**](SendEmailRequestToInner.md) |  | [optional] 
**Subject** | **string** | The subject of the email. | [optional] 
**Body** | **string** | The HTML body of the email. | [optional] 
**BodyPlainText** | **string** | The plain text body of the email. | [optional] 
**Schedule** | **int** | The timestamp indicating the scheduled time of the email. | [optional] 
**MessageId** | **string** | The ID of the email message. | [optional] 
**Status** | **string** | The status of the email. | [optional] 
**StatusText** | **string** | The text description of the email status. | [optional] 
**SoftBounceCount** | **int** | The count of soft bounces. | [optional] 
**HardBounceCount** | **int** | The count of hard bounces. | [optional] 
**Price** | **string** | The price of the email. | [optional] 
**DateAdded** | **int** | The timestamp indicating when the email was added. | [optional] 
**CustomString** | **string** | A custom string. | [optional] 
**Attachments** | [**List&lt;Attachment&gt;**](Attachment.md) |  | [optional] 
**Currency** | [**Currency**](Currency.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

