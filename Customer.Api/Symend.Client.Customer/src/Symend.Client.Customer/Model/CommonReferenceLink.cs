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
    /// Reference link for returning a HATEOAS style link to an API resource
    /// </summary>
    [DataContract(Name = "Common_ReferenceLink")]
    public partial class CommonReferenceLink : IEquatable<CommonReferenceLink>, IValidatableObject
    {
        /// <summary>
        /// Defines Method
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            /// <summary>
            /// Enum GET for value: GET
            /// </summary>
            [EnumMember(Value = "GET")]
            GET = 1,

            /// <summary>
            /// Enum POST for value: POST
            /// </summary>
            [EnumMember(Value = "POST")]
            POST = 2,

            /// <summary>
            /// Enum PUT for value: PUT
            /// </summary>
            [EnumMember(Value = "PUT")]
            PUT = 3,

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            [EnumMember(Value = "DELETE")]
            DELETE = 4,

            /// <summary>
            /// Enum OPTIONS for value: OPTIONS
            /// </summary>
            [EnumMember(Value = "OPTIONS")]
            OPTIONS = 5,

            /// <summary>
            /// Enum HEAD for value: HEAD
            /// </summary>
            [EnumMember(Value = "HEAD")]
            HEAD = 6

        }


        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public MethodEnum? Method { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonReferenceLink" /> class.
        /// </summary>
        /// <param name="href">href.</param>
        /// <param name="rel">rel.</param>
        /// <param name="method">method.</param>
        public CommonReferenceLink(string href = default(string), string rel = default(string), MethodEnum? method = default(MethodEnum?))
        {
            this.Href = href;
            this.Rel = rel;
            this.Method = method;
        }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name = "href", EmitDefaultValue = false)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets Rel
        /// </summary>
        [DataMember(Name = "rel", EmitDefaultValue = false)]
        public string Rel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommonReferenceLink {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Rel: ").Append(Rel).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
            return this.Equals(input as CommonReferenceLink);
        }

        /// <summary>
        /// Returns true if CommonReferenceLink instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonReferenceLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonReferenceLink input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Rel == input.Rel ||
                    (this.Rel != null &&
                    this.Rel.Equals(input.Rel))
                ) && 
                (
                    this.Method == input.Method ||
                    this.Method.Equals(input.Method)
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
                if (this.Href != null)
                {
                    hashCode = (hashCode * 59) + this.Href.GetHashCode();
                }
                if (this.Rel != null)
                {
                    hashCode = (hashCode * 59) + this.Rel.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Method.GetHashCode();
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
