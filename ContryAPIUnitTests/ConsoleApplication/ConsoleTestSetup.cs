using CountryAPI.API.Interface;
using CountryAPI.ConsoleApplication.Class;
using CountryAPI.ConsoleApplication.Interface;
using CountryAPIConsoleApplication.Class;
using Moq;
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
        protected Mock<IValidationHelper> mockValidation;
        protected Mock<IAPICalls> mockApiCalls;
        protected IConsoleActions consoleActions;

        [SetUp]
        public void Setup()
        {
            validation = new ValidationHelper();
            mockValidation = new Mock<IValidationHelper>();
            mockApiCalls = new Mock<IAPICalls>();
            consoleActions = new ConsoleActions(mockValidation.Object, mockApiCalls.Object);
        }

        [TearDown]
        public void Dispose()
        {
            validation = null;
            mockApiCalls = null;
            mockValidation = null;
            consoleActions = null;
        }
    }
}
