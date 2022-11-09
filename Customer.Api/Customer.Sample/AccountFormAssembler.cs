using System.Runtime.Serialization;
using Symend.Client.Customer.Model;

namespace Customer.Sample;


    /// <summary>
    /// Assembles the form needed to patch/update an account using the Customer API.
    /// </summary>
    public class AccountFormAssembler
    {
        public static dynamic AddProperty(string fieldName,
            object value,  Dictionary<string,DataTargetDefinitionDictionaryModel> dtds)
        {
            var targetDtd = dtds.SingleOrDefault(x => x.Value.Name == fieldName);
            
            if (targetDtd.Key == null)
                throw new ArgumentException($"DTD not found for value [{fieldName}]");
            
            return AssembleCustomerAttribute(targetDtd.Key, value, targetDtd.Value.DataType.Value);
        }
        
        public static dynamic AssembleCustomerAttribute(string dataTargetDefinitionId, object value, DataTargetDefinitionDataType dataType) =>
            dataType switch
            {
                DataTargetDefinitionDataType.Boolean => new CustomerAttributeBoolean
                {
                    Id = dataTargetDefinitionId,
                    Value = (bool) value,
                    AttributeType = dataType.ToEnumMemberAttrValue()
                },
                DataTargetDefinitionDataType.DateTime => new CustomerAttributeDateTime
                {
                    Id = dataTargetDefinitionId,
                    Value = ConvertToDateTime(value),
                    AttributeType = dataType.ToEnumMemberAttrValue()
                },
                DataTargetDefinitionDataType.Guid => new CustomerAttributeGuid
                {
                    Id = dataTargetDefinitionId,
                    Value = (Guid)value,
                    AttributeType = dataType.ToEnumMemberAttrValue()
                },
                DataTargetDefinitionDataType.Integer => new CustomerAttributeNumber
                {
                    Id = dataTargetDefinitionId,
                    Value = Convert.ToInt16(value),
                    AttributeType = dataType.ToEnumMemberAttrValue()
                },
                DataTargetDefinitionDataType.Number => new CustomerAttributeNumber
                {
                    Id = dataTargetDefinitionId,
                    Value = Convert.ToDecimal(value),
                    AttributeType = dataType.ToEnumMemberAttrValue()
                },
                DataTargetDefinitionDataType.String => new CustomerAttributeString
                {
                    Id = dataTargetDefinitionId,
                    Value = Convert.ToString(value),
                    AttributeType = dataType.ToEnumMemberAttrValue()
                },
                _ => throw new NotImplementedException($"DataTargetDefinitionDataType:<{dataType}> not implemented yet")
            };
        
        private static DateTime ConvertToDateTime(object value)
        {
            if (value is not DateTime time)
                throw new NotSupportedException($"Converting type:<{value.GetType()}> to DateTime not supported yet");    
            
            return time;
        }
    }

    public static class Extension
    {
        public static string ToEnumMemberAttrValue(this Enum @enum)
        {
            var attr = 
                @enum.GetType().GetMember(@enum.ToString()).FirstOrDefault()?.
                    GetCustomAttributes(false).OfType<EnumMemberAttribute>().
                    FirstOrDefault();
            if (attr == null)
                return @enum.ToString();
            return attr.Value;
        }
    }
    