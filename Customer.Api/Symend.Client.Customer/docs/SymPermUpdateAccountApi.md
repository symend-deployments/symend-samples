# Symend.Client.Customer.Api.SymPermUpdateAccountApi

All URIs are relative to *https://api-dev.symend.io/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UpdateAccount**](SymPermUpdateAccountApi.md#updateaccount) | **PATCH** /v1/accounts/{id} | Update an Account |

<a name="updateaccount"></a>
# **UpdateAccount**
> AccountResponseResultModel UpdateAccount (Guid id, Guid xSymOrganizationId, AccountForm accountForm = null)

Update an Account

Performs a partial update of an account using its GUID as lookup.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class UpdateAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermUpdateAccountApi(config);
            var id = "id_example";  // Guid | Account Id
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var accountForm = new AccountForm(); // AccountForm | Body contains list of properties which are key-value pairs. The keys are attribute IDs as seen in the data-target-defintions endpoint. (optional) 

            try
            {
                // Update an Account
                AccountResponseResultModel result = apiInstance.UpdateAccount(id, xSymOrganizationId, accountForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermUpdateAccountApi.UpdateAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an Account
    ApiResponse<AccountResponseResultModel> response = apiInstance.UpdateAccountWithHttpInfo(id, xSymOrganizationId, accountForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermUpdateAccountApi.UpdateAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Account Id |  |
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
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Client Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

