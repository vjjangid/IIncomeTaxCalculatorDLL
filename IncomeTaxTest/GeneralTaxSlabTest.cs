using IncomeTax.Core.OldTaxRegimeStrategy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IncomeTaxTest
{
    [TestClass]
    public class GeneralTaxSlabTest
    {
        private readonly GeneralTaxSlab generalTaxSlab = new GeneralTaxSlab();
        /// <summary>
        /// Check the Gerneral category perosn having no taxable income
        /// </summary>
        [TestMethod]
        public void CalculateTax_NoTaxCategoryGive_ShouldReturnZero()
        {
            int expected = 0;
            int actual = (int)generalTaxSlab.CalculateTax(250000);
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// General category salary upto 5Lakh
        /// </summary>
        [TestMethod]
        public void CalculateTax_FivePercentTaxCategoryGiven_ShouldReturnDouble()
        {
            int expected = 12500;
            int actual = (int)generalTaxSlab.CalculateTax(500000);
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// General category salary upto 10Lakh
        /// </summary>
        [TestMethod]
        public void GenrealSlab20PercentTaxCategory()
        {
            int expected = 12500 + 100000;
            int actual = (int)generalTaxSlab.CalculateTax(1000000);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// General category salary after 10Lakh
        /// </summary>
        [TestMethod]
        public void GenrealSlab30PercentTaxCategory()
        {
            int expected = 12500 + 100000 + 60000;
            int actual = (int)generalTaxSlab.CalculateTax(1200000);
            Assert.AreEqual(expected, actual);
        }
    }
}
