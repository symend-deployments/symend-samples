# Symend.Client.Customer.Model.CursorPagingCriteria

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Limit** | **int** | The max amount of records to get per-page. | [optional] [default to 25]
**After** | **Guid?** | The cursor value used for getting the next page of records. Can not be used at the same time as &#x60;before&#x60;. | [optional] 
**Before** | **Guid?** | The cursor value used for getting the previous page of records. Can not be used at the same time as &#x60;after&#x60;. | [optional] 
**Sort** | **string** | The property name to sort the records by. Prefixed with &#x60;-&#x60; to sort by descending. | [optional] [default to "-updatedAt"]
**Count** | **bool** | An optional parameter that will return the total count of records when &#x60;true&#x60;. | [optional] [default to false]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

