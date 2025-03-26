using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism;

public class MethodOverloading
{
    public void TotalSum(int a, int b)
    {
        Console.WriteLine("Sum of numbers is " + (a + b));
    }

    public void TotalSum(float a, float b)
    {
        Console.WriteLine("Sum of numbers is " + (a + b));
    }

    public void TotalSum(float a, float b, float c)
    {
        Console.WriteLine("Sum of numbers is " + (a + b + c));
    }

    public static void Main()
    {
        MethodOverloading methodOverloading = new();

        methodOverloading.TotalSum(1, 2);
        methodOverloading.TotalSum(1f, 2f);
        methodOverloading.TotalSum(1f, 2f, 3f);
    }
}
