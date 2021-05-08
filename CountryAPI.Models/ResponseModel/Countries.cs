using System.Xml.Serialization;

namespace CountryAPI.Models.ResponseModel
{
    /// <summary>
    /// Model for Countries returned by API
    /// </summary>
    [XmlRoot(ElementName = "countries")]
	public class Countries
	{

		[XmlElement(ElementName = "country")]
		public Country Country { get; set; }

		[XmlAttribute(AttributeName = "wb")]
		public string Wb { get; set; }

		[XmlAttribute(AttributeName = "page")]
		public int Page { get; set; }

		[XmlAttribute(AttributeName = "pages")]
		public int Pages { get; set; }

		[XmlAttribute(AttributeName = "per_page")]
		public int PerPage { get; set; }

		[XmlAttribute(AttributeName = "total")]
		public int Total { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
