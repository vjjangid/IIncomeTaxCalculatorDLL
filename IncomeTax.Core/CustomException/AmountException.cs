using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Core.CustomException
{
    public class AmountException : Exception
    {
        public AmountException()
        {

        }

        public AmountException(string msg) : base("Attempted for invalid money amount")
        { }
    }
}
