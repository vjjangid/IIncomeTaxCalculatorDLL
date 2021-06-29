using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public abstract class LogBase
    {
        protected readonly object LockObj = new object();
        public abstract void Log(string message);
    }
}
