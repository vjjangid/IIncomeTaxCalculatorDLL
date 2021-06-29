using System;
using IncomeTax.Core.GeneralInterfaces;

namespace IncomeTax.Core
{
    /// <summary>
    /// All the exemptions which can be calculated
    /// </summary>
    public class ExemptionsAndDeductions : IDeductionStandard , I80ccd2Deduction , I80cDeduction , IDeduction80CCD , 
                                            IDeduction80E ,IDeduction80EEA, IDeduction80EEB , IDeduction80G50Percent, 
                                            IDeduction80G100Percent, IDeduction80GGA, IDeduction80GGC , IDeduction80TTA,
                                            IDeduction80U, IDeductionFoodCoupons, IDeductionOthers, IDeductionSection24B,
                                            IDeductionTTB, IDeductionIncomeBusinessProfession, IDeductionI80DD
    {

        #region Properties

        private int _standardDeductionAmount;
        private int _i80Ccd2DeductionAmount;
        private int _i80CEquityLinkedAmount;
        private int _epfAmount;
        private int _i80CLiferInsuranceAmount;
        private int _providentFundAmount;
        private int _housingLoanPrincipalAmount;
        private int _nationalPensionSchemeAmount;
        private int _tuitionFeesAmount;
        private int _othersAmount;
        private int _iDeduction80CcdAmount;
        private int _iDeduction80EAmount;
        private int _iDeduction80EeAmount;
        private int _deduction80EebAmount;
        private int _iDeduction80G50Amount;
        private int _iDeduction80G100PercentAmount;
        private int _iDeduction80GgaAmount;
        private int _iDeduction80GgcAmount;
        private int _deductionTtaAmount;
        private int _iDeduction80UAmount;
        private int _foodCouponsAmount;
        private int _otherDeductionAmount;
        private int _iDeductionSection24BAmount;
        private int _deductionTtbAmount;
        private int _businessAmount;
        private int _professionAmount;
        private int _deduction80DdAmount;

        #endregion

        #region Standard Deduction

        /// <summary>
        /// Taking Standard deduction Amount
        /// </summary>
        public int StandardDeductionAmount 
        { 
            get => _standardDeductionAmount;
            set => _standardDeductionAmount = Validator.ValidateMoneyAmount(value);
        }

        #endregion

        #region 80 CCD
        /// <summary>
        /// Taking Deduction Amount under 80CCD
        /// </summary>
        public int I80CCD2DeductionAmount 
        { 
            get => _i80Ccd2DeductionAmount;
            set => _i80Ccd2DeductionAmount = Validator.ValidateMoneyAmount(value);
        }

        #endregion

        #region 80C

        /// <summary>
        /// Exemptions under 80 C for equity linked funds
        /// </summary>
        public int EquityLinkedAmount 
        { 
            get => _i80CEquityLinkedAmount;
            set => _i80CEquityLinkedAmount = Validator.ValidateMoneyAmount(value);
        }

        /// <summary>
        /// Exemptions under 80C for Employee Provident Fund amount
        /// </summary>
        public int EPFAmount
        {
            get => _epfAmount;
            set => _epfAmount = Validator.ValidateMoneyAmount(value);
        }

        /// <summary>
        /// Exemptions under 80C for Life Insurance 
        /// </summary>
        public int LifeInsuranceAmount 
        {
            get => _i80CLiferInsuranceAmount;
            set => _i80CLiferInsuranceAmount = Validator.ValidateMoneyAmount(value);
        }

        /// <summary>
        /// Exemption under 80C for Provident Fund
        /// </summary>
        public int ProvidentFundAmount  
        {
            get => _providentFundAmount;
            set => _providentFundAmount = Validator.ValidateMoneyAmount(value);
        }

        /// <summary>
        /// Exemption under 80C for Housing Loan Principal Amount
        /// </summary>
        public int HousingLoanPrincipalAmount 
        {
            get => _housingLoanPrincipalAmount;
            set => _housingLoanPrincipalAmount = Validator.ValidateMoneyAmount(value);
        }

        /// <summary>
        /// Exemption under 80C for National Pension Scheme Amount
        /// </summary>
        public int NationalPensionSchemeAmount 
        {
            get => _nationalPensionSchemeAmount;
            set => _nationalPensionSchemeAmount = Validator.ValidateMoneyAmount(value);
        }

        /// <summary>
        /// Exemption under 80C for Tuition Amount
        /// </summary>
        public int TuitionFeesAmount 
        {
            get => _tuitionFeesAmount;
            set => _tuitionFeesAmount = Validator.ValidateMoneyAmount(value);
        }

        /// <summary>
        /// Exemption under 80C for Others Expenses
        /// </summary>
        public int OthersAmount 
        { 
            get => _othersAmount;
            set => _othersAmount = Validator.ValidateMoneyAmount(value);
        }

        #endregion

        #region 80 CCD

        /// <summary>
        /// Deduction under 80CCD
        /// </summary>
        public int IDeduction80CCDAmount 
        {
            get => _iDeduction80CcdAmount;
            set => _iDeduction80CcdAmount = Validator.ValidateMoneyAmount(value);
        }


        #endregion

        #region 80E

        /// <summary>
        /// Deduction under 80E
        /// </summary>
        public int IDeduction80EAmount 
        {
            get => _iDeduction80EAmount;
            set => _iDeduction80EAmount = Validator.ValidateMoneyAmount(value);
        }

        #endregion

        #region 80EEA

        /// <summary>
        /// Deduction under 80 EEA
        /// </summary>
        public int IDeduction80eeaAmount 
        {
            get => _iDeduction80EeAmount;

            set => _iDeduction80EeAmount = Validator.ValidateMoneyAmount(value);
        }

        #endregion

        #region 80 EEB

        public int Deduction80EEBAmount 
        {
            get => _deduction80EebAmount;
            set => _deduction80EebAmount = Validator.ValidateMoneyAmount(value);
        }


        #endregion

        #region 80G 50%

        /// <summary>
        /// Deduction under 80 G which is 50%
        /// </summary>
        public int IDeduction80G50Amount 
        {
            get => _iDeduction80G50Amount;
            set => _iDeduction80G50Amount = Validator.ValidateMoneyAmount(value);
        }


        #endregion

        #region 80G 100%
        
        /// <summary>
        /// Deduction under 80G 100%
        /// </summary>
        public int IDeduction80G100PercentAmount 
        {
            get => _iDeduction80G100PercentAmount;
            set => _iDeduction80G100PercentAmount = Validator.ValidateMoneyAmount(value);
        }

        #endregion

        #region 80 GGA

        /// <summary>
        /// Deduction under 80 GGA 
        /// </summary>
        public int IDeduction80GGAAmount 
        {
            get => _iDeduction80GgaAmount;
            set => _iDeduction80GgaAmount = Validator.ValidateMoneyAmount(value);
        }

        #endregion

        #region 80 GGC
        
        /// <summary>
        /// Deduction under 80 GGC
        /// </summary>
        public int IDeduction80GGCAmount 
        {
            get => _iDeduction80GgcAmount;
            set => _iDeduction80GgcAmount = Validator.ValidateMoneyAmount(value);
        }

        #endregion

        #region TTA Amount

        /// <summary>
        /// Deduction under TTA 
        /// </summary>
        public int DeductionTTA_Amount 
        {
            get => _deductionTtaAmount;
            set => _deductionTtaAmount = Validator.ValidateMoneyAmount(value);
        }


        #endregion

        #region 80 U
        
        /// <summary>
        /// Deduction under 80 u
        /// </summary>
        public int IDeduction80U_Amount
        {
            get => _iDeduction80UAmount;
            set => _iDeduction80UAmount = Validator.ValidateMoneyAmount(value);
        }


        #endregion

        #region Food Coupons
        
        /// <summary>
        /// Deduction under Food Coupons
        /// </summary>
        public int FoodCouponsAmount 
        {
            get => _foodCouponsAmount;
            set => _foodCouponsAmount = Validator.ValidateMoneyAmount(value);
        }



        #endregion

        #region Other Deductions

        /// <summary>
        /// Other deductions
        /// </summary>
        public int OtherDeductionAmount 
        {
            get => _otherDeductionAmount;
            set => _otherDeductionAmount = Validator.ValidateMoneyAmount(value);
        }

        #endregion

        #region Section 24B

        /// <summary>
        /// Deductions under Section 24B
        /// </summary>
        public int IDeductionSection_24BAmount 
        {
            get => _iDeductionSection24BAmount;
            set => _iDeductionSection24BAmount = Validator.ValidateMoneyAmount(value);
        }

        #endregion

        #region TTB

        /// <summary>
        /// Deduction under TTB
        /// </summary>
        public int DeductionTTBAmount 
        {
            get => _deductionTtbAmount;
            set => _deductionTtbAmount = Validator.ValidateMoneyAmount(value);
        }

        #endregion

        #region Business Profession
        
        /// <summary>
        /// Deduction for Business amount
        /// </summary>
        public int BusinessAmount 
        {
            get => _businessAmount;
            set => _businessAmount = Validator.ValidateMoneyAmount(value);
        }

        /// <summary>
        /// Deduction For Profession Amount
        /// </summary>
        public int ProfessionAmount 
        {
            get => _professionAmount;
            set => _professionAmount = Validator.ValidateMoneyAmount(value);
        }


        #endregion

        #region 80DD
        /// <summary>
        /// Deduction under 80DD
        /// </summary>

        public int Deduction80DDAmount 
        {
            get => _deduction80DdAmount;
            set => _deduction80DdAmount = Validator.ValidateMoneyAmount(value);
        }

        #endregion



        #region Method Standard Deduction 

        /// <summary>
        /// standard deduction amount is always there every year for
        /// which every citizen is eligible. For now it is 50000 Rs
        /// </summary>
        /// <returns>Eligible deduction amount</returns>
        public int GetStandardDeductionAmount()
        {
            return 50000;
        }

        #endregion

        #region Method 80C 

        /// <summary>
        /// Total exemption for which candidate is eligible is 150000Rs
        /// </summary>
        /// <returns></returns>
        public int GetAmountUnder80C()
        {
            int total = EPFAmount + EquityLinkedAmount + HousingLoanPrincipalAmount + LifeInsuranceAmount
                        + NationalPensionSchemeAmount + OthersAmount + ProvidentFundAmount + TuitionFeesAmount;

            return Math.Min(total, 150000);
        }


        #endregion

        #region Method Food Coupons 

        public int GetAmountFoodCoupons()
        {
            return Math.Min(26400, _foodCouponsAmount);
        }

        #endregion

        #region Method Section 24B

        /// <summary>
        /// Amount for which the candidate is eligible under section 24B
        /// </summary>
        /// <returns></returns>
        public int GetAmountUnderSection24B()
        {
            return Math.Min(200000, _iDeductionSection24BAmount);
        }

        #endregion

        #region Method 80U

        /// <summary>
        /// Deduction that can be taken under 80U which is 125000
        /// </summary>
        /// <returns></returns>
        public int GetAmountUnder80U()
        {
            return Math.Min(125000, _iDeduction80UAmount);
        }

        #endregion

        #region Method 80EEA
        
        /// <summary>
        /// Maximum deduction that can be claimed under 80EEA which is 1.5 lakh Rs 
        /// </summary>
        /// <returns></returns>
        public int GetAmountUnder80EEA()
        {
            return Math.Min(150000, IDeduction80eeaAmount);
        }
        #endregion

        #region Method 80DD
        /// <summary>
        /// Maximum amount that can be exempted under 80DD which is 1.25 Lakh Rs
        /// </summary>
        /// <returns></returns>
        public int GetAmountUnder80DD()
        {
            return Math.Min(125000, _deduction80DdAmount);
        }
        #endregion

        #region Method 80EEB 
        /// <summary>
        /// Maximum amount that can be exempted under 80EEB which is 1.5 lakh Rs
        /// </summary>
        /// <returns></returns>
        public int GetAmountUnder80EEB()
        {
            return Math.Min(150000, _deduction80EebAmount);
        }
        #endregion

        #region HRA

        /// <summary>
        /// Calculating House rental allowance deduction
        /// </summary>
        /// <param name="hraAmount">Actual Amount received from the company</param>
        /// <param name="basicDa">Actual Basic dearness allowance received</param>
        /// <param name="rentPaid">Actual Rent Paid</param>
        /// <param name="metroStatus">metro status of the user</param>
        /// <returns></returns>
        public int HraExemptions(int hraAmount, int rentPaid, int basicDa, bool metroStatus)
        {
            //Least of the following conditions amount will be taken into consideration
            //1. Actual HRA received
            //2. Actual Rent Paid - 10% of Basic DA
            //3. 50 percent of basic for metro user / 4o percent for non metro user

            double secondCond = rentPaid - (basicDa * 0.1);

            double thirdCond;

            if (metroStatus)
            {
                thirdCond = 0.5 * basicDa;
            }
            else
            {
                thirdCond = 0.4 * basicDa;
            }

            return ((int)Math.Min(hraAmount, Math.Min(secondCond, thirdCond)));
        }

        #endregion

        /// <summary>
        /// Total exemption user can get
        /// </summary>
        /// <returns></returns>
        public int TotalExemption()
        {
            return GetStandardDeductionAmount() + GetAmountUnder80C() + GetAmountUnder80DD() +
                    GetAmountUnder80EEA() + GetAmountUnder80EEB() + GetAmountUnder80U() + GetAmountUnderSection24B() +
                    GetAmountFoodCoupons();
        }

    }
}
