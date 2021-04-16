using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Data
{
    public class CsvFileWriter
    {

        private readonly string _filePath;

        public CsvFileWriter(string filePath)
        {
            _filePath = filePath;
        }

        /// <summary>
        /// Writes one user data to csv file
        /// </summary>
        /// <param name="user"> User details </param>
        public void WriteRecord(UserDetails user)
        {
            string row = user.MobileNumber + ";" + user.UserName + ";" + user.UserPassword;
            try
            {
                CsvFileReader reader = new CsvFileReader(_filePath);
                HashSet<string> validList = reader.ValidUserHashSet();
                if (validList.Contains(user.MobileNumber))
                {
                    throw new ArgumentException("User Already exits");
                }
                else
                {
                    using (StreamWriter writer = File.AppendText(_filePath))
                    {
                        writer.WriteLine(row);
                    }
                }
            }
            catch (ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
                throw exc;
            }
        }

        /// <summary>
        /// Deleltes the user details on the basis of mobile number
        /// </summary>
        /// <param name="MobileNumber"> Mobile number of the user</param>
        public void DeleteRecord(string MobileNumber)
        {
            CsvFileReader reader = new CsvFileReader(_filePath);
            HashSet<string> validList = reader.ValidUserHashSet();

            try
            {
                if (validList.Contains(MobileNumber))
                {
                    string tempFile = Path.GetTempFileName();

                    var lineToKeep = File.ReadLines(_filePath).Where(line => !line.Contains(MobileNumber));

                    File.WriteAllLines(tempFile, lineToKeep);
                    File.Delete(_filePath);

                    File.Move(tempFile, _filePath);
                }
                else
                {
                    throw new ArgumentException("User Doesn't exist");
                }
            }
            catch(ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
              
        }

        /// <summary>
        /// Updates the information of the user in csv file
        /// </summary>
        /// <param name="MobileNumber">User Mobile number</param>
        /// <param name="user">User all details</param>
        public void UpdateRecord(string MobileNumber, UserDetails user)
        {
            CsvFileReader reader = new CsvFileReader(_filePath);
            HashSet<string> validList = reader.ValidUserHashSet();

            if (validList.Contains(MobileNumber))
            {
                CsvFileWriter writer = new CsvFileWriter(_filePath);
                writer.DeleteRecord(MobileNumber);
                writer.WriteRecord(user);
            }

        }
    }
}
