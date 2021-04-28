using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Core.CustomException
{
    public class UserNameException : Exception
    {
        public UserNameException()
        {
                
        }

        public UserNameException(string name) : base("Attempted wrong format user name input")
        { }
    }
}
