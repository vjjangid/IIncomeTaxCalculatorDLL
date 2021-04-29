using IncomeTax.Core.OldTaxRegimeStrategy;
using System.Collections.Generic;

namespace IncomeTax.Core
{
    /// <summary>
    /// Tax slabs under old tax regime
    /// </summary>
    public class OldRegimeTaxSlab
    {

        private Dictionary<AgeCategory, ITaxSlabCharges> taxCategories = new Dictionary<AgeCategory, ITaxSlabCharges>();

        public OldRegimeTaxSlab()
        {
            AddTaxCategories();
        }

        public virtual void AddTaxCategories()
        {
            taxCategories.Add(AgeCategory.General, new GeneralTaxSlab());
            taxCategories.Add(AgeCategory.Senior, new SeniorTaxSlab());
            taxCategories.Add(AgeCategory.SuperSenior, new SuperSeniorTaxSlab());
        }

        public virtual void AddTaxCategories(AgeCategory ageCategory, ITaxSlabCharges newTaxSlab)
        {
            taxCategories.Add(ageCategory, newTaxSlab);
        }

        /// <summary>
        /// Only public function to calculate the tax
        /// </summary>
        /// <param name="ageCategory">Age category of person</param>
        /// <param name="taxableAmount">Taxable amount</param>
        /// <returns></returns>
        public int CalculateTax(AgeCategory ageCategory, double taxableAmount)
        {
            double totalTax = 0;
            ITaxSlabCharges taxSlabCharges = taxCategories[ageCategory];
            totalTax = taxSlabCharges.CalculateTax(taxableAmount);
            return (int)(totalTax);
        }
        
    }
}
