using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace CountryAPI.Models
{
	/// <summary>
	/// Region Model
	/// </summary>
	[JsonObject("region")]
	public class Region
	{
		[JsonPropertyName("id")]
		public string Id { get; set; }

		[JsonPropertyName("iso2code")]
		public string Iso2code { get; set; }

		[JsonPropertyName("value")]
		public string Value { get; set; }
	}
}
