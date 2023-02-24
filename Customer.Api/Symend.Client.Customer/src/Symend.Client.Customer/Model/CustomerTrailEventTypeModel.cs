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
    /// CustomerTrailEventTypeModel
    /// </summary>
    [DataContract(Name = "CustomerTrailEventTypeModel")]
    public partial class CustomerTrailEventTypeModel : IEquatable<CustomerTrailEventTypeModel>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public CustomerTrailEventTypeCategory? Category { get; set; }
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Unknown for value: unknown
            /// </summary>
            [EnumMember(Value = "unknown")]
            Unknown = 1,

            /// <summary>
            /// Enum AccountCreated for value: accountCreated
            /// </summary>
            [EnumMember(Value = "accountCreated")]
            AccountCreated = 2,

            /// <summary>
            /// Enum AccountUpdated for value: accountUpdated
            /// </summary>
            [EnumMember(Value = "accountUpdated")]
            AccountUpdated = 3,

            /// <summary>
            /// Enum CampaignEntered for value: campaignEntered
            /// </summary>
            [EnumMember(Value = "campaignEntered")]
            CampaignEntered = 4,

            /// <summary>
            /// Enum CampaignExited for value: campaignExited
            /// </summary>
            [EnumMember(Value = "campaignExited")]
            CampaignExited = 5,

            /// <summary>
            /// Enum EmailBlocked for value: emailBlocked
            /// </summary>
            [EnumMember(Value = "emailBlocked")]
            EmailBlocked = 6,

            /// <summary>
            /// Enum EmailBounced for value: emailBounced
            /// </summary>
            [EnumMember(Value = "emailBounced")]
            EmailBounced = 7,

            /// <summary>
            /// Enum EmailClicked for value: emailClicked
            /// </summary>
            [EnumMember(Value = "emailClicked")]
            EmailClicked = 8,

            /// <summary>
            /// Enum EmailDelivered for value: emailDelivered
            /// </summary>
            [EnumMember(Value = "emailDelivered")]
            EmailDelivered = 9,

            /// <summary>
            /// Enum EmailFailed for value: emailFailed
            /// </summary>
            [EnumMember(Value = "emailFailed")]
            EmailFailed = 10,

            /// <summary>
            /// Enum EmailMachineOpened for value: emailMachineOpened
            /// </summary>
            [EnumMember(Value = "emailMachineOpened")]
            EmailMachineOpened = 11,

            /// <summary>
            /// Enum EmailOpened for value: emailOpened
            /// </summary>
            [EnumMember(Value = "emailOpened")]
            EmailOpened = 12,

            /// <summary>
            /// Enum EmailRejected for value: emailRejected
            /// </summary>
            [EnumMember(Value = "emailRejected")]
            EmailRejected = 13,

            /// <summary>
            /// Enum EmailSent for value: emailSent
            /// </summary>
            [EnumMember(Value = "emailSent")]
            EmailSent = 14,

            /// <summary>
            /// Enum EmailUnsubscribed for value: emailUnsubscribed
            /// </summary>
            [EnumMember(Value = "emailUnsubscribed")]
            EmailUnsubscribed = 15,

            /// <summary>
            /// Enum LandingPageClick for value: landingPageClick
            /// </summary>
            [EnumMember(Value = "landingPageClick")]
            LandingPageClick = 16,

            /// <summary>
            /// Enum LandingPageSubmission for value: landingPageSubmission
            /// </summary>
            [EnumMember(Value = "landingPageSubmission")]
            LandingPageSubmission = 17,

            /// <summary>
            /// Enum LandingPageViewed for value: landingPageViewed
            /// </summary>
            [EnumMember(Value = "landingPageViewed")]
            LandingPageViewed = 18,

            /// <summary>
            /// Enum PlaybookEntered for value: playbookEntered
            /// </summary>
            [EnumMember(Value = "playbookEntered")]
            PlaybookEntered = 19,

            /// <summary>
            /// Enum PlaybookExited for value: playbookExited
            /// </summary>
            [EnumMember(Value = "playbookExited")]
            PlaybookExited = 20,

            /// <summary>
            /// Enum RepliedToSms for value: repliedToSms
            /// </summary>
            [EnumMember(Value = "repliedToSms")]
            RepliedToSms = 21,

            /// <summary>
            /// Enum SmsBlocked for value: smsBlocked
            /// </summary>
            [EnumMember(Value = "smsBlocked")]
            SmsBlocked = 22,

            /// <summary>
            /// Enum SmsBounced for value: smsBounced
            /// </summary>
            [EnumMember(Value = "smsBounced")]
            SmsBounced = 23,

            /// <summary>
            /// Enum SmsDelivered for value: smsDelivered
            /// </summary>
            [EnumMember(Value = "smsDelivered")]
            SmsDelivered = 24,

            /// <summary>
            /// Enum SmsExpired for value: smsExpired
            /// </summary>
            [EnumMember(Value = "smsExpired")]
            SmsExpired = 25,

            /// <summary>
            /// Enum SmsFailed for value: smsFailed
            /// </summary>
            [EnumMember(Value = "smsFailed")]
            SmsFailed = 26,

            /// <summary>
            /// Enum SmsOptIn for value: smsOptIn
            /// </summary>
            [EnumMember(Value = "smsOptIn")]
            SmsOptIn = 27,

            /// <summary>
            /// Enum SmsOptOut for value: smsOptOut
            /// </summary>
            [EnumMember(Value = "smsOptOut")]
            SmsOptOut = 28,

            /// <summary>
            /// Enum SmsRejected for value: smsRejected
            /// </summary>
            [EnumMember(Value = "smsRejected")]
            SmsRejected = 29,

            /// <summary>
            /// Enum SmsSent for value: smsSent
            /// </summary>
            [EnumMember(Value = "smsSent")]
            SmsSent = 30

        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerTrailEventTypeModel" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="category">category.</param>
        /// <param name="attributeTypes">attributeTypes.</param>
        /// <param name="schemaName">schemaName.</param>
        /// <param name="description">description.</param>
        /// <param name="type">type.</param>
        public CustomerTrailEventTypeModel(Guid id = default(Guid), string name = default(string), CustomerTrailEventTypeCategory? category = default(CustomerTrailEventTypeCategory?), List<CustomerTrailAttributeTypeModel> attributeTypes = default(List<CustomerTrailAttributeTypeModel>), string schemaName = default(string), string description = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Id = id;
            this.Name = name;
            this.Category = category;
            this.AttributeTypes = attributeTypes;
            this.SchemaName = schemaName;
            this.Description = description;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AttributeTypes
        /// </summary>
        [DataMember(Name = "attributeTypes", EmitDefaultValue = false)]
        public List<CustomerTrailAttributeTypeModel> AttributeTypes { get; set; }

        /// <summary>
        /// Gets or Sets SchemaName
        /// </summary>
        [DataMember(Name = "schemaName", EmitDefaultValue = false)]
        public string SchemaName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerTrailEventTypeModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  AttributeTypes: ").Append(AttributeTypes).Append("\n");
            sb.Append("  SchemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as CustomerTrailEventTypeModel);
        }

        /// <summary>
        /// Returns true if CustomerTrailEventTypeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerTrailEventTypeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerTrailEventTypeModel input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.AttributeTypes == input.AttributeTypes ||
                    this.AttributeTypes != null &&
                    input.AttributeTypes != null &&
                    this.AttributeTypes.SequenceEqual(input.AttributeTypes)
                ) && 
                (
                    this.SchemaName == input.SchemaName ||
                    (this.SchemaName != null &&
                    this.SchemaName.Equals(input.SchemaName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Category.GetHashCode();
                if (this.AttributeTypes != null)
                {
                    hashCode = (hashCode * 59) + this.AttributeTypes.GetHashCode();
                }
                if (this.SchemaName != null)
                {
                    hashCode = (hashCode * 59) + this.SchemaName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
