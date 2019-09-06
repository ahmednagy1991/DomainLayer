using Service.ServiceAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleArchitecutre2.mail
{
    public class MailSender : IEmailService
    {
        public void SendMail(string mail, string subject, string body)
        {
         //mail send
        }
    }
}