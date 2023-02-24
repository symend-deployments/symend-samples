# Symend.Client.Customer.Api.SymPermViewSegmentsApi

All URIs are relative to *https://api.symend.io/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetSegment**](SymPermViewSegmentsApi.md#getsegment) | **GET** /v1/segments/{id} | Get a Segment by Id |
| [**GetSegmentRevision**](SymPermViewSegmentsApi.md#getsegmentrevision) | **GET** /v1/segments/{id}/current-revision | Get the current version of a Segment |
| [**ListSegments**](SymPermViewSegmentsApi.md#listsegments) | **GET** /v1/segments | List Segments |

<a name="getsegment"></a>
# **GetSegment**
> SegmentModelResultModel GetSegment (Guid id, Guid xSymOrganizationId)

Get a Segment by Id

Returns a specific segment by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class GetSegmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermViewSegmentsApi(config);
            var id = "id_example";  // Guid | Segment Id
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request

            try
            {
                // Get a Segment by Id
                SegmentModelResultModel result = apiInstance.GetSegment(id, xSymOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermViewSegmentsApi.GetSegment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSegmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Segment by Id
    ApiResponse<SegmentModelResultModel> response = apiInstance.GetSegmentWithHttpInfo(id, xSymOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermViewSegmentsApi.GetSegmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Segment Id |  |
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |

### Return type

[**SegmentModelResultModel**](SegmentModelResultModel.md)

### Authorization

[JSON_Web_Token](../README.md#JSON_Web_Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Client Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsegmentrevision"></a>
# **GetSegmentRevision**
> SegmentRevisionModelResultModel GetSegmentRevision (Guid id, Guid xSymOrganizationId, string status = null)

Get the current version of a Segment

Returns the latest revision of a specific segment by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class GetSegmentRevisionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermViewSegmentsApi(config);
            var id = "id_example";  // Guid | Segment Id
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var status = "status_example";  // string | Segment Status (optional) 

            try
            {
                // Get the current version of a Segment
                SegmentRevisionModelResultModel result = apiInstance.GetSegmentRevision(id, xSymOrganizationId, status);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermViewSegmentsApi.GetSegmentRevision: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSegmentRevisionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the current version of a Segment
    ApiResponse<SegmentRevisionModelResultModel> response = apiInstance.GetSegmentRevisionWithHttpInfo(id, xSymOrganizationId, status);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermViewSegmentsApi.GetSegmentRevisionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Segment Id |  |
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |
| **status** | **string** | Segment Status | [optional]  |

### Return type

[**SegmentRevisionModelResultModel**](SegmentRevisionModelResultModel.md)

### Authorization

[JSON_Web_Token](../README.md#JSON_Web_Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Client Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsegments"></a>
# **ListSegments**
> SegmentGuidPagedModel ListSegments (Guid xSymOrganizationId, int? limit = null, string direction = null, string orderByAttribute = null, string orderByLastValue = null, Guid? cursor = null)

List Segments

Returns a paginated list of all segments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class ListSegmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermViewSegmentsApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var limit = 56;  // int? | The maximum number of segments per page. (optional) 
            var direction = "direction_example";  // string | The ordering direction of the results, ascending (default) or descending (optional) 
            var orderByAttribute = "orderByAttribute_example";  // string | The segment attribute to sort the results by. (optional) 
            var orderByLastValue = "orderByLastValue_example";  // string | Inherited, unused. (optional) 
            var cursor = "cursor_example";  // Guid? | The ID of the last segment on the previous page, leave empty to fetch first page. (optional) 

            try
            {
                // List Segments
                SegmentGuidPagedModel result = apiInstance.ListSegments(xSymOrganizationId, limit, direction, orderByAttribute, orderByLastValue, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermViewSegmentsApi.ListSegments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSegmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Segments
    ApiResponse<SegmentGuidPagedModel> response = apiInstance.ListSegmentsWithHttpInfo(xSymOrganizationId, limit, direction, orderByAttribute, orderByLastValue, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermViewSegmentsApi.ListSegmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |
| **limit** | **int?** | The maximum number of segments per page. | [optional]  |
| **direction** | **string** | The ordering direction of the results, ascending (default) or descending | [optional]  |
| **orderByAttribute** | **string** | The segment attribute to sort the results by. | [optional]  |
| **orderByLastValue** | **string** | Inherited, unused. | [optional]  |
| **cursor** | **Guid?** | The ID of the last segment on the previous page, leave empty to fetch first page. | [optional]  |

### Return type

[**SegmentGuidPagedModel**](SegmentGuidPagedModel.md)

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

