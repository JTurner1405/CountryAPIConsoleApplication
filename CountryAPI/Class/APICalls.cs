using CountryAPI.API.Interface;
using CountryAPI.Models.ResponseModel;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json.Serialization;
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
        public APIRoot RequestCountry(string value)
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

            try
            {
                var response = client.Execute(request);

#if DEBUG
                Trace.WriteLine(response.Content);
#endif

                return this.ConvertStringToObject(response.Content);

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }

            return null;
        }

        /// <summary>
        /// Convert API String content to Objects
        /// </summary>
        /// <param name="value">API Content to convert</param>
        /// <returns>API Root object</returns>
        public APIRoot ConvertStringToObject(string value)
        {
            if(string.IsNullOrEmpty(value))
            {
                return null;
            }

            try
            {
                var result1 = JsonConvert.DeserializeObject<List<Object>>(value);
                var pages = JsonConvert.DeserializeObject<PageCount>(result1[0].ToString());
                var listOfCountry = JsonConvert.DeserializeObject<List<Country>>(result1[1].ToString());
                
                return new APIRoot(pages, listOfCountry);
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
            return null;
        }
    }
}