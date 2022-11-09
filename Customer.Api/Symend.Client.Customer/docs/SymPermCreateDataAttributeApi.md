# Symend.Client.Customer.Api.SymPermCreateDataAttributeApi

All URIs are relative to *https://api-dev.symend.io/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDataTargetDefinition**](SymPermCreateDataAttributeApi.md#createdatatargetdefinition) | **POST** /v1/data-target-definitions | Create a new Data Target Definition |

<a name="createdatatargetdefinition"></a>
# **CreateDataTargetDefinition**
> DataTargetDefinitionModelResultModel CreateDataTargetDefinition (Guid xSymOrganizationId, DataTargetDefinitionForm dataTargetDefinitionForm = null)

Create a new Data Target Definition

Create a new attribute for use in mapping Account data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class CreateDataTargetDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-dev.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermCreateDataAttributeApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var dataTargetDefinitionForm = new DataTargetDefinitionForm(); // DataTargetDefinitionForm |  (optional) 

            try
            {
                // Create a new Data Target Definition
                DataTargetDefinitionModelResultModel result = apiInstance.CreateDataTargetDefinition(xSymOrganizationId, dataTargetDefinitionForm);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermCreateDataAttributeApi.CreateDataTargetDefinition: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDataTargetDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new Data Target Definition
    ApiResponse<DataTargetDefinitionModelResultModel> response = apiInstance.CreateDataTargetDefinitionWithHttpInfo(xSymOrganizationId, dataTargetDefinitionForm);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermCreateDataAttributeApi.CreateDataTargetDefinitionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |
| **dataTargetDefinitionForm** | [**DataTargetDefinitionForm**](DataTargetDefinitionForm.md) |  | [optional]  |

### Return type

[**DataTargetDefinitionModelResultModel**](DataTargetDefinitionModelResultModel.md)

### Authorization

[JSON_Web_Token](../README.md#JSON_Web_Token)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **422** | Client Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

