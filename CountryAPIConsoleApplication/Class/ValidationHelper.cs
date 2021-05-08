using CountryAPI.ConsoleApplication.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CountryAPIConsoleApplication.Class
{
    /// <summary>
    /// Class to Check if string passed is in valid format
    /// </summary>
    public class ValidationHelper : IValidationHelper
    {
        /// <summary>
        /// Check is string passed is Valid
        /// </summary>
        /// <param name="value">String to check </param>
        /// <returns>If valid & Any reason for failures</returns>
        public Tuple<bool, string> ValidString(string value)
        {
            if(string.IsNullOrEmpty(value))
            {
                return new Tuple<bool, string>(false, "No value passed, String must contain either 2 or 3 charcters");
            }

            if(value.Length > 3)
            {
                return new Tuple<bool, string>(false, "String contains to many characters, Maximum of 3 characters allowed");
            }

            if(value.Length < 2)
            {
                return new Tuple<bool, string>(false, "Only 1 character read, String must contain either 2 or 3 charcters");
            }

            return ValidateRegex(value);
        }

        /// <summary>
        /// Check validation against Regex for character types
        /// </summary>
        /// <param name="value">String to check</param>
        /// <returns>If valid & Any reason for failures</returns>
        public Tuple<bool, string> ValidateRegex(string value)
        {
            string pattern = @"^[a-zA-Z]{2,3}$";
            Regex validator = new Regex(pattern);

            if(validator.Match(value).Success)
            {
                return new Tuple<bool, string>(true, string.Empty);
            }
            else
            {
                return new Tuple<bool, string>(false, "String did not match expected requirements. Between 2-3 characters & only characters");
            }            
        }
    }
}
