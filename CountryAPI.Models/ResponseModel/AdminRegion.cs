using Newtonsoft.Json;
using System.Xml.Serialization;

namespace CountryAPI.Models.ResponseModel
{
	/// <summary>
	/// Admin Region Model
	/// </summary>
	[JsonObject("adminregion")]
	public class AdminRegion
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("iso2code")]
		public string Iso2code { get; set; }

		[JsonProperty("value")]
		public string Value { get; set; }
	}
}
