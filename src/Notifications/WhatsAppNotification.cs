using DesignPatternChallenge.Notifications.Interfaces;

namespace DesignPatternChallenge.Notifications;

/// <summary>
/// Notificação concreta por WhatsApp.
/// Implementa INotification com propriedades específicas de WhatsApp.
/// </summary>
public class WhatsAppNotification : INotification
{
    public string Recipient { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public bool UseTemplate { get; set; }

    public void Send()
    {
        Console.WriteLine($"💬 Enviando WhatsApp para {Recipient}");
        Console.WriteLine($"   Mensagem: {Message}");
        Console.WriteLine($"   Template: {UseTemplate}");
    }
}
