using DesignPatternChallenge.Notifications.Creators;

namespace DesignPatternChallenge;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Notificações com Factory Method ===\n");

        // Cada creator encapsula a criação do tipo concreto de notificação.
        // Para adicionar um novo canal (ex: Telegram, Slack), basta criar
        // uma nova classe concreta + um novo creator, sem modificar código existente.

        // Cliente 1 prefere Email
        NotificationCreator emailCreator = new EmailNotificationCreator();
        emailCreator.Notify("cliente@email.com", "Seu pedido 12345 foi confirmado!");
        Console.WriteLine();

        // Cliente 2 prefere SMS
        NotificationCreator smsCreator = new SmsNotificationCreator();
        smsCreator.Notify("+5511999999999", "Pedido 12346 confirmado!");
        Console.WriteLine();

        // Cliente 3 prefere Push
        NotificationCreator pushCreator = new PushNotificationCreator();
        pushCreator.Notify("device-token-abc123", "Seu pedido foi enviado! Rastreamento: BR123456789");
        Console.WriteLine();

        // Cliente 4 prefere WhatsApp
        NotificationCreator whatsappCreator = new WhatsAppNotificationCreator();
        whatsappCreator.Notify("+5511888888888", "✅ Pagamento pendente: R$ 150,00");
        Console.WriteLine();

        // Demonstração de extensibilidade:
        // Podemos usar uma lista de creators para enviar a mesma mensagem por múltiplos canais
        Console.WriteLine("=== Envio Multi-Canal ===\n");

        NotificationCreator[] creators =
        [
            new EmailNotificationCreator(),
            new SmsNotificationCreator(),
            new PushNotificationCreator(),
            new WhatsAppNotificationCreator()
        ];

        foreach (var creator in creators)
        {
            creator.Notify("usuario-multicanal", "Promoção especial para você!");
            Console.WriteLine();
        }
    }
}
