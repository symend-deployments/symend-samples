# Symend.Client.Customer.Api.SymPermPublishSegmentsApi

All URIs are relative to *https://api.symend.io/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PublishSegment**](SymPermPublishSegmentsApi.md#publishsegment) | **PUT** /v1/segments/{id}/actions/publish | Publish a segment |

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
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermPublishSegmentsApi(config);
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
                Debug.Print("Exception when calling SymPermPublishSegmentsApi.PublishSegment: " + e.Message);
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
    Debug.Print("Exception when calling SymPermPublishSegmentsApi.PublishSegmentWithHttpInfo: " + e.Message);
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

