namespace IncomeTax.Core.OldTaxRegimeStrategy
{
    using GeneralInterfaces;
    using SurchargeTaxStrategy;

    /// <inheritdoc  cref="ExemptionsAndDeductions"/>
    /// <summary>
    /// Tax calculation based on old tax regime
    /// What do I need here
    /// ==&gt; Exemption Deduction are present here --&gt; Inherits Exemption and Deduction class
    /// ==&gt; After exempting Deductions I get taxable income 
    /// ==&gt; On this taxable income calculate Tax --&gt; Use OldTaxRegimeSlab class 
    /// ==&gt; Calculate the surcharge on total income --&gt; Implements ISurcharge interface
    /// ==&gt; Calculate the health surcharge on total tax --&gt; Implements the Health Surcharge interface
    /// </summary>
    public class OldTaxRegime : ExemptionsAndDeductions, IHealthAndEducationSurcharge
    {
        private readonly int s_TotalIncome;
        private readonly int s_HraAmount;
        private readonly int s_BasicDaAmount;
        private readonly int s_RentPaid;
        private readonly bool s_MetroStatus;
        private int m_TotalTaxableAmount;

        #region Constructor


        public OldTaxRegime(int totalIncome,
                            int hraAmount,
                            int basicDaAmount,
                            bool metroStatus,
                            int rentPaid)
        {
            s_TotalIncome = totalIncome;
            s_HraAmount = hraAmount;
            s_BasicDaAmount = basicDaAmount;
            s_MetroStatus = metroStatus;
            s_RentPaid = rentPaid;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Health surcharge is applicable on taxable income
        /// </summary>
        /// <returns></returns>
        public int GetHealthSurcharge()
        {
            return (int)(0.04 * m_TotalTaxableAmount);
        }

        /// <summary>
        /// Total cess surcharge on taxable income
        /// </summary>
        /// <returns></returns>
        public int GetSurcharge()
        {
            var surchargeTax = new SurchargeTax(m_TotalTaxableAmount);
            return surchargeTax.TotalSurchageTax();
        }

        /// <summary>
        /// Total tax calculation according to old Tax regime
        /// </summary>
        /// <param name="ageClass"></param>
        /// <returns></returns>
        public int GetTotalTax(AgeCategory ageClass)
        {
            var totalExemption = TotalExemption();
            totalExemption += HraExemptions(s_HraAmount, s_BasicDaAmount, s_RentPaid, s_MetroStatus);
            m_TotalTaxableAmount = s_TotalIncome - totalExemption;
            var oldRegimeTaxSlab = new OldRegimeTaxSlab();
            var totalTax = oldRegimeTaxSlab.CalculateTax(ageClass, m_TotalTaxableAmount);
            totalTax += GetSurcharge() + GetHealthSurcharge();
            return totalTax;
        }

        #endregion
    }
}
