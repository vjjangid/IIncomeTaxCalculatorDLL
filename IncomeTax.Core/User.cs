using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{

    /// <summary>
    /// User Details class
    /// </summary>
    public class User
    {
        private string _fullUserName;

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        /// <summary>
        /// Username
        /// </summary>
        public string FullUserName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName))
                    _fullUserName = LastName;
                else if (!string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrWhiteSpace(LastName))
                    _fullUserName = FirstName;
                else if (string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrWhiteSpace(LastName))
                    _fullUserName = "";
                else
                    _fullUserName = FirstName + " " + LastName;
                
                return _fullUserName;
            }
        }

        /// <summary>
        /// Date of birth of User
        /// </summary>
        public DateTime DOB { get; set; }

        /// <summary>
        /// Whether user salaried or not
        /// </summary>
        public bool IsSalaried { get; set; }

        /// <summary>
        /// Whether user resides in metro or not
        /// </summary>
        public bool ResidesInMetro { get; set; }

        /// <summary>
        /// User age class whether the user senor, general, supersenior
        /// </summary>
        public AgeCategory UserAgeClass
        {
            get
            {
                ///return an enum defining whether the user is senior, general, supersenior
                return UserAgeCategory.FindUserAgeCategory(DOB);
            }
        }

        /// <summary>
        /// Write 
        /// </summary>
        public int MobileNumber { get; set; }

        /// <summary>
        /// To check the validity of inputs
        /// </summary>
        /// <returns></returns>
        public bool Validity()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(_fullUserName))
                isValid = false;
            return isValid;
        }
    }
}
