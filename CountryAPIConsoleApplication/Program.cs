using CountryAPI.API.Class;
using CountryAPI.ConsoleApplication.Class;
using CountryAPI.ConsoleApplication.Interface;
using CountryAPIConsoleApplication.Class;
using System;

namespace CountryAPIConsoleApplication
{
    public class Program
    {
        /// <summary>
        ///  initilize objects & start program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            
            var validation = new ValidationHelper();
            var apiCalls = new APICalls("http://api.worldbank.org/v2/country");


            var consoleOutput = new ConsoleActions(validation, apiCalls);

            consoleOutput.RequestISOValue();
        }

        


    }

    
}
