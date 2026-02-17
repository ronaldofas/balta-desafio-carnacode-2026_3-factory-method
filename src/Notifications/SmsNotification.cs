using DesignPatternChallenge.Notifications.Interfaces;

namespace DesignPatternChallenge.Notifications;

/// <summary>
/// Notificação concreta por SMS.
/// Implementa INotification com propriedades específicas de SMS.
/// </summary>
public class SmsNotification : INotification
{
    public string Recipient { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;

    public void Send()
    {
        Console.WriteLine($"📱 Enviando SMS para {Recipient}");
        Console.WriteLine($"   Mensagem: {Message}");
    }
}
