# ClickSend.Model.SmsReceipt

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimestampSend** | **int** | The time you sent the test message. It’s in the &lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;http://help.clicksend.com/what-is-a-unix-timestamp\&quot;&gt;Unix format&lt;/a&gt;. | [optional] 
**Timestamp** | **int** | The time you receive the test message receipt. It’s in the &lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;http://help.clicksend.com/what-is-a-unix-timestamp\&quot;&gt;Unix format&lt;/a&gt;. | [optional] 
**MessageId** | **string** | The generated ID of the message. This ID is typically used as a reference for &lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://www.clicksend.com/au/help/\&quot;&gt;customer support&lt;/a&gt; in case of any issues. | [optional] 
**StatusCode** | **int** | The status code sent from the &lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://en.wikipedia.org/wiki/SMS_gateway\&quot;&gt;SMS gateway&lt;/a&gt;. Visit &lt;a href&#x3D;\&quot;https://help.clicksend.com/article/8cc479qlbb-list-of-sms-gateway-error-codes\&quot;&gt;this page&lt;/a&gt; for more information. | [optional] 
**StatusText** | **string** | A message describing the status_code of the operation. Visit &lt;a href&#x3D;\&quot;https://help.clicksend.com/article/8cc479qlbb-list-of-sms-gateway-error-codes\&quot;&gt;this page&lt;/a&gt; for more information. | [optional] 
**ErrorCode** | **int** | The error code of the operation. Visit &lt;a href&#x3D;\&quot;https://help.clicksend.com/article/8cc479qlbb-list-of-sms-gateway-error-codes\&quot;&gt;this page&lt;/a&gt; for more information. If no error occurred, the value is **null**. | [optional] 
**ErrorText** | **string** | A message describing the _error_code_ of the operation. Visit &lt;a href&#x3D;\&quot;https://help.clicksend.com/article/8cc479qlbb-list-of-sms-gateway-error-codes\&quot;&gt;this page&lt;/a&gt; for more information. If no error occurred, the value is **null**. | [optional] 
**CustomString** | **string** | A note that was included with the outgoing SMS. If no note was included, the value is **null**. | [optional] 
**SubaccountId** | **int** | The sub-account of the user. A user can have multiple sub-accounts. | [optional] 
**MessageType** | **string** | The type of message (e.g. SMS, MMS, etc). | [optional] 
**Digits** | **int** | The numbers that the recipient pressed on their keypad during the call. A **null** value is returned if the recipient didn&#39;t provide any input.  &lt;div class&#x3D;\&quot;info-box\&quot;&gt;   &lt;h4&gt;&lt;i class&#x3D;\&quot;fas fa-info-circle\&quot;&gt;&lt;/i&gt; Note:&lt;/h4&gt;   &lt;p&gt;This parameter is only relevant to &lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;/messaging/voice-messaging/\&quot;&gt;&lt;strong&gt;Voice Messaging&lt;/strong&gt;&lt;/a&gt; receipts.&lt;/p&gt; &lt;/div&gt; | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

