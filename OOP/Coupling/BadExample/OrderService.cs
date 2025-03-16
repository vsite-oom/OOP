using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Coupling.BadExample
{
    public class OrderService
    {
        public void PlaceOrder()
        {
            EmailService emailService = new();
            emailService.SendEmail("Order processed successfully");
        }
    }
    
}
