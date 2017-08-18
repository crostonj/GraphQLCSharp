using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Nds.Borrower.GraphQl.Util
{
    public class CustomAddressResolver : DefaultContractResolver
    {
        private Dictionary<string, string> PropertyMappings { get; set; }

        public CustomAddressResolver()
        {
            this.PropertyMappings = new Dictionary<string, string>
        {
            {"Address3","ADDRESS3"},
            {"Campaign","CAMPAIGN"},
            {"InvalidByUserId","INVALIDBYUSERID"},
            {"InvalidDate","INVALIDDATE"},
            {"InvokeTrack","INVOKETRACK"},
            {"SequenceNumber","SEQUENCENBR"},
            {"ServiceAttemptDate","SERVICEATTEMPTDATE"},
            {"ServiceCode","SERVICECODE"},
            {"ServiceResponseDate","SERVICERESPONSEDATE"},
            {"ServiceResponseUser","SERVICERESPONSEUSER"},
            {"Source","SOURCE"},
            {"Type","TYPE"},
            {"Status","STATUS"},

            //From AddressDetail in Nds.Borrower.Common
            {"AddDate","DATECREATED"},

            //From Address",""},
            {"IsActive","ACTIVE"},
            //{"IsValid",""}, //TODO return true if STATUS == "Valid"
            {"Address1","ADDRESS1"},
            {"Address2","ADDRESS2"},
            {"AddressStatus",""},
            {"City","CITY"},
            {"StateCode","STATE"},
            {"County","COUNTY"},
            {"ZipCode","ZIP"},
            {"CountryCode","COUNTRY"},
            {"ForeignCountryIndicator","FOREIGNCOUNTRY"}
        };
        }

        protected override string ResolvePropertyName(string propertyName)
        {
            string resolvedName = null;
            var resolved = this.PropertyMappings.TryGetValue(propertyName, out resolvedName);
            return (resolved) ? resolvedName : base.ResolvePropertyName(propertyName);
        }

        protected override JsonContract CreateContract(Type objectType)
        {
            JsonContract contract = base.CreateContract(objectType);

            // this will only be called once and then cached
            if (objectType == typeof(bool) || objectType == typeof(System.Boolean))
            {
                contract.Converter = new BooleanJsonConverter();
            }

            return contract;
        }
    }

    public class BooleanJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(bool);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch (reader.Value.ToString().ToLower().Trim().Replace("\"", ""))
            {
                case "true":
                case "yes":
                case "y":
                case "1":
                    return true;
                case "false":
                case "no":
                case "n":
                case "0":
                    return false;
            }

            // If we reach here, we're pretty much going to throw an error so let's let Json.NET throw it's pretty-fied error message.
            return new JsonSerializer().Deserialize(reader, objectType);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
        }

    }
}
