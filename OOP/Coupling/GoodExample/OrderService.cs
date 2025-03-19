namespace OOP.Coupling.GoodExample
{
    public class OrderService
    {
        private readonly INotificationService _notificationService;

        public OrderService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void PlaceOrder()
        {
            _notificationService.SendNotification("Order placed successfully.");
        }
    }
}
