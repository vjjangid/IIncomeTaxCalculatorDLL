namespace IncomeTax.Core
{
    /// <summary>
    /// Enum for the three categories general, senior, super senior
    /// </summary>
    public enum AgeCategory
    {
        /// <summary>
        /// Age below 60
        /// </summary>
        General,

        /// <summary>
        /// Age between 60 to 80 exclude 80
        /// </summary>
        Senior,

        /// <summary>
        /// Age above 80
        /// </summary>
        SuperSenior
    };
}

