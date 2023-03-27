using Business.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class ValidationServiceTest
    {

        [TestMethod]
        public void ParseNumberTest()
        {
            ValidationService.ParseNumber("1", out int parsedNum);

            Assert.IsTrue(parsedNum == 1);
        }

        [TestMethod]
        public void AssertPositiveTest()
        {
            bool parsed = ValidationService.AssertPositive("1");

            Assert.IsTrue(parsed);
        }

        [TestMethod]
        public void AssertEmailTest()
        {
            bool isEmail = ValidationService.AssertEmail("toni.skobicgmail.com");

            Assert.IsFalse(isEmail);
        }

        [TestMethod]
        public void CheckPhoneNumTest()
        {
            bool isPhone = ValidationService.IsPhoneNumberValid("51252151242144214");

            Assert.IsFalse(isPhone);
        }

        [TestMethod]
        public void AssertStringLengthTest()
        {
            bool stringLength = ValidationService.AssertStringLength("alexandria", 10);

            Assert.IsTrue(stringLength);
        }
    }
}
