using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailNotifier
{
    public class EmailSender : IEmailService
    {
        public bool Send(string toMail,string subject,string body)
        {
            try
            {
                var fromAddress = new MailAddress("notifypiss2016@gmail.com", "PISS Notifier");
                var toAddress = new MailAddress(toMail);
                const string fromPassword = "piss2016";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

}
