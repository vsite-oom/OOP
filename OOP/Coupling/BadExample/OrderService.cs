namespace OOP.Coupling.BadExample
{
    public class OrderService
    {
        public void PlaceOrder()
        {
            EmailService emailService = new();
            emailService.SendEmail("Order placed successfully");
        }
    }
}
