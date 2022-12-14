/*
 * Customer Service API
 *
 * API for Customer Domain Operations
 *
 * The version of the OpenAPI document: v1
 * Contact: support@symend.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Symend.Client.Customer.Client.OpenAPIDateConverter;

namespace Symend.Client.Customer.Model
{
    /// <summary>
    /// Rule
    /// </summary>
    [DataContract(Name = "Rule")]
    public partial class Rule : IEquatable<Rule>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Definition for value: Definition
            /// </summary>
            [EnumMember(Value = "Definition")]
            Definition = 1

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Defines Operator
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum Is for value: is
            /// </summary>
            [EnumMember(Value = "is")]
            Is = 2,

            /// <summary>
            /// Enum IsNot for value: isNot
            /// </summary>
            [EnumMember(Value = "isNot")]
            IsNot = 3,

            /// <summary>
            /// Enum LessThan for value: lessThan
            /// </summary>
            [EnumMember(Value = "lessThan")]
            LessThan = 4,

            /// <summary>
            /// Enum LessThanOrEqual for value: lessThanOrEqual
            /// </summary>
            [EnumMember(Value = "lessThanOrEqual")]
            LessThanOrEqual = 5,

            /// <summary>
            /// Enum GreaterThan for value: greaterThan
            /// </summary>
            [EnumMember(Value = "greaterThan")]
            GreaterThan = 6,

            /// <summary>
            /// Enum GreaterThanOrEqual for value: greaterThanOrEqual
            /// </summary>
            [EnumMember(Value = "greaterThanOrEqual")]
            GreaterThanOrEqual = 7,

            /// <summary>
            /// Enum Contains for value: contains
            /// </summary>
            [EnumMember(Value = "contains")]
            Contains = 8,

            /// <summary>
            /// Enum DoesNotContain for value: doesNotContain
            /// </summary>
            [EnumMember(Value = "doesNotContain")]
            DoesNotContain = 9,

            /// <summary>
            /// Enum IsEmpty for value: isEmpty
            /// </summary>
            [EnumMember(Value = "isEmpty")]
            IsEmpty = 10,

            /// <summary>
            /// Enum IsNotEmpty for value: isNotEmpty
            /// </summary>
            [EnumMember(Value = "isNotEmpty")]
            IsNotEmpty = 11,

            /// <summary>
            /// Enum IsToday for value: isToday
            /// </summary>
            [EnumMember(Value = "isToday")]
            IsToday = 12,

            /// <summary>
            /// Enum IsNotToday for value: isNotToday
            /// </summary>
            [EnumMember(Value = "isNotToday")]
            IsNotToday = 13,

            /// <summary>
            /// Enum IsBeforeToday for value: isBeforeToday
            /// </summary>
            [EnumMember(Value = "isBeforeToday")]
            IsBeforeToday = 14,

            /// <summary>
            /// Enum IsAfterToday for value: isAfterToday
            /// </summary>
            [EnumMember(Value = "isAfterToday")]
            IsAfterToday = 15,

            /// <summary>
            /// Enum IsOneOf for value: isOneOf
            /// </summary>
            [EnumMember(Value = "isOneOf")]
            IsOneOf = 16,

            /// <summary>
            /// Enum IsNotOneOf for value: isNotOneOf
            /// </summary>
            [EnumMember(Value = "isNotOneOf")]
            IsNotOneOf = 17,

            /// <summary>
            /// Enum WasInTheLast for value: wasInTheLast
            /// </summary>
            [EnumMember(Value = "wasInTheLast")]
            WasInTheLast = 18,

            /// <summary>
            /// Enum WasNotInTheLast for value: wasNotInTheLast
            /// </summary>
            [EnumMember(Value = "wasNotInTheLast")]
            WasNotInTheLast = 19,

            /// <summary>
            /// Enum IsInTheNext for value: isInTheNext
            /// </summary>
            [EnumMember(Value = "isInTheNext")]
            IsInTheNext = 20,

            /// <summary>
            /// Enum IsNotInTheNext for value: isNotInTheNext
            /// </summary>
            [EnumMember(Value = "isNotInTheNext")]
            IsNotInTheNext = 21

        }


        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name = "Operator", EmitDefaultValue = false)]
        public OperatorEnum? Operator { get; set; }
        /// <summary>
        /// Defines ValueType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueTypeEnum
        {
            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum Input for value: input
            /// </summary>
            [EnumMember(Value = "input")]
            Input = 2,

            /// <summary>
            /// Enum Attribute for value: attribute
            /// </summary>
            [EnumMember(Value = "attribute")]
            Attribute = 3

        }


        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name = "ValueType", EmitDefaultValue = false)]
        public ValueTypeEnum? ValueType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rule" /> class.
        /// </summary>
        /// <param name="type">type (default to TypeEnum.Definition).</param>
        /// <param name="field">field.</param>
        /// <param name="_operator">_operator.</param>
        /// <param name="value">Value to check against the operation. Value is now expected to be of the Native Type of the Data Target Definition.  i.e. If your Data Target Definition is a Number A value of: 10 will pass. While a value of \&quot;10\&quot; will fail on publish due to the value not matching the correct data type.  Possible Special Key Values for Specific Data Target Definition Data Type: - Datetime   - {{TODAY}} - This should be evaluated as the today date on evaluation of the rule during RUN TIME (NOT on publish during DESIGN TIME)    Values for Specific Data Target Definition Data Types - Datetime   - isBeforeToday - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - isAfterToday - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - wasInTheLast - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - wasNotInTheLast - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - isInTheNext - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - isNotInTheNext - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed..</param>
        /// <param name="valueType">valueType.</param>
        public Rule(TypeEnum? type = TypeEnum.Definition, Guid field = default(Guid), OperatorEnum? _operator = default(OperatorEnum?), Object value = default(Object), ValueTypeEnum? valueType = default(ValueTypeEnum?))
        {
            this.Type = type;
            this.Field = field;
            this.Operator = _operator;
            this.Value = value;
            this.ValueType = valueType;
        }

        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name = "Field", EmitDefaultValue = false)]
        public Guid Field { get; set; }

        /// <summary>
        /// Value to check against the operation. Value is now expected to be of the Native Type of the Data Target Definition.  i.e. If your Data Target Definition is a Number A value of: 10 will pass. While a value of \&quot;10\&quot; will fail on publish due to the value not matching the correct data type.  Possible Special Key Values for Specific Data Target Definition Data Type: - Datetime   - {{TODAY}} - This should be evaluated as the today date on evaluation of the rule during RUN TIME (NOT on publish during DESIGN TIME)    Values for Specific Data Target Definition Data Types - Datetime   - isBeforeToday - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - isAfterToday - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - wasInTheLast - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - wasNotInTheLast - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - isInTheNext - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - isNotInTheNext - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.
        /// </summary>
        /// <value>Value to check against the operation. Value is now expected to be of the Native Type of the Data Target Definition.  i.e. If your Data Target Definition is a Number A value of: 10 will pass. While a value of \&quot;10\&quot; will fail on publish due to the value not matching the correct data type.  Possible Special Key Values for Specific Data Target Definition Data Type: - Datetime   - {{TODAY}} - This should be evaluated as the today date on evaluation of the rule during RUN TIME (NOT on publish during DESIGN TIME)    Values for Specific Data Target Definition Data Types - Datetime   - isBeforeToday - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - isAfterToday - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - wasInTheLast - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - wasNotInTheLast - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - isInTheNext - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.   - isNotInTheNext - Value must be in ISO8601 Duration Format. The value should be limited to Days, Weeks and Months even though the format allows hours/minutes/seconds and years. Combination of units are not allowed.</value>
        [DataMember(Name = "Value", EmitDefaultValue = false)]
        public Object Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Rule {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Rule);
        }

        /// <summary>
        /// Returns true if Rule instances are equal
        /// </summary>
        /// <param name="input">Instance of Rule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Rule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.Operator == input.Operator ||
                    this.Operator.Equals(input.Operator)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    this.ValueType.Equals(input.ValueType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Field != null)
                {
                    hashCode = (hashCode * 59) + this.Field.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Operator.GetHashCode();
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ValueType.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
