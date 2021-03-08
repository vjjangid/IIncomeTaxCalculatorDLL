using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxDLL
{
    public class ExcemtionsAndDeductions : IDeductionStandard , I80CCD2Deduction , I80C_Deduction , IDeduction80CCD , 
                                            IDeduction80E ,IDeduction80EEA, IDeduction80EEB , IDeduction80G50Percent, 
                                            IDeduction80G100Percent, IDeduction80GGA, IDeduction80GGC , IDeduction80TTA,
                                            IDeduction80U, IDeductionFoodCoupons, IDeductionOthers, IDeductionSection24B,
                                            IDeductionTTB, I_DeductionIncomeBusinessProfession, IDeductionI80DD
    {

        #region Properties

        private double _standardDeductionAmount;
        private double _I80CCD2DeductionAmount;
        private double _I80CEquityLinkedAmount;
        private double _I80C_EPFAmount;
        private double _I80C_LiferInsuranceAmount;
        private double _I80C_ProvidentFundAmount;
        private double _I80C_HousingLoanPrincipalAmount;
        private double _I80C_NationalPensionSchemeAmount;
        private double _I80C_TuitionFeesAmount;
        private double _I80C_OthersAmount;
        private double _IDeduction80CCDAmount;
        private double _IDeduction80EAmount;
        private double _IDeduction80EE_Amount;
        private double _Deduction80EEBAmount;
        private double _IDeduction80G50Amount;
        private double _IDeduction80G100PercentAmount;
        private double _IDeduction80GGAAmount;
        private double _IDeduction80GGCAmount;
        private double _DeductionTTA_Amount;
        private double _IDeduction80U_Amount;
        private double _FoodCouponsAmount;
        private double _OtherDeductionAmount;
        private double _IDeductionSection_24BAmount;
        private double _DeductionTTBAmount;
        private double _BusinessAmount;
        private double _ProfessionAmount;
        private double _Deduction80DDAmount;

        #endregion

        #region Standar Deduction

        /// <summary>
        /// Taking Standard deduction Amount
        /// </summary>
        public double StandardDeductionAmount 
        { 
            get
            {
                return _standardDeductionAmount;
            }
            set
            {
                _standardDeductionAmount = value;
            }
        }

        #endregion

        #region 80 CCD
        /// <summary>
        /// Taking Deduction Amount under 80CCD
        /// </summary>
        public double I80CCD2DeductionAmount 
        { 
            get
            {
                return _I80CCD2DeductionAmount;
            }
            set
            {
                _I80CCD2DeductionAmount = value;
            }
        }

        #endregion

        #region 80C

        /// <summary>
        /// Excemptions under 80 C for equity linked funds
        /// </summary>
        public double I80C_EquityLinkedAmount 
        { 
            get
            {
                return _I80CEquityLinkedAmount;
            }
            set
            {
                _I80CEquityLinkedAmount = value;
            }
        }

        /// <summary>
        /// Excemptions under 80C for Employee Provident Fund amount
        /// </summary>
        public double I80C_EPFAmount
        {
            get
            {
                return _I80C_EPFAmount;
            }
            set
            {
                _I80C_EPFAmount = value;
            }
        }

        /// <summary>
        /// Excemptions under 80C for Life Insurance 
        /// </summary>
        public double I80C_LifeInsuranceAmount 
        {
            get 
            {
                return _I80C_LiferInsuranceAmount;
            }
            set
            {
                _I80C_LiferInsuranceAmount = value;
            }
        }

        /// <summary>
        /// Exemption under 80C for Provident Fund
        /// </summary>
        public double I80C_ProvidentFundAmount 
        {
            get
            {
                return _I80C_ProvidentFundAmount;
            }
            set
            {
                _I80C_ProvidentFundAmount = value;
            }
        }

        /// <summary>
        /// Excemption under 80C for Housing Loan Principal Amount
        /// </summary>
        public double I80C_HousingLoanPrincipalAmount 
        {
            get
            {
                return _I80C_HousingLoanPrincipalAmount;
            }
            set
            {
                _I80C_HousingLoanPrincipalAmount = value;
            }
        }

        /// <summary>
        /// Excemption under 80C for National Pension Scheme Amount
        /// </summary>
        public double I80C_NationalPensionSchemeAmount 
        {
            get
            {
                return _I80C_NationalPensionSchemeAmount;
            }
            set
            {
                _I80C_NationalPensionSchemeAmount = value;
            }
        }

        /// <summary>
        /// Excemption under 80C for Tuition Amount
        /// </summary>
        public double I80C_TuitionFeesAmount 
        {
            get
            {
                return _I80C_TuitionFeesAmount;
            }
            set
            {
                _I80C_TuitionFeesAmount = value;
            }
        }

        /// <summary>
        /// Excmeption under 80C for Others Expenses
        /// </summary>
        public double I80C_OthersAmount 
        { 
            get
            {
                return _I80C_OthersAmount;
            }
            set
            {
                _I80C_OthersAmount = value;
            }
        }

        #endregion

        #region 80 CCD

        /// <summary>
        /// Deduction under 80CCD
        /// </summary>
        public double IDeduction80CCDAmount 
        {
            get
            {
                return _IDeduction80CCDAmount;
            }
            set
            {
                _IDeduction80CCDAmount = value;
            }
        }


        #endregion

        #region 80E

        /// <summary>
        /// Deduction under 80E
        /// </summary>
        public double IDeduction80EAmount 
        {
            get
            {
                return _IDeduction80EAmount;
            }
            set
            {
                _IDeduction80EAmount = value;
            }
        }

        #endregion

        #region 80E

        /// <summary>
        /// Deduction under 80 EEA
        /// </summary>
        public double IDeduction80EEA_Amount 
        {
            get
            {
                return _IDeduction80EE_Amount;
            }

            set
            {
                _IDeduction80EE_Amount = value;
            }
        }

        #endregion

        #region 80 EEB

        public double Deduction80EEBAmount 
        {
            get
            {
                return _Deduction80EEBAmount;
            }
            set
            {
                _Deduction80EEBAmount = value;
            }
        }


        #endregion

        #region 80G 50%

        /// <summary>
        /// Deduction under 80 G which is 50%
        /// </summary>
        public double IDeduction80G50Amount 
        {
            get
            {
                return _IDeduction80G50Amount;
            }
            set
            {
                _IDeduction80G50Amount = value;
            }
        }


        #endregion

        #region 80G 100%
        
        /// <summary>
        /// Deduction under 80G 100%
        /// </summary>
        public double IDeduction80G100PercentAmount 
        {
            get
            {
                return _IDeduction80G100PercentAmount;
            }
            set
            {
                _IDeduction80G100PercentAmount = value;
            }
        }

        #endregion

        #region 80 GGA

        /// <summary>
        /// Deduction under 80 GGA 
        /// </summary>
        public double IDeduction80GGAAmount 
        {
            get
            {
                return _IDeduction80GGAAmount;
            }
            set
            {
                _IDeduction80GGAAmount = value;
            }
        }

        #endregion

        #region 80 GGC
        
        /// <summary>
        /// Deduction under 80 GGC
        /// </summary>
        public double IDeduction80GGCAmount 
        {
            get
            {
                return _IDeduction80GGCAmount;
            }
            set
            {
                _IDeduction80GGCAmount = value;
            }
        }

        #endregion

        #region TTA Amount

        /// <summary>
        /// Deduction under TTA 
        /// </summary>
        public double DeductionTTA_Amount 
        {
            get
            {
                return _DeductionTTA_Amount;
            }
            set
            {
                _DeductionTTA_Amount = value;
            }
        }


        #endregion

        #region 80 U
        
        /// <summary>
        /// Deduction under 80 u
        /// </summary>
        public double IDeduction80U_Amount
        {
            get
            {
                return _IDeduction80U_Amount;
            }
            set
            {
                _IDeduction80U_Amount = value;
            }
        }


        #endregion

        #region Food Coupons
        
        /// <summary>
        /// Deduction under Food Coupons
        /// </summary>
        public double FoodCouponsAmount 
        {
            get
            {
                return _FoodCouponsAmount;
            }
            set
            {
                _FoodCouponsAmount = value;
            }
        }



        #endregion

        #region Other Deductions

        /// <summary>
        /// Other deductions
        /// </summary>
        public double OtherDeductionAmount 
        {
            get
            {
                return _OtherDeductionAmount;
            }
            set
            {
                _OtherDeductionAmount = value;
            }
        }

        #endregion

        #region Section 24B

        /// <summary>
        /// Deductions under Section 24B
        /// </summary>
        public double IDeductionSection_24BAmount 
        {
            get
            {
                return _IDeductionSection_24BAmount;
            }
            set
            {
                _IDeductionSection_24BAmount = value;
            }
        }

        #endregion

        #region TTB

        /// <summary>
        /// Deduction under TTB
        /// </summary>
        public double DeductionTTBAmount 
        {
            get
            {
                return _DeductionTTBAmount;
            }
            set
            {
                _DeductionTTBAmount = value;
            }
        }

        #endregion


        #region Business Profession
        
        /// <summary>
        /// Deduction for Business amount
        /// </summary>
        public double BusinessAmount 
        {
            get
            {
                return _BusinessAmount;
            }
            set
            {
                _BusinessAmount = value;
            }
        }

        /// <summary>
        /// Deduction For Profession Amount
        /// </summary>
        public double ProfessionAmount 
        {
            get
            {
                return _ProfessionAmount;
            }
            set
            {
                _ProfessionAmount = value;
            }
        }


        #endregion

        #region
        /// <summary>
        /// Deduction under 80DD
        /// </summary>

        public double Deduction80DDAmount 
        {
            get
            {
                return _Deduction80DDAmount;
            }
            set
            {
                _Deduction80DDAmount = value;
            }
        }

        #endregion
    }
}
