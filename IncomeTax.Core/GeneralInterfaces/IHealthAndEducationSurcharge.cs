namespace IncomeTax.Core.GeneralInterfaces
{
    /// <summary>
    /// Surcharge is applicable on whole calculated tax
    /// </summary>
    internal interface IHealthAndEducationSurcharge
    {
        int GetHealthSurcharge();
    }
}
