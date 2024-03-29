# Symend.Client.Customer - the C# library for the Customer Service API

API for Customer Domain Operations

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: v1
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://github.com/symend-deployments/symend](https://github.com/symend-deployments/symend)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.symend.io/customer";
            // Configure Bearer token for authorization: JSON_Web_Token
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AccountsApi(config);
            var xSymOrganizationId = 51840c3a-4bb9-4b4a-b8d9-0ca1f93a76a7;  // Guid | Organization UUID of the client making the request
            var accountForm = new AccountForm(); // AccountForm | Body contains list of properties which are key-value pairs. The keys are attribute IDs as seen in the data-target-defintions endpoint. (optional) 

            try
            {
                // Create/Update Accounts
                AccountResponseResultModel result = apiInstance.CreateUpdateAccount(xSymOrganizationId, accountForm);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountsApi.CreateUpdateAccount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.symend.io/customer*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountsApi* | [**CreateUpdateAccount**](docs\AccountsApi.md#createupdateaccount) | **PUT** /v1/accounts | Create/Update Accounts
*AccountsApi* | [**GetAccount**](docs\AccountsApi.md#getaccount) | **GET** /v1/accounts/{id} | Get an Account by Id
*AccountsApi* | [**ListAccountSummary**](docs\AccountsApi.md#listaccountsummary) | **GET** /v1/accounts/actions/get-summary-list | List Account Summary
*AccountsApi* | [**ListAccounts**](docs\AccountsApi.md#listaccounts) | **GET** /v1/accounts | List Accounts
*AccountsApi* | [**UpdateAccount**](docs\AccountsApi.md#updateaccount) | **PATCH** /v1/accounts/{id} | Update an Account
*AccountsApi* | [**UpdateAccountSync**](docs\AccountsApi.md#updateaccountsync) | **PATCH** /v1/accounts/{id}/actions/update-immediate | Update an Account synchronously
*CustomerTrailApi* | [**GetAttributeValuesByEventId**](docs\CustomerTrailApi.md#getattributevaluesbyeventid) | **GET** /v1/customer-trail-events/{eventId} | This endpoint returns the attributes to the event id
*CustomerTrailApi* | [**GetCustomerEventsByAccountKey**](docs\CustomerTrailApi.md#getcustomereventsbyaccountkey) | **GET** /v1/accounts/customer-trail-events | Get Customer Trail events for an Account by Account Key
*CustomerTrailApi* | [**GetCustomerEventsByAccountKeyOrderByDateTime**](docs\CustomerTrailApi.md#getcustomereventsbyaccountkeyorderbydatetime) | **GET** /v2/accounts/customer-trail-events | Get Customer Trail events for an Account by Account Key
*CustomerTrailApi* | [**GetCustomerTrailEventsForAccount**](docs\CustomerTrailApi.md#getcustomertraileventsforaccount) | **GET** /v1/accounts/{id}/customer-trail-events | Get Customer Trail events for an Account
*CustomerTrailApi* | [**GetCustomerTrailEventsForAccountPagedDateTime**](docs\CustomerTrailApi.md#getcustomertraileventsforaccountpageddatetime) | **GET** /v2/accounts/{id}/customer-trail-events | Get Customer Trail events for an Account
*CustomerTrailApi* | [**GetCustomerTrailOptions**](docs\CustomerTrailApi.md#getcustomertrailoptions) | **GET** /v1/customer-trail-options | Get Customer Trail options
*DataCategoriesApi* | [**GetDataCategories**](docs\DataCategoriesApi.md#getdatacategories) | **GET** /v1/data-categories | List Data Categories
*DataTargetDefinitionsApi* | [**CreateDataTargetDefinition**](docs\DataTargetDefinitionsApi.md#createdatatargetdefinition) | **POST** /v1/data-target-definitions | Create a new Data Target Definition
*DataTargetDefinitionsApi* | [**GetDataTargetDefinition**](docs\DataTargetDefinitionsApi.md#getdatatargetdefinition) | **GET** /v1/data-target-definitions/{dataTargetDefinitionId} | Get Data Target Definition by Id
*DataTargetDefinitionsApi* | [**GetDataTargetDefinitions**](docs\DataTargetDefinitionsApi.md#getdatatargetdefinitions) | **GET** /v1/data-target-definitions | List of Data Target Definitions
*DataTargetDefinitionsApi* | [**GetDataTargetDefinitionsDictionary**](docs\DataTargetDefinitionsApi.md#getdatatargetdefinitionsdictionary) | **GET** /v1/data-target-definitions/dictionary | List of Data Target Definitions (dictionary)
*ListEventTypesApi* | [**ListCustomerTrailEventTypes**](docs\ListEventTypesApi.md#listcustomertraileventtypes) | **GET** /v1/customer-trail-event-types | GET Customer Trail event types
*SegmentsApi* | [**CopySegment**](docs\SegmentsApi.md#copysegment) | **POST** /v1/segments/{id}/actions/clone | Clone a segment
*SegmentsApi* | [**CreateSegment**](docs\SegmentsApi.md#createsegment) | **POST** /v1/segments | Create a Segment
*SegmentsApi* | [**DeleteSegment**](docs\SegmentsApi.md#deletesegment) | **DELETE** /v1/segments/{id} | Delete Segment
*SegmentsApi* | [**GetSegment**](docs\SegmentsApi.md#getsegment) | **GET** /v1/segments/{id} | Get a Segment by Id
*SegmentsApi* | [**GetSegmentRevision**](docs\SegmentsApi.md#getsegmentrevision) | **GET** /v1/segments/{id}/current-revision | Get the current version of a Segment
*SegmentsApi* | [**ListSegments**](docs\SegmentsApi.md#listsegments) | **GET** /v1/segments | List Segments
*SegmentsApi* | [**PublishSegment**](docs\SegmentsApi.md#publishsegment) | **PUT** /v1/segments/{id}/actions/publish | Publish a segment
*SegmentsApi* | [**UpdateSegment**](docs\SegmentsApi.md#updatesegment) | **PUT** /v1/segments/{id} | Update a Segment
*SymPermCreateAccountApi* | [**CreateUpdateAccount**](docs\SymPermCreateAccountApi.md#createupdateaccount) | **PUT** /v1/accounts | Create/Update Accounts
*SymPermCreateDataAttributeApi* | [**CreateDataTargetDefinition**](docs\SymPermCreateDataAttributeApi.md#createdatatargetdefinition) | **POST** /v1/data-target-definitions | Create a new Data Target Definition
*SymPermCreateSegmentsApi* | [**CopySegment**](docs\SymPermCreateSegmentsApi.md#copysegment) | **POST** /v1/segments/{id}/actions/clone | Clone a segment
*SymPermCreateSegmentsApi* | [**CreateSegment**](docs\SymPermCreateSegmentsApi.md#createsegment) | **POST** /v1/segments | Create a Segment
*SymPermDeleteSegmentsApi* | [**DeleteSegment**](docs\SymPermDeleteSegmentsApi.md#deletesegment) | **DELETE** /v1/segments/{id} | Delete Segment
*SymPermPublishSegmentsApi* | [**PublishSegment**](docs\SymPermPublishSegmentsApi.md#publishsegment) | **PUT** /v1/segments/{id}/actions/publish | Publish a segment
*SymPermUpdateAccountApi* | [**UpdateAccount**](docs\SymPermUpdateAccountApi.md#updateaccount) | **PATCH** /v1/accounts/{id} | Update an Account
*SymPermUpdateAccountSyncApi* | [**UpdateAccountSync**](docs\SymPermUpdateAccountSyncApi.md#updateaccountsync) | **PATCH** /v1/accounts/{id}/actions/update-immediate | Update an Account synchronously
*SymPermUpdateSegmentsApi* | [**UpdateSegment**](docs\SymPermUpdateSegmentsApi.md#updatesegment) | **PUT** /v1/segments/{id} | Update a Segment
*SymPermViewAccountsApi* | [**GetAccount**](docs\SymPermViewAccountsApi.md#getaccount) | **GET** /v1/accounts/{id} | Get an Account by Id
*SymPermViewAccountsApi* | [**ListAccountSummary**](docs\SymPermViewAccountsApi.md#listaccountsummary) | **GET** /v1/accounts/actions/get-summary-list | List Account Summary
*SymPermViewAccountsApi* | [**ListAccounts**](docs\SymPermViewAccountsApi.md#listaccounts) | **GET** /v1/accounts | List Accounts
*SymPermViewCustomerTrailApi* | [**GetAttributeValuesByEventId**](docs\SymPermViewCustomerTrailApi.md#getattributevaluesbyeventid) | **GET** /v1/customer-trail-events/{eventId} | This endpoint returns the attributes to the event id
*SymPermViewCustomerTrailApi* | [**GetCustomerEventsByAccountKey**](docs\SymPermViewCustomerTrailApi.md#getcustomereventsbyaccountkey) | **GET** /v1/accounts/customer-trail-events | Get Customer Trail events for an Account by Account Key
*SymPermViewCustomerTrailApi* | [**GetCustomerEventsByAccountKeyOrderByDateTime**](docs\SymPermViewCustomerTrailApi.md#getcustomereventsbyaccountkeyorderbydatetime) | **GET** /v2/accounts/customer-trail-events | Get Customer Trail events for an Account by Account Key
*SymPermViewCustomerTrailApi* | [**GetCustomerTrailEventsForAccount**](docs\SymPermViewCustomerTrailApi.md#getcustomertraileventsforaccount) | **GET** /v1/accounts/{id}/customer-trail-events | Get Customer Trail events for an Account
*SymPermViewCustomerTrailApi* | [**GetCustomerTrailEventsForAccountPagedDateTime**](docs\SymPermViewCustomerTrailApi.md#getcustomertraileventsforaccountpageddatetime) | **GET** /v2/accounts/{id}/customer-trail-events | Get Customer Trail events for an Account
*SymPermViewDataAttributesApi* | [**GetDataCategories**](docs\SymPermViewDataAttributesApi.md#getdatacategories) | **GET** /v1/data-categories | List Data Categories
*SymPermViewDataAttributesApi* | [**GetDataTargetDefinition**](docs\SymPermViewDataAttributesApi.md#getdatatargetdefinition) | **GET** /v1/data-target-definitions/{dataTargetDefinitionId} | Get Data Target Definition by Id
*SymPermViewDataAttributesApi* | [**GetDataTargetDefinitions**](docs\SymPermViewDataAttributesApi.md#getdatatargetdefinitions) | **GET** /v1/data-target-definitions | List of Data Target Definitions
*SymPermViewDataAttributesApi* | [**GetDataTargetDefinitionsDictionary**](docs\SymPermViewDataAttributesApi.md#getdatatargetdefinitionsdictionary) | **GET** /v1/data-target-definitions/dictionary | List of Data Target Definitions (dictionary)
*SymPermViewMappingApi* | [**GetCustomerTrailOptions**](docs\SymPermViewMappingApi.md#getcustomertrailoptions) | **GET** /v1/customer-trail-options | Get Customer Trail options
*SymPermViewMappingApi* | [**ListCustomerTrailEventTypes**](docs\SymPermViewMappingApi.md#listcustomertraileventtypes) | **GET** /v1/customer-trail-event-types | GET Customer Trail event types
*SymPermViewSegmentsApi* | [**GetSegment**](docs\SymPermViewSegmentsApi.md#getsegment) | **GET** /v1/segments/{id} | Get a Segment by Id
*SymPermViewSegmentsApi* | [**GetSegmentRevision**](docs\SymPermViewSegmentsApi.md#getsegmentrevision) | **GET** /v1/segments/{id}/current-revision | Get the current version of a Segment
*SymPermViewSegmentsApi* | [**ListSegments**](docs\SymPermViewSegmentsApi.md#listsegments) | **GET** /v1/segments | List Segments


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountAttributeResponseModel](docs\AccountAttributeResponseModel.md)
 - [Model.AccountExtendedModel](docs\AccountExtendedModel.md)
 - [Model.AccountExtendedModelResultModel](docs\AccountExtendedModelResultModel.md)
 - [Model.AccountForm](docs\AccountForm.md)
 - [Model.AccountFormAttributesInner](docs\AccountFormAttributesInner.md)
 - [Model.AccountResponse](docs\AccountResponse.md)
 - [Model.AccountResponseResultModel](docs\AccountResponseResultModel.md)
 - [Model.AccountSearchOption](docs\AccountSearchOption.md)
 - [Model.AccountSearchOptionModel](docs\AccountSearchOptionModel.md)
 - [Model.AccountSearchResult](docs\AccountSearchResult.md)
 - [Model.AccountSearchResultGuidPagedModel](docs\AccountSearchResultGuidPagedModel.md)
 - [Model.AccountSummarySearchResult](docs\AccountSummarySearchResult.md)
 - [Model.AccountSummarySearchResultGuidPagedModel](docs\AccountSummarySearchResultGuidPagedModel.md)
 - [Model.CommonErrorDetail](docs\CommonErrorDetail.md)
 - [Model.CommonErrorModel](docs\CommonErrorModel.md)
 - [Model.CommonReferenceLink](docs\CommonReferenceLink.md)
 - [Model.CustomerAttribute](docs\CustomerAttribute.md)
 - [Model.CustomerAttributeBoolean](docs\CustomerAttributeBoolean.md)
 - [Model.CustomerAttributeBooleanList](docs\CustomerAttributeBooleanList.md)
 - [Model.CustomerAttributeDateTime](docs\CustomerAttributeDateTime.md)
 - [Model.CustomerAttributeDateTimeList](docs\CustomerAttributeDateTimeList.md)
 - [Model.CustomerAttributeGuid](docs\CustomerAttributeGuid.md)
 - [Model.CustomerAttributeGuidList](docs\CustomerAttributeGuidList.md)
 - [Model.CustomerAttributeInteger](docs\CustomerAttributeInteger.md)
 - [Model.CustomerAttributeIntegerList](docs\CustomerAttributeIntegerList.md)
 - [Model.CustomerAttributeNumber](docs\CustomerAttributeNumber.md)
 - [Model.CustomerAttributeNumberList](docs\CustomerAttributeNumberList.md)
 - [Model.CustomerAttributeString](docs\CustomerAttributeString.md)
 - [Model.CustomerAttributeStringList](docs\CustomerAttributeStringList.md)
 - [Model.CustomerTrailAttributeTypeModel](docs\CustomerTrailAttributeTypeModel.md)
 - [Model.CustomerTrailAttributeValueModel](docs\CustomerTrailAttributeValueModel.md)
 - [Model.CustomerTrailAttributeValueModelValue](docs\CustomerTrailAttributeValueModelValue.md)
 - [Model.CustomerTrailEventAttributeValueModel](docs\CustomerTrailEventAttributeValueModel.md)
 - [Model.CustomerTrailEventAttributeValueResultModel](docs\CustomerTrailEventAttributeValueResultModel.md)
 - [Model.CustomerTrailEventModel](docs\CustomerTrailEventModel.md)
 - [Model.CustomerTrailEventModelV2](docs\CustomerTrailEventModelV2.md)
 - [Model.CustomerTrailEventPagedModel](docs\CustomerTrailEventPagedModel.md)
 - [Model.CustomerTrailEventPagedModelV2](docs\CustomerTrailEventPagedModelV2.md)
 - [Model.CustomerTrailEventTypeCategory](docs\CustomerTrailEventTypeCategory.md)
 - [Model.CustomerTrailEventTypeCollectionModel](docs\CustomerTrailEventTypeCollectionModel.md)
 - [Model.CustomerTrailEventTypeModel](docs\CustomerTrailEventTypeModel.md)
 - [Model.CustomerTrailOptionModel](docs\CustomerTrailOptionModel.md)
 - [Model.DataTargetDefinitionCategory](docs\DataTargetDefinitionCategory.md)
 - [Model.DataTargetDefinitionDataType](docs\DataTargetDefinitionDataType.md)
 - [Model.DataTargetDefinitionDictionaryModel](docs\DataTargetDefinitionDictionaryModel.md)
 - [Model.DataTargetDefinitionForm](docs\DataTargetDefinitionForm.md)
 - [Model.DataTargetDefinitionModel](docs\DataTargetDefinitionModel.md)
 - [Model.DataTargetDefinitionModelResultModel](docs\DataTargetDefinitionModelResultModel.md)
 - [Model.DataTargetDefinitionSearchResultGuidPagedModel](docs\DataTargetDefinitionSearchResultGuidPagedModel.md)
 - [Model.DataTargetDefinitionStructureType](docs\DataTargetDefinitionStructureType.md)
 - [Model.DateTimePagedMetadata](docs\DateTimePagedMetadata.md)
 - [Model.EventCategoryOptionModel](docs\EventCategoryOptionModel.md)
 - [Model.GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter](docs\GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter.md)
 - [Model.GetCustomerTrailEventsForAccountSearchParameterParameter](docs\GetCustomerTrailEventsForAccountSearchParameterParameter.md)
 - [Model.GetDataTargetDefinitionsDataTargetDefinitionSearchCriteriaParameter](docs\GetDataTargetDefinitionsDataTargetDefinitionSearchCriteriaParameter.md)
 - [Model.GuidDataTargetDefinitionDictionaryModelIDictionaryResultModel](docs\GuidDataTargetDefinitionDictionaryModelIDictionaryResultModel.md)
 - [Model.GuidPagedMetadata](docs\GuidPagedMetadata.md)
 - [Model.OrderBy](docs\OrderBy.md)
 - [Model.PublishState](docs\PublishState.md)
 - [Model.Rule](docs\Rule.md)
 - [Model.RuleGroup](docs\RuleGroup.md)
 - [Model.RuleGroupRulesInner](docs\RuleGroupRulesInner.md)
 - [Model.Segment](docs\Segment.md)
 - [Model.SegmentCloneForm](docs\SegmentCloneForm.md)
 - [Model.SegmentForm](docs\SegmentForm.md)
 - [Model.SegmentFormRules](docs\SegmentFormRules.md)
 - [Model.SegmentGuidPagedModel](docs\SegmentGuidPagedModel.md)
 - [Model.SegmentModel](docs\SegmentModel.md)
 - [Model.SegmentModelResultModel](docs\SegmentModelResultModel.md)
 - [Model.SegmentRevisionModel](docs\SegmentRevisionModel.md)
 - [Model.SegmentRevisionModelResultModel](docs\SegmentRevisionModelResultModel.md)
 - [Model.SegmentRevisionModelRules](docs\SegmentRevisionModelRules.md)
 - [Model.SegmentRevisionSummaryModel](docs\SegmentRevisionSummaryModel.md)
 - [Model.SegmentSummaryModel](docs\SegmentSummaryModel.md)
 - [Model.StringIEnumerableResultModel](docs\StringIEnumerableResultModel.md)
 - [Model.StringIEnumerableResultModelDataInner](docs\StringIEnumerableResultModelDataInner.md)
 - [Model.UserModel](docs\UserModel.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="JSON_Web_Token"></a>
### JSON_Web_Token

- **Type**: Bearer Authentication

