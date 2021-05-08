using System.Xml.Serialization;

namespace CountryAPI.Models.ResponseModel
{
	/// <summary>
	/// Country Model
	/// </summary>
    [XmlRoot(ElementName = "country")]
	public class Country
	{

		[XmlElement(ElementName = "iso2Code")]
		public string Iso2Code { get; set; }

		[XmlElement(ElementName = "name")]
		public string Name { get; set; }

		[XmlElement(ElementName = "region")]
		public Region Region { get; set; }

		[XmlElement(ElementName = "adminregion")]
		public AdminRegion Adminregion { get; set; }

		[XmlElement(ElementName = "incomeLevel")]
		public IncomeLevel IncomeLevel { get; set; }

		[XmlElement(ElementName = "lendingType")]
		public LendingType LendingType { get; set; }

		[XmlElement(ElementName = "capitalCity")]
		public string CapitalCity { get; set; }

		[XmlElement(ElementName = "longitude")]
		public double Longitude { get; set; }

		[XmlElement(ElementName = "latitude")]
		public double Latitude { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
