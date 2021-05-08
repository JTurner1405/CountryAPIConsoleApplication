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
        public void test()
        {
            var result = client.RequestCountry("gb");

            Assert.IsNotNull(result);
        }

        [Test]
        public void test1()
        {
            var result = client.RequestCountry(string.Empty);

            Assert.IsNotNull(result);
        }
    }
}
