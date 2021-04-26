using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Core.SurchargeTaxStrategy
{
    public class SurchargeTax
    {

        private const int FiftyLakh = 5000000;
        private const int OneCrore = 10000000;
        private const int TwoCrore = 20000000;
        private const int FiveCrore = 50000000;

        private readonly int taxableIncome;
        
        private List<int> incomeCategories = new List<int>();      
        private Dictionary<int, ISurchargeTax> surchargeCategories = new Dictionary<int, ISurchargeTax>();
        

        public SurchargeTax(int taxableIncome)
        {
            this.taxableIncome = taxableIncome;
            setIncomeCategories();
        }

        public virtual void setIncomeCategories()
        {
            incomeCategories.Add(FiftyLakh);
            incomeCategories.Add(OneCrore);
            incomeCategories.Add(TwoCrore);
            incomeCategories.Add(FiveCrore);
            incomeCategories.Sort();
            incomeCategories.Reverse();

            surchargeCategories.Add(FiftyLakh, new SurchargeTenPercent());
            surchargeCategories.Add(OneCrore, new SurchargeFifteenPercent());
            surchargeCategories.Add(TwoCrore, new SurchargeTwentyFivePercent());
            surchargeCategories.Add(FiveCrore, new SurchargeThirtySevenPercent());
            surchargeCategories.Add(0, null);
        }

        public int getCategory()
        {
            foreach (var i in incomeCategories)
            {
                if (taxableIncome >= i)
                    return i;
            }
            return 0;
        }

        public int TotalSurchageTax()
        {
            ISurchargeTax totalTax = surchargeCategories[getCategory()];
            if(totalTax != null)
                return totalTax.GetSurcharge(taxableIncome);
            return 0;
        }

    }
}
