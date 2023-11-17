﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using ParkPlannerPark;
//
//    var park = Park.FromJson(jsonString);

namespace ParkPlannerPark
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Park
    {
        [JsonProperty("total")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Total { get; set; }

        [JsonProperty("limit")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Limit { get; set; }

        [JsonProperty("start")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Start { get; set; }

        [JsonProperty("data")]
        public List<Datum> Data { get; set; }
    }

    public partial class Datum
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("parkCode")]
        public string ParkCode { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("latLong")]
        public string LatLong { get; set; }

        [JsonProperty("activities")]
        public List<Activity> Activities { get; set; }

        [JsonProperty("topics")]
        public List<Activity> Topics { get; set; }

        [JsonProperty("states")]
        public string States { get; set; }

        [JsonProperty("contacts")]
        public Contacts Contacts { get; set; }

        [JsonProperty("entranceFees")]
        public List<Entrance> EntranceFees { get; set; }

        [JsonProperty("entrancePasses")]
        public List<Entrance> EntrancePasses { get; set; }

        [JsonProperty("fees")]
        public List<object> Fees { get; set; }

        [JsonProperty("directionsInfo")]
        public string DirectionsInfo { get; set; }

        [JsonProperty("directionsUrl")]
        public Uri DirectionsUrl { get; set; }

        [JsonProperty("operatingHours")]
        public List<OperatingHour> OperatingHours { get; set; }

        [JsonProperty("addresses")]
        public List<Address> Addresses { get; set; }

        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        [JsonProperty("weatherInfo")]
        public string WeatherInfo { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("relevanceScore")]
        public long RelevanceScore { get; set; }
    }

    public partial class Activity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stateCode")]
        public StateCode StateCode { get; set; }

        [JsonProperty("countryCode")]
        public CountryCode CountryCode { get; set; }

        [JsonProperty("provinceTerritoryCode")]
        public string ProvinceTerritoryCode { get; set; }

        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("type")]
        public AddressType Type { get; set; }

        [JsonProperty("line3")]
        public string Line3 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }
    }

    public partial class Contacts
    {
        [JsonProperty("phoneNumbers")]
        public List<PhoneNumber> PhoneNumbers { get; set; }

        [JsonProperty("emailAddresses")]
        public List<EmailAddress> EmailAddresses { get; set; }
    }

    public partial class EmailAddress
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddressEmailAddress { get; set; }
    }

    public partial class PhoneNumber
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumberPhoneNumber { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("type")]
        public PhoneNumberType Type { get; set; }
    }

    public partial class Entrance
    {
        [JsonProperty("cost")]
        public string Cost { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("credit")]
        public string Credit { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("altText")]
        public string AltText { get; set; }

        [JsonProperty("caption")]
        public string Caption { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class OperatingHour
    {
        [JsonProperty("exceptions")]
        public List<ExceptionElement> Exceptions { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("standardHours")]
        public Hours StandardHours { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public partial class ExceptionElement
    {
        [JsonProperty("exceptionHours")]
        public Hours ExceptionHours { get; set; }

        [JsonProperty("startDate")]
        public DateTimeOffset StartDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("endDate")]
        public DateTimeOffset EndDate { get; set; }
    }

    public partial class Hours
    {
        [JsonProperty("wednesday", NullValueHandling = NullValueHandling.Ignore)]
        public string Wednesday { get; set; }

        [JsonProperty("monday", NullValueHandling = NullValueHandling.Ignore)]
        public string Monday { get; set; }

        [JsonProperty("thursday", NullValueHandling = NullValueHandling.Ignore)]
        public string Thursday { get; set; }

        [JsonProperty("sunday", NullValueHandling = NullValueHandling.Ignore)]
        public string Sunday { get; set; }

        [JsonProperty("tuesday", NullValueHandling = NullValueHandling.Ignore)]
        public string Tuesday { get; set; }

        [JsonProperty("friday", NullValueHandling = NullValueHandling.Ignore)]
        public string Friday { get; set; }

        [JsonProperty("saturday", NullValueHandling = NullValueHandling.Ignore)]
        public string Saturday { get; set; }
    }

    public enum CountryCode { Us };

    public enum AddressType { Mailing, Physical };

    public enum PhoneNumberType { Fax, Tty, Voice };

    public enum StateCode {  };                                                               

    public partial class Park
    {
        public static Park FromJson(string json) => JsonConvert.DeserializeObject<Park>(json, ParkPlannerPark.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Park self) => JsonConvert.SerializeObject(self, ParkPlannerPark.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                CountryCodeConverter.Singleton,
                AddressTypeConverter.Singleton,
                PhoneNumberTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class CountryCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CountryCode) || t == typeof(CountryCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "US")
            {
                return CountryCode.Us;
            }
            throw new Exception("Cannot unmarshal type CountryCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CountryCode)untypedValue;
            if (value == CountryCode.Us)
            {
                serializer.Serialize(writer, "US");
                return;
            }
            throw new Exception("Cannot marshal type CountryCode");
        }

        public static readonly CountryCodeConverter Singleton = new CountryCodeConverter();
    }

    internal class AddressTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddressType) || t == typeof(AddressType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Mailing":
                    return AddressType.Mailing;
                case "Physical":
                    return AddressType.Physical;
            }
            throw new Exception("Cannot unmarshal type AddressType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddressType)untypedValue;
            switch (value)
            {
                case AddressType.Mailing:
                    serializer.Serialize(writer, "Mailing");
                    return;
                case AddressType.Physical:
                    serializer.Serialize(writer, "Physical");
                    return;
            }
            throw new Exception("Cannot marshal type AddressType");
        }

        public static readonly AddressTypeConverter Singleton = new AddressTypeConverter();
    }

    internal class PhoneNumberTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PhoneNumberType) || t == typeof(PhoneNumberType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Fax":
                    return PhoneNumberType.Fax;
                case "TTY":
                    return PhoneNumberType.Tty;
                case "Voice":
                    return PhoneNumberType.Voice;
            }
            throw new Exception("Cannot unmarshal type PhoneNumberType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PhoneNumberType)untypedValue;
            switch (value)
            {
                case PhoneNumberType.Fax:
                    serializer.Serialize(writer, "Fax");
                    return;
                case PhoneNumberType.Tty:
                    serializer.Serialize(writer, "TTY");
                    return;
                case PhoneNumberType.Voice:
                    serializer.Serialize(writer, "Voice");
                    return;
            }
            throw new Exception("Cannot marshal type PhoneNumberType");
        }

        public static readonly PhoneNumberTypeConverter Singleton = new PhoneNumberTypeConverter();
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
