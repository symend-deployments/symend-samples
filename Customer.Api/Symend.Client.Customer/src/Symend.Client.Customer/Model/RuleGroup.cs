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
    /// RuleGroup
    /// </summary>
    [DataContract(Name = "RuleGroup")]
    public partial class RuleGroup : IEquatable<RuleGroup>, IValidatableObject
    {
        /// <summary>
        /// Defines Condition
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConditionEnum
        {
            /// <summary>
            /// Enum Or for value: Or
            /// </summary>
            [EnumMember(Value = "Or")]
            Or = 1,

            /// <summary>
            /// Enum And for value: And
            /// </summary>
            [EnumMember(Value = "And")]
            And = 2
        }


        /// <summary>
        /// Gets or Sets Condition
        /// </summary>
        [DataMember(Name = "Condition", EmitDefaultValue = false)]
        public ConditionEnum? Condition { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Group for value: Group
            /// </summary>
            [EnumMember(Value = "Group")]
            Group = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "Type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleGroup" /> class.
        /// </summary>
        /// <param name="condition">condition.</param>
        /// <param name="rules">rules.</param>
        /// <param name="type">type (default to TypeEnum.Group).</param>
        public RuleGroup(ConditionEnum? condition = default(ConditionEnum?), List<RuleGroupRulesInner> rules = default(List<RuleGroupRulesInner>), TypeEnum? type = TypeEnum.Group)
        {
            this.Condition = condition;
            this.Rules = rules;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Rules
        /// </summary>
        [DataMember(Name = "Rules", EmitDefaultValue = false)]
        public List<RuleGroupRulesInner> Rules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RuleGroup {\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as RuleGroup);
        }

        /// <summary>
        /// Returns true if RuleGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleGroup input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Condition == input.Condition ||
                    this.Condition.Equals(input.Condition)
                ) && 
                (
                    this.Rules == input.Rules ||
                    this.Rules != null &&
                    input.Rules != null &&
                    this.Rules.SequenceEqual(input.Rules)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = (hashCode * 59) + this.Condition.GetHashCode();
                if (this.Rules != null)
                {
                    hashCode = (hashCode * 59) + this.Rules.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
