namespace OOP.Encapsulation;
public class BankAccountService
{
    private decimal _balance;

        public BankAccountService(decimal balance)
    {
        Deposit(balance);
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit must be positive");
        }

        _balance += amount;
    }


    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdraw must be positive");
        }

        if (_balance < amount)
        {
            throw new InvalidOperationException("Insufficient balance");
        }

        _balance -= amount;
    }

    public static class BankAccountServiceExample
    {
        public static void Main()
        {
            try
            {
                var account = new BankAccountService(1000);
                Console.WriteLine(account.GetBalance());
                account.Deposit(1000);
                Console.WriteLine(account.GetBalance());
                account.Withdraw(500);
                Console.WriteLine(account.GetBalance());
                
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