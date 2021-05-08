using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace CountryAPI.Models.ResponseModel
{
    /// <summary>
    /// Model for Countries returned by API
    /// </summary>
    public class Countries
	{
		public List<Country> Country { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("per_page")]
        public string PerPage { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
	}
}
