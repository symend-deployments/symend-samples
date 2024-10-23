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
    /// DataTargetDefinitionForm
    /// </summary>
    [DataContract(Name = "DataTargetDefinitionForm")]
    public partial class DataTargetDefinitionForm : IEquatable<DataTargetDefinitionForm>, IValidatableObject
    {
        /// <summary>
        /// Defines DataType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataTypeEnum
        {
            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown,

            /// <summary>
            /// Enum String for value: string
            /// </summary>
            [EnumMember(Value = "string")]
            String,

            /// <summary>
            /// Enum Integer for value: integer
            /// </summary>
            [EnumMember(Value = "integer")]
            Integer,

            /// <summary>
            /// Enum Boolean for value: boolean
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean,

            /// <summary>
            /// Enum Datetime for value: datetime
            /// </summary>
            [EnumMember(Value = "datetime")]
            Datetime,

            /// <summary>
            /// Enum Number for value: number
            /// </summary>
            [EnumMember(Value = "number")]
            Number,

            /// <summary>
            /// Enum Guid for value: guid
            /// </summary>
            [EnumMember(Value = "guid")]
            Guid,

            /// <summary>
            /// Enum DateOnly for value: dateOnly
            /// </summary>
            [EnumMember(Value = "dateOnly")]
            DateOnly
        }


        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name = "dataType", EmitDefaultValue = false)]
        public DataTypeEnum? DataType { get; set; }
        /// <summary>
        /// Defines Category
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum Keydate for value: keydate
            /// </summary>
            [EnumMember(Value = "keydate")]
            Keydate = 1,

            /// <summary>
            /// Enum Customer for value: customer
            /// </summary>
            [EnumMember(Value = "customer")]
            Customer = 2,

            /// <summary>
            /// Enum Contact for value: contact
            /// </summary>
            [EnumMember(Value = "contact")]
            Contact = 3,

            /// <summary>
            /// Enum Billing for value: billing
            /// </summary>
            [EnumMember(Value = "billing")]
            Billing = 4,

            /// <summary>
            /// Enum Account for value: account
            /// </summary>
            [EnumMember(Value = "account")]
            Account = 5,

            /// <summary>
            /// Enum Uncategorized for value: uncategorized
            /// </summary>
            [EnumMember(Value = "uncategorized")]
            Uncategorized = 6,

            /// <summary>
            /// Enum Property for value: property
            /// </summary>
            [EnumMember(Value = "property")]
            Property = 7
        }


        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Defines StructureType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StructureTypeEnum
        {
            /// <summary>
            /// Enum Single for value: single
            /// </summary>
            [EnumMember(Value = "single")]
            Single = 1,

            /// <summary>
            /// Enum Collection for value: collection
            /// </summary>
            [EnumMember(Value = "collection")]
            Collection = 2
        }


        /// <summary>
        /// Gets or Sets StructureType
        /// </summary>
        [DataMember(Name = "structureType", EmitDefaultValue = false)]
        public StructureTypeEnum? StructureType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataTargetDefinitionForm" /> class.
        /// </summary>
        /// <param name="name">Data Target Definition Property Name.  Name must start with a letter, can only contain letters, digits, underscore and dashes..</param>
        /// <param name="dataType">dataType.</param>
        /// <param name="isPii">isPii.</param>
        /// <param name="category">category.</param>
        /// <param name="structureType">structureType.</param>
        /// <param name="description">description.</param>
        public DataTargetDefinitionForm(string name = default(string), DataTypeEnum? dataType = default(DataTypeEnum?), bool isPii = default(bool), CategoryEnum? category = default(CategoryEnum?), StructureTypeEnum? structureType = default(StructureTypeEnum?), string description = default(string))
        {
            this.Name = name;
            this.DataType = dataType;
            this.IsPii = isPii;
            this.Category = category;
            this.StructureType = structureType;
            this.Description = description;
        }

        /// <summary>
        /// Data Target Definition Property Name.  Name must start with a letter, can only contain letters, digits, underscore and dashes.
        /// </summary>
        /// <value>Data Target Definition Property Name.  Name must start with a letter, can only contain letters, digits, underscore and dashes.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IsPii
        /// </summary>
        [DataMember(Name = "isPii", EmitDefaultValue = true)]
        public bool IsPii { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataTargetDefinitionForm {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  IsPii: ").Append(IsPii).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  StructureType: ").Append(StructureType).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as DataTargetDefinitionForm);
        }

        /// <summary>
        /// Returns true if DataTargetDefinitionForm instances are equal
        /// </summary>
        /// <param name="input">Instance of DataTargetDefinitionForm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataTargetDefinitionForm input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DataType == input.DataType ||
                    this.DataType.Equals(input.DataType)
                ) && 
                (
                    this.IsPii == input.IsPii ||
                    this.IsPii.Equals(input.IsPii)
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.StructureType == input.StructureType ||
                    this.StructureType.Equals(input.StructureType)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DataType.GetHashCode();
                hashCode = (hashCode * 59) + this.IsPii.GetHashCode();
                hashCode = (hashCode * 59) + this.Category.GetHashCode();
                hashCode = (hashCode * 59) + this.StructureType.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
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
