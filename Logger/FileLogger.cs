using System.IO;

namespace Logger
{
    public class FileLogger : LogBase
    {
        private readonly string _filePath = @"C:\UserData\z0049n3x\Documents\log.txt";
        public override void Log(string message)
        {
            lock (LockObj)
            {
                using(StreamWriter streamWriter = new StreamWriter(_filePath))
                {
                    streamWriter.WriteLine(message);
                    streamWriter.Close();
                }
            }
        }
    }
}
