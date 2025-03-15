using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Encapsulation
{
    class BadBankAccountService
    {
        public decimal balance { get; set; }

        public static class BadBankAccountServiceExample
        {
            public static void Main()
            {
                try
                {
                    var bankAccount = new BadBankAccountService();
                    bankAccount.balance = 1000;
                    bankAccount.balance = -1000;
                    Console.WriteLine(bankAccount.balance);
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
}
