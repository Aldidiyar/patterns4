using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns4
{
    internal class ConcreteNotificationObserver : INotificationObserver
    {
        private List<INotification> observers = new List<INotification>();
        public void AddObserver(INotification notification)
        {
            observers.Add(notification);
        }
        public void DeleteObserver(INotification notification)
        {
            observers.Remove(notification);
        }
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Notify();
            }
        }
    }
}
