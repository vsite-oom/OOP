namespace OOP.Abstraction;
public class BadEmailService
{
    public void SendEmail() => Console.WriteLine("Sending email...");
    public void Connect() => Console.WriteLine("Connecting to email server...");
    public void Authenticate() => Console.WriteLine("Authenticating...");
    public void Disconnect() => Console.WriteLine("Disconnecting from email server...");
}

public static class BadEmailServiceExample
{
    public static void Main()
    {
        try
        {
            var emailService = new BadEmailService();
            emailService.Connect();
            emailService.Authenticate();
            emailService.SendEmail();
            emailService.Disconnect();
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
