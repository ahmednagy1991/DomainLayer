using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.ServiceAbstraction
{
    public interface IEmailService
    {
        void SendMail(string mail, string subject, string body);
    }
}
