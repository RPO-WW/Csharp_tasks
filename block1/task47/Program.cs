using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите x первой точки:");
        double x1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите y первой точки:");
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите x второй точки:");
        double x2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите y второй точки:");
        double y2 = double.Parse(Console.ReadLine());

        double dx = x2 - x1;
        double dy = y2 - y1;
        double distance = Math.Sqrt(dx * dx + dy * dy);

        Console.WriteLine("Расстояние между точками: " + distance);
    }
}