using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using IncomeTax.Core;
using IncomeTax.Core.OldTaxRegimeStrategy;
using IncomeTax.Data;

namespace IncomeTax.UI
{
    public partial class Form1 : Form
    {
        private User _user = new User();
        private UserRepository _userRepository = new UserRepository();
        //private string _filePath;
        //private IUserRepository userRepo;



        #region Resources

        /// <summary>
        /// Create data file to store user information 
        /// </summary>
        //public void CreateDataFile()
        //{
        //    string path = AppDomain.CurrentDomain.BaseDirectory;
        //    string directoryName = "Data\\";

        //    string fullDirectoryPath = path + directoryName;
        //    string fileName = "data.csv";


        //    if (!Directory.Exists(fullDirectoryPath))
        //    {
        //        Directory.CreateDirectory(fullDirectoryPath);
        //    }
        //    if (!File.Exists(fullDirectoryPath + fileName))
        //    {
        //        Console.WriteLine("File doesnot exist");
        //        File.Create(fullDirectoryPath + fileName);
        //        Console.WriteLine("New File created");
        //    }


        //    _filePath = fullDirectoryPath + fileName;
        //}

        #endregion

        #region Constructor

        public Form1()
        {
            //CreateDataFile();
            InitializeComponent();
            InitialCustomization(); 
        }

        #endregion

        #region Customizing form

        private void InitialCustomization()
        {
            //panelHome.BackgroundImage = Image.FromFile(@"C:\Users\z0049n3x\source\repos\IncomeTaxCalc\IncomeTaxCalculator\Images\Croped2975891.jpg");
            //panelHome.Visible = true;
            panelLogin.Visible = false;
            PannelSignUp.Visible = false;
            panelTaxProfille.Visible = false;
            panelIncomeAndExpense.Visible = false;
            textBoxStandardDeduction.Text = "50000";
            textBoxStandardDeduction.Enabled = false;
            textBoxOutputOldTax.Enabled = false;
            textBoxOutputNewTaxRegime.Enabled = false;
            textBoxOutputOldTax.Text = "Rs ";
            textBoxOutputNewTaxRegime.Text = "Rs ";
        }

        #endregion

        #region Menu Bar
        /// <summary>
        /// Close button functionality (exit the application)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Button for minimizing window
        /// </summary>
        /// <param name="sender">The even sender</param>
        /// <param name="e">The event parameters</param>
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        #endregion


        #region Side Panel 

        /// <summary>
        /// Side Nav Tax Profile finctionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTaxProfile_Click(object sender, EventArgs e)
        {
            panelFloatBar.Height = ButtonTaxProfile.Height;
            panelFloatBar.Top = ButtonTaxProfile.Top;

            //On click of tax profile button just show 
            panelTaxProfille.Visible = true;
            panelHome.Visible = false;
            panelLogin.Visible = false;
            panelIncomeAndExpense.Visible = false;

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelFloatBar.Height = buttonHome.Height;
            panelFloatBar.Top = buttonHome.Top;

            //Show home panel
            panelHome.Visible = true;

            //and hide other panels
            panelLogin.Visible = false;
            panelIncomeAndExpense.Visible = false;
            panelTaxProfille.Visible = false;
        }

        #endregion

        #region Tax profile Submit Functionality

