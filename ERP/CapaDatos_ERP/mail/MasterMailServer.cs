using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace CapaDatos_ERP.mail
{
    public abstract class MasterMailServer
    {
        //Atributos
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        //Inicializar propiedades del cliente SMTP
        protected void initializeSmtpClient()
        {
            //smtpClient = new SmtpClient();
            //smtpClient.Credentials = new NetworkCredential(senderMail, password);
            //smtpClient.Host = host;
            //smtpClient.Port = port;
            //smtpClient.EnableSsl = ssl;
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential("soportecorreosrisko@gmail.com", "rkpo1432");
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        }
        public void sendMail(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(senderMail);
                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                    smtpClient.Send(mailMessage);//Enviar mensaje
            


            }
            catch (Exception ex) {
                Console.WriteLine("error de envio",ex);
            }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
