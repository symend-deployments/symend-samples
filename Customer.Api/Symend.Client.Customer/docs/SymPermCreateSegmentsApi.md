# Symend.Client.Customer.Api.SymPermCreateSegmentsApi

All URIs are relative to *http://api.local.symendinc.com/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CopySegment**](SymPermCreateSegmentsApi.md#copysegment) | **POST** /v1/segments/{id}/actions/clone | Clone a segment |
| [**CreateSegment**](SymPermCreateSegmentsApi.md#createsegment) | **POST** /v1/segments | Create a Segment |

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

            var apiInstance = new SymPermCreateSegmentsApi(config);
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
                Debug.Print("Exception when calling SymPermCreateSegmentsApi.CopySegment: " + e.Message);
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
    Debug.Print("Exception when calling SymPermCreateSegmentsApi.CopySegmentWithHttpInfo: " + e.Message);
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

            var apiInstance = new SymPermCreateSegmentsApi(config);
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
                Debug.Print("Exception when calling SymPermCreateSegmentsApi.CreateSegment: " + e.Message);
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
    Debug.Print("Exception when calling SymPermCreateSegmentsApi.CreateSegmentWithHttpInfo: " + e.Message);
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

