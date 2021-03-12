using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTaxDLL
{
    public class AgeCatogry
    {
        public enum UserAgeCatogry
        {
            /// <summary>
            /// Age below 60
            /// </summary>
            General,

            /// <summary>
            /// Age between 60 to 80 exclude 80
            /// </summary>
            Senior,

            /// <summary>
            /// Age above 80
            /// </summary>
            SuperSenior
        };
    }
}
