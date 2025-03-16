using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Composition;

    public class Car
    {
        private readonly Engine engine = new();
        private readonly Wheels wheels = new();
        private readonly Chassis chassis = new();
        private readonly Seats seats = new();
    

    public void StartCar()
        {
            engine.Start();
            wheels.Rotate();
            chassis.Support();
            seats.Sit();
            Console.WriteLine("Car started");
        }
    }

public static class CarExample
{
    public static void Main()
    {
        try
        {
            var car = new Car();
            car.StartCar();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Done");
        }
    }
}


