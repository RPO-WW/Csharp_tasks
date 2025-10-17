using System;

class Program
{
    static void Main()
    {
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());

        double x = -b / a;
        Console.WriteLine("x = " + x);

    }
}