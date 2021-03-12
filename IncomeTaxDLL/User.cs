using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxDLL
{

    /// <summary>
    /// User Details class
    /// </summary>
    public class User
    {
        private string _userName;
        
        /// <summary>
        /// Username
        /// </summary>
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }

        /// <summary>
        /// Date of birth of User
        /// </summary>
        public DateTime? DOB { get; set; }

        /// <summary>
        /// Whether user salaried or not
        /// </summary>
        public bool IsSalaried { get; set; }

        /// <summary>
        /// Whether user resides in metro or not
        /// </summary>
        public bool ResidesInMetro { get; set; }

        public AgeCatogry.UserAgeCatogry AgeClass
        {
            get;
            set;
        }
    }
}
