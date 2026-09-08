# ClickSend C# SDK

[![NuGet](https://img.shields.io/nuget/v/ClickSend.svg)](https://www.nuget.org/packages/ClickSend)
[![NuGet downloads](https://img.shields.io/nuget/dt/ClickSend.svg)](https://www.nuget.org/packages/ClickSend)
[![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![API: v3](https://img.shields.io/badge/ClickSend%20API-v3-brightgreen.svg)](https://developers.clicksend.com/docs/rest/v3/)

Official .NET client for the [ClickSend API](https://developers.clicksend.com/) — send SMS, MMS, voice and email messages, run SMS and MMS campaigns, manage numbers, contacts and subaccounts, and pull delivery receipts and reporting through a single authenticated HTTPS client.

This library is generated from ClickSend's official OpenAPI v3 specification and is maintained by ClickSend. It covers every endpoint of the [ClickSend REST API](https://developers.clicksend.com/docs/rest/v3/).

- 📚 **API reference:** https://developers.clicksend.com/docs/rest/v3/
- 🔑 **Dashboard & API credentials:** https://dashboard.clicksend.com
- 🗂 **Source & issues:** https://github.com/ClickSend/clicksend-csharp-v2
- 💬 **Support:** https://help.clicksend.com

## Features

- **Messaging** — SMS, MMS, voice / text-to-speech, transactional email, email-to-SMS
- **Campaigns** — SMS and MMS campaigns
- **Numbers & sender IDs** — dedicated numbers, own numbers, alpha tags, default senders
- **Contacts** — contact lists, contacts and the address book
- **Account & billing** — account details, transactions, subaccounts, referrals, reseller accounts
- **Delivery & reporting** — delivery receipts, inbound messages, statistics
- **Extras** — URL shortening, file uploads, number verification, international messaging
- **Typed models** for every request and response, with async methods throughout
- **HTTP Basic auth** with your ClickSend username and API key
- **Identifiable traffic** — requests are sent with a `ClickSend-SDK/<version>/csharp` `User-Agent` by default
- MIT licensed

## Requirements

- .NET 10.0 or newer

## Installation

```sh
dotnet add package ClickSend
```

## Authentication

Every API class authenticates with HTTP Basic auth using your ClickSend **username** and **API key**, both available from the [ClickSend Dashboard](https://dashboard.clicksend.com/#/account/subaccount). Supply them through environment variables rather than hard-coding them:

```sh
export CLICKSEND_USERNAME="your-username"
export CLICKSEND_API_KEY="your-api-key"
```

## Quickstart

```csharp
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ClickSend.Api;
using ClickSend.Client;
using ClickSend.Extensions;
using ClickSend.Model;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureApi((context, services, options) =>
    {
        BasicToken token = new(
            Environment.GetEnvironmentVariable("CLICKSEND_USERNAME"),
            Environment.GetEnvironmentVariable("CLICKSEND_API_KEY"));
        options.AddTokens(token);
    })
    .Build();

var smsApi = host.Services.GetRequiredService<ISmsApi>();

var sendSmsRequest = new SendSmsRequest(
    messages: new List<SendSmsRequestMessagesInner>
    {
        new(body: "Hello from ClickSend!", to: "+61411111111", source: "sdk")
    });

ISendSmsApiResponse response = await smsApi.SendSmsAsync(sendSmsRequest: sendSmsRequest);
SendSms? result = response.Ok();
```

## More Examples

### View account details

```csharp
var managementApi = host.Services.GetRequiredService<IManagementApi>();
IViewAccountDetailsApiResponse response = await managementApi.ViewAccountDetailsAsync();
ViewAccountDetails? account = response.Ok();
```

### Send an MMS

```csharp
var mmsApi = host.Services.GetRequiredService<IMmsApi>();

var sendMmsRequest = new SendMmsRequest(
    mediaFile: "https://clicksend.com/logo.png",
    messages: new List<SendMmsRequestMessagesInner>
    {
        new(to: "+61411111111", from: "sdk", subject: "Hello", body: "Hello from ClickSend!", source: "sdk")
    });

ISendMmsApiResponse response = await mmsApi.SendMmsAsync(sendMmsRequest: sendMmsRequest);
SendMms? result = response.Ok();
```

## Configuration

The base URL defaults to `https://rest.clicksend.com`. Override it, along with the `HttpClient` and its
handlers, from the `ConfigureApi` builder:

```csharp
.ConfigureApi((context, services, options) =>
{
    options.AddTokens(new BasicToken(username, apiKey));
})
.ConfigureHttpClients((context, services, builder) =>
{
    builder.ConfigureHttpClient(client =>
    {
        client.BaseAddress = new Uri("https://rest.clicksend.com");
        client.Timeout = TimeSpan.FromSeconds(30);
    });
});
```

## Error Handling

Call `response.Ok()` for the deserialized success payload, or inspect the response for failures:

```csharp
ISendSmsApiResponse response = await smsApi.SendSmsAsync(sendSmsRequest: sendSmsRequest);

if (response.IsSuccessStatusCode)
{
    SendSms? result = response.Ok();
}
else
{
    // response.StatusCode  — HTTP status code
    // response.RawContent  — raw error payload from the API
}
```

## Documentation

- Full REST API reference: https://developers.clicksend.com/docs/rest/v3/
- Per-endpoint SDK docs: the [`docs/`](docs) directory in this repository
- Source code: https://github.com/ClickSend/clicksend-csharp-v2

## Versioning

This package follows [semantic versioning](https://semver.org/). Breaking changes are released as major versions.

## Support

- Help Centre: https://help.clicksend.com
- Contact support: https://clicksend.com/contact
- SDK bugs and feature requests: https://github.com/ClickSend/clicksend-csharp-v2/issues

## License

Released under the [MIT License](https://opensource.org/licenses/MIT).

---

**Keywords:** clicksend, sms, sms api, send sms, bulk sms, text message, texting, mms, mms api, voice, voice call, text to speech, tts, ivr, email to sms, sms campaign, mms campaign, url shortening, number verification, messaging, notifications, otp, 2fa, two factor authentication, transactional sms, marketing sms, appointment reminders, alerts, csharp, dotnet, netstandard, rest api, clicksend sdk
