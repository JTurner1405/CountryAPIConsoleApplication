using System.Xml.Serialization;

namespace CountryAPI.Models.ResponseModel
{
	/// <summary>
	/// Admin Region Model
	/// </summary>
    [XmlRoot(ElementName = "adminregion")]
	public class AdminRegion
	{

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlAttribute(AttributeName = "iso2code")]
		public string Iso2code { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
