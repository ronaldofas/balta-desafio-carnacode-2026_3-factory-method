using DesignPatternChallenge.Notifications.Interfaces;

namespace DesignPatternChallenge.Notifications.Creators;

/// <summary>
/// Creator concreto para notificações por Push.
/// </summary>
public class PushNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification()
    {
        return new PushNotification();
    }
}
