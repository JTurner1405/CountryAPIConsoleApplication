using CountryAPI.Models.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryAPI.API.Interface
{
    /// <summary>
    /// Interface for all API call actions
    /// </summary>
    public interface IAPICalls
    {
        /// <summary>
        /// Request country data based on ISO value passed
        /// </summary>
        /// <param name="value">ISO value to request data on</param>
        /// <returns>Country data returned</returns>
        Countries RequestCountry(string value);
    }
}
