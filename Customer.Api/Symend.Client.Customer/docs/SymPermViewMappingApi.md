# Symend.Client.Customer.Api.SymPermViewMappingApi

All URIs are relative to *https://api.symend.io/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCustomerTrailOptions**](SymPermViewMappingApi.md#getcustomertrailoptions) | **GET** /v1/customer-trail-options | Get Customer Trail options |
| [**ListCustomerTrailEventTypes**](SymPermViewMappingApi.md#listcustomertraileventtypes) | **GET** /v1/customer-trail-event-types | GET Customer Trail event types |

<a name="getcustomertrailoptions"></a>
# **GetCustomerTrailOptions**
> CustomerTrailOptionModel GetCustomerTrailOptions (Guid xSymOrganizationId)

Get Customer Trail options

Get Customer Trail Options- Account Search Options (Search for a Customer Account by AccountId, AccountKey, Email, Phone) and Event Category Options (accountUpdates, emailActivities etc.).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class GetCustomerTrailOptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermViewMappingApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request

            try
            {
                // Get Customer Trail options
                CustomerTrailOptionModel result = apiInstance.GetCustomerTrailOptions(xSymOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermViewMappingApi.GetCustomerTrailOptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerTrailOptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Customer Trail options
    ApiResponse<CustomerTrailOptionModel> response = apiInstance.GetCustomerTrailOptionsWithHttpInfo(xSymOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermViewMappingApi.GetCustomerTrailOptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |

### Return type

[**CustomerTrailOptionModel**](CustomerTrailOptionModel.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcustomertraileventtypes"></a>
# **ListCustomerTrailEventTypes**
> CustomerTrailEventTypeCollectionModel ListCustomerTrailEventTypes ()

GET Customer Trail event types

Lists all customer trail event types, including their associated attribute types.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class ListCustomerTrailEventTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermViewMappingApi(config);

            try
            {
                // GET Customer Trail event types
                CustomerTrailEventTypeCollectionModel result = apiInstance.ListCustomerTrailEventTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermViewMappingApi.ListCustomerTrailEventTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCustomerTrailEventTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GET Customer Trail event types
    ApiResponse<CustomerTrailEventTypeCollectionModel> response = apiInstance.ListCustomerTrailEventTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermViewMappingApi.ListCustomerTrailEventTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CustomerTrailEventTypeCollectionModel**](CustomerTrailEventTypeCollectionModel.md)

### Authorization

[JSON_Web_Token](../README.md#JSON_Web_Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

