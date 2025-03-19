namespace OOP.Coupling.GoodExample;
public class GoodProgram
{
    public static void Main()
    {
        try
        {
            //var orderServiceSms = new OrderService(new SmsService());
            //orderServiceSms.PlaceOrder();

            var orderServiceEmail = new OrderService(new EmailService());
            orderServiceEmail.PlaceOrder();
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