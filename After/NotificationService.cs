using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.After
{
    class NotificationService
    {
        public readonly List<IMessageService> _services;

        public NotificationService(List<IMessageService> services)
        {
            _services = services;
        }

        public void Notify()
        {
            foreach (var service in _services)
            {
                service.Send();
            }
        }
    }
}
