using IncomeTax.Data;
using System;
using System.IO;

namespace IncomeTax.Core
{
    public class UserRepository
    {
        public string FilePath { get; private set; }

        private IUserRepository _userRepo;
        
        public UserRepository()
        {
            CreateDataFile();
        }

        public void CreateDataFile()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string directoryName = "Data\\";

            string fullDirectoryPath = path + directoryName;
            string fileName = "data.csv";


            if (!Directory.Exists(fullDirectoryPath))
            {
                Directory.CreateDirectory(fullDirectoryPath);
            }
            if (!File.Exists(fullDirectoryPath + fileName))
            {
                File.Create(fullDirectoryPath + fileName);
            }


            FilePath = fullDirectoryPath + fileName;
            ////FilePath = @"C:\UserData\z0049n3x\Documents\data.csv";
        }

        public void CreateUser(UserDetails user)
        {
            Console.WriteLine("FilePaths is " + FilePath);
            _userRepo = new CsvRepository(FilePath, user);
            try
            {
                _userRepo.Create(user);
            }
            catch (ArgumentException exc)
            {
                throw exc;
            }
        }

        public bool IsValidUser(UserDetails user)
        {
            _userRepo = new CsvRepository(FilePath, user);
            return _userRepo.ValidateUser(user);
        }

        
    }
}
