using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Data
{
    public struct UserDetails : IEquatable<UserDetails>
    {

        public string MobileNumber { get; }
        public string UserName { get ; }

        public string UserPassword { get; set; }
        
        public UserDetails(string MobileNumber, string Name, string Password)
        {
            this.MobileNumber = MobileNumber;
            UserName = Name;
            UserPassword = Password;
        }

        public bool Equals(UserDetails user)
        {
            bool isEqual = (user.MobileNumber == MobileNumber && user.UserName == UserName
                                && user.UserPassword == UserPassword);
            return isEqual;
        }

    }
}
