using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{
    class BadEmailService
    {
        public void SendEmail() => Console.WriteLine("Sending email...");
        public void Connect() => Console.WriteLine("Connecting...");
        public void Authenticate() => Console.WriteLine("Authenticating...");
        public void Disconnect() => Console.WriteLine("Disconnecting...");
    }

    public static class BadEmailServiceExample
    {
        public static void Main()
        {
            try
            {
                var emailService = new 
            }
        }
    }
}
