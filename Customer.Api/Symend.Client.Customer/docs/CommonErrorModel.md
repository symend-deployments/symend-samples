# Symend.Client.Customer.Model.CommonErrorModel
Error model for non-success responses.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | Server-defined error code | 
**Message** | **string** | Human-readable representation of the error. | 
**Severity** | **string** | The severity of the error. One of &#x60;critical&#x60;, &#x60;warning&#x60;, or &#x60;information&#x60;. | 
**TraceId** | **string** | Distributed trace ID of the request. | [optional] 
**Details** | [**List&lt;CommonErrorDetail&gt;**](CommonErrorDetail.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

