using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns4
{
    internal interface INotificationFactory
    {
        public INotification CreateNotification(string notificationType);
    }
}
