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
    /// CustomerAttribute
    /// </summary>
    [DataContract(Name = "CustomerAttribute")]
    public partial class CustomerAttribute : IEquatable<CustomerAttribute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAttribute" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="attributeType">attributeType.</param>
        public CustomerAttribute(string id = default(string), string attributeType = default(string))
        {
            this.Id = id;
            this.AttributeType = attributeType;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AttributeType
        /// </summary>
        [DataMember(Name = "attributeType", EmitDefaultValue = false)]
        public string AttributeType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerAttribute {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AttributeType: ").Append(AttributeType).Append("\n");
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
            return this.Equals(input as CustomerAttribute);
        }

        /// <summary>
        /// Returns true if CustomerAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerAttribute input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AttributeType == input.AttributeType ||
                    (this.AttributeType != null &&
                    this.AttributeType.Equals(input.AttributeType))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.AttributeType != null)
                {
                    hashCode = (hashCode * 59) + this.AttributeType.GetHashCode();
                }
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
