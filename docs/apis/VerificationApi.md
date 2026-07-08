# ClickSend.Api.VerificationApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ForgotPassword**](VerificationApi.md#forgotpassword) | **PUT** /v3/forgot-password | Forgot Password |
| [**ForgotUsername**](VerificationApi.md#forgotusername) | **PUT** /v3/forgot-username | Forgot Username |

<a id="forgotpassword"></a>
# **ForgotPassword**
> ForgotPassword ForgotPassword (string contentType = null, ForgotPasswordRequest forgotPasswordRequest = null)

Forgot Password

_Forgot password_  A user can send their username to this endpoint to be sent an email with their registered email address that will have a verification code.  Once you have this verification email containing the code you can send it to the [forgotten-password/verify](/#verify-forgot-password) endpoint along with a new password and the ID of that subaccount.  _Ask your administrator if you do not know your subaccount id._  ### Properties  | **Name** | **Type** | **Required** | **Restrictions** | **Description** | | - -- | - -- | - -- | - -- | - -- | | username | string | true | none | Username belonging to account |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #6BBD5B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint does not require authentication</span>  </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **forgotPasswordRequest** | [**ForgotPasswordRequest**](ForgotPasswordRequest.md) |  | [optional]  |

### Return type

[**ForgotPassword**](ForgotPassword.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="forgotusername"></a>
# **ForgotUsername**
> ForgotUsername ForgotUsername (string contentType = null, ForgotUsernameRequest forgotUsernameRequest = null)

Forgot Username

_Forgot username_  Requires the user to pass either the email registered to an account or the phone number, **not** both  ### Properties  | **Name** | **Type** | **Required** | **Restrictions** | **Description** | | - -- | - -- | - -- | - -- | - -- | | email | string | true | none | Email belonging to account | | phone_number | string | true | none | Phone belonging to account |  Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.  <div style=\"background-color: #6BBD5B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint does not require authentication</span>  </div>   


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |
| **forgotUsernameRequest** | [**ForgotUsernameRequest**](ForgotUsernameRequest.md) |  | [optional]  |

### Return type

[**ForgotUsername**](ForgotUsername.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

