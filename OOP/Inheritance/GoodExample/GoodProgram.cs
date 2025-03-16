using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance.GoodExample
{
    public class GoodProgram
    {
        public static void Main()
        {
            try
            {
                Car car = new("Toyota", "Corolla", 2021);
                car.NumberOfDoors = 4;
                car.Start();
                car.Stop();
                car.Drive();
                Bike bike = new("Yamaha", "Y2F-R1", 2021);
                bike.Wheelie();
                bike.Start();
                bike.Stop();
                bike.Drive();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            finally
            {
                Console.WriteLine("Program completed");
            }
        }
    }
}
