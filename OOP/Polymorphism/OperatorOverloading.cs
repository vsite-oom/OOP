using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism;

public class OperatorOverloading
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
        int x = 10;
        int y = 20;

        string a = "Hello";
        string b = "Nooo";

        Console.WriteLine(a + b);
        Console.WriteLine(x + y);
    }
}
