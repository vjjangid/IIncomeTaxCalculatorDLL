using System;
using System.Collections.Generic;

namespace IncomeTax.Data
{
    public class CsvRepository : IUserRepository
    {
        private string _filePath;
        private CsvFileReader _reader;
        private CsvFileWriter _writer;

        //Load data at the start of application in a dictionary for efficiency
        private HashSet<string> _validUser; 

        public CsvRepository(string filePath, UserDetails user)
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
            _writer = new CsvFileWriter(_filePath);
            _writer.WriteRecord(user);
            
        }

        /// <summary>
        /// Delete User
        /// </summary>
        /// <param name="user">User Details</param>
        public void Delete(UserDetails user)
        {
            _writer = new CsvFileWriter(_filePath);
            _writer.DeleteRecord(user.MobileNumber);
        }

        /// <summary>
        /// Read csv file to check validity of user
        /// </summary>
        /// <param name="user">user details</param>
        /// <returns>boolean value true if user exist in database</returns>
        public bool Read(UserDetails user)
        {
            _reader = new CsvFileReader(_filePath);
            _validUser = _reader.ValidUserHashSet();

            return _validUser.Contains(user.MobileNumber);
        }

        /// <summary>
        /// Modification in user details
        /// </summary>
        /// <param name="user">User details</param>
        public void Update(UserDetails user)
        {
            _writer = new CsvFileWriter(_filePath);
            _writer.UpdateRecord(user.MobileNumber, user);
        }

        public bool ValidateUser(UserDetails user)
        {
            _reader = new CsvFileReader(_filePath);
            Dictionary<string, List<string>> allData = _reader.RetrieveAllData();

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
