namespace OOP.Coupling.GoodExample
{
    public class SmsService : INotificationService
    {
        public void SendNotification(string message) => Console.WriteLine("SMS: " + message);
    }
}
