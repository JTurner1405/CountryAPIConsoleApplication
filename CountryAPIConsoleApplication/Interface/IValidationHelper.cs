using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryAPI.ConsoleApplication.Interface
{
    /// <summary>
    /// Interface for validation methods
    /// </summary>
    public interface IValidationHelper
    {
        /// <summary>
        /// Check is string passed is Valid
        /// </summary>
        /// <param name="value">String to check </param>
        /// <returns>If valid & Any reason for failures</returns>
        Tuple<bool, string> IsValidString(string value);

        /// <summary>
        /// Check validation against Regex for character types
        /// </summary>
        /// <param name="value">String to check</param>
        /// <returns>If valid & Any reason for failures</returns>
        Tuple<bool, string> ValidateRegex(string value);
    }
}
