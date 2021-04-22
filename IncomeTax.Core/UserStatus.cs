using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Core
{
    
    /// <summary>
    /// Status of user in application
    /// </summary>
    public enum UserStatus
    {
        /// <summary>
        /// User is registered with our appliacation
        /// </summary>
        Registered,

        /// <summary>
        /// User wants to use appliacation as GuestUser
        /// </summary>
        Guest,

        /// <summary>
        /// New user wants register
        /// </summary>
        NewUser


    }
}
