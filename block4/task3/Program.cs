using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Определение области точки");
        Console.WriteLine("Введите координаты точки (x, y):");
        
        Console.Write("x = ");
        double x = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("y = ");
        double y = Convert.ToDouble(Console.ReadLine());
        
        double distanceSquared = x * x + y * y;
        double radiusSquared = 16;
        if (distanceSquared <= radiusSquared)
        {
            Console.WriteLine($"Точка ({x}, {y}) попадает в область I (внутри круга)");
        }
        else
        {
            Console.WriteLine($"Точка ({x}, {y}) попадает в область II (вне круга)");
        }
    }
}