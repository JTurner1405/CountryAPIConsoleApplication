using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryAPI.ConsoleApplication.Interface
{
    /// <summary>
    /// Interface for Console operations
    /// </summary>
    public interface IConsoleActions
    {
        /// <summary>
        /// Request ISO value from user;
        /// </summary>
        void RequestISOValue();

        /// <summary>
        /// Takes value entered & passes output of API to user
        /// </summary>
        /// <param name="value">Value to Check</param>
        /// <returns>output of api calls</returns>
        string OutputResult(string value);
    }
}
