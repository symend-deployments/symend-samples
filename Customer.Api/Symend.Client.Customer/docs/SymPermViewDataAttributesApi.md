# Symend.Client.Customer.Api.SymPermViewDataAttributesApi

All URIs are relative to *https://api.symend.io/customer*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetDataCategories**](SymPermViewDataAttributesApi.md#getdatacategories) | **GET** /v1/data-categories | List Data Categories |
| [**GetDataTargetDefinition**](SymPermViewDataAttributesApi.md#getdatatargetdefinition) | **GET** /v1/data-target-definitions/{dataTargetDefinitionId} | Get Data Target Definition by Id |
| [**GetDataTargetDefinitions**](SymPermViewDataAttributesApi.md#getdatatargetdefinitions) | **GET** /v1/data-target-definitions | List of Data Target Definitions |
| [**GetDataTargetDefinitionsDictionary**](SymPermViewDataAttributesApi.md#getdatatargetdefinitionsdictionary) | **GET** /v1/data-target-definitions/dictionary | List of Data Target Definitions (dictionary) |

<a name="getdatacategories"></a>
# **GetDataCategories**
> StringIEnumerableResultModel GetDataCategories (Guid xSymOrganizationId)

List Data Categories

Returns the list of enumerated types to be used as a Category in the data-target-definitions endpoints.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class GetDataCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new SymPermViewDataAttributesApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request

            try
            {
                // List Data Categories
                StringIEnumerableResultModel result = apiInstance.GetDataCategories(xSymOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermViewDataAttributesApi.GetDataCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Data Categories
    ApiResponse<StringIEnumerableResultModel> response = apiInstance.GetDataCategoriesWithHttpInfo(xSymOrganizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymPermViewDataAttributesApi.GetDataCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xSymOrganizationId** | **Guid** | Organization UUID of the client making the request |  |

### Return type

[**StringIEnumerableResultModel**](StringIEnumerableResultModel.md)

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

<a name="getdatatargetdefinition"></a>
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

            var apiInstance = new SymPermViewDataAttributesApi(config);
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
                Debug.Print("Exception when calling SymPermViewDataAttributesApi.GetDataTargetDefinition: " + e.Message);
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
    Debug.Print("Exception when calling SymPermViewDataAttributesApi.GetDataTargetDefinitionWithHttpInfo: " + e.Message);
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

<a name="getdatatargetdefinitions"></a>
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

            var apiInstance = new SymPermViewDataAttributesApi(config);
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
                Debug.Print("Exception when calling SymPermViewDataAttributesApi.GetDataTargetDefinitions: " + e.Message);
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
    Debug.Print("Exception when calling SymPermViewDataAttributesApi.GetDataTargetDefinitionsWithHttpInfo: " + e.Message);
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

<a name="getdatatargetdefinitionsdictionary"></a>
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

            var apiInstance = new SymPermViewDataAttributesApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request

            try
            {
                // List of Data Target Definitions (dictionary)
                GuidDataTargetDefinitionDictionaryModelIDictionaryResultModel result = apiInstance.GetDataTargetDefinitionsDictionary(xSymOrganizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymPermViewDataAttributesApi.GetDataTargetDefinitionsDictionary: " + e.Message);
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
    Debug.Print("Exception when calling SymPermViewDataAttributesApi.GetDataTargetDefinitionsDictionaryWithHttpInfo: " + e.Message);
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

