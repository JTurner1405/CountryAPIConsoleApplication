using CountryAPI.API.Class;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContryAPI.UnitTests.API
{
    public class APICallsTestSetup
    {
        protected APICalls client;
        [SetUp]
        public void Setup()
        {
            var url = "http://api.worldbank.org/v2/country";
            client = new APICalls(url);
        }

        [TearDown]
        public void Dispose()
        {
            client = null;
        }
    }
}
