using System;

namespace Patterns4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            INotificationFactory notificationFactory = new NotificationFactory();
            INotification telegramNotification = notificationFactory.CreateNotification("Telegram");
            INotification whatsappNotification = notificationFactory.CreateNotification("Whatsapp");
            INotificationObserver notificationService = new ConcreteNotificationObserver();
            notificationService.AddObserver(telegramNotification);
            notificationService.AddObserver(whatsappNotification);
            notificationService.NotifyObservers();
        }
    }
}
