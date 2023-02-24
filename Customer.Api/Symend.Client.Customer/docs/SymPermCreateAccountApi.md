# Symend.Client.Customer.Api.SymPermCreateAccountApi

All URIs are relative to *https://api.symend.io/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateUpdateAccount**](SymPermCreateAccountApi.md#createupdateaccount) | **PUT** /v1/accounts | Create/Update Accounts |

<a name="createupdateaccount"></a>
# **CreateUpdateAccount**
> AccountResponseResultModel CreateUpdateAccount (Guid xSymOrganizationId, AccountForm accountForm = null)

Create/Update Accounts

Creates an account or performs a partial update using its AccountKey as lookup.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class CreateUpdateAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermCreateAccountApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var accountForm = new AccountForm(); // AccountForm | Body contains list of properties which are key-value pairs. The keys are attribute IDs as seen in the data-target-defintions endpoint. (optional) 

            try
            {
                // Create/Update Accounts
                AccountResponseResultModel result = apiInstance.CreateUpdateAccount(xSymOrganizationId, accountForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermCreateAccountApi.CreateUpdateAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateUpdateAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create/Update Accounts
    ApiResponse<AccountResponseResultModel> response = apiInstance.CreateUpdateAccountWithHttpInfo(xSymOrganizationId, accountForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermCreateAccountApi.CreateUpdateAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |
| **accountForm** | [**AccountForm**](AccountForm.md) | Body contains list of properties which are key-value pairs. The keys are attribute IDs as seen in the data-target-defintions endpoint. | [optional]  |

### Return type

[**AccountResponseResultModel**](AccountResponseResultModel.md)

### Authorization

[JSON_Web_Token](../README.md#JSON_Web_Token)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **422** | Client Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

