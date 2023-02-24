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
    /// GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter
    /// </summary>
    [DataContract(Name = "GetCustomerEventsByAccountKeyOrderByDateTime_searchParameter_parameter")]
    public partial class GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter : IEquatable<GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter" /> class.
        /// </summary>
        /// <param name="category">category.</param>
        /// <param name="playbookId">playbookId.</param>
        /// <param name="playbookName">playbookName.</param>
        /// <param name="campaignId">campaignId.</param>
        /// <param name="campaignName">campaignName.</param>
        /// <param name="campaignPersistentId">campaignPersistentId.</param>
        public GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter(string category = default(string), Guid? playbookId = default(Guid?), string playbookName = default(string), Guid? campaignId = default(Guid?), string campaignName = default(string), Guid? campaignPersistentId = default(Guid?))
        {
            this.Category = category;
            this.PlaybookId = playbookId;
            this.PlaybookName = playbookName;
            this.CampaignId = campaignId;
            this.CampaignName = campaignName;
            this.CampaignPersistentId = campaignPersistentId;
        }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = true)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets PlaybookId
        /// </summary>
        [DataMember(Name = "playbookId", EmitDefaultValue = true)]
        public Guid? PlaybookId { get; set; }

        /// <summary>
        /// Gets or Sets PlaybookName
        /// </summary>
        [DataMember(Name = "playbookName", EmitDefaultValue = true)]
        public string PlaybookName { get; set; }

        /// <summary>
        /// Gets or Sets CampaignId
        /// </summary>
        [DataMember(Name = "campaignId", EmitDefaultValue = true)]
        public Guid? CampaignId { get; set; }

        /// <summary>
        /// Gets or Sets CampaignName
        /// </summary>
        [DataMember(Name = "campaignName", EmitDefaultValue = true)]
        public string CampaignName { get; set; }

        /// <summary>
        /// Gets or Sets CampaignPersistentId
        /// </summary>
        [DataMember(Name = "campaignPersistentId", EmitDefaultValue = true)]
        public Guid? CampaignPersistentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  PlaybookId: ").Append(PlaybookId).Append("\n");
            sb.Append("  PlaybookName: ").Append(PlaybookName).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  CampaignName: ").Append(CampaignName).Append("\n");
            sb.Append("  CampaignPersistentId: ").Append(CampaignPersistentId).Append("\n");
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
            return this.Equals(input as GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter);
        }

        /// <summary>
        /// Returns true if GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCustomerEventsByAccountKeyOrderByDateTimeSearchParameterParameter input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.PlaybookId == input.PlaybookId ||
                    (this.PlaybookId != null &&
                    this.PlaybookId.Equals(input.PlaybookId))
                ) && 
                (
                    this.PlaybookName == input.PlaybookName ||
                    (this.PlaybookName != null &&
                    this.PlaybookName.Equals(input.PlaybookName))
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
                ) && 
                (
                    this.CampaignName == input.CampaignName ||
                    (this.CampaignName != null &&
                    this.CampaignName.Equals(input.CampaignName))
                ) && 
                (
                    this.CampaignPersistentId == input.CampaignPersistentId ||
                    (this.CampaignPersistentId != null &&
                    this.CampaignPersistentId.Equals(input.CampaignPersistentId))
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
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.PlaybookId != null)
                {
                    hashCode = (hashCode * 59) + this.PlaybookId.GetHashCode();
                }
                if (this.PlaybookName != null)
                {
                    hashCode = (hashCode * 59) + this.PlaybookName.GetHashCode();
                }
                if (this.CampaignId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignId.GetHashCode();
                }
                if (this.CampaignName != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignName.GetHashCode();
                }
                if (this.CampaignPersistentId != null)
                {
                    hashCode = (hashCode * 59) + this.CampaignPersistentId.GetHashCode();
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
