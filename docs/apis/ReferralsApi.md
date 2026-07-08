# ClickSend.Api.ReferralsApi

All URIs are relative to *https://rest.clicksend.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ViewReferralAccounts**](ReferralsApi.md#viewreferralaccounts) | **GET** /v3/referral/accounts/ | View Referral Accounts |

<a id="viewreferralaccounts"></a>
# **ViewReferralAccounts**
> ViewReferralAccounts ViewReferralAccounts (string contentType = null)

View Referral Accounts

_Get all referral accounts_  ### Parameters  | Parameter | In | Type | Required | Description | | - -- | - -- | - -- | - -- | - -- | | page | query | integer(int32) | false | [Page number](/#pagination) | | limit | query | integer(int32) | false | [Number of records per page](/#pagination) |   Refer to [Status Codes](/#status-codes) for definitions of HTTP status code responses.   <div style=\"background-color: #FF6A4B; padding: 10px; border-radius: 8px;\">   <span style=\"color: white;\">This endpoint requires authentication,</span>    <a href=\"/docs/#authentication\" style=\"color: white; text-decoration: underline;\">more info...</a> </div>


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contentType** | **string** |  | [optional]  |

### Return type

[**ViewReferralAccounts**](ViewReferralAccounts.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

