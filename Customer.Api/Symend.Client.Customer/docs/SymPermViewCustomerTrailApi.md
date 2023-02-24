# Symend.Client.Customer.Api.SymPermViewCustomerTrailApi

All URIs are relative to *https://api.symend.io/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetAttributeValuesByEventId**](SymPermViewCustomerTrailApi.md#getattributevaluesbyeventid) | **GET** /v1/customer-trail-events/{eventId} | This endpoint returns the attributes to the event id |
| [**GetCustomerEventsByAccountKey**](SymPermViewCustomerTrailApi.md#getcustomereventsbyaccountkey) | **GET** /v1/accounts/customer-trail-events | Get Customer Trail events for an Account by Account Key |
| [**GetCustomerEventsByAccountKeyOrderByDateTime**](SymPermViewCustomerTrailApi.md#getcustomereventsbyaccountkeyorderbydatetime) | **GET** /v2/accounts/customer-trail-events | Get Customer Trail events for an Account by Account Key |
| [**GetCustomerTrailEventsForAccount**](SymPermViewCustomerTrailApi.md#getcustomertraileventsforaccount) | **GET** /v1/accounts/{id}/customer-trail-events | Get Customer Trail events for an Account |
| [**GetCustomerTrailEventsForAccountPagedDateTime**](SymPermViewCustomerTrailApi.md#getcustomertraileventsforaccountpageddatetime) | **GET** /v2/accounts/{id}/customer-trail-events | Get Customer Trail events for an Account |

<a name="getattributevaluesbyeventid"></a>
# **GetAttributeValuesByEventId**
> CustomerTrailEventAttributeValueResultModel GetAttributeValuesByEventId (string eventId)

This endpoint returns the attributes to the event id

This endpoint returns the associated to the event id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class GetAttributeValuesByEventIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermViewCustomerTrailApi(config);
            var eventId = "eventId_example";  // string | 

            try
            {
                // This endpoint returns the attributes to the event id
                CustomerTrailEventAttributeValueResultModel result = apiInstance.GetAttributeValuesByEventId(eventId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermViewCustomerTrailApi.GetAttributeValuesByEventId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAttributeValuesByEventIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // This endpoint returns the attributes to the event id
    ApiResponse<CustomerTrailEventAttributeValueResultModel> response = apiInstance.GetAttributeValuesByEventIdWithHttpInfo(eventId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermViewCustomerTrailApi.GetAttributeValuesByEventIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventId** | **string** |  |  |

### Return type

[**CustomerTrailEventAttributeValueResultModel**](CustomerTrailEventAttributeValueResultModel.md)

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
| **403** | Forbidden |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermViewCustomerTrailApi(config);
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
                Debug.Print("Exception when calling SymPermViewCustomerTrailApi.GetCustomerEventsByAccountKey: " + e.Message);
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
    Debug.Print("Exception when calling SymPermViewCustomerTrailApi.GetCustomerEventsByAccountKeyWithHttpInfo: " + e.Message);
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

<a name="getcustomereventsbyaccountkeyorderbydatetime"></a>
# **GetCustomerEventsByAccountKeyOrderByDateTime**
> CustomerTrailEventPagedModelV2 GetCustomerEventsByAccountKeyOrderByDateTime (Guid xSymOrganizationId, string accountKey, string interval, GuidPagedMetadata paging = null, GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter searchParameter = null)

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
    public class GetCustomerEventsByAccountKeyOrderByDateTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermViewCustomerTrailApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var accountKey = "accountKey_example";  // string | This is the account key to be used to return related customer trail events ordered by DateTime Descending
            var interval = 2022-07-01T00:00/2022-07-15T00:00;  // string | The Datetime interval must be in the following format i.e.  2022-07-01T00:00/2022-07-15T00:00
            var paging = new GuidPagedMetadata(); // GuidPagedMetadata | Paging Criteria (optional) 
            var searchParameter = new GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter(); // GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter | Search Parameter (optional) 

            try
            {
                // Get Customer Trail events for an Account by Account Key
                CustomerTrailEventPagedModelV2 result = apiInstance.GetCustomerEventsByAccountKeyOrderByDateTime(xSymOrganizationId, accountKey, interval, paging, searchParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermViewCustomerTrailApi.GetCustomerEventsByAccountKeyOrderByDateTime: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerEventsByAccountKeyOrderByDateTimeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Customer Trail events for an Account by Account Key
    ApiResponse<CustomerTrailEventPagedModelV2> response = apiInstance.GetCustomerEventsByAccountKeyOrderByDateTimeWithHttpInfo(xSymOrganizationId, accountKey, interval, paging, searchParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermViewCustomerTrailApi.GetCustomerEventsByAccountKeyOrderByDateTimeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |
| **accountKey** | **string** | This is the account key to be used to return related customer trail events ordered by DateTime Descending |  |
| **interval** | **string** | The Datetime interval must be in the following format i.e.  2022-07-01T00:00/2022-07-15T00:00 |  |
| **paging** | [**GuidPagedMetadata**](GuidPagedMetadata.md) | Paging Criteria | [optional]  |
| **searchParameter** | [**GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter**](GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter.md) | Search Parameter | [optional]  |

### Return type

[**CustomerTrailEventPagedModelV2**](CustomerTrailEventPagedModelV2.md)

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
| **422** | Unprocessable Entity (WebDAV) |  -  |
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
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermViewCustomerTrailApi(config);
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
                Debug.Print("Exception when calling SymPermViewCustomerTrailApi.GetCustomerTrailEventsForAccount: " + e.Message);
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
    Debug.Print("Exception when calling SymPermViewCustomerTrailApi.GetCustomerTrailEventsForAccountWithHttpInfo: " + e.Message);
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

<a name="getcustomertraileventsforaccountpageddatetime"></a>
# **GetCustomerTrailEventsForAccountPagedDateTime**
> CustomerTrailEventPagedModelV2 GetCustomerTrailEventsForAccountPagedDateTime (string id, Guid xSymOrganizationId, string interval, GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter searchParameter = null)

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
    public class GetCustomerTrailEventsForAccountPagedDateTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermViewCustomerTrailApi(config);
            var id = "id_example";  // string | The GUID associated with the desired account
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var interval = 2022-07-01T00:00/2022-07-15T00:00;  // string | The Datetime interval must be in the following format i.e.  2022-07-01T00:00/2022-07-15T00:00
            var searchParameter = new GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter(); // GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter | Search Parameter (optional) 

            try
            {
                // Get Customer Trail events for an Account
                CustomerTrailEventPagedModelV2 result = apiInstance.GetCustomerTrailEventsForAccountPagedDateTime(id, xSymOrganizationId, interval, searchParameter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermViewCustomerTrailApi.GetCustomerTrailEventsForAccountPagedDateTime: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCustomerTrailEventsForAccountPagedDateTimeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Customer Trail events for an Account
    ApiResponse<CustomerTrailEventPagedModelV2> response = apiInstance.GetCustomerTrailEventsForAccountPagedDateTimeWithHttpInfo(id, xSymOrganizationId, interval, searchParameter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermViewCustomerTrailApi.GetCustomerTrailEventsForAccountPagedDateTimeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The GUID associated with the desired account |  |
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |
| **interval** | **string** | The Datetime interval must be in the following format i.e.  2022-07-01T00:00/2022-07-15T00:00 |  |
| **searchParameter** | [**GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter**](GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter.md) | Search Parameter | [optional]  |

### Return type

[**CustomerTrailEventPagedModelV2**](CustomerTrailEventPagedModelV2.md)

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
| **422** | Unprocessable Entity (WebDAV) |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

