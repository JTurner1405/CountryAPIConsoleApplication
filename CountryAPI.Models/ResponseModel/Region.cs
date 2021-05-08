using System.Xml.Serialization;

namespace CountryAPI.Models
{
	/// <summary>
	/// Region Model
	/// </summary>
    [XmlRoot(ElementName = "region")]
	public class Region
	{

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlAttribute(AttributeName = "iso2code")]
		public string Iso2code { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
