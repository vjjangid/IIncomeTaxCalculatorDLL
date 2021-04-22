using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IncomeTax.Core;

namespace IncomeTaxTest
{
    /// <summary>
    /// Testing the slab rates of tax
    /// </summary>
    [TestClass]
    public class OldRegimeTaxSlabTest
    {
        /// <summary>
        /// Check the Gerneral category perosn having no taxable income
        /// </summary>
        [TestMethod]
        public void GenrealSlabNoTaxCategory()
        {
            //--Arrange
            OldRegimeTaxSlab old = new OldRegimeTaxSlab();
            int expected = 0;

            //--Act
            int actual = old.calculateTax(AgeCategory.General, 250000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }


        /// <summary>
        /// General category salary upto 5Lakh
        /// </summary>
        [TestMethod]
        public void GenrealSlab5PercentTaxCategory()
        {
            //--Arrange
            OldRegimeTaxSlab old = new OldRegimeTaxSlab();
            int expected = 12500;

            //--Act
            int actual = old.calculateTax(AgeCategory.General, 500000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// General category salary upto 10Lakh
        /// </summary>
        [TestMethod]
        public void GenrealSlab20PercentTaxCategory()
        {
            //--Arrange
            OldRegimeTaxSlab old = new OldRegimeTaxSlab();
            int expected = 12500 + 100000;

            //--Act
            int actual = old.calculateTax(AgeCategory.General, 1000000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// General category salary after 10Lakh
        /// </summary>
        [TestMethod]
        public void GenrealSlab30PercentTaxCategory()
        {
            //--Arrange
            OldRegimeTaxSlab old = new OldRegimeTaxSlab();
            int expected = 12500 + 100000 + 60000;

            //--Act
            int actual = old.calculateTax(AgeCategory.General, 1200000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Check the Senior category perosn having no taxable income
        /// </summary>
        [TestMethod]
        public void SeniorSlabNoTaxCategory()
        {
            //--Arrange
            OldRegimeTaxSlab old = new OldRegimeTaxSlab();
            int expected = 0;

            //--Act
            int actual = old.calculateTax(AgeCategory.Senior, 300000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Check the Senior category perosn having income upto 5Lakh
        /// </summary>
        [TestMethod]
        public void SeniorSlab5PercentTaxCategory()
        {
            //--Arrange
            OldRegimeTaxSlab old = new OldRegimeTaxSlab();
            int expected = 10000;

            //--Act
            int actual = old.calculateTax(AgeCategory.Senior, 500000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Check the Senior category perosn having income upto 10Lakh
        /// </summary>
        [TestMethod]
        public void SeniorSlab20PercentTaxCategory()
        {
            //--Arrange
            OldRegimeTaxSlab old = new OldRegimeTaxSlab();
            int expected = 10000 + 100000;

            //--Act
            int actual = old.calculateTax(AgeCategory.Senior, 1000000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Check the Senior category perosn having income more than 10Lakh
        /// </summary>
        [TestMethod]
        public void SeniorSlab30PercentTaxCategory()
        {
            //--Arrange
            OldRegimeTaxSlab old = new OldRegimeTaxSlab();
            int expected = 10000 + 100000 + 60000;

            //--Act
            int actual = old.calculateTax(AgeCategory.Senior, 1200000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Check the Super Senior category perosn having no taxable income
        /// </summary>
        [TestMethod]
        public void SuperSeniorSlabNoTaxCategory()
        {
            //--Arrange
            OldRegimeTaxSlab old = new OldRegimeTaxSlab();
            int expected = 0;

            //--Act
            int actual = old.calculateTax(AgeCategory.SuperSenior, 500000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Check the Super Senior category perosn having income upto 10L
        /// </summary>
        [TestMethod]
        public void SuperSeniorSlab20PercentTaxCategory()
        {
            //--Arrange
            OldRegimeTaxSlab old = new OldRegimeTaxSlab();
            int expected = 100000;

            //--Act
            int actual = old.calculateTax(AgeCategory.SuperSenior, 1000000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Check the Super Senior category perosn having income more then 10L
        /// </summary>
        [TestMethod]
        public void SuperSeniorSlab30PercentTaxCategory()
        {
            //--Arrange
            OldRegimeTaxSlab old = new OldRegimeTaxSlab();
            int expected = 100000 + 60000;

            //--Act
            int actual = old.calculateTax(AgeCategory.SuperSenior, 1200000);

            //--Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
