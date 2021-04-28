using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Core
{
    /// <summary>
    /// All the exemtions which can be calculated
    /// </summary>
    public class ExemptionsAndDeductions : IDeductionStandard , I80CCD2Deduction , I80C_Deduction , IDeduction80CCD , 
                                            IDeduction80E ,IDeduction80EEA, IDeduction80EEB , IDeduction80G50Percent, 
                                            IDeduction80G100Percent, IDeduction80GGA, IDeduction80GGC , IDeduction80TTA,
                                            IDeduction80U, IDeductionFoodCoupons, IDeductionOthers, IDeductionSection24B,
                                            IDeductionTTB, IDeductionIncomeBusinessProfession, IDeductionI80DD
    {

        #region Properties

        private int _standardDeductionAmount;
        private int _I80CCD2DeductionAmount;
        private int _I80CEquityLinkedAmount;
        private int _I80C_EPFAmount;
        private int _I80C_LiferInsuranceAmount;
        private int _I80C_ProvidentFundAmount;
        private int _I80C_HousingLoanPrincipalAmount;
        private int _I80C_NationalPensionSchemeAmount;
        private int _I80C_TuitionFeesAmount;
        private int _I80C_OthersAmount;
        private int _IDeduction80CCDAmount;
        private int _IDeduction80EAmount;
        private int _IDeduction80EE_Amount;
        private int _Deduction80EEBAmount;
        private int _IDeduction80G50Amount;
        private int _IDeduction80G100PercentAmount;
        private int _IDeduction80GGAAmount;
        private int _IDeduction80GGCAmount;
        private int _DeductionTTA_Amount;
        private int _IDeduction80U_Amount;
        private int _FoodCouponsAmount;
        private int _OtherDeductionAmount;
        private int _IDeductionSection_24BAmount;
        private int _DeductionTTBAmount;
        private int _BusinessAmount;
        private int _ProfessionAmount;
        private int _Deduction80DDAmount;

        #endregion

        #region Standard Deduction

        /// <summary>
        /// Taking Standard deduction Amount
        /// </summary>
        public int StandardDeductionAmount 
        { 
            get
            {
                return _standardDeductionAmount;
            }
            set
            {
                _standardDeductionAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        #endregion

        #region 80 CCD
        /// <summary>
        /// Taking Deduction Amount under 80CCD
        /// </summary>
        public int I80CCD2DeductionAmount 
        { 
            get
            {
                return _I80CCD2DeductionAmount;
            }
            set
            {
                _I80CCD2DeductionAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        #endregion

        #region 80C

        /// <summary>
        /// Excemptions under 80 C for equity linked funds
        /// </summary>
        public int I80C_EquityLinkedAmount 
        { 
            get
            {
                return _I80CEquityLinkedAmount;
            }
            set
            {
                _I80CEquityLinkedAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Excemptions under 80C for Employee Provident Fund amount
        /// </summary>
        public int I80C_EPFAmount
        {
            get
            {
                return _I80C_EPFAmount;
            }
            set
            {
                _I80C_EPFAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Excemptions under 80C for Life Insurance 
        /// </summary>
        public int I80C_LifeInsuranceAmount 
        {
            get 
            {
                return _I80C_LiferInsuranceAmount;
            }
            set
            {
                _I80C_LiferInsuranceAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Exemption under 80C for Provident Fund
        /// </summary>
        public int I80C_ProvidentFundAmount 
        {
            get
            {
                return _I80C_ProvidentFundAmount;
            }
            set
            {
                _I80C_ProvidentFundAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Excemption under 80C for Housing Loan Principal Amount
        /// </summary>
        public int I80C_HousingLoanPrincipalAmount 
        {
            get
            {
                return _I80C_HousingLoanPrincipalAmount;
            }
            set
            {
                _I80C_HousingLoanPrincipalAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Excemption under 80C for National Pension Scheme Amount
        /// </summary>
        public int I80C_NationalPensionSchemeAmount 
        {
            get
            {
                return _I80C_NationalPensionSchemeAmount;
            }
            set
            {
                _I80C_NationalPensionSchemeAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Excemption under 80C for Tuition Amount
        /// </summary>
        public int I80C_TuitionFeesAmount 
        {
            get
            {
                return _I80C_TuitionFeesAmount;
            }
            set
            {
                _I80C_TuitionFeesAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Excmeption under 80C for Others Expenses
        /// </summary>
        public int I80C_OthersAmount 
        { 
            get
            {
                return _I80C_OthersAmount;
            }
            set
            {
                _I80C_OthersAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        #endregion

        #region 80 CCD

        /// <summary>
        /// Deduction under 80CCD
        /// </summary>
        public int IDeduction80CCDAmount 
        {
            get
            {
                return _IDeduction80CCDAmount;
            }
            set
            {
                _IDeduction80CCDAmount = Validator.ValidateMoneyAmount(value);
            }
        }


        #endregion

        #region 80E

        /// <summary>
        /// Deduction under 80E
        /// </summary>
        public int IDeduction80EAmount 
        {
            get
            {
                return _IDeduction80EAmount;
            }
            set
            {
                _IDeduction80EAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        #endregion

        #region 80EEA

        /// <summary>
        /// Deduction under 80 EEA
        /// </summary>
        public int IDeduction80EEA_Amount 
        {
            get
            {
                return _IDeduction80EE_Amount;
            }

            set
            {
                _IDeduction80EE_Amount = Validator.ValidateMoneyAmount(value);
            }
        }

        #endregion

        #region 80 EEB

        public int Deduction80EEBAmount 
        {
            get
            {
                return _Deduction80EEBAmount;
            }
            set
            {
                _Deduction80EEBAmount = Validator.ValidateMoneyAmount(value);
            }
        }


        #endregion

        #region 80G 50%

        /// <summary>
        /// Deduction under 80 G which is 50%
        /// </summary>
        public int IDeduction80G50Amount 
        {
            get
            {
                return _IDeduction80G50Amount;
            }
            set
            {
                _IDeduction80G50Amount = Validator.ValidateMoneyAmount(value);
            }
        }


        #endregion

        #region 80G 100%
        
        /// <summary>
        /// Deduction under 80G 100%
        /// </summary>
        public int IDeduction80G100PercentAmount 
        {
            get
            {
                return _IDeduction80G100PercentAmount;
            }
            set
            {
                _IDeduction80G100PercentAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        #endregion

        #region 80 GGA

        /// <summary>
        /// Deduction under 80 GGA 
        /// </summary>
        public int IDeduction80GGAAmount 
        {
            get
            {
                return _IDeduction80GGAAmount;
            }
            set
            {
                _IDeduction80GGAAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        #endregion

        #region 80 GGC
        
        /// <summary>
        /// Deduction under 80 GGC
        /// </summary>
        public int IDeduction80GGCAmount 
        {
            get
            {
                return _IDeduction80GGCAmount;
            }
            set
            {
                _IDeduction80GGCAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        #endregion

        #region TTA Amount

        /// <summary>
        /// Deduction under TTA 
        /// </summary>
        public int DeductionTTA_Amount 
        {
            get
            {
                return _DeductionTTA_Amount;
            }
            set
            {
                _DeductionTTA_Amount = Validator.ValidateMoneyAmount(value);
            }
        }


        #endregion

        #region 80 U
        
        /// <summary>
        /// Deduction under 80 u
        /// </summary>
        public int IDeduction80U_Amount
        {
            get
            {
                return _IDeduction80U_Amount;
            }
            set
            {
                _IDeduction80U_Amount = Validator.ValidateMoneyAmount(value);
            }
        }


        #endregion

        #region Food Coupons
        
        /// <summary>
        /// Deduction under Food Coupons
        /// </summary>
        public int FoodCouponsAmount 
        {
            get
            {
                return _FoodCouponsAmount;
            }
            set
            {
                _FoodCouponsAmount = Validator.ValidateMoneyAmount(value);
            }
        }



        #endregion

        #region Other Deductions

        /// <summary>
        /// Other deductions
        /// </summary>
        public int OtherDeductionAmount 
        {
            get
            {
                return _OtherDeductionAmount;
            }
            set
            {
                _OtherDeductionAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        #endregion

        #region Section 24B

        /// <summary>
        /// Deductions under Section 24B
        /// </summary>
        public int IDeductionSection_24BAmount 
        {
            get
            {
                return _IDeductionSection_24BAmount;
            }
            set
            {
                _IDeductionSection_24BAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        #endregion

        #region TTB

        /// <summary>
        /// Deduction under TTB
        /// </summary>
        public int DeductionTTBAmount 
        {
            get
            {
                return _DeductionTTBAmount;
            }
            set
            {
                _DeductionTTBAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        #endregion

        #region Business Profession
        
        /// <summary>
        /// Deduction for Business amount
        /// </summary>
        public int BusinessAmount 
        {
            get
            {
                return _BusinessAmount;
            }
            set
            {
                _BusinessAmount = Validator.ValidateMoneyAmount(value);
            }
        }

        /// <summary>
        /// Deduction For Profession Amount
        /// </summary>
        public int ProfessionAmount 
        {
            get
            {
                return _ProfessionAmount;
            }
            set
            {
                _ProfessionAmount = Validator.ValidateMoneyAmount(value);
            }
        }


        #endregion

        #region 80DD
        /// <summary>
        /// Deduction under 80DD
        /// </summary>

        public int Deduction80DDAmount 
        {
            get
            {
                return _Deduction80DDAmount;
            }
            set
            {
                _Deduction80DDAmount = Validator.ValidateMoneyAmount(value);
            }
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
            int total = I80C_EPFAmount + I80C_EquityLinkedAmount + I80C_HousingLoanPrincipalAmount + I80C_LifeInsuranceAmount
                        + I80C_NationalPensionSchemeAmount + I80C_OthersAmount + I80C_ProvidentFundAmount + I80C_TuitionFeesAmount;

            return Math.Min(total, 150000);
        }


        #endregion

        #region Method Food Coupons 

        public int GetAmountFoodCoupons()
        {
            return Math.Min(26400, _FoodCouponsAmount);
        }

        #endregion

        #region Method Section 24B

        /// <summary>
        /// Amount for which the candidate is eligible under section 24B
        /// </summary>
        /// <returns></returns>
        public int GetAmountUnderSection24B()
        {
            return Math.Min(200000, _IDeductionSection_24BAmount);
        }

        #endregion

        #region Method 80U

        /// <summary>
        /// Deduction that can be taken under 80U which is 125000
        /// </summary>
        /// <returns></returns>
        public int GetAmountUnder80U()
        {
            return Math.Min(125000, _IDeduction80U_Amount);
        }

        #endregion

        #region Method 80EEA
        
        /// <summary>
        /// Maximum deduction that can be claimed under 80EEA which is 1.5 lakh Rs 
        /// </summary>
        /// <returns></returns>
        public int GetAmountUnder80EEA()
        {
            return Math.Min(150000, IDeduction80EEA_Amount);
        }
        #endregion

        #region Method 80DD
        /// <summary>
        /// Maximum amount that can be exempted under 80DD which is 1.25 Lakh Rs
        /// </summary>
        /// <returns></returns>
        public int GetAmountUnder80DD()
        {
            return Math.Min(125000, _Deduction80DDAmount);
        }
        #endregion

        #region Method 80EEB 
        /// <summary>
        /// Maximum amount that can be exempted under 80EEB which is 1.5 Lakh Rs
        /// </summary>
        /// <returns></returns>
        public int GetAmountUnder80EEB()
        {
            return Math.Min(150000, _Deduction80EEBAmount);
        }
        #endregion

        #region HRA

        /// <summary>
        /// Calculating House rental allowance deduction
        /// </summary>
        /// <param name="HRAAmount">Actual Amount received from the company</param>
        /// <param name="BasicDA">Actual Basic dearness allowance received</param>
        /// <param name="rentPaid">Actual Rent Paid</param>
        /// <param name="metroStatus">metro status of the user</param>
        /// <returns></returns>
        public int HraExemptions(int HraAmount, int rentPaid, int BasicDA, bool metroStatus)
        {
            //Least of the following conditions amount will be taken into consideration
            //1. Actual HRA received
            //2. Actual Rent Paid - 10% of BAsic DA
            //3. 50 percent of basic for metro user / 4o percent for non metro user

            double secondCond = rentPaid - (BasicDA * 0.1);

            double thirdCond;

            if (metroStatus)
            {
                thirdCond = 0.5 * BasicDA;
            }
            else
            {
                thirdCond = 0.4 * BasicDA;
            }

            return ((int)Math.Min(HraAmount, Math.Min(secondCond, thirdCond)));
        }

        #endregion

        /// <summary>
        /// Total exemption user can get
        /// </summary>
        /// <returns></returns>
        public int TotalExmeption()
        {
            return GetStandardDeductionAmount() + GetAmountUnder80C() + GetAmountUnder80DD() +
                    GetAmountUnder80EEA() + GetAmountUnder80EEB() + GetAmountUnder80U() + GetAmountUnderSection24B() +
                    GetAmountFoodCoupons();
        }

    }
}
