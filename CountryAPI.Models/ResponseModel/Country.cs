using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace CountryAPI.Models.ResponseModel
{
	/// <summary>
	/// Country Model
	/// </summary>]
    public class Country
	{
        [XmlAttribute(AttributeName = "id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "iso2code")]
		[JsonPropertyName("iso2code")]
		public string Iso2Code { get; set; }

        [XmlElement(ElementName = "name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "region")]
        [JsonPropertyName("region")]
        public Region Region { get; set; }

        [XmlElement(ElementName = "adminregion")]
        [JsonPropertyName("adminregion")]
        public AdminRegion Adminregion { get; set; }

        [XmlElement(ElementName = "incomeLevel")]
        [JsonPropertyName("incomeLevel")]
        public IncomeLevel IncomeLevel { get; set; }

        [XmlElement(ElementName = "lendingType")]
        [JsonPropertyName("lendingType")]
        public LendingType LendingType { get; set; }

        [XmlElement(ElementName = "capitalCity")]
        [JsonPropertyName("capitalCity")]
        public string CapitalCity { get; set; }

        [XmlElement(ElementName = "longitude")]
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        [XmlElement(ElementName = "latitude")]
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        public override string ToString()
        {
            return "Country Name: " + this.Name + "\nRegion: " + this.Region.Value + "\nCapital City: " + this.CapitalCity + "\nLongitude: " + this.Longitude + "\nLatitude: " + this.Latitude;
        }

    }
}
