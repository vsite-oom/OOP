namespace OOP.Encapsulation;

public class BadBankAccountService
{
    public decimal balance { get; set; }
}

public static class BadBankAccountServiceExample
{
    public static void Main()
    {
        try
        {
            var bankAccount = new BadBankAccountService();
            bankAccount.balance = 1000;
            //bankAccount.balance = -1000;
            Console.WriteLine(bankAccount.balance);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally 
        {
            Console.WriteLine("Program completed.");
        }
    }
}
