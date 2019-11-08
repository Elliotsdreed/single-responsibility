using MailKit.Net.Smtp;  
using MailKit.Security;  
using MimeKit;  
using System.Threading.Tasks;  

namespace single_responsidsoudyg
{
    public class EmailService
    {
         public async Task SendEmailAsync(string email, string subject, string message)  
        {  
            var emailMessage = new MimeMessage();  
  
            emailMessage.From.Add(new MailboxAddress("Elliot Reed", "A90004728@student.peterborough.ac.uk"));  
            emailMessage.To.Add(new MailboxAddress(string.Empty, email));  
            emailMessage.Subject = subject;  
            emailMessage.Body = new TextPart("plain") { Text = message };  
  
            using (SmtpClient smtpClient = new SmtpClient())  
            {  
                smtpClient.LocalDomain = "peterborough.ac.uk";  
                await smtpClient.ConnectAsync("smtp.relay.uri", 25, SecureSocketOptions.None).ConfigureAwait(false);  
                await smtpClient.SendAsync(emailMessage).ConfigureAwait(false);  
                await smtpClient.DisconnectAsync(true).ConfigureAwait(false);  
            }  
        }
    }
}