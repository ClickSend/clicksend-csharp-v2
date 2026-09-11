# Migration Guide: IO.ClickSend (legacy) → ClickSend (v2)

This guide helps you migrate from the legacy ClickSend C# SDK (NuGet package `IO.ClickSend`, root namespace `IO.ClickSend.*`) to the current v2 SDK (NuGet package `ClickSend`, root namespace `ClickSend.*`). Of all seven ClickSend SDK languages, **C# has the largest architectural rewrite**: the legacy SDK is RestSharp-based, targets .NET Framework 4.8, and hands you a `Configuration`/`ApiClient`/`*Api` object graph you build by hand; v2 uses a "generichost" architecture, targets **.NET 10.0**, and is dependency-injection-first — there is no `Configuration` or `ApiClient` class at all. Read this guide fully, especially §3, §4 and §9, before touching a production integration.

## Contents

1. [Why this migration isn't a drop-in replacement](#1-why-this-migration-isnt-a-drop-in-replacement)
2. [Installation & imports](#2-installation--imports)
3. [Authentication & client setup](#3-authentication--client-setup)
4. [Base path / URL changes](#4-base-path--url-changes)
5. [Method naming convention change](#5-method-naming-convention-change)
6. [Request payloads: `*Request` models replace reusable domain models](#6-request-payloads-request-models-replace-reusable-domain-models)
7. [Response payloads are now properly typed](#7-response-payloads-are-now-properly-typed)
8. [Error handling changes](#8-error-handling-changes)
9. [Removed: synchronous calls — every operation is now async-only](#9-removed-synchronous-calls--every-operation-is-now-async-only)
10. [Class-by-class mapping (all 37 legacy classes)](#10-class-by-class-mapping-all-37-legacy-classes)
11. [Side-by-side examples for common operations](#11-side-by-side-examples-for-common-operations)
12. [The Voice naming trap (read this before touching voice code)](#12-the-voice-naming-trap-read-this-before-touching-voice-code)
13. [Endpoints/methods removed in v2](#13-endpointsmethods-removed-in-v2)
14. [Brand-new resources and methods in v2](#14-brand-new-resources-and-methods-in-v2)
15. [Step-by-step migration checklist](#15-step-by-step-migration-checklist)

## 1. Why this migration isn't a drop-in replacement

The legacy SDK grew organically against ClickSend's v3 API: one API class per rough "concept" (five separate email classes — `TransactionalEmailApi`, `EmailMarketingApi`, `UserEmailTemplatesApi`, `MasterEmailTemplatesApi`, `EmailDeliveryReceiptRulesApi`), method names followed a `Resource`+HTTP-verb PascalCase pattern (`SmsSendPost`, `SmsHistoryGet`), request bodies were broad reusable domain models (`SmsMessage`, `SmsMessageCollection`), every response was typed `string` and never deserialized, and — importantly — **every single operation ships both a synchronous method and a separately-generated async method** (`SmsSendPost` *and* `SmsSendPostAsync`, plus `...WithHttpInfo` variants of each, so four methods per endpoint). The HTTP layer is RestSharp, JSON is Newtonsoft.Json, and the project targets .NET Framework 4.8 using an old-style (non-SDK) `.csproj`.

The v2 SDK is generated fresh from ClickSend's current OpenAPI v3 specification using a "generichost" C# architecture, which:

- Groups methods into **one class per resource/tag (26 classes instead of 37)** — several legacy classes merged, one split, and Fax, Letters, Postcards and address-detection were dropped entirely (see [§13](#13-endpointsmethods-removed-in-v2)).
- Names methods after the endpoint's **operationId** in PascalCase with an `Async` suffix (`SendSmsAsync`, `ViewSmsHistoryAsync`) instead of `Resource`+verb.
- Has **no `Configuration`/`ApiClient` object pair at all.** API classes (`SmsApi`, `EmailApi`, ...) are registered into .NET's dependency-injection container and resolved by interface (`ISmsApi`, `IEmailApi`, ...) — see [§3](#3-authentication--client-setup).
- Ships **async-only.** There is no synchronous method anywhere in v2; every operation is `Task<IXxxApiResponse> XxxAsync(..., CancellationToken cancellationToken = default)`, plus an `XxxOrDefaultAsync` sibling (see [§9](#9-removed-synchronous-calls--every-operation-is-now-async-only)).
- Wraps every request body in a dedicated, single-purpose `*Request` model, using a `ClickSend.Client.Option<T>` wrapper on optional fields/parameters to distinguish "not sent" from "sent as null/default" (see [§6](#6-request-payloads-request-models-replace-reusable-domain-models)).
- Returns a typed, per-operation response object from every call (`ISendSmsApiResponse`, ...) instead of a raw `string` — and, critically, **does not throw an exception for non-2xx HTTP responses**; you inspect the response instead (see [§7](#7-response-payloads-are-now-properly-typed) and [§8](#8-error-handling-changes)).
- Uses `System.Text.Json` instead of Newtonsoft.Json, has `#nullable enable` throughout, and targets **.NET 10.0** instead of .NET Framework 4.8.
- Adds built-in `CancellationToken` support and optional Polly-based retry/timeout/circuit-breaker policies — neither existed in legacy.

None of this changes the underlying REST API — it's the same ClickSend v3 API — but it changes **every call site**, and the setup code changes completely.

## 2. Installation & imports

| | Legacy (`IO.ClickSend`) | v2 (`ClickSend`) |
|---|---|---|
| NuGet package ID | `IO.ClickSend` | `ClickSend` |
| Root namespace | `IO.ClickSend` (API/model classes live under the nested `IO.ClickSend.ClickSend.Api` / `IO.ClickSend.ClickSend.Model`) | `ClickSend` (API/model classes live directly under `ClickSend.Api` / `ClickSend.Model`) |
| Target framework | .NET Framework 4.8 (old-style `.csproj`, `packages.config`) | **.NET 10.0** (SDK-style `.csproj`) |
| Version at time of writing | Not pinned in source (`.nuspec` uses a `$version$` build placeholder) | `6.0.2` |
| HTTP stack | RestSharp 112.1.0 | `System.Net.Http.HttpClient` via `Microsoft.Extensions.Http` |
| JSON library | Newtonsoft.Json 13.0.3 + JsonSubTypes | `System.Text.Json` (built in, no extra package) |
| DI / hosting | none | `Microsoft.Extensions.Hosting` + `Microsoft.Extensions.DependencyInjection` |
| Resilience | none (roll your own) | `Microsoft.Extensions.Http.Polly` (opt-in retry/timeout/circuit-breaker) |
| Nullability | not annotated | `#nullable enable` throughout |

```sh
# Legacy
Install-Package IO.ClickSend

# v2
dotnet add package ClickSend
```

The two packages have different package IDs and root namespaces, so **they can be installed side by side** during an incremental, file-by-file migration.

**Target framework.** Legacy targets .NET Framework 4.8. v2 targets .NET 10.0. If your project still targets .NET Framework, you need to move it to a current .NET target before adopting v2.

```csharp
// Legacy
using IO.ClickSend.Client;
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.ClickSend.Model;

// v2
using ClickSend.Client;
using ClickSend.Api;
using ClickSend.Model;
using ClickSend.Extensions;   // new — needed for ConfigureApi(...) / AddApi(...)
```

## 3. Authentication & client setup

This is the section with the biggest non-mechanical change in the entire migration. Legacy configures a single, global, **mutable static** `Configuration.Default` object and then `new`'s up API classes directly:

```csharp
// Legacy
using IO.ClickSend.ClickSend.Api;
using IO.ClickSend.Client;

Configuration.Default.Username = "YOUR_USERNAME";
Configuration.Default.Password = "YOUR_PASSWORD";

var smsApi = new SMSApi();

string result = smsApi.SmsSendPost(collection);
```

v2 has **no `Configuration` class and no `ApiClient` class.** Instead, API clients are registered into .NET's dependency-injection container through `ClickSend.Extensions`, and credentials are supplied as a `BasicToken`, not static fields:

```csharp
// v2
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using ClickSend.Api;
using ClickSend.Client;
using ClickSend.Extensions;

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

ISendSmsApiResponse response = await smsApi.SendSmsAsync(sendSmsRequest: request);
```

### What's actually going on under `ConfigureApi`

`ConfigureApi` is an `IHostBuilder` extension method (`ClickSend.Extensions.IHostBuilderExtensions.ConfigureApi`) whose callback receives `(HostBuilderContext context, IServiceCollection services, HostConfiguration options)`. Internally it:

1. Creates a `ClickSend.Client.HostConfiguration` wrapping your `IServiceCollection` (this also registers `System.Text.Json` converters for every model, and a per-API `...ApiEvents` singleton you can subscribe to for request/response/error hooks).
2. Runs your callback — this is where you call `options.AddTokens(...)`.
3. Calls `HostConfiguration.AddApiHttpClients()` **for you, automatically, if you didn't already call it** — this registers `services.AddHttpClient<IXxxApi, XxxApi>(...)` for every one of the 26 API interfaces.

If you're already inside an ASP.NET Core (or other) app with an existing `IServiceCollection`, use the equivalent `services.AddApi(options => { ... })` extension instead of building a standalone `IHostBuilder`:

```csharp
// Inside an existing ASP.NET Core Program.cs
builder.Services.AddApi(options =>
{
    options.AddTokens(new BasicToken(username, apiKey));
});
```

Either way, resolve API classes **by interface** via DI — `host.Services.GetRequiredService<ISmsApi>()` or constructor-inject `ISmsApi` into your own class. There is no `new SmsApi()` path in v2: the generated constructors take dependencies (an `HttpClient`, `IApiFactory`, `JsonSerializerOptions`, a `TokenProvider<BasicToken>`, an `...ApiEvents` singleton, an `ILoggerFactory`) that only the container wires up for you.

### Credentials: `BasicToken` instead of `Configuration.Default`

`BasicToken(username, password)` is a plain class in `ClickSend.Client`; `options.AddTokens(token)` registers it as a singleton `TokenContainer<BasicToken>`. There is **no more global mutable configuration object** — credentials are scoped to whichever host/service collection you register them against, which makes multi-account usage straightforward (register multiple tokens; the SDK round-robins and automatically backs a token off for a period after it receives a `429`).

### Overriding the base address, timeout, or headers

The way to customize the underlying `HttpClient` is to call `options.AddApiHttpClients(...)` **yourself**, inside the same `ConfigureApi`/`AddApi` callback, before the framework calls it for you with defaults:

```csharp
.ConfigureApi((context, services, options) =>
{
    options.AddTokens(new BasicToken(username, apiKey));

    options.AddApiHttpClients(
        client =>
        {
            client.BaseAddress = new Uri("https://rest.clicksend.com");
            client.Timeout = TimeSpan.FromSeconds(30);
            // if you set your own Action<HttpClient>, you are also
            // responsible for the User-Agent header — see below.
        },
        builder => builder.AddRetryPolicy(retries: 3));
})
```

> **Note on the SDK's own README.** The `ClickSend` package's `README.md` shows a separate `.ConfigureHttpClients((context, services, builder) => ...)` call chained after `.ConfigureApi(...)`. Grepping the actual generated source (`src/ClickSend/Extensions/*.cs`) for `ConfigureHttpClients` finds **no such extension method** in this build — the only supported way to customize the `HttpClient` is `HostConfiguration.AddApiHttpClients(Action<HttpClient> client, Action<IHttpClientBuilder> builder)`, called through the `options` parameter already available inside `ConfigureApi`, as shown above. Treat the README's `ConfigureHttpClients` snippet as inaccurate for this generated version and use `options.AddApiHttpClients(...)` instead.

**Default wiring, if you never call `AddApiHttpClients` yourself:** `HostConfiguration.AddApiHttpClients()` falls back to an internal default `Action<IServiceProvider, HttpClient>` that sets `client.BaseAddress = new Uri("https://rest.clicksend.com")` and adds a default `User-Agent: ClickSend-SDK/6.0.2/csharp` header via `TryAddWithoutValidation`. **This default is only used when you don't supply your own `Action<HttpClient>`.** If you call `options.AddApiHttpClients(client => { ... })` with your own delegate (e.g. to set a timeout), your delegate *replaces* the default entirely — you must set `BaseAddress` yourself, and if you want the `ClickSend-SDK/...` branding you must add the `User-Agent` header yourself too.

## 4. Base path / URL changes

| | Legacy | v2 |
|---|---|---|
| Default base URL | `https://rest.clicksend.com/v3` (`Configuration.BasePath`, set in the constructor) | `https://rest.clicksend.com` (`ClientUtils.BASE_ADDRESS`) |
| Per-method path | `/sms/send` (no version prefix — baked into the base path) | `/v3/sms/send` (the `/v3` prefix is part of each method's request path, built at call time) |
| Override | `Configuration.Default.BasePath = "..."` or `new Configuration { BasePath = "..." }` | `client.BaseAddress = new Uri("...")` inside `options.AddApiHttpClients(client => { ... })` (see [§3](#3-authentication--client-setup)) |

The final resolved URL is identical in both cases (`https://rest.clicksend.com/v3/sms/send`). This only matters if you've pointed the legacy SDK's `BasePath` at a proxy or mock server ending in `/v3` — remove that suffix when you move to v2, or you'll request `.../v3/v3/sms/send`.

## 5. Method naming convention change

Every method on every API class has been renamed. There's no shared prefix/suffix you can find-and-replace — the new names follow each endpoint's operationId (PascalCased, with an `Async` suffix), which reads like an English phrase, while the old ones followed `Resource`+HTTP-verb.

| Legacy | v2 |
|---|---|
| `SmsSendPost` | `SendSmsAsync` |
| `SmsHistoryGet` | `ViewSmsHistoryAsync` |
| `SmsHistoryExportGet` | `ExportSmsHistoryAsync` |
| `SmsTemplatesByTemplateIdDelete` | `DeleteSmsTemplateAsync` |
| `ListsContactsByListIdPost` | `CreateNewContactAsync` |
| `SubaccountsPost` | `CreateSubaccountAsync` |
| `VoiceLangGet` | `ViewVoiceLanguagesAsync` |
| `NumbersSearchByCountryGet` | `ViewAvailableNumbersAsync` |

**You cannot mechanically derive the new name from the old one.** Use the mapping tables in [§10](#10-class-by-class-mapping-all-37-legacy-classes)–[§11](#11-side-by-side-examples-for-common-operations), or resolve the relevant `IXxxApi` interface and use your editor's autocomplete on `Async` — the new names are descriptive enough that the right method is usually the first sensible match.

## 6. Request payloads: `*Request` models replace reusable domain models

Legacy methods took a broad, reusable domain model directly as the `body` parameter:

```csharp
// Legacy
var message = new SmsMessage(body: "Hello from ClickSend!", to: "+61411111111", source: "sdk");
var collection = new SmsMessageCollection(messages: new List<SmsMessage> { message });

string result = smsApi.SmsSendPost(collection);
```

v2 introduces **one dedicated `*Request` model per operation**, and every method takes named optional parameters — an `Option<string> contentType`, the request model itself, and a `CancellationToken`:

```csharp
// v2
var request = new SendSmsRequest(
    messages: new List<SendSmsRequestMessagesInner>
    {
        new(body: "Hello from ClickSend!", to: "+61411111111", source: "sdk")
    });

ISendSmsApiResponse response = await smsApi.SendSmsAsync(sendSmsRequest: request);
```

Practical implications:

- **The old domain-model class names mostly don't exist in v2.** `SmsMessage`, `SmsMessageCollection`, `Email`, `Voice`, `Contact`, `ContactList`, `Subaccount`, etc. are gone, replaced by per-operation request/response models. Nested list items get their own generated models too (e.g. `SendSmsRequestMessagesInner`, `SendMmsRequestMessagesInner`).
- **Always pass the payload as a named argument** (`sendSmsRequest: request`) — every method signature is `XxxAsync(Option<string> contentType = default, Option<TRequest> xxxRequest = default, CancellationToken cancellationToken = default)`, so a positional call risks landing your payload in the wrong parameter.

### `Option<T>`

`ClickSend.Client.Option<T>` is a small struct wrapping a value plus an internal "is this set?" flag, used everywhere a request field or method parameter is optional. An unset `Option<T>` is omitted from the request entirely; a set `Option<T>` (including one explicitly set to `null` or a default-looking value) is sent as-is — this distinguishes "caller didn't set this" from "caller explicitly set it." `Option<T>` implicitly converts to and from `T` in both directions, so in practice you just assign or pass a plain value (`source: "sdk"`) and it's wrapped automatically; you only interact with `Option<T>` explicitly if you need to leave a field unset versus sending an explicit value, or when reading a model's paired `XxxOption` property (e.g. `message.SourceOption.IsSet`).

**The `source` default is a real, verified example of this.** The OpenAPI spec marks `default: sdk` on the `source` field of SMS/MMS/voice message items, but the C# generator only reflects that in an XML doc comment — the actual constructor parameter defaults to an *unset* `Option<T>`, so `source` would simply be omitted from the request unless the caller sets it. ClickSend's build patches this via `Api/MessageSourceDefaults.cs`, which implements the generator's own empty `partial void FormatSendSms(...)` / `FormatSendMms(...)` / `FormatSendVoiceMessage(...)` hooks (emitted specifically for this kind of customization) to set `message.Source = "sdk-csharp"` on each message that didn't already set one, immediately before the request is serialized. This only fires through the SDK's own `SmsApi.SendSmsAsync`, `MmsApi.SendMmsAsync`, and `VoiceMessagingApi.SendVoiceMessageAsync` call paths.

### The sender field

`From` is a plain property name in **both** SDKs — `from` is only a contextual keyword in LINQ query syntax, not a reserved word, so it never needed escaping. Legacy's `SmsMessage.From` is a normal `string` property. v2's `SendSmsRequestMessagesInner.From` is a convenience property (`get`/`set`) backed by `FromOption` of type `Option<string?>`, following the same pattern as every other optional field on that model (`Source`/`SourceOption`, `FromEmail`/`FromEmailOption`, etc.). You can set it as a plain string either way; reach for the `...Option` property only if you need to check or force "unset."

## 7. Response payloads are now properly typed

Legacy responses were **always typed `string`** and never deserialized — you parsed the JSON yourself, knowing the shape out-of-band from the API docs.

```csharp
// Legacy — return value is a raw JSON string
string result = smsApi.SmsSendPost(collection);
```

v2 returns a typed, operation-specific response object (e.g. `ISendSmsApiResponse`) implementing a common `IApiResponse` (status code, headers, content headers, raw content, request timestamp, `IsSuccessStatusCode`) plus one or more status-specific accessor interfaces — most commonly `IOk<TType>`:

```csharp
// v2
ISendSmsApiResponse response = await smsApi.SendSmsAsync(sendSmsRequest: request);

bool httpOk = response.IsSuccessStatusCode;   // any 2xx
bool isOk = response.IsOk;                    // true specifically for 200
SendSms? result = response.Ok();              // typed model if IsOk, else null
bool got = response.TryOk(out SendSms? r);     // true + out-value if IsOk
System.Net.HttpStatusCode status = response.StatusCode;
string rawBody = response.RawContent;
```

`Ok()` deserializes only when the response's actual status code matches what that accessor represents — it returns `null` otherwise, it does **not** throw. If an operation's OpenAPI spec defines a typed shape for a specific error status, the generated response class also implements the matching interface (e.g. `IBadRequest<TType>` with its own `.BadRequest()` / `.TryBadRequest(out result)`), but `SendSmsAsync`'s response in this build only implements `IOk<SendSms?>` — for a non-200 response, check `.StatusCode` and `.RawContent` directly (see [§8](#8-error-handling-changes)).

## 8. Error handling changes

**This is the change most likely to bite you silently**, because the legacy and v2 error-handling *models* are fundamentally different, not just renamed.

Legacy genuinely throws `IO.ClickSend.Client.ApiException` on a non-2xx response — every generated method calls `ExceptionFactory` (`Configuration.DefaultExceptionFactory` by default) after the RestSharp call returns, and throws whatever it produces:

```csharp
// Legacy — IO.ClickSend.Client.ApiException
try
{
    string result = smsApi.SmsSendPost(collection);
}
catch (IO.ClickSend.Client.ApiException e)
{
    int statusCode = e.ErrorCode;        // int
    string message = e.Message;
    dynamic errorContent = e.ErrorContent;
}
```

v2 also ships a `ClickSend.Client.ApiException` class (`.ReasonPhrase`, `.StatusCode` as `HttpStatusCode`, `.RawContent`), and every generated method's XML doc comment claims `<exception cref="ApiException">Thrown when fails to make API call</exception>`. **That doc comment is stale boilerplate from the code-generator template.** Grepping the entire generated `Api/` and `Client/` source for `throw new ApiException` / `new ApiException(` finds **zero occurrences** — nowhere in this build does a v2 API method actually construct or throw `ClickSend.Client.ApiException`.

What v2 methods actually do: every call **always returns its typed `IXxxApiResponse`**, 2xx or not. For a 400/401/404/500/etc. response, `IsSuccessStatusCode` is `false`, `IsOk` is `false`, `.Ok()` returns `null`, and the real status and body are on `.StatusCode` / `.RawContent`. The generated method body wraps the whole call in a `try { ... } catch (Exception e) { OnErrorXxxDefaultImplementation(e, ...); Events.ExecuteOnErrorXxx(e); throw; }` — that `catch` only fires for a genuine transport-level failure (a network error, a timeout/cancellation, a JSON deserialization exception), and it **rethrows the original exception type unchanged** — `HttpRequestException`, `TaskCanceledException`, etc. — never wrapped as `ApiException`.

```csharp
// v2 — no exception on a non-2xx response; inspect the response instead
ISendSmsApiResponse response = await smsApi.SendSmsAsync(sendSmsRequest: request);

if (response.IsSuccessStatusCode)
{
    SendSms? result = response.Ok();
}
else
{
    System.Net.HttpStatusCode statusCode = response.StatusCode;
    string rawBody = response.RawContent;
}

// try/catch is still appropriate for transport failures:
try
{
    response = await smsApi.SendSmsAsync(sendSmsRequest: request, cancellationToken: token);
}
catch (HttpRequestException e)      // network-level failure — not an ApiException
{
    // ...
}
catch (OperationCanceledException e) // cancellation or client-side timeout
{
    // ...
}
```

**Audit every `catch (ApiException e)` block around a v2 call.** It will compile (`ClickSend.Client.ApiException` exists), but it will not fire for the 4xx/5xx cases you migrated it for — those come back as an ordinary, non-throwing response object. Replace status-code branching that used to live in a `catch` block with a check on `response.IsSuccessStatusCode` / `response.StatusCode` immediately after the `await`.

## 9. Removed: synchronous calls — every operation is now async-only

Legacy is **not** sync-only — for every single endpoint, the generated `ISMSApi`-style interface exposes four methods: `SmsSendPost` (sync), `SmsSendPostWithHttpInfo` (sync, with status/headers), `SmsSendPostAsync` (async), and `SmsSendPostAsyncWithHttpInfo` (async, with status/headers). Plenty of legacy integrations were built directly against the synchronous surface.

```csharp
// Legacy — both of these exist and both work
string result = smsApi.SmsSendPost(collection);                 // synchronous
string result2 = await smsApi.SmsSendPostAsync(collection);     // also available
```

v2 ships **only** the async surface — there is no synchronous method anywhere in the SDK. Every operation is `Task<IXxxApiResponse> XxxAsync(..., CancellationToken cancellationToken = default)`, with an `XxxOrDefaultAsync` sibling that swallows a transport-level exception and returns `null` instead (it does **not** change how HTTP error statuses are surfaced — see [§8](#8-error-handling-changes) — it only affects the transport-failure `catch` path described there):

```csharp
// v2 — this is the only surface; there is no synchronous SendSms method
ISendSmsApiResponse response = await smsApi.SendSmsAsync(sendSmsRequest: request);

// returns null instead of throwing on a transport-level failure
ISendSmsApiResponse? maybeResponse = await smsApi.SendSmsOrDefaultAsync(sendSmsRequest: request);
```

If your legacy code called the synchronous methods from async code, or called `.Result`/`.Wait()` on the async ones (a common anti-pattern that risks deadlocks), migrating every call site to a real `await XxxAsync(...)` removes that thread-blocking entirely — but it also means **every call site needs an `async` method up the call stack**, which is worth budgeting time for if your legacy integration is currently fully synchronous.

**New in v2, replacing what legacy never had:**

| Feature | How |
|---|---|
| Cancellation | Every method takes a trailing `CancellationToken cancellationToken = default` — thread through `httpContext.RequestAborted` or your own token. |
| Nullable-on-failure variant | `XxxOrDefaultAsync(...)` returns `null` instead of propagating a transport-level exception. |
| Retry / timeout / circuit breaker | Polly-backed `IHttpClientBuilder` extensions, opted into via the `builder` callback of `options.AddApiHttpClients(client, builder)` (see [§3](#3-authentication--client-setup)): `AddRetryPolicy(retries: 3)`, `AddTimeoutPolicy(TimeSpan.FromSeconds(30))`, `AddCircuitBreakerPolicy(handledEventsAllowedBeforeBreaking: 5, durationOfBreak: TimeSpan.FromSeconds(30))`. |
| Automatic 429 backoff | Tokens registered via `AddTokens(...)` get a `TokenProvider`/`RateLimitProvider` that automatically starts a cool-down period for a token when a call using it returns HTTP 429. |

If you had hand-rolled retry/timeout wrappers around the legacy RestSharp client, they can likely be replaced with the built-in Polly policies.

## 10. Class-by-class mapping (all 37 legacy classes)

26 v2 classes now cover what used to be 37 legacy classes. Several legacy classes merged (five email classes → one `EmailApi`), `ContactApi`/`ContactListApi`/`SearchApi` split and merged into `ContactsApi`+`ListsApi`, the Fax/Letters/Postcards/address-detection classes were **dropped entirely** (see [§13](#13-endpointsmethods-removed-in-v2)), and — critically — the two Voice classes **swapped roles** in v2 naming (see [§12](#12-the-voice-naming-trap-read-this-before-touching-voice-code)).

| Legacy class | → | v2 class(es) | Notes |
|---|---|---|---|
| `AccountApi` (account details/usage) | → | `ManagementApi` | `AccountGet`/`AccountUseageBySubaccountGet` → `ViewAccountDetailsAsync`/`ViewAccountUsageAsync`. |
| `AccountApi` (forgot password/username) | → | `VerificationApi` | `ForgotPasswordPut`/`ForgotUsernamePut` → `ForgotPasswordAsync`/`ForgotUsernameAsync`. Four `AccountApi` methods have no v2 equivalent — see [§13](#13-endpointsmethods-removed-in-v2). |
| `AccountRechargeApi` | → | `TransactionsApi` | Renamed 1:1 (6 methods). |
| `ContactApi` | → | `ContactsApi`, `ListsApi` | Split: single-contact-by-id CRUD → `ContactsApi`; list-scoped contact ops (create/list/copy/transfer/remove-opted-out) → `ListsApi`. |
| `ContactListApi` | → | `ListsApi` | Merged into `ListsApi`. |
| `CountriesApi` | → | `InternationalMessagingApi` | `CountriesGet` → `ListCountriesAsync`. |
| `DeliveryIssuesApi` | → | `MessageDeliveryApi` | Renamed. Unrelated to the delivery-*receipt-rule* classes despite the similar name. |
| `DetectAddressApi` | → | _(removed)_ | Address detection/parsing has no v2 equivalent — see [§13](#13-endpointsmethods-removed-in-v2). |
| `EmailDeliveryReceiptRulesApi` | → | `EmailApi` | Folded into the unified `EmailApi`. |
| `EmailMarketingApi` | → | `EmailApi` | Folded into the unified `EmailApi`. |
| `EmailToSmsApi` | → | `EmailToSmsApi` | Same class name, methods renamed (7 → 7). |
| `FAXApi` | → | _(removed)_ | Fax is not part of the v2 SDK — see [§13](#13-endpointsmethods-removed-in-v2). |
| `FAXDeliveryReceiptRulesApi` | → | _(removed)_ | Fax is not part of the v2 SDK — see [§13](#13-endpointsmethods-removed-in-v2). |
| `GlobalSendingApi` | → | `InternationalMessagingApi` | Folded in. |
| `InboundFAXRulesApi` | → | _(removed)_ | Fax is not part of the v2 SDK — see [§13](#13-endpointsmethods-removed-in-v2). |
| `InboundSMSRulesApi` | → | `SmsApi` | Folded in as `*SmsInboundAutomation(s)Async`. |
| `MMSApi` | → | `MmsApi` | Renamed 1:1 for 4 methods; 2 dropped — see [§13](#13-endpointsmethods-removed-in-v2). |
| `MasterEmailTemplatesApi` | → | `EmailApi` | Folded into the unified `EmailApi`. |
| `MmsCampaignApi` | → | `MmsCampaignsApi` | Renamed 1:1 (6 methods). |
| `NumberApi` | → | `NumbersApi` | Renamed 1:1 (3 methods), plus a brand-new `RegisterNumbersAsync` — see [§14](#14-brand-new-resources-and-methods-in-v2). |
| `PostLetterApi` | → | _(removed)_ | Letters is not part of the v2 SDK — see [§13](#13-endpointsmethods-removed-in-v2). |
| `PostPostcardApi` | → | _(removed)_ | Postcards is not part of the v2 SDK — see [§13](#13-endpointsmethods-removed-in-v2). |
| `PostReturnAddressApi` | → | `AddressesApi` | Renamed 1:1 (5 methods). |
| `ReferralAccountApi` | → | `ReferralsApi` | `ReferralAccountsGet` → `ViewReferralAccountsAsync`. |
| `ResellerAccountApi` | → | `ResellerApi` | Merged with `TransferCreditApi`. |
| `SMSApi` | → | `SmsApi` | Renamed 1:1 for all core methods. |
| `SMSDeliveryReceiptRulesApi` | → | `SmsApi` | Folded in as `*SmsDeliveryReceiptRule(s)Async`. |
| `SearchApi` | → | `ListsApi` | `SearchContactsListsGet` → `ViewContactListsAsync`. |
| `SmsCampaignApi` | → | `SmsCampaignsApi` | Renamed 1:1 (6 methods). |
| `StatisticsApi` | → | `StatisticsApi` | Same class name: `StatisticsSmsGet`/`StatisticsVoiceGet` → `ViewSmsStatisticsAsync`/`ViewVoiceStatisticsAsync`. |
| `SubaccountApi` | → | `SubaccountsApi` | Renamed 1:1 (6 methods). |
| `TimezonesApi` | → | `InternationalMessagingApi` | `TimezonesGet` → `TimezonesAsync`. |
| `TransactionalEmailApi` | → | `EmailApi` | Folded into the unified `EmailApi`. |
| `TransferCreditApi` | → | `ResellerApi` | Merged with `ResellerAccountApi`; `ResellerTransferCreditPut` → `ResellerTransferCreditAsync`. |
| `UploadApi` | → | `UploadsApi` | `UploadsPost` → `UploadAMediaFileAsync`. |
| `UserEmailTemplatesApi` | → | `EmailApi` | Folded into the unified `EmailApi`. |
| `VoiceApi` (send/history/price/lang) | → | **`VoiceMessagingApi`** | ⚠️ See [§12](#12-the-voice-naming-trap-read-this-before-touching-voice-code) — this is *not* the new `VoiceApi`. 2 methods dropped — see [§13](#13-endpointsmethods-removed-in-v2). |
| `VoiceDeliveryReceiptRulesApi` | → | **`VoiceApi`** | ⚠️ See [§12](#12-the-voice-naming-trap-read-this-before-touching-voice-code) — the new `VoiceApi` only has delivery-receipt-rule methods. |

`AlphaTagsApi`, `DefaultSendersApi`, `OwnNumbersApi`, and `UrlShorteningApi` in v2 have **no legacy predecessor at all** — see [§14](#14-brand-new-resources-and-methods-in-v2).

### Email: the five legacy classes → `EmailApi`

| Legacy | v2 (`EmailApi`) |
|---|---|
| `TransactionalEmailApi.EmailSendPost` | `SendEmailAsync` |
| `TransactionalEmailApi.EmailHistoryGet` | `ViewEmailHistoryAsync` |
| `TransactionalEmailApi.EmailHistoryExportGet` | `ExportEmailHistoryAsync` |
| `TransactionalEmailApi.EmailPricePost` | `CalculateEmailPriceAsync` |
| `EmailMarketingApi.EmailCampaignPost` | `SendEmailCampaignAsync` |
| `EmailMarketingApi.EmailCampaignsGet` | `ViewAllEmailCampaignsAsync` |
| `EmailMarketingApi.EmailCampaignGet` | `ViewEmailCampaignAsync` |
| `EmailMarketingApi.EmailCampaignPut` | `UpdateEmailCampaignAsync` |
| `EmailMarketingApi.CancelEmailCampaignPut` | `CancelEmailCampaignAsync` |
| `EmailMarketingApi.EmailCampaignPricePost` | `CalculateEmailCampaignPriceAsync` |
| `EmailMarketingApi.EmailCampaignHistoryGet` | `ViewEmailCampaignHistoryAsync` |
| `EmailMarketingApi.EmailCampaignHistoryExportGet` | `ExportEmailCampaignHistoryAsync` |
| `EmailMarketingApi.AllowedEmailAddressGet` | `ViewAllowedEmailAddressesAsync` |
| `EmailMarketingApi.AllowedEmailAddressPost` | `CreateAllowedEmailAddressAsync` |
| `EmailMarketingApi.SpecificAllowedEmailAddressGet` | `ViewAllowedEmailAddressAsync` |
| `EmailMarketingApi.SpecificAllowedEmailAddressDelete` | `DeleteAllowedEmailAddressAsync` |
| `EmailMarketingApi.VerifyAllowedEmailAddressGet` | `VerifyAllowedEmailAddressAsync` |
| `EmailMarketingApi.SendVerificationTokenGet` | `SendEmailVerificationTokenAsync` |
| `UserEmailTemplatesApi.EmailTemplatesGet` | `ViewEmailTemplatesAsync` |
| `UserEmailTemplatesApi.EmailTemplateGet` | `ViewEmailTemplateAsync` |
| `UserEmailTemplatesApi.EmailTemplatePost` | `CreateEmailTemplateAsync` |
| `UserEmailTemplatesApi.EmailTemplatePut` | `UpdateEmailTemplateAsync` |
| `UserEmailTemplatesApi.EmailTemplateDelete` | `DeleteEmailTemplateAsync` |
| `MasterEmailTemplatesApi.MasterEmailTemplatesGet` | `ViewMasterEmailTemplatesAsync` |
| `MasterEmailTemplatesApi.MasterEmailTemplateGet` | `ViewMasterEmailTemplateAsync` |
| `MasterEmailTemplatesApi.MasterEmailTemplateCategoriesGet` | `ViewTemplateCategoriesAsync` |
| `MasterEmailTemplatesApi.MasterEmailTemplateCategoryGet` | `ViewTemplateCategoryAsync` |
| `MasterEmailTemplatesApi.MasterEmailTemplatesInCategoryGet` | `ViewTemplatesInCategoryAsync` |
| `EmailDeliveryReceiptRulesApi.EmailDeliveryReceiptAutomationsGet` | `ViewEmailDeliveryReceiptRulesAsync` |
| `EmailDeliveryReceiptRulesApi.EmailDeliveryReceiptAutomationGet` | `ViewEmailDeliveryReceiptRuleAsync` |
| `EmailDeliveryReceiptRulesApi.EmailDeliveryReceiptAutomationPost` | `CreateEmailDeliveryReceiptRuleAsync` |
| `EmailDeliveryReceiptRulesApi.EmailDeliveryReceiptAutomationPut` | `UpdateEmailDeliveryReceiptRuleAsync` |
| `EmailDeliveryReceiptRulesApi.EmailDeliveryReceiptAutomationDelete` | `DeleteEmailDeliveryReceiptRuleAsync` |

### SMS: `SMSApi` + `InboundSMSRulesApi` + `SMSDeliveryReceiptRulesApi` → `SmsApi`

| Legacy | v2 (`SmsApi`) |
|---|---|
| `SMSApi.SmsSendPost` | `SendSmsAsync` |
| `SMSApi.SmsHistoryGet` | `ViewSmsHistoryAsync` |
| `SMSApi.SmsHistoryExportGet` | `ExportSmsHistoryAsync` |
| `SMSApi.SmsPricePost` | `CalculateSmsPriceAsync` |
| `SMSApi.SmsCancelAllPut` | `CancelAllSmsAsync` |
| `SMSApi.SmsCancelByMessageIdPut` | `CancelSmsAsync` |
| `SMSApi.SmsInboundGet` | `ViewInboundSmsAsync` |
| `SMSApi.SmsInboundPost` | `CreateTestInboundSmsAsync` |
| `SMSApi.SmsInboundReadPut` | `MarkInboundSmsAsReadAsync` |
| `SMSApi.SmsInboundReadByMessageIdPut` | `MarkSpecificInboundSmsMessageAsReadAsync` |
| `SMSApi.SmsReceiptsGet` | `ViewSmsReceiptsAsync` |
| `SMSApi.SmsReceiptsByMessageIdGet` | `ViewSpecificSmsReceiptAsync` |
| `SMSApi.SmsReceiptsPost` | `CreateTestSmsReceiptAsync` |
| `SMSApi.SmsReceiptsReadPut` | `MarkSmsReceiptAsReadAsync` |
| `SMSApi.SmsTemplatesGet` | `ViewSmsTemplatesAsync` |
| `SMSApi.SmsTemplatesPost` | `CreateSmsTemplateAsync` |
| `SMSApi.SmsTemplatesByTemplateIdPut` | `UpdateSmsTemplateAsync` |
| `SMSApi.SmsTemplatesByTemplateIdDelete` | `DeleteSmsTemplateAsync` |
| `InboundSMSRulesApi.SmsInboundAutomationsGet` | `ViewSmsInboundAutomationsAsync` |
| `InboundSMSRulesApi.SmsInboundAutomationGet` | `ViewSmsInboundAutomationAsync` |
| `InboundSMSRulesApi.SmsInboundAutomationPost` | `CreateSmsInboundAutomationAsync` |
| `InboundSMSRulesApi.SmsInboundAutomationPut` | `UpdateSmsInboundAutomationAsync` |
| `InboundSMSRulesApi.SmsInboundAutomationDelete` | `DeleteSmsInboundAutomationAsync` |
| `SMSDeliveryReceiptRulesApi.SmsDeliveryReceiptAutomationsGet` | `ViewSmsDeliveryReceiptRulesAsync` |
| `SMSDeliveryReceiptRulesApi.SmsDeliveryReceiptAutomationGet` | `ViewSmsDeliveryReceiptRuleAsync` |
| `SMSDeliveryReceiptRulesApi.SmsDeliveryReceiptAutomationPost` | `CreateSmsDeliveryReceiptRuleAsync` |
| `SMSDeliveryReceiptRulesApi.SmsDeliveryReceiptAutomationPut` | `UpdateSmsDeliveryReceiptRuleAsync` |
| `SMSDeliveryReceiptRulesApi.SmsDeliveryReceiptAutomationDelete` | `DeleteSmsDeliveryReceiptRuleAsync` |
| — | `ViewASpecificSmsTemplateAsync` *(new — see [§14](#14-brand-new-resources-and-methods-in-v2))* |
| — | `ViewASpecificInboundSmsMessageAsync` *(new — see [§14](#14-brand-new-resources-and-methods-in-v2))* |

### Contacts & lists: `ContactApi` + `ContactListApi` + `SearchApi` → `ContactsApi` + `ListsApi`

| Legacy | v2 |
|---|---|
| `ContactApi.ListsContactsByListIdAndContactIdGet` | `ContactsApi.GetSpecificContactAsync` |
| `ContactApi.ListsContactsByListIdAndContactIdPut` | `ContactsApi.UpdateContactAsync` |
| `ContactApi.ListsContactsByListIdAndContactIdDelete` | `ContactsApi.DeleteContactAsync` |
| `ContactApi.ListsContactsByListIdPost` | `ListsApi.CreateNewContactAsync` |
| `ContactApi.ListsContactsByListIdGet` | `ListsApi.ViewListContactsAsync` |
| `ContactApi.ListsCopyContactPut` | `ListsApi.CopyContactToListAsync` |
| `ContactApi.ListsTransferContactPut` | `ListsApi.TransferContactToListAsync` |
| `ContactApi.ListsRemoveOptedOutContactsByListIdAndOptOutListIdPut` | `ListsApi.RemoveOptedOutContactsAsync` |
| `ContactListApi.ListsGet` | `ListsApi.ViewListsAsync` |
| `ContactListApi.ListsPost` | `ListsApi.CreateListAsync` |
| `ContactListApi.ListsByListIdGet` | `ListsApi.ViewSpecificListAsync` |
| `ContactListApi.ListsByListIdPut` | `ListsApi.UpdateListAsync` |
| `ContactListApi.ListsByListIdDelete` | `ListsApi.DeleteListAsync` |
| `ContactListApi.ListsImportByListIdPost` | `ListsApi.ImportContactsAsync` |
| `ContactListApi.ListsRemoveDuplicatesByListIdPut` | `ListsApi.RemoveDuplicateContactsAsync` |
| `SearchApi.SearchContactsListsGet` | `ListsApi.ViewContactListsAsync` |

### Account & billing

| Legacy | v2 |
|---|---|
| `AccountApi.AccountGet` | `ManagementApi.ViewAccountDetailsAsync` |
| `AccountApi.AccountUseageBySubaccountGet` | `ManagementApi.ViewAccountUsageAsync` |
| `AccountApi.ForgotPasswordPut` | `VerificationApi.ForgotPasswordAsync` |
| `AccountApi.ForgotUsernamePut` | `VerificationApi.ForgotUsernameAsync` |
| `AccountRechargeApi.RechargeCreditCardGet` | `TransactionsApi.CurrentPaymentInfoAsync` |
| `AccountRechargeApi.RechargeCreditCardPut` | `TransactionsApi.UpdatePaymentInfoAsync` |
| `AccountRechargeApi.RechargePackagesGet` | `TransactionsApi.ViewRechargePackagesAsync` |
| `AccountRechargeApi.RechargePurchaseByPackageIdPut` | `TransactionsApi.PurchaseRechargePackageAsync` |
| `AccountRechargeApi.RechargeTransactionsGet` | `TransactionsApi.ViewAllTransactionsAsync` |
| `AccountRechargeApi.RechargeTransactionsByTransactionIdGet` | `TransactionsApi.ViewSpecificTransactionAsync` |
| `ResellerAccountApi.ResellerAccountsGet` | `ResellerApi.ViewClientAccountsAsync` |
| `ResellerAccountApi.ResellerAccountsPost` | `ResellerApi.CreateResellerAccountAsync` |
| `ResellerAccountApi.ResellerAccountsByClientUserIdGet` | `ResellerApi.ViewSpecificClientAccountAsync` |
| `ResellerAccountApi.ResellerAccountsByClientUserIdPut` | `ResellerApi.UpdateClientAccountAsync` |
| `TransferCreditApi.ResellerTransferCreditPut` | `ResellerApi.ResellerTransferCreditAsync` |
| `SubaccountApi.SubaccountsGet` | `SubaccountsApi.ViewSubaccountsAsync` |
| `SubaccountApi.SubaccountsPost` | `SubaccountsApi.CreateSubaccountAsync` |
| `SubaccountApi.SubaccountsBySubaccountIdGet` | `SubaccountsApi.ViewSpecificSubaccountAsync` |
| `SubaccountApi.SubaccountsBySubaccountIdPut` | `SubaccountsApi.UpdateSubaccountAsync` |
| `SubaccountApi.SubaccountsBySubaccountIdDelete` | `SubaccountsApi.DeleteSubaccountAsync` |
| `SubaccountApi.SubaccountsRegenApiKeyBySubaccountIdPut` | `SubaccountsApi.GenerateNewApiKeyAsync` |
| `ReferralAccountApi.ReferralAccountsGet` | `ReferralsApi.ViewReferralAccountsAsync` |

### Numbers, addresses, uploads, international, delivery issues

| Legacy | v2 |
|---|---|
| `NumberApi.NumbersGet` | `NumbersApi.ViewYourNumbersAsync` |
| `NumberApi.NumbersSearchByCountryGet` | `NumbersApi.ViewAvailableNumbersAsync` |
| `NumberApi.NumbersBuyByDedicatedNumberPost` | `NumbersApi.PurchaseDedicatedNumberAsync` |
| `PostReturnAddressApi.PostReturnAddressesGet` | `AddressesApi.ViewYourReturnAddressesAsync` |
| `PostReturnAddressApi.PostReturnAddressesPost` | `AddressesApi.CreateReturnAddressAsync` |
| `PostReturnAddressApi.PostReturnAddressesByReturnAddressIdGet` | `AddressesApi.ViewSpecificReturnAddressAsync` |
| `PostReturnAddressApi.PostReturnAddressesByReturnAddressIdPut` | `AddressesApi.UpdateReturnAddressAsync` |
| `PostReturnAddressApi.PostReturnAddressesByReturnAddressIdDelete` | `AddressesApi.DeleteReturnAddressAsync` |
| `UploadApi.UploadsPost` | `UploadsApi.UploadAMediaFileAsync` |
| `CountriesApi.CountriesGet` | `InternationalMessagingApi.ListCountriesAsync` |
| `TimezonesApi.TimezonesGet` | `InternationalMessagingApi.TimezonesAsync` |
| `GlobalSendingApi.ListCountriesGet` | `InternationalMessagingApi.GetCountriesForGlobalSendingAsync` |
| `GlobalSendingApi.UserCountriesGet` | `InternationalMessagingApi.ViewCountriesAsync` |
| `GlobalSendingApi.UserCountriesPost` | `InternationalMessagingApi.SelectCountriesForGlobalSendingAsync` |
| `GlobalSendingApi.UserCountriesAgreePost` | `InternationalMessagingApi.AgreeToRulesAndRegulationAsync` |
| `DeliveryIssuesApi.DeliveryIssuesGet` | `MessageDeliveryApi.GetAllDeliveryIssuesAsync` |
| `DeliveryIssuesApi.DeliveryIssuesPost` | `MessageDeliveryApi.CreateDeliveryIssueAsync` |

### MMS, campaigns, voice, statistics

| Legacy | v2 |
|---|---|
| `MMSApi.MmsSendPost` | `MmsApi.SendMmsAsync` |
| `MMSApi.MmsHistoryGet` | `MmsApi.ViewMmsHistoryAsync` |
| `MMSApi.MmsHistoryExportGet` | `MmsApi.ExportMmsHistoryAsync` |
| `MMSApi.MmsPricePost` | `MmsApi.CalculateMmsPriceAsync` |
| `MmsCampaignApi.MmsCampaignsSendPost` | `MmsCampaignsApi.SendMmsCampaignAsync` |
| `MmsCampaignApi.MmsCampaignsGet` | `MmsCampaignsApi.ViewAllMmsCampaignsAsync` |
| `MmsCampaignApi.MmsCampaignByMmsCampaignIdGet` | `MmsCampaignsApi.ViewMmsCampaignAsync` |
| `MmsCampaignApi.MmsCampaignsByMmsCampaignIdPut` | `MmsCampaignsApi.UpdateMmsCampaignAsync` |
| `MmsCampaignApi.MmsCampaignsCancelByMmsCampaignIdPut` | `MmsCampaignsApi.CancelMmsCampaignAsync` |
| `MmsCampaignApi.MmsCampaignsPricePost` | `MmsCampaignsApi.CalculateMmsCampaignPriceAsync` |
| `SmsCampaignApi.SmsCampaignsSendPost` | `SmsCampaignsApi.SendSmsCampaignAsync` |
| `SmsCampaignApi.SmsCampaignsGet` | `SmsCampaignsApi.ViewSmsCampaignsAsync` |
| `SmsCampaignApi.SmsCampaignBySmsCampaignIdGet` | `SmsCampaignsApi.ViewSpecificSmsCampaignAsync` |
| `SmsCampaignApi.SmsCampaignsBySmsCampaignIdPut` | `SmsCampaignsApi.UpdateSmsCampaignAsync` |
| `SmsCampaignApi.SmsCampaignsCancelBySmsCampaignIdPut` | `SmsCampaignsApi.CancelSmsCampaignAsync` |
| `SmsCampaignApi.SmsCampaignsPricePost` | `SmsCampaignsApi.CalculateSmsCampaignPriceAsync` |
| `VoiceApi.VoiceSendPost` | `VoiceMessagingApi.SendVoiceMessageAsync` ⚠️ [§12](#12-the-voice-naming-trap-read-this-before-touching-voice-code) |
| `VoiceApi.VoiceHistoryGet` | `VoiceMessagingApi.GetVoiceHistoryAsync` |
| `VoiceApi.VoiceHistoryExportGet` | `VoiceMessagingApi.ExportVoiceHistoryAsync` |
| `VoiceApi.VoicePricePost` | `VoiceMessagingApi.CalculateVoicePriceAsync` |
| `VoiceApi.VoiceLangGet` | `VoiceMessagingApi.ViewVoiceLanguagesAsync` |
| `VoiceApi.VoiceCancelAllPut` | `VoiceMessagingApi.CancelAllVoiceMessagesAsync` |
| `VoiceApi.VoiceCancelByMessageIdPut` | `VoiceMessagingApi.CancelVoiceMessageAsync` |
| `VoiceApi.VoiceReceiptsGet` | `VoiceMessagingApi.ViewVoiceReceiptsAsync` |
| `VoiceDeliveryReceiptRulesApi.VoiceDeliveryReceiptAutomationsGet` | `VoiceApi.ViewVoiceDeliveryReceiptRulesAsync` ⚠️ [§12](#12-the-voice-naming-trap-read-this-before-touching-voice-code) |
| `VoiceDeliveryReceiptRulesApi.VoiceDeliveryReceiptAutomationGet` | `VoiceApi.ViewVoiceDeliveryReceiptRuleAsync` |
| `VoiceDeliveryReceiptRulesApi.VoiceDeliveryReceiptAutomationPost` | `VoiceApi.CreateVoiceDeliveryReceiptRuleAsync` |
| `VoiceDeliveryReceiptRulesApi.VoiceDeliveryReceiptAutomationPut` | `VoiceApi.UpdateVoiceDeliveryReceiptRuleAsync` |
| `VoiceDeliveryReceiptRulesApi.VoiceDeliveryReceiptAutomationDelete` | `VoiceApi.DeleteVoiceDeliveryReceiptRuleAsync` |
| `StatisticsApi.StatisticsSmsGet` | `StatisticsApi.ViewSmsStatisticsAsync` |
| `StatisticsApi.StatisticsVoiceGet` | `StatisticsApi.ViewVoiceStatisticsAsync` |

### Email-to-SMS: `EmailToSmsApi` → `EmailToSmsApi`

| Legacy | v2 |
|---|---|
| `SmsEmailSmsGet` | `ViewAllowedEmailsAsync` |
| `SmsEmailSmsPost` | `AddAllowedEmailAsync` |
| `SmsEmailSmsStrippedStringPost` | `CreateStrippedStringRuleAsync` |
| `SmsEmailSmsStrippedStringGet` | `ViewStrippedStringRuleAsync` |
| `SmsEmailSmsStrippedStringsGet` | `ViewStrippedStringRulesAsync` |
| `SmsEmailSmsStrippedStringPut` | `UpdateStrippedStringRuleAsync` |
| `SmsEmailSmsStrippedStringDelete` | `DeleteStrippedStringRuleAsync` |

## 11. Side-by-side examples for common operations

### Send an SMS

```csharp
// Legacy
var message = new SmsMessage(body: "Hello from ClickSend!", to: "+61411111111", source: "php");
var collection = new SmsMessageCollection(messages: new List<SmsMessage> { message });

try
{
    string result = smsApi.SmsSendPost(collection);   // raw JSON string
    Console.WriteLine(result);
}
catch (ApiException e)
{
    Console.WriteLine($"Error {e.ErrorCode}: {e.Message}");
}

// v2
var request = new SendSmsRequest(
    messages: new List<SendSmsRequestMessagesInner>
    {
        new(body: "Hello from ClickSend!", to: "+61411111111", source: "sdk")
    });

ISendSmsApiResponse response = await smsApi.SendSmsAsync(sendSmsRequest: request);

if (response.IsSuccessStatusCode)
{
    SendSms? result = response.Ok();      // typed SendSms instance
}
else
{
    Console.WriteLine($"Error {(int)response.StatusCode}: {response.RawContent}");
}
```

### View SMS history

```csharp
// Legacy — all params are optional
string result = smsApi.SmsHistoryGet(q: q, dateFrom: from, dateTo: to, page: page, limit: limit);

// v2 — page/limit/q are still there, plus a new orderBy; pass by name
IViewSmsHistoryApiResponse response = await smsApi.ViewSmsHistoryAsync(
    page: page, limit: limit, q: q, orderBy: "date:desc",
    dateFrom: from, dateTo: to);
```

> Always check the current signature before porting a call — parameter sets changed (this one gained `orderBy`).

### Send an MMS / Email / Voice message

Same pattern on every channel — build a `Send<Channel>Request`, call `Send<Channel>Async(...)`:

| Channel | Legacy call | v2 call |
|---|---|---|
| MMS | `mmsApi.MmsSendPost(mmsMessageCollection)` | `mmsApi.SendMmsAsync(sendMmsRequest: request)` |
| Email | `emailApi.EmailSendPost(email)` | `emailApi.SendEmailAsync(sendEmailRequest: request)` |
| Voice | `voiceApi.VoiceSendPost(voiceCollection)` (legacy `VoiceApi`) | `voiceMessagingApi.SendVoiceMessageAsync(sendVoiceMessageRequest: request)` (⚠️ new `VoiceMessagingApi` — see [§12](#12-the-voice-naming-trap-read-this-before-touching-voice-code)) |

> **Fax, Letters, and Postcards are not part of the v2 SDK** — there is no `SendFaxAsync` / `PostLettersSendAsync` / `PostPostcardsSendAsync` equivalent. See [§13](#13-endpointsmethods-removed-in-v2).

### Create a contact in a list

```csharp
// Legacy — contact model first, list_id (int) second
string result = contactApi.ListsContactsByListIdPost(contact, listId);

// v2 — listId is now FIRST and a STRING; payload is a named argument
ICreateNewContactApiResponse response = await listsApi.CreateNewContactAsync(
    listId.ToString(),
    createNewContactRequest: request);
```

### List contacts / lists — pagination parameters were dropped

```csharp
// Legacy — page / limit / updatedAfter were real parameters
contactApi.ListsContactsByListIdGet(listId, page: page, limit: limit, updatedAfter: ts);
contactListApi.ListsGet(page: page, limit: limit);
subaccountApi.SubaccountsGet(page: page, limit: limit);

// v2 — those parameters no longer exist on the signature
await listsApi.ViewListContactsAsync(listId.ToString());
await listsApi.ViewListsAsync();
await subaccountsApi.ViewSubaccountsAsync();
```

**This is a real behavior change, not just a rename.** `ListsApi.ViewListsAsync`, `ListsApi.ViewListContactsAsync`, and `SubaccountsApi.ViewSubaccountsAsync` in v2 take no `page`/`limit`/`updatedAfter` — verified directly against the generated method signatures. Confirm against the current API reference how pagination is handled for any workflow that relied on them before you ship.

### Create a subaccount

```csharp
// Legacy
string result = subaccountApi.SubaccountsPost(subaccount);

// v2
ICreateSubaccountApiResponse response = await subaccountsApi.CreateSubaccountAsync(createSubaccountRequest: request);
```

## 12. The Voice naming trap (read this before touching voice code)

This is the single most confusing rename in the whole migration, and a naive search-and-replace of `VoiceApi` will silently point your code at the wrong class:

- Legacy **`VoiceApi`** (send a voice message, view/export history, calculate price, list voice languages, cancel, view receipts) → renamed to new **`VoiceMessagingApi`**.
- Legacy **`VoiceDeliveryReceiptRulesApi`** (create/update/delete/view delivery-receipt rules) → renamed to new **`VoiceApi`**.

The new `VoiceApi` has **nothing to do with sending voice calls** — verified directly against `src/ClickSend/Api/VoiceApi.cs`, it exposes exactly five methods: `CreateVoiceDeliveryReceiptRuleAsync`, `DeleteVoiceDeliveryReceiptRuleAsync`, `UpdateVoiceDeliveryReceiptRuleAsync`, `ViewVoiceDeliveryReceiptRuleAsync`, `ViewVoiceDeliveryReceiptRulesAsync` — it is purely the old delivery-receipt-rules class under a new name. To migrate voice-sending code, resolve `IVoiceMessagingApi`:

```csharp
// Wrong — this compiles, but v2 VoiceApi only has delivery-receipt-rule methods
var voiceApi = host.Services.GetRequiredService<IVoiceApi>();
await voiceApi.SendVoiceMessageAsync(...);          // does not exist — compile error

// Correct
var voiceMessagingApi = host.Services.GetRequiredService<IVoiceMessagingApi>();
await voiceMessagingApi.SendVoiceMessageAsync(sendVoiceMessageRequest: request);
```

(In C# this actually fails to *compile* rather than throwing at runtime, since `IVoiceApi` and `IVoiceMessagingApi` are distinct interfaces — but it's still easy to resolve the wrong one by habit and get a confusing compiler error, or to have written your own thin wrapper interface around "VoiceApi" that now needs repointing.)

## 13. Endpoints/methods removed in v2

### Entire products dropped

The **Fax**, **Letters**, and **Postcards** products, plus post-mail **address detection**, have **no presence at all** in the v2 SDK — no API class, no models. If your integration sends faxes, letters, or postcards, or uses address detection, there is currently no v2 SDK path for it; call the REST API directly or keep the legacy SDK installed alongside v2 for just that functionality (the two packages can coexist — see [§2](#2-installation--imports)).

| Legacy class(es) | Covered (legacy) | v2 |
|---|---|---|
| `FAXApi`, `FAXDeliveryReceiptRulesApi`, `InboundFAXRulesApi` | send fax, fax history/export, fax price, fax receipts, fax delivery-receipt rules, inbound fax rules | _none_ |
| `PostLetterApi` | send letter, letter history/export, letter price | _none_ |
| `PostPostcardApi` | send postcard, postcard history/export, postcard price | _none_ |
| `DetectAddressApi` | address detection/parsing (`DetectAddressPost`) | _none_ |

### Individual methods dropped (class otherwise survived)

The following legacy operations have **no equivalent anywhere in the v2 SDK**. If your integration depends on any of these, check the current ClickSend API reference before upgrading — the underlying endpoint may have been retired, moved, or simply not covered by the new spec at build time:

- `AccountApi.AccountPost` — create a new account
- `AccountApi.AccountVerifySendPut` — send account activation token
- `AccountApi.AccountVerifyVerifyByActivationTokenPut` — verify a new account
- `AccountApi.ForgotPasswordVerifyPut` — verify a forgot-password token
- `MMSApi.MmsReceiptsGet` — view MMS delivery receipts
- `MMSApi.MmsReceiptsReadPut` — mark MMS receipts as read
- `VoiceApi.VoiceReceiptsPost` (legacy class — send/history/price voice API, not the delivery-receipt-rules one) — create a test voice receipt
- `VoiceApi.VoiceReceiptsReadPut` (legacy class, same caveat) — mark voice receipts as read

Additionally, **pagination parameters (`page`, `limit`, `updatedAfter`) were dropped** from several method signatures even where the class survived — notably `ListsApi.ViewListsAsync`, `ListsApi.ViewListContactsAsync`, and `SubaccountsApi.ViewSubaccountsAsync` (see [§11](#11-side-by-side-examples-for-common-operations)).

## 14. Brand-new resources and methods in v2

No legacy counterpart at all — nothing to migrate, but worth knowing they exist:

- **`AlphaTagsApi`** — `ListAlphaTagsAsync`, `GetAlphaTagAsync`, `RequestAlphaTagAsync`, `DeleteAlphaTagAsync`
- **`DefaultSendersApi`** — `GetDefaultSendersListAsync`, `GetDefaultSenderDetailsAsync`, `CreateDefaultSenderAsync`, `UpdateDefaultSenderAsync`, `DeleteDefaultSenderAsync`, `ListCompliantSenderTypesAsync`
- **`OwnNumbersApi`** (Bring Your Own Number) — `ListOwnNumbersAsync`, `GetOwnNumberDetailAsync`, `UpdateOwnNumberAsync`, `DeleteOwnNumberAsync`, `RequestOwnNumberVerificationOtpAsync`, `VerifyOwnNumberOtpAsync`
- **`UrlShorteningApi`** — `ShortUrlGetStatisticsAsync`, `ShortUrlGetTrackingAsync`
- **`NumbersApi.RegisterNumbersAsync`** — number registration (alongside the renamed `NumberApi` methods)
- **`SmsApi.ViewASpecificInboundSmsMessageAsync`** and **`SmsApi.ViewASpecificSmsTemplateAsync`** — fetch a single inbound message / template by ID (legacy only exposed the list endpoints)

## 15. Step-by-step migration checklist

1. **Swap the package**: remove `IO.ClickSend`, `dotnet add package ClickSend`. The two can coexist during an incremental migration ([§2](#2-installation--imports)).
2. **Move the project to a current .NET target** — v2 requires .NET 10.0; legacy targeted .NET Framework 4.8.
3. **Replace `using IO.ClickSend.*` with `using ClickSend.*`**, and add `using ClickSend.Extensions;` wherever you set up the client.
4. **Throw away `Configuration.Default` / `new XxxApi()` entirely** and set up DI instead: `Host.CreateDefaultBuilder().ConfigureApi((context, services, options) => options.AddTokens(new BasicToken(username, apiKey))).Build()`, or `services.AddApi(...)` inside an existing app. Resolve every API by interface via `host.Services.GetRequiredService<IXxxApi>()` ([§3](#3-authentication--client-setup)). If you need a custom base address, timeout, or headers, call `options.AddApiHttpClients(client => { ... })` yourself inside that same callback — do not rely on the README's `ConfigureHttpClients` snippet, which does not exist as a real extension method in this build.
5. **Rebuild every request payload** with the matching `*Request` model (or object initializer), passed as a **named argument** (`sendSmsRequest: request`) so it doesn't land in the leading `contentType` slot ([§6](#6-request-payloads-request-models-replace-reusable-domain-models)). The sender field stays `From` in both SDKs — no rename needed there.
6. **Rename every method call** using the [§10](#10-class-by-class-mapping-all-37-legacy-classes)/[§11](#11-side-by-side-examples-for-common-operations) tables or your editor's autocomplete on the resolved `IXxxApi` interface. **Pay special attention to `VoiceApi` → `VoiceMessagingApi`** ([§12](#12-the-voice-naming-trap-read-this-before-touching-voice-code)).
7. **Convert every call site to `await XxxAsync(...)`** — v2 has no synchronous surface at all, unlike legacy which shipped both. Thread a `CancellationToken` through where relevant ([§9](#9-removed-synchronous-calls--every-operation-is-now-async-only)).
8. **Update response handling** — use `response.Ok()` / `response.IsOk` / `response.IsSuccessStatusCode` on the returned `IXxxApiResponse` instead of parsing a raw `string` ([§7](#7-response-payloads-are-now-properly-typed)).
9. **Rewrite your error handling.** Do not assume `catch (ApiException e)` will fire for a 4xx/5xx response in v2 — it won't; the generated calls never throw `ApiException` despite the doc comments claiming otherwise. Check `response.StatusCode`/`response.RawContent` after every call, and reserve try/catch for genuine transport failures (`HttpRequestException`, `OperationCanceledException`) ([§8](#8-error-handling-changes)).
10. **Check for removed endpoints and dropped products** ([§13](#13-endpointsmethods-removed-in-v2)) — Fax, Letters, Postcards, and address detection are entirely gone, plus a handful of individual account/MMS/voice-receipt methods — confirm a replacement exists in the current API before shipping.
11. **Re-check every pagination-dependent call** to `ListsApi.ViewListsAsync`, `ListsApi.ViewListContactsAsync`, and `SubaccountsApi.ViewSubaccountsAsync` — `page`/`limit`/`updatedAfter` no longer exist on those signatures.
12. **Test each migrated call against ClickSend sandbox/test credentials** before deploying. A renamed method or a misresolved `VoiceApi`/`VoiceMessagingApi` interface is usually a compile-time error in C#, but response-shape and error-handling regressions will not be — smoke-test every endpoint your integration uses.
