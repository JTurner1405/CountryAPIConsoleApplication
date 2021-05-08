using CountryAPI.ConsoleApplication.Interface;
using CountryAPIConsoleApplication.Class;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContryAPI.UnitTests.ConsoleApplication
{
    public class ConsoleTestSetup
    {
        protected IValidationHelper validation;

        [SetUp]
        public void Setup()
        {
            validation = new ValidationHelper();
        }

        [TearDown]
        public void Dispose()
        {
            validation = null;
        }
    }
}
