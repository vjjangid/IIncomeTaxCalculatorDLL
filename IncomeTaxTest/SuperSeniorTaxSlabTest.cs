using IncomeTax.Core.OldTaxRegimeStrategy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IncomeTaxTest
{
    [TestClass]
    public class SuperSeniorTaxSlabTest
    {
        private readonly SuperSeniorTaxSlab superSeniorTaxSlab = new SuperSeniorTaxSlab();

        /// <summary>
        /// Check the Super Senior category perosn having no taxable income
        /// </summary>
        [TestMethod]
        public void CalculateTax_NoTaxCategoryIncomeGiven_ShouldReturnZero()
        {
            int expected = 0;
            int actual = (int)superSeniorTaxSlab.CalculateTax(500000);
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Check the Super Senior category perosn having income upto 10L
        /// </summary>
        [TestMethod]
        public void CalculateTax_TwentyPercentTaxCategoryIncomeGive_ShouldReturnDouble()
        {
            int expected = 100000;
            int actual = (int)superSeniorTaxSlab.CalculateTax(1000000);
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Check the Super Senior category perosn having income more then 10L
        /// </summary>
        [TestMethod]
        public void Calculate_ThirtyPercentTaxCategoryIncomeGiven_ShouldReturnDouble()
        {
            int expected = 100000 + 60000;
            int actual = (int)superSeniorTaxSlab.CalculateTax(1200000);
            Assert.AreEqual(expected, actual);

        }
    }
}
