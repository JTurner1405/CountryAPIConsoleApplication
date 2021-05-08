using CountryAPI.API.Interface;
using CountryAPI.Models.ResponseModel;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;

namespace CountryAPI.API.Class
{
    /// <summary>
    /// Class to carry out Rest API Calls
    /// </summary>
    public class APICalls : IAPICalls
    {
        private readonly RestClient client;
        
        /// <summary>
        /// Initilize RestSharp Client with URL to send request to
        /// </summary>
        /// <param name="url"></param>
        public APICalls(string url)
        {
            client = new RestClient(url);
            //client.UseDotNetXmlSerializer();
        }

        /// <summary>
        /// Request country data based on ISO value passed
        /// </summary>
        /// <param name="value">ISO value to request data on</param>
        /// <returns>Country data returned</returns>
        public Countries RequestCountry(string value)
        {
            RestRequest request;
            if(string.IsNullOrEmpty(value))
            {
                request = new RestRequest();
            }
            else
            {
                request = new RestRequest(value);
            }
            request.AddParameter("format", "json");

            var response = client.Execute(request);
            Trace.WriteLine(response.Content);
            try
            {
                var result1 = JsonConvert.DeserializeObject<List<Countries>>(response.Content);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }

            return null;
        }
    }
}
