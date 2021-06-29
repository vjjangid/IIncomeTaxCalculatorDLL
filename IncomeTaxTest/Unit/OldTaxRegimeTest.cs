namespace IncomeTaxTest.Unit
{
    using IncomeTax.Core.OldTaxRegimeStrategy;
    using NUnit.Framework;

    [TestFixture]
    internal class OldTaxRegimeTest
    {
        private OldTaxRegime m_OldTaxRegime;

        [OneTimeSetUp]
        public void Init()
        {
            m_OldTaxRegime = new OldTaxRegime(800000,
                                              400000,
                                              200000,
                                              true,
                                              100000);
        }

        [Test]
        public void Given_Amount_When_Invoke_GetHealthSurcharge_Then_Return_HealthTax()
        {

        }

    }
}

