# Symend.Client.Customer.Api.CustomerTrailApi

All URIs are relative to *http://api.local.symendinc.com/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCustomerEventsByAccountKey**](CustomerTrailApi.md#getcustomereventsbyaccountkey) | **GET** /v1/accounts/customer-trail-events | Get Customer Trail events for an Account by Account Key |
| [**GetCustomerTrailEventsForAccount**](CustomerTrailApi.md#getcustomertraileventsforaccount) | **GET** /v1/accounts/{id}/customer-trail-events | Get Customer Trail events for an Account |

<a name="getcustomereventsbyaccountkey"></a>
# **GetCustomerEventsByAccountKey**
> CustomerTrailEventPagedModel GetCustomerEventsByAccountKey (Guid xSymOrganizationId, string accountKey, GetCustomerTrailEventsForAccountSearchParameterParameter searchParameter = null, GuidPagedMetadata paging = null)

Get Customer Trail events for an Account by Account Key

Returns a detailed list of Customer Trail Events for a specific Account, by Account Key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class GetCustomerEventsByAccountKeyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.local.symendinc.com/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomerTrailApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var accountKey = "accountKey_example";  // string | This is the account key to be used to return related customer trail events
            var searchParameter = new GetCustomerTrailEventsForAccountSearchParameterParameter(); // GetCustomerTrailEventsForAccountSearchParameterParameter | Search Parameter (optional) 
            var paging = new GuidPagedMetadata(); // GuidPagedMetadata | Paging Criteria (optional) 

            try
            {
                // Get Customer Trail events for an Account by Account Key
                CustomerTrailEventPagedModel result = apiInstance.GetCustomerEventsByAccountKey(xSymOrganizationId, accountKey, searchParameter, paging);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomerTrailApi.GetCustomerEventsByAccountKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerEventsByAccountKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Customer Trail events for an Account by Account Key
    ApiResponse<CustomerTrailEventPagedModel> response = apiInstance.GetCustomerEventsByAccountKeyWithHttpInfo(xSymOrganizationId, accountKey, searchParameter, paging);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomerTrailApi.GetCustomerEventsByAccountKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |
| **accountKey** | **string** | This is the account key to be used to return related customer trail events |  |
| **searchParameter** | [**GetCustomerTrailEventsForAccountSearchParameterParameter**](GetCustomerTrailEventsForAccountSearchParameterParameter.md) | Search Parameter | [optional]  |
| **paging** | [**GuidPagedMetadata**](GuidPagedMetadata.md) | Paging Criteria | [optional]  |

### Return type

[**CustomerTrailEventPagedModel**](CustomerTrailEventPagedModel.md)

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
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcustomertraileventsforaccount"></a>
# **GetCustomerTrailEventsForAccount**
> CustomerTrailEventPagedModel GetCustomerTrailEventsForAccount (string id, Guid xSymOrganizationId, GetCustomerTrailEventsForAccountSearchParameterParameter searchParameter = null, GuidPagedMetadata paging = null)

Get Customer Trail events for an Account

Returns a detailed list of Customer Trail Events for a specific Account, by ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class GetCustomerTrailEventsForAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.local.symendinc.com/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CustomerTrailApi(config);
            var id = "id_example";  // string | The GUID associated with the desired account
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var searchParameter = new GetCustomerTrailEventsForAccountSearchParameterParameter(); // GetCustomerTrailEventsForAccountSearchParameterParameter | Search Parameter (optional) 
            var paging = new GuidPagedMetadata(); // GuidPagedMetadata | Paging Criteria (optional) 

            try
            {
                // Get Customer Trail events for an Account
                CustomerTrailEventPagedModel result = apiInstance.GetCustomerTrailEventsForAccount(id, xSymOrganizationId, searchParameter, paging);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CustomerTrailApi.GetCustomerTrailEventsForAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerTrailEventsForAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Customer Trail events for an Account
    ApiResponse<CustomerTrailEventPagedModel> response = apiInstance.GetCustomerTrailEventsForAccountWithHttpInfo(id, xSymOrganizationId, searchParameter, paging);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CustomerTrailApi.GetCustomerTrailEventsForAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The GUID associated with the desired account |  |
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |
| **searchParameter** | [**GetCustomerTrailEventsForAccountSearchParameterParameter**](GetCustomerTrailEventsForAccountSearchParameterParameter.md) | Search Parameter | [optional]  |
| **paging** | [**GuidPagedMetadata**](GuidPagedMetadata.md) | Paging Criteria | [optional]  |

### Return type

[**CustomerTrailEventPagedModel**](CustomerTrailEventPagedModel.md)

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
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

