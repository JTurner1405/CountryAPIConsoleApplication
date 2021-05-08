using System.Xml.Serialization;

namespace CountryAPI.Models.ResponseModel
{
	/// <summary>
	/// Income Level Model
	/// </summary>
    [XmlRoot(ElementName = "incomeLevel")]
	public class IncomeLevel
	{

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlAttribute(AttributeName = "iso2code")]
		public string Iso2code { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
