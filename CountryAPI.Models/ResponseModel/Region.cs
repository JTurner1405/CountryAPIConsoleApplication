using Newtonsoft.Json;
using System.Xml.Serialization;

namespace CountryAPI.Models
{
	/// <summary>
	/// Region Model
	/// </summary>
	[JsonObject("region")]
	public class Region
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("iso2code")]
		public string Iso2code { get; set; }

		[JsonProperty("value")]
		public string Value { get; set; }
	}
}
