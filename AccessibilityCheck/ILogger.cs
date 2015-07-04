using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessibilityCheck
{
    interface ILogger
    {
        void Log(LogLevel level,string template, params object[] args); 
    }

    public enum LogLevel
    {
        Error,
        Warning,
        Info,
        Debug
    };
}
