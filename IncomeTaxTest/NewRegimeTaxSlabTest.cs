using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IncomeTax;

namespace IncomeTaxTest
{
    /// <summary>
    /// To check new regime tax slab
    /// </summary>
    [TestClass]
    public class NewRegimeTaxSlabTest
    {
        /// <summary>
        /// No taxable income test that is 2.5Lakh
        /// </summary>
        [TestMethod]
        public void NewRegimeTaxSlabNoTaxTest()
        {
            //--Arrange
            NewRegimeTaxSlab newSlab = new NewRegimeTaxSlab();
            int expected = 0;

            //--Act
            int actual = newSlab.Calculate(250000);

            //--Assert
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        /// Income upto 5L
        /// </summary>
        [TestMethod]
        public void NewRegimeTaxSlab5PercentTaxTest()
        {
            //--Arrange
            NewRegimeTaxSlab newSlab = new NewRegimeTaxSlab();
            int expected = 12500;

            //--Act
            int actual = newSlab.Calculate(500000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Income upto 7.5L
        /// </summary>
        [TestMethod]
        public void NewRegimeTaxSlab10PercentTaxTest()
        {
            //--Arrange
            NewRegimeTaxSlab newSlab = new NewRegimeTaxSlab();
            int expected = 12500 + 25000;

            //--Act
            int actual = newSlab.Calculate(750000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Income upto 10L
        /// </summary>
        [TestMethod]
        public void NewRegimeTaxSlab15PercentTaxTest()
        {
            //--Arrange
            NewRegimeTaxSlab newSlab = new NewRegimeTaxSlab();
            int expected = 12500 + 25000 + 37500;

            //--Act
            int actual = newSlab.Calculate(1000000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Income upto 12.5L
        /// </summary>
        [TestMethod]
        public void NewRegimeTaxSlab20PercentTaxTest()
        {
            //--Arrange
            NewRegimeTaxSlab newSlab = new NewRegimeTaxSlab();
            int expected = 12500 + 25000 + 37500 + 50000;

            //--Act
            int actual = newSlab.Calculate(1250000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Income upto 15L
        /// </summary>
        [TestMethod]
        public void NewRegimeTaxSlab25PercentTaxTest()
        {
            //--Arrange
            NewRegimeTaxSlab newSlab = new NewRegimeTaxSlab();
            int expected = 12500 + 25000 + 37500 + 50000 + 62500;

            //--Act
            int actual = newSlab.Calculate(1500000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Income upto 30L
        /// </summary>
        [TestMethod]
        public void NewRegimeTaxSlab30PercentTaxTest()
        {
            //--Arrange
            NewRegimeTaxSlab newSlab = new NewRegimeTaxSlab();
            int expected = 12500 + 25000 + 37500 + 50000 + 62500 + 150000;

            //--Act
            int actual = newSlab.Calculate(2000000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
