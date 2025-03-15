using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Composition
{
    public class Car
    {
        private readonly Engine engine = new();
        private readonly Wheels wheels = new();
        private readonly Chassis chassis = new();
        private readonly Seats seats = new();
    }

    public void StartCar()
        {
            engine.Start();
            wheels.Rotate();
            chassis.Support();
            seats.Sit();
        }
}
