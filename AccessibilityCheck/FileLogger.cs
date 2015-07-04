using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AccessibilityCheck
{
    class FileLogger : ILogger
    {
        public void Log(LogLevel level, string template, params object[] args)
        {
            try
            {
                Directory.CreateDirectory(@"Logs\");
                using (StreamWriter writer = File.AppendText(@"Logs\Log_" + DateTime.Now.ToShortDateString() + ".txt"))
                {
                    writer.WriteLine("{0} : {1} - {2}", level, String.Format(template, args), DateTime.Now);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
