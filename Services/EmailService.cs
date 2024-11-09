using System;
using System.Net;
using System.Net.Mail;
using lesson_26_10_24.Services.Interfaces;

namespace lesson_26_10_24.Services;

public class EmailService : IEmailService
{
    public async Task SendEmailAsync(string to, string subject, string body)
    {
        using var smtpClient = new SmtpClient("smtp.gmail.com")
        {
            Port = 587,
            Credentials = new NetworkCredential("pronin6030@mail.ru", "application_password"),
            EnableSsl = true
        };

        var mailMessage = new MailMessage("pronin6030@mail.ru", to, subject, body);

        await smtpClient.SendMailAsync(mailMessage);
    }
}
