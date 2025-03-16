using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{ 
    public class EmailService

    {
        public void SendEmail() => Console.WriteLine("Sending email...");
        public void Connect() => Console.WriteLine("Connecting...");
        public void Authenticate() => Console.WriteLine("Authenticating...");
        public void Disconnect() => Console.WriteLine("Disconnecting...");
    }

    public static class EmailServiceExample
    {
        public static void Main()
        {
            try
            {
                var emailService = new EmailService();
                emailService.Connect();
                emailService.Disconnect();
                emailService.Authenticate();
                emailService.SendEmail();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program Completed.");
            }
        }
    }
}
