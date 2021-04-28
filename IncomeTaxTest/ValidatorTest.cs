using IncomeTax.Core;
using IncomeTax.Core.CustomException;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IncomeTaxTest
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        public void ValidateMoneyAmount_NegativeAmountGiven_ShouldReturnZero()
        {
            //--Arrange
            
            int expected = 0;

            //--Act
            int actual = Validator.ValidateMoneyAmount(-15000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidateMobileNumber_ValidMobileNumberGiven_ShouldReturnTrue()
        {
            //Arrange
            bool expected = true;

            //Act
            bool original = Validator.ValidateMobileNumber("918502803874");

            //Assert
            Assert.AreEqual(expected, original);
        }

        [TestMethod]
        public void ValidateNonEmptyInput_EmptyStringGiven_ShouldReturnFalse()
        {
            bool expected = false;
            bool original = Validator.ValidateNonEmptyInput("");
            Assert.AreEqual(expected, original);
        }

        [TestMethod]
        public void ValdateName_InvalidNameGiven_ShouldReturnFalse()
        {
            bool expected = false;
            bool original = Validator.ValidateName("213Vijay");
            Assert.AreEqual(expected, original);
        }

        [TestMethod]
        public void ValidateDOB_InvalidAgeGiven_ShouldReturnFalse()
        {
            bool expected = false;
            bool original = Validator.ValidateDOB(13);
            Assert.AreEqual(expected, original);
        }

    }
}
