namespace IncomeTaxTest.Unit
{
    using IncomeTax.Core.OldTaxRegimeStrategy;
    using NUnit.Framework;

    [TestFixture]
    public class SeniorTaxSlabTest
    {
        private SeniorTaxSlab m_SeniorTaxSlab;

        [OneTimeSetUp]
        public void Init()
        {
            m_SeniorTaxSlab = new SeniorTaxSlab();
        }

        [Test]
        public void Given_Negative_Tax_Amount_When_CalculateTax_Invoked_Then_Returns_Zero()
        {
            //Arrange
            const int expected = 0;

            //Act
            var actual = (int)m_SeniorTaxSlab.CalculateTax(-1523);

            //Assert
            Assert.AreEqual(expected, actual, "Not able to handle the negative amount");
        }

        /// <summary>
        /// Check the Senior category person having no taxable income
        /// </summary>
        [Test]
        public void CalculateTax_NoTaxCategoryIncomeGiven_ShouldReturnZero()
        {
            //Arrange
            const int expected = 0;

            //Act
            int actual = (int)m_SeniorTaxSlab.CalculateTax(300000);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Check the Senior category person having income up-to 5Lakh
        /// </summary>
        [Test]
        public void Given_FivePercentTaxCategory_Amount_When_CalculateTax_Invoked_Then_Returns_TaxAmount()
        {
            //Arrange
            const int expected = 10000;

            //Act
            var actual = (int)m_SeniorTaxSlab.CalculateTax(500000);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Check the Senior category person having income up-to 10Lakh
        /// </summary>
        [Test]
        public void Given_GeneralSlab20PercentTaxCategory_Amount_When_CalculateTax_Invoked_Then_Returns_TaxAmount()
        {
            //Arrange
            const int expected = 10000 + 100000;

            //Act
            var actual = (int)m_SeniorTaxSlab.CalculateTax(1000000);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Check the Senior category person having income more than 10Lakh
        /// </summary>
        [Test]
        public void Given_GeneralSlab30PercentTaxCategory_Amount_When_CalculateTax_Invoked_Then_Return_TaxAmount()
        {
            //Arrange
            const int expected = 10000 + 100000 + 60000;

            //Act
            var actual = (int)m_SeniorTaxSlab.CalculateTax(1200000);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
