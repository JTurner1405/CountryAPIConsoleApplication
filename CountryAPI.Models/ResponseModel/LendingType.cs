using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CountryAPI.Models.ResponseModel
{
	/// <summary>
	/// Lending Type Model
	/// </summary>
	[XmlRoot(ElementName = "lendingType")]
	public class LendingType
	{

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlAttribute(AttributeName = "iso2code")]
		public string Iso2code { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
