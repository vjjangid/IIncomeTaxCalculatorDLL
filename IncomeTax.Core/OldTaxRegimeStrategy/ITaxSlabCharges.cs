namespace IncomeTax.Core.OldTaxRegimeStrategy
{
    public interface ITaxSlabCharges
    {
        double CalculateTax(double taxableAmount);

    }
}
