using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        // Aqui você pode implementar envio de e-mail real usando SMTP ou outras ferramentas.
        Console.WriteLine($"E-mail para: {email}, Assunto: {subject}, Mensagem: {htmlMessage}");
        return Task.CompletedTask; // Implementação fictícia
    }
}
