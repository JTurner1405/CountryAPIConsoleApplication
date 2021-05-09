using CountryAPI.Models;
using CountryAPI.Models.ResponseModel;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContryAPI.UnitTests.ConsoleApplication
{
    public class ConsoleActionTests : ConsoleTestSetup
    {
        [Test]
        public void OutputResultInvalidValueTest()
        {
            mockValidation.Setup(x => x.IsValidString(It.IsAny<string>())).Returns(new Tuple<bool, string>(false, "Test Response"));

            var result = consoleActions.OutputResult("value");

            Assert.IsFalse(string.IsNullOrEmpty(result));
            Assert.AreEqual("Value entered is not valid. Due to Test Response", result);
        }

        [Test]
        public void OutputResultExitValueTest()
        {
            var result = consoleActions.OutputResult("exit");

            Assert.IsTrue(string.IsNullOrEmpty(result));
        }

        [Test]
        public void OutputResultNoResponseFromAPITest()
        {
            mockValidation.Setup(x => x.IsValidString(It.IsAny<string>())).Returns(new Tuple<bool, string>(true, string.Empty));
            mockApiCalls.Setup(x => x.RequestCountry(It.IsAny<string>())).Returns((APIRoot)null);

            var result = consoleActions.OutputResult("value");

            Assert.IsFalse(string.IsNullOrEmpty(result));
            Assert.AreEqual("No Response return from API.", result);
        }

        [Test]
        public void OutputResultSuccessfulResponseTest()
        {
            mockValidation.Setup(x => x.IsValidString(It.IsAny<string>())).Returns(new Tuple<bool, string>(true, string.Empty));
            mockApiCalls.Setup(x => x.RequestCountry(It.IsAny<string>())).Returns(new APIRoot(new PageCount(), new List<Country>()
            {
                new Country()
                {
                    Name = "Test Country",
                    Longitude = "55",
                    Latitude = "66",
                    CapitalCity = "Capital",
                    Region = new Region()
                    {
                        Value = "Wales"
                    }
                }
            }));

            var result = consoleActions.OutputResult("value");

            Assert.IsFalse(string.IsNullOrEmpty(result));
            Assert.AreEqual("Country Name: Test Country\nRegion: Wales\nCapital City: Capital\nLongitude: 55\nLatitude: 66\n", result);
        }
    }
}
