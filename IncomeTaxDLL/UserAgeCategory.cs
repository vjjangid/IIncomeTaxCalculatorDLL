using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax
{
    

    public static class UserAgeCategory
    {
        /// <summary>
        /// Calculate the user age ==> Need to check the logic
        /// </summary>
        /// <param name="dob"></param>
        /// <returns></returns>
        private static int CalculateAge(DateTime dob)
        {
            var today = DateTime.Today;

            var age = today.Year - dob.Year;

            if (dob.Date > today.AddYears(-age))
                age--;

            return age;
        }


        /// <summary>
        /// Age category of the user
        /// </summary>
        /// <param name="dob">Date of birth</param>
        /// <returns></returns>
        public static AgeCategory FindUserAgeCategory(DateTime dob)
        {
            AgeCategory userAgeCatogry;
            var age = CalculateAge(dob);
            if (age >= 0 && age < 60)
                userAgeCatogry = AgeCategory.General;
            else if (age >= 60 && age < 80)
                userAgeCatogry = AgeCategory.Senior;
            else
                userAgeCatogry = AgeCategory.SuperSenior;

            return userAgeCatogry;
        }
    }
}
