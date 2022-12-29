using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSample.MailService
{
    public interface IMailServiceImplementor
    {
        void SendMail(string reciver, string title, string message);
        void EmailList();

    }


    public class GmailService : IMailServiceImplementor
    {
        public void EmailList()
        {
            Console.WriteLine($"List Of {nameof(GmailService)} List");
        }

        public void SendMail(string reciver, string title, string message)
        {
            Console.WriteLine($"Email Send to {reciver} With {nameof(GmailService)}");
        }
    }

    public class YahooService : IMailServiceImplementor
    {
        public void EmailList()
        {
            Console.WriteLine($"List Of {nameof(YahooService)} List");
        }

        public void SendMail(string reciver, string title, string message)
        {
            Console.WriteLine($"Email Send to {reciver} With {nameof(YahooService)}");
        }
    }

    public class MyCompanyMailService : IMailServiceImplementor
    {
        public void EmailList()
        {
            Console.WriteLine($"List Of {nameof(MyCompanyMailService)} List");
        }

        public void SendMail(string reciver, string title, string message)
        {
            Console.WriteLine($"Email Send to {reciver} With {nameof(MyCompanyMailService)}");
        }
    }


}
