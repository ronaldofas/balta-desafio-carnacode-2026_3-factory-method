using DesignPatternChallenge.Notifications.Interfaces;

namespace DesignPatternChallenge.Notifications;

/// <summary>
/// Notificação concreta por Push Notification.
/// Implementa INotification com propriedades específicas de push.
/// </summary>
public class PushNotification : INotification
{
    public string Recipient { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public int Badge { get; set; }

    public void Send()
    {
        Console.WriteLine($"🔔 Enviando Push para dispositivo {Recipient}");
        Console.WriteLine($"   Título: {Title}");
        Console.WriteLine($"   Mensagem: {Message}");
        Console.WriteLine($"   Badge: {Badge}");
    }
}
