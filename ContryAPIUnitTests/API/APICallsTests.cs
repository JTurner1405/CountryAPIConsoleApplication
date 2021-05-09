using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContryAPI.UnitTests.API
{
    public class APICallsTests : APICallsTestSetup
    {
        [Test]
        public void RequestCountryGBTest()
        {
            var result = client.RequestCountry("gb");

            Assert.IsNotNull(result);
            Assert.AreEqual("United Kingdom", result.CountryList.FirstOrDefault().Name);
            Assert.AreEqual("GBR", result.CountryList.FirstOrDefault().Id);
        }

        [Test]
        public void RequestCountryAllTest()
        {
            var result = client.RequestCountry(string.Empty);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.CountryList.Any());
            Assert.AreEqual(50, result.CountryList.Count);
        }

        [Test]
        public void ConvertStringToObjectTest()
        {
            var result = client.ConvertStringToObject("[{\"page\":1,\"pages\":1,\"per_page\":\"50\",\"total\":1},[{\"id\":\"GBR\",\"iso2Code\":\"GB\",\"name\":\"United Kingdom\",\"region\":{\"id\":\"ECS\",\"iso2code\":\"Z7\",\"value\":\"Europe & Central Asia\"},\"adminregion\":{\"id\":\"\",\"iso2code\":\"\",\"value\":\"\"},\"incomeLevel\":{\"id\":\"HIC\",\"iso2code\":\"XD\",\"value\":\"High income\"},\"lendingType\":{\"id\":\"LNX\",\"iso2code\":\"XX\",\"value\":\"Not classified\"},\"capitalCity\":\"London\",\"longitude\":\"-0.126236\",\"latitude\":\"51.5002\"}]]");

            Assert.IsNotNull(result);
        }

        [Test]
        public void ConvertStringToObjectEmptyStringTest()
        {
            var result = client.ConvertStringToObject(string.Empty);

            Assert.IsNull(result);

        }

        [Test]
        public void ConvertStringToObjectInvalidStringTest()
        {
            var result = client.ConvertStringToObject("Testing Test Test");

            Assert.IsNull(result);

        }
    }
}
