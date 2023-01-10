using System.Text.Json.Serialization;

namespace Wheater.Proxy.Atlas.Resposes.SearchAddress;

public class AddressResponse
{
    [JsonPropertyName("municipality")] public string Municipality { get; set; }

    [JsonPropertyName("countrySubdivision")]
    public string CountrySubdivision { get; set; }

    [JsonPropertyName("countryCode")] public string CountryCode { get; set; }

    [JsonPropertyName("country")] public string Country { get; set; }

    [JsonPropertyName("countryCodeISO3")] public string CountryCodeIso3 { get; set; }

    [JsonPropertyName("freeformAddress")] public string FreeformAddress { get; set; }

    [JsonPropertyName("streetNumber")] public string StreetNumber { get; set; }

    [JsonPropertyName("streetName")] public string StreetName { get; set; }

    [JsonPropertyName("postalCode")] public string PostalCode { get; set; }

    [JsonPropertyName("extendedPostalCode")]
    public string ExtendedPostalCode { get; set; }

    [JsonPropertyName("localName")] public string LocalName { get; set; }
}