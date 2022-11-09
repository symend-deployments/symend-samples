# Symend.Client.Customer.Api.SegmentsApi

All URIs are relative to *http://api.local.symendinc.com/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CopySegment**](SegmentsApi.md#copysegment) | **POST** /v1/segments/{id}/actions/clone | Clone a segment |
| [**CreateSegment**](SegmentsApi.md#createsegment) | **POST** /v1/segments | Create a Segment |
| [**DeleteSegment**](SegmentsApi.md#deletesegment) | **DELETE** /v1/segments/{id} | Delete Segment |
| [**GetSegment**](SegmentsApi.md#getsegment) | **GET** /v1/segments/{id} | Get a Segment by Id |
| [**GetSegmentRevision**](SegmentsApi.md#getsegmentrevision) | **GET** /v1/segments/{id}/current-revision | Get the current version of a Segment |
| [**ListSegments**](SegmentsApi.md#listsegments) | **GET** /v1/segments | List Segments |
| [**PublishSegment**](SegmentsApi.md#publishsegment) | **PUT** /v1/segments/{id}/actions/publish | Publish a segment |
| [**UpdateSegment**](SegmentsApi.md#updatesegment) | **PUT** /v1/segments/{id} | Update a Segment |

<a name="copysegment"></a>
# **CopySegment**
> SegmentModelResultModel CopySegment (Guid id, Guid xSymOrganizationId, string status = null, SegmentCloneForm segmentCloneForm = null)

Clone a segment

Creates a copy of the most recent revision of a specific segment that is in a given state, as a new segment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class CopySegmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.local.symendinc.com/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SegmentsApi(config);
            var id = "id_example";  // Guid | Segment Id
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var status = "status_example";  // string | The revision state to copy, published or draft. (optional) 
            var segmentCloneForm = new SegmentCloneForm(); // SegmentCloneForm | This Segment Clone Form is optional, if you do not pass in a form. The service will default the name back to the segment revision it is copying. (optional) 

            try
            {
                // Clone a segment
                SegmentModelResultModel result = apiInstance.CopySegment(id, xSymOrganizationId, status, segmentCloneForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.CopySegment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CopySegmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Clone a segment
    ApiResponse<SegmentModelResultModel> response = apiInstance.CopySegmentWithHttpInfo(id, xSymOrganizationId, status, segmentCloneForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SegmentsApi.CopySegmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Segment Id |  |
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |
| **status** | **string** | The revision state to copy, published or draft. | [optional]  |
| **segmentCloneForm** | [**SegmentCloneForm**](SegmentCloneForm.md) | This Segment Clone Form is optional, if you do not pass in a form. The service will default the name back to the segment revision it is copying. | [optional]  |

### Return type

[**SegmentModelResultModel**](SegmentModelResultModel.md)

### Authorization

[JSON_Web_Token](../README.md#JSON_Web_Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Client Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createsegment"></a>
# **CreateSegment**
> SegmentModelResultModel CreateSegment (Guid xSymOrganizationId, SegmentForm segmentForm = null)

Create a Segment

Creates a new segment, initially in the draft state.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class CreateSegmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.local.symendinc.com/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SegmentsApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var segmentForm = new SegmentForm(); // SegmentForm |  (optional) 

            try
            {
                // Create a Segment
                SegmentModelResultModel result = apiInstance.CreateSegment(xSymOrganizationId, segmentForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.CreateSegment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSegmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Segment
    ApiResponse<SegmentModelResultModel> response = apiInstance.CreateSegmentWithHttpInfo(xSymOrganizationId, segmentForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SegmentsApi.CreateSegmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |
| **segmentForm** | [**SegmentForm**](SegmentForm.md) |  | [optional]  |

### Return type

[**SegmentModelResultModel**](SegmentModelResultModel.md)

### Authorization

[JSON_Web_Token](../README.md#JSON_Web_Token)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **422** | Client Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesegment"></a>
# **DeleteSegment**
> void DeleteSegment (Guid id, Guid xSymOrganizationId)

Delete Segment

Delete a segment by its ID. Segment cannot be in a published state.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class DeleteSegmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.local.symendinc.com/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SegmentsApi(config);
            var id = "id_example";  // Guid | Segment Id
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request

            try
            {
                // Delete Segment
                apiInstance.DeleteSegment(id, xSymOrganizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.DeleteSegment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSegmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Segment
    apiInstance.DeleteSegmentWithHttpInfo(id, xSymOrganizationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SegmentsApi.DeleteSegmentWithHttpInfo: " + e.Message);
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

void (empty response body)

### Authorization

[JSON_Web_Token](../README.md#JSON_Web_Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Client Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
            config.BasePath = "http://api.local.symendinc.com/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SegmentsApi(config);
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
                Debug.Print("Exception when calling SegmentsApi.GetSegment: " + e.Message);
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
    Debug.Print("Exception when calling SegmentsApi.GetSegmentWithHttpInfo: " + e.Message);
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
            config.BasePath = "http://api.local.symendinc.com/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SegmentsApi(config);
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
                Debug.Print("Exception when calling SegmentsApi.GetSegmentRevision: " + e.Message);
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
    Debug.Print("Exception when calling SegmentsApi.GetSegmentRevisionWithHttpInfo: " + e.Message);
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
            config.BasePath = "http://api.local.symendinc.com/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SegmentsApi(config);
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
                Debug.Print("Exception when calling SegmentsApi.ListSegments: " + e.Message);
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
    Debug.Print("Exception when calling SegmentsApi.ListSegmentsWithHttpInfo: " + e.Message);
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

<a name="publishsegment"></a>
# **PublishSegment**
> SegmentModelResultModel PublishSegment (Guid id, Guid xSymOrganizationId)

Publish a segment

Creates a copy of the most recent draft revision of a segment, setting the status of the revision to published.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class PublishSegmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.local.symendinc.com/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SegmentsApi(config);
            var id = "id_example";  // Guid | Segment Id
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request

            try
            {
                // Publish a segment
                SegmentModelResultModel result = apiInstance.PublishSegment(id, xSymOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.PublishSegment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PublishSegmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Publish a segment
    ApiResponse<SegmentModelResultModel> response = apiInstance.PublishSegmentWithHttpInfo(id, xSymOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SegmentsApi.PublishSegmentWithHttpInfo: " + e.Message);
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
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **422** | Client Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesegment"></a>
# **UpdateSegment**
> SegmentModelResultModel UpdateSegment (Guid id, Guid xSymOrganizationId, SegmentForm segmentForm = null)

Update a Segment

Performs an update on a specific segment by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class UpdateSegmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://api.local.symendinc.com/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SegmentsApi(config);
            var id = "id_example";  // Guid | Segment Id
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var segmentForm = new SegmentForm(); // SegmentForm |  (optional) 

            try
            {
                // Update a Segment
                SegmentModelResultModel result = apiInstance.UpdateSegment(id, xSymOrganizationId, segmentForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SegmentsApi.UpdateSegment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSegmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Segment
    ApiResponse<SegmentModelResultModel> response = apiInstance.UpdateSegmentWithHttpInfo(id, xSymOrganizationId, segmentForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SegmentsApi.UpdateSegmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Segment Id |  |
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |
| **segmentForm** | [**SegmentForm**](SegmentForm.md) |  | [optional]  |

### Return type

[**SegmentModelResultModel**](SegmentModelResultModel.md)

### Authorization

[JSON_Web_Token](../README.md#JSON_Web_Token)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json, application/xml
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

