using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Coupling.BadExample
{
    public class EmailService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine(message);
        }
    }
}
