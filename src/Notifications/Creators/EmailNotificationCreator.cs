using DesignPatternChallenge.Notifications.Interfaces;

namespace DesignPatternChallenge.Notifications.Creators;

/// <summary>
/// Creator concreto para notificações por Email.
/// </summary>
public class EmailNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification()
    {
        return new EmailNotification();
    }
}
