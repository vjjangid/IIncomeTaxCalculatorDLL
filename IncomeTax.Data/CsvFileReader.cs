using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeTax.Data
{
    public class CsvFileReader
    {

        private readonly string _fileName;
        private HashSet<string> userlist;

        public CsvFileReader(string fileName)
        {
            _fileName = fileName;
        }

        /// <summary>
        /// Return the hash set of stored user in database
        /// </summary>
        /// <returns>Hash set of string</returns>
        public HashSet<string> ValidUserHashSet()
        {       
            try
            {
                if (File.Exists(_fileName))
                {
                    using (StreamReader reader = new StreamReader(File.OpenRead(_fileName)))
                    {
                        userlist = new HashSet<string>();

                        string line = "";
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] linearray = line.Split(';');
                            userlist.Add(linearray[0]);
                        }
                    }

                }
                else
                {
                    throw new FileNotFoundException("$File doesn't exist");
                }
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }

            return userlist;
        }

        /// <summary>
        /// Enumerator of stored database
        /// </summary>
        /// <returns>Enumerator of string</returns>
        public IEnumerable<string> ValiduserListEnumerator()
        { 
            return userlist;
        }

        public Dictionary<string, List<string>> RetrieveAllData()
        {
            Dictionary<string, List<string>> allRecords = new Dictionary<string, List<string>>();

            try
            {
                if (File.Exists(_fileName))
                {
                    using (StreamReader reader = new StreamReader(File.OpenRead(_fileName)))
                    {
                        

                        string line = "";
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] linearray = line.Split(';');
                            List<string> temp = new List<string>();

                            for (int i = 1; i < linearray.Length; i++)
                            {
                                temp.Add(linearray[i]);
                            }

                            string MobileNumber = linearray[0];
                            allRecords.Add(MobileNumber, temp);
                        }
                    }

                }
                else
                {
                    throw new FileNotFoundException("$File doesn't exist");
                }
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
                throw exc;
            }
            return allRecords;
        }
    }
}
