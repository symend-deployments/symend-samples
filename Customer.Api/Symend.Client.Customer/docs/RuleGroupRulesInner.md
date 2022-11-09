# Symend.Client.Customer.Model.RuleGroupRulesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] [default to TypeEnum.Group]
**Field** | **Guid** |  | [optional] 
**Operator** | **string** |  | [optional] 
**Value** | **Object** | Value to check against the operation. Value is now expected to be of the Native Type of the Data Target Definition.  i.e. If your Data Target Definition is a Number A value of: 10 will pass. While a value of \&quot;10\&quot; will fail on publish due to the value not matching the correct data type.  Possible Special Key Values for Specific Data Target Definition Data Type: - Datetime   - {{TODAY}} - This should be evaluated as the today date on evaluation of the rule during RUN TIME (NOT on publish during DESIGN TIME)    Values for Specific Data Target Definition Data Types - Datetime   - isBeforeToday - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - isAfterToday - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - wasInTheLast - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - wasNotInTheLast - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - isInTheNext - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - isNotInTheNext - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed. | [optional] 
**ValueType** | **string** |  | [optional] 
**Condition** | **string** |  | [optional] 
**Rules** | [**List&lt;RuleGroupRulesInner&gt;**](RuleGroupRulesInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

