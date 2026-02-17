using DesignPatternChallenge.Notifications.Interfaces;

namespace DesignPatternChallenge.Notifications.Creators;

/// <summary>
/// Creator concreto para notificações por SMS.
/// </summary>
public class SmsNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification()
    {
        return new SmsNotification();
    }
}
