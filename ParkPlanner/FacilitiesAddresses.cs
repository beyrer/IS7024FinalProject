﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using ParkPlannerAddresses;
//
//    var facilitiesAddresses = FacilitiesAddresses.FromJson(jsonString);

namespace ParkPlannerAddresses
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class FacilitiesAddresses
    {
        [JsonProperty("METADATA", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }

        [JsonProperty("RECDATA", NullValueHandling = NullValueHandling.Ignore)]
        public List<Recdatum> Recdata { get; set; }
    }

    public partial class Metadata
    {
        [JsonProperty("RESULTS", NullValueHandling = NullValueHandling.Ignore)]
        public Results Results { get; set; }

        [JsonProperty("SEARCH_PARAMETERS", NullValueHandling = NullValueHandling.Ignore)]
        public SearchParameters SearchParameters { get; set; }
    }

    public partial class Results
    {
        [JsonProperty("CURRENT_COUNT", NullValueHandling = NullValueHandling.Ignore)]
        public long? CurrentCount { get; set; }

        [JsonProperty("TOTAL_COUNT", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }
    }

    public partial class SearchParameters
    {
        [JsonProperty("LIMIT", NullValueHandling = NullValueHandling.Ignore)]
        public long? Limit { get; set; }

        [JsonProperty("OFFSET", NullValueHandling = NullValueHandling.Ignore)]
        public long? Offset { get; set; }

        [JsonProperty("QUERY", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }
    }

    public partial class Recdatum
    {
        [JsonProperty("AddressCountryCode", NullValueHandling = NullValueHandling.Ignore)]
        public AddressCountryCodeUnion? AddressCountryCode { get; set; }

        [JsonProperty("AddressStateCode", NullValueHandling = NullValueHandling.Ignore)]
        public string AddressStateCode { get; set; }

        [JsonProperty("City", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        [JsonProperty("FacilityAddressID", NullValueHandling = NullValueHandling.Ignore)]
        public string FacilityAddressId { get; set; }

        [JsonProperty("FacilityAddressType", NullValueHandling = NullValueHandling.Ignore)]
        public FacilityAddressType? FacilityAddressType { get; set; }

        [JsonProperty("FacilityID", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? FacilityId { get; set; }

        [JsonProperty("FacilityStreetAddress1", NullValueHandling = NullValueHandling.Ignore)]
        public string FacilityStreetAddress1 { get; set; }

        [JsonProperty("FacilityStreetAddress2", NullValueHandling = NullValueHandling.Ignore)]
        public string FacilityStreetAddress2 { get; set; }

        [JsonProperty("FacilityStreetAddress3", NullValueHandling = NullValueHandling.Ignore)]
        public string FacilityStreetAddress3 { get; set; }

        [JsonProperty("LastUpdatedDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastUpdatedDate { get; set; }

        [JsonProperty("PostalCode", NullValueHandling = NullValueHandling.Ignore)]
        public string PostalCode { get; set; }
    }

    public enum AddressCountryCodeEnum { AddressCountryCodeUnitedStates, Empty, The3526952799, UnitedStates, Usa };

    public enum FacilityAddressType { Default, Mailing, Physical };

    public partial struct AddressCountryCodeUnion
    {
        public AddressCountryCodeEnum? Enum;
        public long? Integer;

        public static implicit operator AddressCountryCodeUnion(AddressCountryCodeEnum Enum) => new AddressCountryCodeUnion { Enum = Enum };
        public static implicit operator AddressCountryCodeUnion(long Integer) => new AddressCountryCodeUnion { Integer = Integer };
    }

    public partial class FacilitiesAddresses
    {
        public static FacilitiesAddresses FromJson(string json) => JsonConvert.DeserializeObject<FacilitiesAddresses>(json, ParkPlannerAddresses.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this FacilitiesAddresses self) => JsonConvert.SerializeObject(self, ParkPlannerAddresses.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                AddressCountryCodeUnionConverter.Singleton,
                AddressCountryCodeEnumConverter.Singleton,
                FacilityAddressTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class AddressCountryCodeUnionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddressCountryCodeUnion) || t == typeof(AddressCountryCodeUnion?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    switch (stringValue)
                    {
                        case "":
                            return new AddressCountryCodeUnion { Enum = AddressCountryCodeEnum.Empty };
                        case "(352) 695-2799":
                            return new AddressCountryCodeUnion { Enum = AddressCountryCodeEnum.The3526952799 };
                        case "UNITED STATES":
                            return new AddressCountryCodeUnion { Enum = AddressCountryCodeEnum.AddressCountryCodeUnitedStates };
                        case "USA":
                            return new AddressCountryCodeUnion { Enum = AddressCountryCodeEnum.Usa };
                        case "United States":
                            return new AddressCountryCodeUnion { Enum = AddressCountryCodeEnum.UnitedStates };
                    }
                    long l;
                    if (Int64.TryParse(stringValue, out l))
                    {
                        return new AddressCountryCodeUnion { Integer = l };
                    }
                    break;
            }
            throw new Exception("Cannot unmarshal type AddressCountryCodeUnion");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (AddressCountryCodeUnion)untypedValue;
            if (value.Enum != null)
            {
                switch (value.Enum)
                {
                    case AddressCountryCodeEnum.Empty:
                        serializer.Serialize(writer, "");
                        return;
                    case AddressCountryCodeEnum.The3526952799:
                        serializer.Serialize(writer, "(352) 695-2799");
                        return;
                    case AddressCountryCodeEnum.AddressCountryCodeUnitedStates:
                        serializer.Serialize(writer, "UNITED STATES");
                        return;
                    case AddressCountryCodeEnum.Usa:
                        serializer.Serialize(writer, "USA");
                        return;
                    case AddressCountryCodeEnum.UnitedStates:
                        serializer.Serialize(writer, "United States");
                        return;
                }
            }
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value.ToString());
                return;
            }
            throw new Exception("Cannot marshal type AddressCountryCodeUnion");
        }

        public static readonly AddressCountryCodeUnionConverter Singleton = new AddressCountryCodeUnionConverter();
    }

    internal class AddressCountryCodeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddressCountryCodeEnum) || t == typeof(AddressCountryCodeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "":
                    return AddressCountryCodeEnum.Empty;
                case "(352) 695-2799":
                    return AddressCountryCodeEnum.The3526952799;
                case "UNITED STATES":
                    return AddressCountryCodeEnum.AddressCountryCodeUnitedStates;
                case "USA":
                    return AddressCountryCodeEnum.Usa;
                case "United States":
                    return AddressCountryCodeEnum.UnitedStates;
            }
            throw new Exception("Cannot unmarshal type AddressCountryCodeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddressCountryCodeEnum)untypedValue;
            switch (value)
            {
                case AddressCountryCodeEnum.Empty:
                    serializer.Serialize(writer, "");
                    return;
                case AddressCountryCodeEnum.The3526952799:
                    serializer.Serialize(writer, "(352) 695-2799");
                    return;
                case AddressCountryCodeEnum.AddressCountryCodeUnitedStates:
                    serializer.Serialize(writer, "UNITED STATES");
                    return;
                case AddressCountryCodeEnum.Usa:
                    serializer.Serialize(writer, "USA");
                    return;
                case AddressCountryCodeEnum.UnitedStates:
                    serializer.Serialize(writer, "United States");
                    return;
            }
            throw new Exception("Cannot marshal type AddressCountryCodeEnum");
        }

        public static readonly AddressCountryCodeEnumConverter Singleton = new AddressCountryCodeEnumConverter();
    }

    internal class FacilityAddressTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FacilityAddressType) || t == typeof(FacilityAddressType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Default":
                    return FacilityAddressType.Default;
                case "Mailing":
                    return FacilityAddressType.Mailing;
                case "Physical":
                    return FacilityAddressType.Physical;
            }
            throw new Exception("Cannot unmarshal type FacilityAddressType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FacilityAddressType)untypedValue;
            switch (value)
            {
                case FacilityAddressType.Default:
                    serializer.Serialize(writer, "Default");
                    return;
                case FacilityAddressType.Mailing:
                    serializer.Serialize(writer, "Mailing");
                    return;
                case FacilityAddressType.Physical:
                    serializer.Serialize(writer, "Physical");
                    return;
            }
            throw new Exception("Cannot marshal type FacilityAddressType");
        }

        public static readonly FacilityAddressTypeConverter Singleton = new FacilityAddressTypeConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
