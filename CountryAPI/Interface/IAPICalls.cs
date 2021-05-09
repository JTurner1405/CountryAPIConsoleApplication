using CountryAPI.Models.ResponseModel;

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
        APIRoot RequestCountry(string value);

        /// <summary>
        /// Convert API String content to Objects
        /// </summary>
        /// <param name="value">API Content to convert</param>
        /// <returns>API Root object</returns>
        APIRoot ConvertStringToObject(string value);
    }
}
