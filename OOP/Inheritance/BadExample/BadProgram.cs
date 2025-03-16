namespace OOP.Inheritance.BadExample;
public class BadProgram
{
    public static void Main()
    {
        try
        {
            Car car = new("Toyota", "Corolla", 2021);
            car.Start();
            car.Drive();
            car.Stop();
            Bike bike = new("Yamaha", "YZF-R1", 2021);
            bike.Start();
            bike.Drive();
            bike.Stop();
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