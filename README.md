# ClickSend C# SDK

Official .NET client for the [ClickSend API](https://developers.clicksend.com/) — send and manage SMS, MMS, email, voice, fax, letters, postcards, and more.

## Installation

```sh
dotnet add package ClickSend
```

## Getting Started

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

## Authentication

The API uses HTTP Basic authentication — your ClickSend **username** and **API key** (available from the [ClickSend Dashboard](https://dashboard.clicksend.com/#/account/subaccount)), supplied via `BasicToken`.

## Documentation

Full API reference: https://developers.clicksend.com/docs/rest/v3/

## Support

Need help? Contact [ClickSend Support](https://clicksend.com/contact) or visit the [Help Centre](https://help.clicksend.com/).