namespace OOP.Coupling.GoodExample
{
    internal class EmailService : INotificationService
    {
        public void SendNotification(string message) => Console.WriteLine("Email: " + message);
    }
}
