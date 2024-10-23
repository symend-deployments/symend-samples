# Symend.Client.Customer.Api.DataTargetDefinitionsApi

All URIs are relative to *https://api.symend.io/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDataTargetDefinition**](DataTargetDefinitionsApi.md#createdatatargetdefinition) | **POST** /v1/data-target-definitions | Create a new Data Target Definition |
| [**GetDataTargetDefinition**](DataTargetDefinitionsApi.md#getdatatargetdefinition) | **GET** /v1/data-target-definitions/{dataTargetDefinitionId} | Get Data Target Definition by Id |
| [**GetDataTargetDefinitions**](DataTargetDefinitionsApi.md#getdatatargetdefinitions) | **GET** /v1/data-target-definitions | List of Data Target Definitions |
| [**GetDataTargetDefinitionsDictionary**](DataTargetDefinitionsApi.md#getdatatargetdefinitionsdictionary) | **GET** /v1/data-target-definitions/dictionary | List of Data Target Definitions (dictionary) |

<a id="createdatatargetdefinition"></a>
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
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DataTargetDefinitionsApi(config);
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
                Debug.Print("Exception when calling DataTargetDefinitionsApi.CreateDataTargetDefinition: " + e.Message);
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
    Debug.Print("Exception when calling DataTargetDefinitionsApi.CreateDataTargetDefinitionWithHttpInfo: " + e.Message);
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

<a id="getdatatargetdefinition"></a>
# **GetDataTargetDefinition**
> DataTargetDefinitionModelResultModel GetDataTargetDefinition (Guid dataTargetDefinitionId, Guid xSymOrganizationId)

Get Data Target Definition by Id

Returns a specific data attribute by its ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class GetDataTargetDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DataTargetDefinitionsApi(config);
            var dataTargetDefinitionId = "dataTargetDefinitionId_example";  // Guid | Data Target Definition Id
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request

            try
            {
                // Get Data Target Definition by Id
                DataTargetDefinitionModelResultModel result = apiInstance.GetDataTargetDefinition(dataTargetDefinitionId, xSymOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataTargetDefinitionsApi.GetDataTargetDefinition: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataTargetDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Data Target Definition by Id
    ApiResponse<DataTargetDefinitionModelResultModel> response = apiInstance.GetDataTargetDefinitionWithHttpInfo(dataTargetDefinitionId, xSymOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataTargetDefinitionsApi.GetDataTargetDefinitionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dataTargetDefinitionId** | **Guid** | Data Target Definition Id |  |
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |

### Return type

[**DataTargetDefinitionModelResultModel**](DataTargetDefinitionModelResultModel.md)

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
| **422** | Client Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdatatargetdefinitions"></a>
# **GetDataTargetDefinitions**
> DataTargetDefinitionSearchResultGuidPagedModel GetDataTargetDefinitions (Guid xSymOrganizationId, GetDataTargetDefinitionsDataTargetDefinitionSearchCriteriaParameter dataTargetDefinitionSearchCriteria = null, GuidPagedMetadata paging = null)

List of Data Target Definitions

Returns a list of all possible attributes for an Account in a list format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class GetDataTargetDefinitionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DataTargetDefinitionsApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var dataTargetDefinitionSearchCriteria = new GetDataTargetDefinitionsDataTargetDefinitionSearchCriteriaParameter(); // GetDataTargetDefinitionsDataTargetDefinitionSearchCriteriaParameter | Data Target Definition Search Criteria (optional) 
            var paging = new GuidPagedMetadata(); // GuidPagedMetadata | Paging Criteria (optional) 

            try
            {
                // List of Data Target Definitions
                DataTargetDefinitionSearchResultGuidPagedModel result = apiInstance.GetDataTargetDefinitions(xSymOrganizationId, dataTargetDefinitionSearchCriteria, paging);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataTargetDefinitionsApi.GetDataTargetDefinitions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataTargetDefinitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List of Data Target Definitions
    ApiResponse<DataTargetDefinitionSearchResultGuidPagedModel> response = apiInstance.GetDataTargetDefinitionsWithHttpInfo(xSymOrganizationId, dataTargetDefinitionSearchCriteria, paging);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataTargetDefinitionsApi.GetDataTargetDefinitionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |
| **dataTargetDefinitionSearchCriteria** | [**GetDataTargetDefinitionsDataTargetDefinitionSearchCriteriaParameter**](GetDataTargetDefinitionsDataTargetDefinitionSearchCriteriaParameter.md) | Data Target Definition Search Criteria | [optional]  |
| **paging** | [**GuidPagedMetadata**](GuidPagedMetadata.md) | Paging Criteria | [optional]  |

### Return type

[**DataTargetDefinitionSearchResultGuidPagedModel**](DataTargetDefinitionSearchResultGuidPagedModel.md)

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

<a id="getdatatargetdefinitionsdictionary"></a>
# **GetDataTargetDefinitionsDictionary**
> GuidDataTargetDefinitionDictionaryModelIDictionaryResultModel GetDataTargetDefinitionsDictionary (Guid xSymOrganizationId)

List of Data Target Definitions (dictionary)

Returns a list of all possible attributes for an Account in a dictionary format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class GetDataTargetDefinitionsDictionaryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DataTargetDefinitionsApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request

            try
            {
                // List of Data Target Definitions (dictionary)
                GuidDataTargetDefinitionDictionaryModelIDictionaryResultModel result = apiInstance.GetDataTargetDefinitionsDictionary(xSymOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataTargetDefinitionsApi.GetDataTargetDefinitionsDictionary: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataTargetDefinitionsDictionaryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List of Data Target Definitions (dictionary)
    ApiResponse<GuidDataTargetDefinitionDictionaryModelIDictionaryResultModel> response = apiInstance.GetDataTargetDefinitionsDictionaryWithHttpInfo(xSymOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataTargetDefinitionsApi.GetDataTargetDefinitionsDictionaryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |

### Return type

[**GuidDataTargetDefinitionDictionaryModelIDictionaryResultModel**](GuidDataTargetDefinitionDictionaryModelIDictionaryResultModel.md)

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

