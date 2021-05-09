using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryAPI.Models.ResponseModel
{
    /// <summary>
    /// Root Object for storing API Response
    /// </summary>
    public class APIRoot
    {
        public List<Country> CountryList { get; set; }

        public PageCount Countries { get; set; }

        /// <summary>
        /// Constructor for Setting up API Root
        /// </summary>
        /// <param name="rootObject">Page object</param>
        /// <param name="countryList">Lost of country objects</param>
        public APIRoot(PageCount rootObject, List<Country> countryList)
        {
            this.Countries = rootObject;
            this.CountryList = countryList;
        }
    }
}
