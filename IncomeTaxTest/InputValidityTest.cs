using IncomeTax.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace IncomeTaxTest
{
    [TestClass]
    public class InputValidityTest
    {
        [TestMethod]
        public void AmountValidityTest()
        {
            //--Arrange
            
            int expected = 0;

            //--Act
            int actual = InputValidity.ValidAmounts(-15000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void MobileNumberValidityTest()
        {
            //Arrange
            bool expected = true;

            //Act
            bool original = InputValidity.ValidMobileNumber("918502803874");

            //Assert
            Assert.AreEqual(expected, original);
        }
    }
}
