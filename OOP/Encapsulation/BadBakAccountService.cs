namespace OOP.Encapsulation;
public class BadBakAccountService
{
    public decimal balance { get; set; }
}

public static class BadBakAccountServiceExample
{
    public static void Main()
    {
        try
        {
            var account = new BadBakAccountService();
            account.balance = 1000;
            account.balance = -1000;
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