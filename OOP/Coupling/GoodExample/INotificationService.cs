using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Coupling.GoodExample
{
    public interface INotificationService
    {
        public void SendNotification(string message);
    }
}
