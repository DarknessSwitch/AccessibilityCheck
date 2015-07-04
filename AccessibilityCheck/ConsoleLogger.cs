using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessibilityCheck
{
    class ConsoleLogger : ILogger
    {
        public void Log(LogLevel level, string template, params object[] args)
        {
            Console.WriteLine("{0} : {1} - {2}", level, String.Format(template, args), DateTime.Now);
        }        
    }
}
