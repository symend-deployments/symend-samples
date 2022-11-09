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
using System.Reflection;

namespace Symend.Client.Customer.Model
{
    /// <summary>
    /// RuleGroupRulesInner
    /// </summary>
    [JsonConverter(typeof(RuleGroupRulesInnerJsonConverter))]
    [DataContract(Name = "RuleGroup_Rules_inner")]
    public partial class RuleGroupRulesInner : AbstractOpenAPISchema, IEquatable<RuleGroupRulesInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleGroupRulesInner" /> class
        /// with the <see cref="Rule" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Rule.</param>
        public RuleGroupRulesInner(Rule actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuleGroupRulesInner" /> class
        /// with the <see cref="RuleGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of RuleGroup.</param>
        public RuleGroupRulesInner(RuleGroup actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(Rule))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(RuleGroup))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Rule, RuleGroup");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Rule`. If the actual instance is not `Rule`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Rule</returns>
        public Rule GetRule()
        {
            return (Rule)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `RuleGroup`. If the actual instance is not `RuleGroup`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of RuleGroup</returns>
        public RuleGroup GetRuleGroup()
        {
            return (RuleGroup)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleGroupRulesInner {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, RuleGroupRulesInner.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of RuleGroupRulesInner
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of RuleGroupRulesInner</returns>
        public static RuleGroupRulesInner FromJson(string jsonString)
        {
            RuleGroupRulesInner newRuleGroupRulesInner = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newRuleGroupRulesInner;
            }

            try
            {
                newRuleGroupRulesInner = new RuleGroupRulesInner(JsonConvert.DeserializeObject<Rule>(jsonString, RuleGroupRulesInner.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newRuleGroupRulesInner;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Rule: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newRuleGroupRulesInner = new RuleGroupRulesInner(JsonConvert.DeserializeObject<RuleGroup>(jsonString, RuleGroupRulesInner.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newRuleGroupRulesInner;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RuleGroup: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RuleGroupRulesInner);
        }

        /// <summary>
        /// Returns true if RuleGroupRulesInner instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleGroupRulesInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleGroupRulesInner input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for RuleGroupRulesInner
    /// </summary>
    public class RuleGroupRulesInnerJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(RuleGroupRulesInner).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return RuleGroupRulesInner.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}