// Post-generation patch (see .circleci/config.yml, "Generate C# SDK" step).
//
// The OpenAPI spec sets `default: sdk` on the `source` field of SMS/MMS/Voice
// send-message bodies, but the csharp generator only reflects that in the XML
// doc comment — the actual constructor parameter defaults to an unset Option<T>,
// so `source` is simply omitted from the request unless the caller sets it.
// openapi-generator's csharp templates emit an empty `partial void FormatSendX(...)`
// hook right before each request is serialized specifically for this kind of
// customization, so this file implements those hooks instead of patching the
// generated model/API sources directly.

#nullable enable

using ClickSend.Client;
using ClickSend.Model;

namespace ClickSend.Api
{
    public sealed partial class SmsApi
    {
        partial void FormatSendSms(ref Option<string> contentType, Option<SendSmsRequest> sendSmsRequest)
        {
            if (!sendSmsRequest.IsSet || sendSmsRequest.Value?.Messages == null) return;
            foreach (var message in sendSmsRequest.Value.Messages)
            {
                if (!message.SourceOption.IsSet)
                    message.Source = "sdk-csharp";
            }
        }
    }

    public sealed partial class MmsApi
    {
        partial void FormatSendMms(ref Option<string> contentType, Option<SendMmsRequest> sendMmsRequest)
        {
            if (!sendMmsRequest.IsSet || sendMmsRequest.Value?.Messages == null) return;
            foreach (var message in sendMmsRequest.Value.Messages)
            {
                if (!message.SourceOption.IsSet)
                    message.Source = "sdk-csharp";
            }
        }
    }

    public sealed partial class VoiceMessagingApi
    {
        partial void FormatSendVoiceMessage(ref Option<string> contentType, Option<SendVoiceMessageRequest> sendVoiceMessageRequest)
        {
            if (!sendVoiceMessageRequest.IsSet || sendVoiceMessageRequest.Value?.Messages == null) return;
            foreach (var message in sendVoiceMessageRequest.Value.Messages)
            {
                if (!message.SourceOption.IsSet)
                    message.Source = "sdk-csharp";
            }
        }
    }
}
