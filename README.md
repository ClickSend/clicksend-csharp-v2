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
var response = await smsApi.SmsSendPostAsync(/* smsMessageCollection */);
```

## Authentication

The API uses HTTP Basic authentication — your ClickSend **username** and **API key** (available from the [ClickSend Dashboard](https://dashboard.clicksend.com/#/account/subaccount)), supplied via `BasicToken`.

## Documentation

Full API reference: https://developers.clicksend.com/docs/rest/v3/

## Support

Need help? Contact [ClickSend Support](https://clicksend.com/contact) or visit the [Help Centre](https://help.clicksend.com/).
