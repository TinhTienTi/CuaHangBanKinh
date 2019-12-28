using System.Net;
using System.Net.Mail;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DataAccess.EmailServices
{
    public abstract class MasterEmailServer
    {
        private SmtpClient smtpClient;
        protected string senderEmail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }
        protected void initializeStmpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderEmail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }
        public void SendEmail (string subject,string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(senderEmail);
                foreach(string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);
            }
            catch (Exception) { }
            finally {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
