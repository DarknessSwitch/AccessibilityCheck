using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace AccessibilityCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            IocInit();
            var checker = Ioc.Get<IHttpCheck>();

            for (int i = 0; i < 10; i++)
            {
                checker.IsWebsiteAccessible();
            }
            Console.ReadKey();
        }
        private static void IocInit()
        {
            Ioc.Init((kernel) =>
                {
                    kernel.Bind<IHttpCheck>().To<HttpCheckConcrete>().InTransientScope();
                    kernel.Bind<ILogger>().To<CombinedLogger>().InTransientScope();
                });
        }
    }
}
