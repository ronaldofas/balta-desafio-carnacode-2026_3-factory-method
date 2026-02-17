using DesignPatternChallenge.Notifications.Interfaces;

namespace DesignPatternChallenge.Notifications.Creators;

/// <summary>
/// Classe abstrata Creator do padrão Factory Method.
/// Define o factory method que as subclasses devem implementar
/// e fornece métodos utilitários para envio de notificações.
/// </summary>
public abstract class NotificationCreator
{
    /// <summary>
    /// Factory Method — as subclasses decidem qual INotification criar.
    /// </summary>
    public abstract INotification CreateNotification();

    /// <summary>
    /// Envia uma notificação genérica usando o factory method.
    /// </summary>
    public void Notify(string recipient, string message)
    {
        var notification = CreateNotification();
        notification.Recipient = recipient;
        notification.Message = message;
        notification.Send();
    }
}
