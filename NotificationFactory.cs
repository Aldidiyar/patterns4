using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns4
{
    internal class NotificationFactory : INotificationFactory
    {
        public INotification CreateNotification(string notificationType)
        {
            if (notificationType == "Telegram")
            {
                return new TelegramNotification();
            }
            else if (notificationType == "Whatsapp")
            {
                return new WhatsappNotification();
            }
            else
            { 
                return null;
            }
        }
    }
}
