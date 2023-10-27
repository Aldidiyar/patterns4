using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns4
{
    internal interface INotificationObserver
    {
        void AddObserver(INotification notification);
        void DeleteObserver(INotification notification);
        void NotifyObservers();

    }
}
