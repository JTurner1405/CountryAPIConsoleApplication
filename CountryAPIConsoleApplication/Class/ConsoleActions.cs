using CountryAPI.API.Interface;
using CountryAPI.ConsoleApplication.Interface;
using CountryAPIConsoleApplication.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryAPI.ConsoleApplication.Class
{
    /// <summary>
    /// Console Actions class
    /// </summary>
    public class ConsoleActions : IConsoleActions
    {
        private readonly IValidationHelper validation;
        private readonly IAPICalls apiCalls;

        /// <summary>
        /// Initilize Class 
        /// </summary>
        /// <param name="helper"></param>
        public ConsoleActions(IValidationHelper helper, IAPICalls apiCalls)
        {
            validation = helper;
            this.apiCalls = apiCalls;
        }

        /// <summary>
        /// Request ISO value from user;
        /// </summary>
        public void RequestISOValue()
        {
            string value = string.Empty;
                while (!value.Equals("exit"))
            {
                Console.WriteLine("Please Enter a country ISO Code? or \"exit\" to leave");
                value = Console.ReadLine();
                Console.WriteLine(OutputResult(value));
            }
        }

        /// <summary>
        /// Takes value entered & passes output of API to user
        /// </summary>
        /// <param name="value">Value to Check</param>
        /// <returns>output of api calls</returns>
        public string OutputResult(string value)
        {
            if (!value.Equals("exit"))
            {
                Tuple<bool, string> isValid = validation.IsValidString(value);

                if (isValid.Item1)
                {
                    var response = apiCalls.RequestCountry(value);

                    if (response == null)
                    {
                        return "No Response return from API.";
                    }

                    string returnString = string.Empty;
                    foreach (var country in response.CountryList)
                    {
                        returnString += country + "\n";
                    }
                    return returnString;
                }
                else
                {
                    return "Value entered is not valid. Due to " + isValid.Item2;
                }
            }
            return string.Empty;
        }
    }
}
