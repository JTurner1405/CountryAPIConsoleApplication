using CountryAPI.ConsoleApplication.Interface;
using CountryAPIConsoleApplication.Class;
using System;

namespace CountryAPIConsoleApplication
{
    public class Program
    {
        private static IValidationHelper validation;

        /// <summary>
        ///  initilize objects & start program
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            
            validation = new ValidationHelper();

            RequestISOValue();
        }

        /// <summary>
        /// Read Console Input
        /// </summary>
        public static void RequestISOValue()
        {
            Console.WriteLine("Please Enter a country ISO Code?");
            var responseValue = Console.ReadLine();

            Tuple<bool, string> isValid = validation.ValidString(responseValue);

            if (isValid.Item1)
            {
                Console.WriteLine("Value is valid");
            }
            else
            {
                Console.WriteLine("Value entered is not valid. Due to " + isValid.Item2);
            }
        }


    }

    
}
