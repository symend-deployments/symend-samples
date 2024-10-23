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
    /// SegmentRevisionModelRules
    /// </summary>
    [JsonConverter(typeof(SegmentRevisionModelRulesJsonConverter))]
    [DataContract(Name = "SegmentRevisionModel_rules")]
    public partial class SegmentRevisionModelRules : AbstractOpenAPISchema, IEquatable<SegmentRevisionModelRules>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentRevisionModelRules" /> class
        /// with the <see cref="Rule" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Rule.</param>
        public SegmentRevisionModelRules(Rule actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentRevisionModelRules" /> class
        /// with the <see cref="RuleGroup" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of RuleGroup.</param>
        public SegmentRevisionModelRules(RuleGroup actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
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
                if (value.GetType() == typeof(Rule) || value is Rule)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(RuleGroup) || value is RuleGroup)
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
            sb.Append("class SegmentRevisionModelRules {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, SegmentRevisionModelRules.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of SegmentRevisionModelRules
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of SegmentRevisionModelRules</returns>
        public static SegmentRevisionModelRules FromJson(string jsonString)
        {
            SegmentRevisionModelRules newSegmentRevisionModelRules = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newSegmentRevisionModelRules;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(Rule).GetProperty("AdditionalProperties") == null)
                {
                    newSegmentRevisionModelRules = new SegmentRevisionModelRules(JsonConvert.DeserializeObject<Rule>(jsonString, SegmentRevisionModelRules.SerializerSettings));
                }
                else
                {
                    newSegmentRevisionModelRules = new SegmentRevisionModelRules(JsonConvert.DeserializeObject<Rule>(jsonString, SegmentRevisionModelRules.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("Rule");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Rule: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(RuleGroup).GetProperty("AdditionalProperties") == null)
                {
                    newSegmentRevisionModelRules = new SegmentRevisionModelRules(JsonConvert.DeserializeObject<RuleGroup>(jsonString, SegmentRevisionModelRules.SerializerSettings));
                }
                else
                {
                    newSegmentRevisionModelRules = new SegmentRevisionModelRules(JsonConvert.DeserializeObject<RuleGroup>(jsonString, SegmentRevisionModelRules.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("RuleGroup");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RuleGroup: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newSegmentRevisionModelRules;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SegmentRevisionModelRules);
        }

        /// <summary>
        /// Returns true if SegmentRevisionModelRules instances are equal
        /// </summary>
        /// <param name="input">Instance of SegmentRevisionModelRules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SegmentRevisionModelRules input)
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
    /// Custom JSON converter for SegmentRevisionModelRules
    /// </summary>
    public class SegmentRevisionModelRulesJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(SegmentRevisionModelRules).GetMethod("ToJson").Invoke(value, null)));
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
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return SegmentRevisionModelRules.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return SegmentRevisionModelRules.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
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
