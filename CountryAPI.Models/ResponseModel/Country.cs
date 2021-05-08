using Newtonsoft.Json;
using System.Xml.Serialization;

namespace CountryAPI.Models.ResponseModel
{
	/// <summary>
	/// Country Model
	/// </summary>]
    public class Country
	{
        [XmlAttribute(AttributeName = "id")]
        [JsonProperty("id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "iso2code")]
		[JsonProperty("iso2code")]
		public string Iso2Code { get; set; }

        [XmlElement(ElementName = "name")]
        [JsonProperty("name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "region")]
        [JsonProperty("region")]
        public Region Region { get; set; }

        [XmlElement(ElementName = "adminregion")]
        [JsonProperty("adminregion")]
        public AdminRegion Adminregion { get; set; }

        [XmlElement(ElementName = "incomeLevel")]
        [JsonProperty("incomeLevel")]
        public IncomeLevel IncomeLevel { get; set; }

        [XmlElement(ElementName = "lendingType")]
        [JsonProperty("lendingType")]
        public LendingType LendingType { get; set; }

        [XmlElement(ElementName = "capitalCity")]
        [JsonProperty("capitalCity")]
        public string CapitalCity { get; set; }

        [XmlElement(ElementName = "longitude")]
        [JsonProperty("longitude")]
        public string Longitude { get; set; }

        [XmlElement(ElementName = "latitude")]
        [JsonProperty("latitude")]
        public string Latitude { get; set; }

    }
}
