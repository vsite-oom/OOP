using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Coupling.GoodExample
{
    public class OrderService
    {
        private readonly INotificationService _notificationService;

        public OrderService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void PlaceOrder()
        {
            _notificationService.SendNotification("Order processed successfully");
        }
    }
}
