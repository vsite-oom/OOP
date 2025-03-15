namespace OOP.Coupling.GoodExample;
public class EmailService : INotificationService
{
    public void SendNotification(string message) => Console.WriteLine("Email: " + message);
}