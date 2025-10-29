using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());
        
        double y;
        
        if (x > 0)
        {
            y = Math.Pow(Math.Sin(x), 2);
        }
        else
        {
            y = 1 - 2 * Math.Sin(Math.Pow(x, 2));
        }
        
        Console.WriteLine($"При x = {x}");
        Console.WriteLine($"y = {y}");
        Console.WriteLine($"y = {y:F4} (с округлением до 4 знаков)");
    }
}