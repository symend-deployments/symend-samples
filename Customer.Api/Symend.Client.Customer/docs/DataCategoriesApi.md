# Symend.Client.Customer.Api.DataCategoriesApi

All URIs are relative to *https://api.symend.io/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDataCategories**](DataCategoriesApi.md#getdatacategories) | **GET** /v1/data-categories | List Data Categories |

<a id="getdatacategories"></a>
# **GetDataCategories**
> StringIEnumerableResultModel GetDataCategories (Guid xSymOrganizationId)

List Data Categories

Returns the list of enumerated types to be used as a Category in the data-target-definitions endpoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class GetDataCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DataCategoriesApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request

            try
            {
                // List Data Categories
                StringIEnumerableResultModel result = apiInstance.GetDataCategories(xSymOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataCategoriesApi.GetDataCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Data Categories
    ApiResponse<StringIEnumerableResultModel> response = apiInstance.GetDataCategoriesWithHttpInfo(xSymOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataCategoriesApi.GetDataCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |

### Return type

[**StringIEnumerableResultModel**](StringIEnumerableResultModel.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

