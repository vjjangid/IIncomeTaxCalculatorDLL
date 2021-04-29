using IncomeTax.Core.OldTaxRegimeStrategy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IncomeTaxTest
{
    [TestClass]
    public class SeniorTaxSlabTest
    {
        private readonly SeniorTaxSlab seniorTaxSlab = new SeniorTaxSlab();

        /// <summary>
        /// Check the Senior category perosn having no taxable income
        /// </summary>
        [TestMethod]
        public void CalculateTax_NoTaxCategoryIncomeGiven_ShouldReturnZero()
        {
            int expected = 0;
            int actual = (int)seniorTaxSlab.CalculateTax(300000);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Check the Senior category perosn having income upto 5Lakh
        /// </summary>
        [TestMethod]
        public void CalculateTax_FivePercentTaxCategoryIncomeGive_ShouldReturnDouble()
        {
            int expected = 10000;
            int actual = (int)seniorTaxSlab.CalculateTax(500000);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Check the Senior category perosn having income upto 10Lakh
        /// </summary>
        [TestMethod]
        public void CalculateTax_TwentyPercentTaxCategoryIncomeGiven_ShouldReturnDouble()
        {
            int expected = 10000 + 100000;
            int actual = (int)seniorTaxSlab.CalculateTax(1000000);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Check the Senior category perosn having income more than 10Lakh
        /// </summary>
        [TestMethod]
        public void CalculateTax_ThirtyPercentTaxCategoryIncomeGiven_ShouldReturnDouble()
        {
            int expected = 10000 + 100000 + 60000;
            int actual = (int)seniorTaxSlab.CalculateTax(1200000);
            Assert.AreEqual(expected, actual);
        }
    }
}
