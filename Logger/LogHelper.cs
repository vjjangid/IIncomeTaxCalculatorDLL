using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public static class LogHelper
    {
        private static LogBase _logger = null;

        static public void Log(LogTarget logTarget, string message)
        {
            switch (logTarget)
            {
                case LogTarget.File:
                    _logger = new FileLogger();
                    break;
            }
        }
    }
}
