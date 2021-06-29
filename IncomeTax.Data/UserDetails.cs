using System;

namespace IncomeTax.Data
{
    public struct UserDetails : IEquatable<UserDetails>
    {

        public string MobileNumber { get; }
        public string UserName { get; }

        public string UserPassword { get; set; }

        public UserDetails(string mobileNumber, string name, string password)
        {
            this.MobileNumber = mobileNumber;
            UserName = name;
            UserPassword = password;
        }

        public bool Equals(UserDetails user)
        {
            bool isEqual = (user.MobileNumber == MobileNumber && user.UserName == UserName
                                && user.UserPassword == UserPassword);
            return isEqual;
        }

    }
}
