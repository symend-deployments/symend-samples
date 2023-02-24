# Symend.Client.Customer.Api.SymPermViewAccountsApi

All URIs are relative to *https://api.symend.io/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAccount**](SymPermViewAccountsApi.md#getaccount) | **GET** /v1/accounts/{id} | Get an Account by Id |
| [**ListAccountSummary**](SymPermViewAccountsApi.md#listaccountsummary) | **GET** /v1/accounts/actions/get-summary-list | List Account Summary |
| [**ListAccounts**](SymPermViewAccountsApi.md#listaccounts) | **GET** /v1/accounts | List Accounts |

<a name="getaccount"></a>
# **GetAccount**
> AccountExtendedModelResultModel GetAccount (Guid id, Guid xSymOrganizationId)

Get an Account by Id

Returns a specific account using its GUID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class GetAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermViewAccountsApi(config);
            var id = "id_example";  // Guid | Account Id
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request

            try
            {
                // Get an Account by Id
                AccountExtendedModelResultModel result = apiInstance.GetAccount(id, xSymOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermViewAccountsApi.GetAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an Account by Id
    ApiResponse<AccountExtendedModelResultModel> response = apiInstance.GetAccountWithHttpInfo(id, xSymOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermViewAccountsApi.GetAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Account Id |  |
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |

### Return type

[**AccountExtendedModelResultModel**](AccountExtendedModelResultModel.md)

### Authorization

[JSON_Web_Token](../README.md#JSON_Web_Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Client Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccountsummary"></a>
# **ListAccountSummary**
> AccountSummarySearchResultGuidPagedModel ListAccountSummary (Guid xSymOrganizationId, string accountKey = null, string email = null, string phone = null, int? limit = null, string direction = null, string orderByAttribute = null, string orderByLastValue = null, Guid? cursor = null)

List Account Summary

Returns a paginated list of all accounts summary. Optionally, searches within that list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class ListAccountSummaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermViewAccountsApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var accountKey = "accountKey_example";  // string | Return an account with a specific account key (optional) 
            var email = "email_example";  // string | An email to search for within the accounts list (optional) 
            var phone = "phone_example";  // string | A phone number to search for within the accounts list (optional) 
            var limit = 56;  // int? | The maximum number of accounts to return per page, default 100. (optional) 
            var direction = "direction_example";  // string | The ordering direction of the results, ascending (default) or descending (optional) 
            var orderByAttribute = "orderByAttribute_example";  // string | The account attribute to sort the results by (optional) 
            var orderByLastValue = "orderByLastValue_example";  // string | Inherited, unused (optional) 
            var cursor = "cursor_example";  // Guid? | The ID of the last account on the previous page, leave empty to fetch first page (optional) 

            try
            {
                // List Account Summary
                AccountSummarySearchResultGuidPagedModel result = apiInstance.ListAccountSummary(xSymOrganizationId, accountKey, email, phone, limit, direction, orderByAttribute, orderByLastValue, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermViewAccountsApi.ListAccountSummary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAccountSummaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Account Summary
    ApiResponse<AccountSummarySearchResultGuidPagedModel> response = apiInstance.ListAccountSummaryWithHttpInfo(xSymOrganizationId, accountKey, email, phone, limit, direction, orderByAttribute, orderByLastValue, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermViewAccountsApi.ListAccountSummaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |
| **accountKey** | **string** | Return an account with a specific account key | [optional]  |
| **email** | **string** | An email to search for within the accounts list | [optional]  |
| **phone** | **string** | A phone number to search for within the accounts list | [optional]  |
| **limit** | **int?** | The maximum number of accounts to return per page, default 100. | [optional]  |
| **direction** | **string** | The ordering direction of the results, ascending (default) or descending | [optional]  |
| **orderByAttribute** | **string** | The account attribute to sort the results by | [optional]  |
| **orderByLastValue** | **string** | Inherited, unused | [optional]  |
| **cursor** | **Guid?** | The ID of the last account on the previous page, leave empty to fetch first page | [optional]  |

### Return type

[**AccountSummarySearchResultGuidPagedModel**](AccountSummarySearchResultGuidPagedModel.md)

### Authorization

[JSON_Web_Token](../README.md#JSON_Web_Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaccounts"></a>
# **ListAccounts**
> AccountSearchResultGuidPagedModel ListAccounts (Guid xSymOrganizationId, string accountKey = null, string email = null, string phone = null, int? limit = null, string direction = null, string orderByAttribute = null, string orderByLastValue = null, Guid? cursor = null)

List Accounts

Returns a paginated list of all accounts. Optionally, searches within that list.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class ListAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermViewAccountsApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var accountKey = "accountKey_example";  // string | Return an account with a specific account key (optional) 
            var email = "email_example";  // string | An email to search for within the accounts list (optional) 
            var phone = "phone_example";  // string | A phone number to search for within the accounts list (optional) 
            var limit = 56;  // int? | The maximum number of accounts to return per page, default 100. (optional) 
            var direction = "direction_example";  // string | The ordering direction of the results, ascending (default) or descending (optional) 
            var orderByAttribute = "orderByAttribute_example";  // string | The account attribute to sort the results by (optional) 
            var orderByLastValue = "orderByLastValue_example";  // string | Inherited, unused (optional) 
            var cursor = "cursor_example";  // Guid? | The ID of the last account on the previous page, leave empty to fetch first page (optional) 

            try
            {
                // List Accounts
                AccountSearchResultGuidPagedModel result = apiInstance.ListAccounts(xSymOrganizationId, accountKey, email, phone, limit, direction, orderByAttribute, orderByLastValue, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermViewAccountsApi.ListAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Accounts
    ApiResponse<AccountSearchResultGuidPagedModel> response = apiInstance.ListAccountsWithHttpInfo(xSymOrganizationId, accountKey, email, phone, limit, direction, orderByAttribute, orderByLastValue, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermViewAccountsApi.ListAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |
| **accountKey** | **string** | Return an account with a specific account key | [optional]  |
| **email** | **string** | An email to search for within the accounts list | [optional]  |
| **phone** | **string** | A phone number to search for within the accounts list | [optional]  |
| **limit** | **int?** | The maximum number of accounts to return per page, default 100. | [optional]  |
| **direction** | **string** | The ordering direction of the results, ascending (default) or descending | [optional]  |
| **orderByAttribute** | **string** | The account attribute to sort the results by | [optional]  |
| **orderByLastValue** | **string** | Inherited, unused | [optional]  |
| **cursor** | **Guid?** | The ID of the last account on the previous page, leave empty to fetch first page | [optional]  |

### Return type

[**AccountSearchResultGuidPagedModel**](AccountSearchResultGuidPagedModel.md)

### Authorization

[JSON_Web_Token](../README.md#JSON_Web_Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **201** | Created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

