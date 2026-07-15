# ClickSend.Model.SmsCampaign
The parameters related to the SMS campaign.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SmsCampaignId** | **int** | The ID of the SMS campaign. | [optional] 
**Name** | **string** | The name of the SMS campaign. | [optional] 
**UserId** | **int** | The unique user ID of the sender. | [optional] 
**SubaccountId** | **int** | The sub-account of the user. A user can have multiple sub-accounts. | [optional] 
**ListId** | **int** | The _list_id_ of the contact list to which the SMS campaign was sent or will be sent to. | [optional] 
**From** | **string** | The sender of the message. This is also referred to as the **Sender ID**. If your **Sender ID** has a different country code to the recipient’s, it&#39;ll be replaced by a local number, except in &lt;a href&#x3D;\&quot;https://help.clicksend.com/category/mfdctha7f0-country-specific-features-and-restrictions\&quot; target&#x3D;\&quot;_blank\&quot;&gt;certain countries&lt;/a&gt;. If the sender number is blocked, a different number will replace it. | [optional] 
**Body** | **string** | The message body of the SMS campaign sent. | [optional] 
**Schedule** | **int** | The scheduled date of the message. It is in &lt;a href&#x3D;\&quot;http://help.clicksend.com/what-is-a-unix-timestamp\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Unix format&lt;/a&gt;. | [optional] 
**Status** | **string** | The status of the SMS. Available statuses are:    - _Approved_: The SMS campaign has been approved and is ready to be sent.   - _Cancelled_: The SMS campaign was scheduled but has been cancelled before sending.   - _Draft_: The SMS campaign is saved as a draft and has not been sent.   - _Failed_: The SMS campaign failed to send due to an issue.   - _Queued_: The SMS campaign is waiting to be sent.   - _Scheduled_: The SMS campaign is set to be sent at a later time.   - _Sending_: The SMS campaign is currently being sent.   - _Sent_: The SMS campaign has been sent, but this does not guarantee that all messages were successfully delivered.   - _WaitApproval_: The SMS campaign is awaiting approval from ClickSend, which may take a few minutes. | [optional] 
**DateAdded** | **int** | The date you created the SMS campaign. It is in &lt;a href&#x3D;\&quot;http://help.clicksend.com/what-is-a-unix-timestamp\&quot; target&#x3D;\&quot;_blank\&quot;&gt;Unix format&lt;/a&gt;. | [optional] 
**CustomString** | **string** | The custom note that was added when creating or updating the SMS campaign. | [optional] 
**UrlToShorten** | **string** | The original URL that had been shorten. It will return an **empty** value if the SMS campaign didn’t include any shortened URL. | [optional] 
**UnsubscribeLink** | **int** | Indicates whether an unsubscribe link has been included in the message. To provide the option to unsubscribe, you can add the literal &#x60;StopMsg.me/xxxxx&#x60; in the message body. This parameter specifies whether the link was added:    - **0**: The unsubscribe option was not provided.   - **1**: The unsubscribe option was provided. | [optional] 
**Source** | **string** | The source of the request. For example, the name of your application. It&#39;s used to identify messages sent from various applications. It will return a **null** value if the source was not specified in the SMS campaign. | [optional] 
**Senders** | [**List&lt;SmsCampaignSendersInner&gt;**](SmsCampaignSendersInner.md) | The specific sender IDs for each recipient country. It will return a **null** value if you did not specify the sender in the SMS campaign. | [optional] 
**TotalCount** | **int** | The total number of messages sent in the SMS campaign. | [optional] 
**ListName** | **string** | The name of the contact list of the SMS campaign. This is related of the _list_id_ parameter. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

