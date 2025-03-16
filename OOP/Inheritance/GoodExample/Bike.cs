using OOP.Inheritance.BadExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance.GoodExample
{
    public class Bike : Vehicle
    {

        public Bike(string brand, string model, int year) : base(brand,model,year)
        {
           
        }

        public void Wheelie() => Console.WriteLine("Bike is doing wheelie...");
    }
}
