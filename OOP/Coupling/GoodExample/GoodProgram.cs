using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Coupling.GoodExample
{
    public class GoodProgram
    {
        public static void Main()
        {
            try
            {
                var orderServiceEmail = new OrderService(new EmailService());
                orderServiceEmail.PlaceOrder();
                var orderServiceSms = new OrderService(new SmsService());
                orderServiceSms.PlaceOrder();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }
        }
    }
}
