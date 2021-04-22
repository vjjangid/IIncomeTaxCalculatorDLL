using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace IncomeTax.Data
{
    public class CSVRepository : IUserRepository
    {
        private string _filePath;
        private CsvFileReader reader;
        private CsvFileWriter writer;

        //Load data at the start of application in a dictionary for efficiency
        private HashSet<string> ValidUser; 

        public CSVRepository(string filePath, UserDetails user)
        {
            _filePath = filePath;
            
        }
        

        /// <summary>
        /// Creating a new user
        /// </summary>
        /// <returns></returns>
        public void Create(UserDetails user)
        {
            //Check whether user already exist or not
            //Using dictionary here is good keeping Mobile Number as key
            writer = new CsvFileWriter(_filePath);
            writer.WriteRecord(user);
            
        }

        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="user">User Details</param>
        public void Delete(UserDetails user)
        {
            writer = new CsvFileWriter(_filePath);
            writer.DeleteRecord(user.MobileNumber);
        }

        /// <summary>
        /// Read csv file to check validity of user
        /// </summary>
        /// <param name="user">user details</param>
        /// <returns>boolean value true if user exist in database</returns>
        public bool Read(UserDetails user)
        {
            reader = new CsvFileReader(_filePath);
            ValidUser = reader.ValidUserHashSet();

            return ValidUser.Contains(user.MobileNumber);
        }

        /// <summary>
        /// Modification in user details
        /// </summary>
        /// <param name="user">User details</param>
        public void Update(UserDetails user)
        {
            writer = new CsvFileWriter(_filePath);
            writer.UpdateRecord(user.MobileNumber, user);
        }

        public bool ValidateUser(UserDetails user)
        {
            reader = new CsvFileReader(_filePath);
            Dictionary<string, List<string>> allData = reader.RetrieveAllData();

            try
            {
                if (allData.ContainsKey(user.MobileNumber))
                {
                    string password = allData[user.MobileNumber][1];
                    return (allData.ContainsKey(user.MobileNumber) &&
                            user.UserPassword == password);
                }
                else
                {
                    throw new ArgumentException("User Doesn't exist");
                }
            }
            catch(ArgumentException exc)
            {
                throw exc;
            }  
        }
    }
}
