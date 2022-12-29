using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSample.MailService
{
    public static class Implementation
    {
        public static IMailServiceImplementor GetImplementor()
        {
             string config = ConfigurationManager.AppSettings["EmailImplementation"];

            if (config == "gmail")
            {
                return new GmailService();
            }
            else if (config == "yahoo")
            {
                return new YahooService();
            }

            return new MyCompanyMailService();
        }

    }
}
