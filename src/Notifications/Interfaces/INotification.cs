namespace DesignPatternChallenge.Notifications.Interfaces;

/// <summary>
/// Interface base para o padrão Factory Method.
/// Define o contrato comum que todas as notificações devem seguir.
/// </summary>
public interface INotification
{
    string Recipient { get; set; }
    string Message { get; set; }
    void Send();
}
