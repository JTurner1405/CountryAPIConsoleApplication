using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContryAPI.UnitTests.ConsoleApplication
{
    
    public class ValidationHelperTests : ConsoleTestSetup
    {

        [Test]
        public void ValidateRegexNumberTest()
        {
            var result = validation.ValidateRegex("aa4");

            Assert.IsFalse(result.Item1);
            Assert.AreEqual("String did not match expected requirements. Between 2-3 characters & only characters", result.Item2);
        }

        [Test]
        public void ValidateRegexCharactersTest()
        {
            var result = validation.ValidateRegex("abc");

            Assert.IsTrue(result.Item1);
            Assert.AreEqual(string.Empty, result.Item2);
        }

        [Test]
        public void ValidateRegexSymbolsTest()
        {
            var result = validation.ValidateRegex("a$d");

            Assert.IsFalse(result.Item1);
            Assert.AreEqual("String did not match expected requirements. Between 2-3 characters & only characters", result.Item2);
        }

        [Test]
        public void ValidateRegexLongStringTest()
        {
            var result = validation.ValidateRegex("abdd");

            Assert.IsFalse(result.Item1);
            Assert.AreEqual("String did not match expected requirements. Between 2-3 characters & only characters", result.Item2);
        }

        [Test]
        public void ValidateRegexShortStringTest()
        {
            var result = validation.ValidateRegex("a");

            Assert.IsFalse(result.Item1);
            Assert.AreEqual("String did not match expected requirements. Between 2-3 characters & only characters", result.Item2);
        }

        [Test]
        public void ValidStringEmptyStringTest()
        {
            var result = validation.IsValidString(string.Empty);
            Assert.IsTrue(result.Item1);
        }

        [Test]
        public void ValidStringTest()
        {
            var result = validation.IsValidString("abc");
            Assert.IsTrue(result.Item1);
            Assert.IsEmpty(result.Item2);
        }

        [Test]
        public void ValidStringToShortTest()
        {
            var result = validation.IsValidString("a");
            Assert.IsFalse(result.Item1);
            Assert.AreEqual("Only 1 character read, String must contain either 2 or 3 charcters", result.Item2);
        }

        [Test]
        public void ValidStringToLongTest()
        {
            var result = validation.IsValidString("asdfasdf");

            Assert.IsFalse(result.Item1);
            Assert.AreEqual("String contains to many characters, Maximum of 3 characters allowed", result.Item2);
        }
    }
}
