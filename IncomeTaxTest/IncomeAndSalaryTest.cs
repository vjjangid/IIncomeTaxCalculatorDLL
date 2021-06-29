namespace IncomeTaxTest
{
    using IncomeTax.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Testing the Income and salary class
    /// </summary>
    [TestClass]
    public class IncomeAndSalaryTest
    {
        [TestMethod]
        public void IncomeAndSalaryAmountValidityTest()
        {
            //--Arrange
            IncomeAndSalary incomeAndSalary = new IncomeAndSalary();
            incomeAndSalary.BasicDAAmount = -898;
            int expected = 0;

            // --Act
            int actual = incomeAndSalary.BasicDAAmount;

            // --Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
