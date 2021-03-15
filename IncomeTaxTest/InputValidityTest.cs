using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IncomeTax;
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
    }
}