        /// <summary>
        /// Tax Profile submit button functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSubmit_Click(object sender, EventArgs e)
        {

            bool conditionsMet = true;

            if(!radioButtonSalariedNo.Checked && !radioButtonSalariedYes.Checked)
            {
                conditionsMet = false;
                MessageBox.Show("Are you salaried or not ?", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if( !radioButtonMetroYes.Checked && !radioButtonMetroNo.Checked )
            {
                conditionsMet = false;
                MessageBox.Show("Do you resides in metro city ?", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if( !radioButtonMale.Checked && !radioButtonFemale.Checked && !radioButtonOther.Checked)
            {
                conditionsMet = false;
                MessageBox.Show("Gender ?", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //conditionsMet = true;
            }

            
            if(conditionsMet)
            {
                
                _user.DOB = dateTimePicker1.Value;

                if (radioButtonSalariedYes.Checked)
                    _user.IsSalaried = true;
                else
                    _user.IsSalaried = false;

                if (radioButtonMetroYes.Checked)
                    _user.ResidesInMetro = true;
                else
                    _user.ResidesInMetro = false;

                panelTaxProfille.Visible = false;
                panelIncomeAndExpense.Visible = true;
            }
           
        }

        
        /// <summary>
        /// Calculating all the taxes and give resuts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGo_Click(object sender, EventArgs e)
        {
           
            IncomeAndSalary userIncome = new IncomeAndSalary();

            userIncome.BasicDAAmount = CheckInputValidity(textBoxBasicDA.Text);
            userIncome.HRA_Amount = CheckInputValidity(textBoxHRA.Text);
            userIncome.BonusCommissionAmount = CheckInputValidity(textBoxBonusComm.Text);
            userIncome.OtherAllowancesAmount = CheckInputValidity(textBoxOtherAllowance.Text);
            userIncome.BusinessAmount = CheckInputValidity(textBoxBusiness.Text);
            userIncome.ProfessionAmount = CheckInputValidity(textBoxProfession.Text);
            userIncome.ShortTermCGNormalRates = CheckInputValidity(textBoxSTGNM.Text);
            userIncome.ShortTermCG15 = CheckInputValidity(textBoxSTCG15.Text);
            userIncome.LongTermCG10 = CheckInputValidity(textBoxLTCG10.Text);
            userIncome.LongTermCG20 = CheckInputValidity(textBoxLTCG20.Text);
            userIncome.InterestFixedDeposits = CheckInputValidity(textBoxFD.Text);
            userIncome.InterestSavingsBankAccounts = CheckInputValidity(textBoxSavingsAcc.Text);
            userIncome.OtherSources = CheckInputValidity(textBoxOtherSources.Text);

            int totalIncome = userIncome.TotalSalaryAndIncome();

            OldTaxRegime oldTax = new OldTaxRegime(totalIncome, userIncome.HRA_Amount, 
                                  userIncome.BasicDAAmount, radioButtonMetroYes.Checked);

            oldTax.StandardDeductionAmount = CheckInputValidity(textBoxStandardDeduction.Text);
            oldTax.Deduction80EEBAmount = CheckInputValidity(textBox80EEB.Text);
            oldTax.FoodCouponsAmount = CheckInputValidity(textBoxFoodCoupons.Text);
            oldTax.EPFAmount = CheckInputValidity(textBoxEPF.Text);
            oldTax.EquityLinkedAmount = CheckInputValidity(textBoxEquity.Text);
            oldTax.HousingLoanPrincipalAmount = CheckInputValidity(textBoxHousingLoanPrincipal.Text);
            oldTax.LifeInsuranceAmount = CheckInputValidity(textBoxLifeInsurance.Text);
            oldTax.NationalPensionSchemeAmount = CheckInputValidity(textBoxNPS.Text);
            oldTax.ProvidentFundAmount = CheckInputValidity(textBoxPPF.Text);
            oldTax.TuitionFeesAmount = CheckInputValidity(textBoxTuition.Text);
            oldTax.IDeduction80eeaAmount = CheckInputValidity(textBox80EEEA.Text);
            oldTax.IDeduction80U_Amount = CheckInputValidity(textBox80U.Text);
            oldTax.Deduction80DDAmount = CheckInputValidity(textBox80DD.Text);
            oldTax.IDeductionSection_24BAmount = CheckInputValidity(textBoxSection24B.Text);
            oldTax.IDeduction80GGAAmount = CheckInputValidity(textBox80GG.Text);

            double totalGrossSalaryNewRegime = totalIncome;

            int totalOldRegimeTax = oldTax.GetTotalTax(_user.UserAgeClass);

            textBoxOutputOldTax.AppendText(totalOldRegimeTax.ToString());

            NewTaxRegime newRegimeTax = new NewTaxRegime(totalIncome);
            int totalNewRegimeTax = newRegimeTax.TotalTax();

            textBoxOutputNewTaxRegime.AppendText(totalNewRegimeTax.ToString());

            buttonGo.Enabled = false;
        }

        /// <summary>
        /// Helper Function for checking input validity
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private int CheckInputValidity(string input)
        {
            int number;
            if( String.IsNullOrEmpty(input) )
            {
                return 0;
            }
            else
            {
                if( int.TryParse(input, out number))
                {
                    return number;
                }
                else
                {
                    MessageBox.Show("Amount can't be in string format", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    throw new ArgumentException("Amount can't be in string format");
                }
            }
        }

        /// <summary>
        /// Reset all the inputs given by user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox80D.Clear();
            textBox80DD.Clear();
            textBox80DDB.Clear();
            textBox80EEB.Clear();
            textBox80EEEA.Clear();
            textBox80GG.Clear();
            textBox80GGA.Clear();
            textBox80U.Clear();
            textBoxBasicDA.Clear();
            textBoxBonusComm.Clear();
            textBoxBusiness.Clear();
            textBoxEPF.Clear();
            textBoxEquity.Clear();
            textBoxFD.Clear();
            textBoxFoodCoupons.Clear();
            textBoxHousingLoanPrincipal.Clear();
            textBoxHRA.Clear();
            textBoxLifeInsurance.Clear();
            textBoxLTCG10.Clear();
            textBoxLTCG20.Clear();
            textBoxNPS.Clear();
            textBoxOtherAllowance.Clear();
            textBoxOtherExemptions.Clear();
            textBoxOthers.Clear();
            textBoxOtherSources.Clear();
            textBoxPPF.Clear();
            textBoxProfession.Clear();
            textBoxSavingsAcc.Clear();
            textBoxSection24B.Clear();
            textBoxSTCG15.Clear();
            textBoxSTGNM.Clear();
            textBoxTuition.Clear();
            buttonGo.Enabled = true;

            textBoxOutputNewTaxRegime.Text = "Rs ";
            textBoxOutputOldTax.Text = "Rs ";
        }

        #endregion

        #region Signup page

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string mobileNumber = textBoxMobileNumber.Text;
            if (!Validator.ValidateMobileNumber(mobileNumber))
            {
                MessageBox.Show("Wrong Mobile Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string userName = textBoxFirstName.Text + textBoxLastName.Text;
            string password = textBoxPassword.Text;

            UserDetails user = new UserDetails(mobileNumber, userName, password);

            
            //userRepo = new CSVRepository(_filePath, user);

            try
            {
                _userRepository.CreateUser(user);
                MessageBox.Show($"Welcome {userName}", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ArgumentException exc)
            {
                MessageBox.Show($"{exc.Message}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            panelSalaried.Visible = true;           
            PannelSignUp.Visible = false;
        }

        #endregion

        #region Home Page

        private void ButtonRegistered_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelHome.Visible = false;
        }

        private void ButtonGuest_Click(object sender, EventArgs e)
        {
            panelTaxProfille.Visible = true;
            panelHome.Visible = false;
        }

        private void ButtonNewUser_Click(object sender, EventArgs e)
        {
            PannelSignUp.Visible = true;
        }

        #endregion

        #region Login Page

        /// <summary>
        /// Process done on logging of the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLoginGo_Click(object sender, EventArgs e)
        {

            panelHome.Visible = false;

            if (!Validator.ValidateMobileNumber(textBoxLoginMobileNumber.Text))
            {
                MessageBox.Show("Wrong Mobile Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserDetails user = new UserDetails(textBoxLoginMobileNumber.Text, null , textBoxLoginPassword.Text);

            //userRepo = new CSVRepository(_filePath, user);
            CsvFileReader reader = new CsvFileReader(_userRepository.FilePath);
            Dictionary<string, List<string>> allData = reader.RetrieveAllData();

            try
            {                                                     
                if (_userRepository.IsValidUser(user))
                {
                    MessageBox.Show($"Welcome {allData[user.MobileNumber][0]}", "Logged in",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelTaxProfille.Visible = true;
                    panelLogin.Visible = false;
                }

            }
            catch (ArgumentException exc)
            {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
             
            textBoxLoginMobileNumber.Clear();
            textBoxLoginPassword.Clear();

        }

        /// <summary>
        /// Back button functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoginBack_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = false;
            panelHome.Visible = true;
        }

        #endregion
        
    }
}
