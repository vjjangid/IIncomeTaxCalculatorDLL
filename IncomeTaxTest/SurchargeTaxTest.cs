using IncomeTax.Core.SurchargeTaxStrategy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IncomeTaxTest
{
    [TestClass]
    public class SurchargeTaxTest
    {
        [TestMethod]
        public void getCategory_GeneralTaxableIncomeGiven_ShouldReturnInteger()
        {
            SurchargeTax tax = new SurchargeTax(25000000);
            int expected = 20000000;

            int original = tax.getCategory();

            Assert.AreEqual(expected, original);
        }

        [TestMethod]
        public void getCategory_NoCategoryTaxableIncomeGiven_ShouldReturnZero()
        {
            SurchargeTax tax = new SurchargeTax(1000000);
            int expected = 0;

            int original = tax.getCategory();

            Assert.AreEqual(expected, original);
        }

        [TestMethod]
        public void getTotalTax_GeneralTaxableIncomeGiven_ShouldReturnIntTax()
        {
            SurchargeTax tax = new SurchargeTax(10000000);
            int expected = 1500000;

            int original = tax.TotalSurchageTax();

            Assert.AreEqual(expected, original);
        }

        [TestMethod]
        public void getTotalTax_NoCategoryTaxableIncomeGiven_ShouldReturnZero()
        {

            SurchargeTax tax = new SurchargeTax(1000000);
            int expected = 0;

            int original = tax.TotalSurchageTax();

            Assert.AreEqual(expected, original);
        }
    }
}
