namespace OOP.Coupling.BadExample;
public class BadProgram
{
    public static void Main()
    {
        try
        {
            var orderService = new OrderService();
            orderService.PlaceOrder();
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
