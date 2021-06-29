using System.Collections.Generic;

namespace IncomeTax.Core.SurchargeTaxStrategy
{
    public class SurchargeTax
    {

        private const int FiftyLakh = 5000000;
        private const int OneCrore = 10000000;
        private const int TwoCrore = 20000000;
        private const int FiveCrore = 50000000;

        private readonly int _taxableIncome;
        
        private List<int> _incomeCategories = new List<int>();      
        private Dictionary<int, ISurchargeTax> _surchargeCategories = new Dictionary<int, ISurchargeTax>();
        

        public SurchargeTax(int taxableIncome)
        {
            this._taxableIncome = taxableIncome;
            setIncomeCategories();
        }

        public virtual void setIncomeCategories()
        {
            _incomeCategories.Add(FiftyLakh);
            _incomeCategories.Add(OneCrore);
            _incomeCategories.Add(TwoCrore);
            _incomeCategories.Add(FiveCrore);
            _incomeCategories.Sort();
            _incomeCategories.Reverse();

            _surchargeCategories.Add(FiftyLakh, new SurchargeTenPercent());
            _surchargeCategories.Add(OneCrore, new SurchargeFifteenPercent());
            _surchargeCategories.Add(TwoCrore, new SurchargeTwentyFivePercent());
            _surchargeCategories.Add(FiveCrore, new SurchargeThirtySevenPercent());
            _surchargeCategories.Add(0, null);
        }

        public int getCategory()
        {
            foreach (var i in _incomeCategories)
            {
                if (_taxableIncome >= i)
                    return i;
            }
            return 0;
        }

        public int TotalSurchageTax()
        {
            ISurchargeTax totalTax = _surchargeCategories[getCategory()];
            if(totalTax != null)
                return totalTax.GetSurcharge(_taxableIncome);
            return 0;
        }

    }
}
