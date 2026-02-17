using DesignPatternChallenge.Notifications.Interfaces;

namespace DesignPatternChallenge.Notifications.Creators;

/// <summary>
/// Creator concreto para notificações por WhatsApp.
/// </summary>
public class WhatsAppNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification()
    {
        return new WhatsAppNotification();
    }
}
