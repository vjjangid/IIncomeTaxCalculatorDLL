namespace IncomeTax.Core.OldTaxRegimeStrategy
{
    using System.Collections.Generic;

    /// <summary>
    /// Tax slabs under old tax regime
    /// </summary>
    public class OldRegimeTaxSlab
    {
        private readonly Dictionary<AgeCategory, ITaxSlabCharges> s_MTaxCategories = new Dictionary<
                                                                                     AgeCategory,
                                                                                     ITaxSlabCharges>();

        public OldRegimeTaxSlab()
        {
            AddTaxCategories();
        }

        public void AddTaxCategories()
        {
            s_MTaxCategories.Add(AgeCategory.General, new GeneralTaxSlab());
            s_MTaxCategories.Add(AgeCategory.Senior, new SeniorTaxSlab());
            s_MTaxCategories.Add(AgeCategory.SuperSenior, new SuperSeniorTaxSlab());
        }

        public virtual void AddTaxCategories(AgeCategory ageCategory, ITaxSlabCharges newTaxSlab)
        {
            s_MTaxCategories.Add(ageCategory, newTaxSlab);
        }

        /// <summary>
        /// Only public function to calculate the tax
        /// </summary>
        /// <param name="ageCategory">Age category of person</param>
        /// <param name="taxableAmount">Taxable amount</param>
        /// <returns></returns>
        public int CalculateTax(AgeCategory ageCategory, double taxableAmount)
        {
            var taxSlabCharges = s_MTaxCategories[ageCategory];
            var totalTax = taxSlabCharges.CalculateTax(taxableAmount);
            return (int)(totalTax);
        }       
    }
}
