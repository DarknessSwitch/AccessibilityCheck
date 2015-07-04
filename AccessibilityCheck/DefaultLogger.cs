using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessibilityCheck
{
    class DefaultLogger : ILogger
    {
        public void Log(LogLevel level, string template, params object[] args)
        {
            Console.WriteLine(template, args);
        }
    }
}
