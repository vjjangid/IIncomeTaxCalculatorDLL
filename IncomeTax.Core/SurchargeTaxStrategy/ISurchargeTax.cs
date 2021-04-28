namespace IncomeTax.Core
{
    interface ISurchargeTax
    { 
        int GetSurcharge(int taxableIncome);
    }
}
