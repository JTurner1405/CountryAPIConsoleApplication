using System.Text.Json.Serialization;

namespace CountryAPI.Models.ResponseModel
{
    /// <summary>
    /// Model for Pages returned by API
    /// </summary>
    public class PageCount
	{
        [JsonPropertyName("page")]
        public int Page { get; set; }
        [JsonPropertyName("pages")]
        public int Pages { get; set; }

        [JsonPropertyName("per_page")]
        public string PerPage { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
