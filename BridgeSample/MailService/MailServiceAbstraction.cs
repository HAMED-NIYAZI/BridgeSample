using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSample.MailService
{
    public abstract class MailServiceAbstraction
    {
        private readonly IMailServiceImplementor mailServiceImplementor;
        public MailServiceAbstraction()
        {
            mailServiceImplementor = Implementation.GetImplementor();
        }
        public virtual void Send(EmailInforMationDto email) 
        {
            mailServiceImplementor.SendMail(email.Reciver, email.Title, email.Message);
         }
    }

    public class RefinedMailService : MailServiceAbstraction
    {
    }

    public class EmailInforMationDto
    {
        public string Reciver { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}


