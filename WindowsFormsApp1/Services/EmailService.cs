using iTextSharp.text;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.IO;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services
{
    public class EmailService
    {
        public async Task<bool> SendEmail(Email email, string attachmentFilePath, string attachmentFileName)
        {
            var client = new SendGridClient(email.apiKey);
            var from = new EmailAddress(email.fromEmail);
            var to = new EmailAddress(email.toEmail);
            var msg = MailHelper.CreateSingleEmail(from, to, email.subject, email.plainTextContent, email.htmlContent);

            var attachment =  File.ReadAllBytes(attachmentFilePath);
            var base64Content = Convert.ToBase64String(attachment);
            msg.AddAttachment(attachmentFileName, base64Content);

            var response = await client.SendEmailAsync(msg);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }
    }
}
