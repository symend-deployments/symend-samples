# Symend.Client.Customer.Api.SymPermUpdateSegmentsApi

All URIs are relative to *http://api.local.symendinc.com/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UpdateSegment**](SymPermUpdateSegmentsApi.md#updatesegment) | **PUT** /v1/segments/{id} | Update a Segment |

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

            var apiInstance = new SymPermUpdateSegmentsApi(config);
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
                Debug.Print("Exception when calling SymPermUpdateSegmentsApi.UpdateSegment: " + e.Message);
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
    Debug.Print("Exception when calling SymPermUpdateSegmentsApi.UpdateSegmentWithHttpInfo: " + e.Message);
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

