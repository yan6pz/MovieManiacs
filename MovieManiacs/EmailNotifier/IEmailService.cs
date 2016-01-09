using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifier
{
    public interface IEmailService
    {
        bool Send(string toMail, string subject, string body);
    }
}
