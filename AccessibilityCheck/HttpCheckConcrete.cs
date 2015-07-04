using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Ninject;

namespace AccessibilityCheck
{
    class HttpCheckConcrete : IHttpCheck
    {
        public string Url { get; set; }
        private ILogger _logger = new DefaultLogger();
        
        [Inject]
        public ILogger Logger
        { 
            get { return _logger; }
            set { _logger = value; }
        }

        public bool IsWebsiteAccessible()
        {
            bool result;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Logger.Log(LogLevel.Info, "{0} is accessible", Url);
                    result = true;
                }
            }
            catch(Exception e)
            {
                Logger.Log(LogLevel.Error, "{0} is not accessible. Error : {1}", Url, e.Message);
                result = false;
            }
            return result;
        }

        public HttpCheckConcrete()
        {
            this.Url = "http://dou.ua/";
        }
    }
}
