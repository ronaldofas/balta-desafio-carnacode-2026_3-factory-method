using DesignPatternChallenge.Notifications.Interfaces;

namespace DesignPatternChallenge.Notifications;

/// <summary>
/// Notificação concreta por Email.
/// Implementa INotification e adiciona propriedades específicas de e-mail.
/// </summary>
public class EmailNotification : INotification
{
    public string Recipient { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public bool IsHtml { get; set; }

    public void Send()
    {
        Console.WriteLine($"📧 Enviando Email para {Recipient}");
        Console.WriteLine($"   Assunto: {Subject}");
        Console.WriteLine($"   Mensagem: {Message}");
        Console.WriteLine($"   HTML: {IsHtml}");
    }
}
