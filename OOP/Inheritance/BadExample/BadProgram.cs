namespace OOP.Inheritance.BadExample;

public class BadProgram
{
    public static void Main()
    {
        try
        {
            Car car = new("Toyota", "Corolla", 2021);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally()
    }
}
