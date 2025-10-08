using System;

public class Rectangle
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите длину первой стороны прямоугольника (a):");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите длину второй стороны прямоугольника (b):");
        double b = Convert.ToDouble(Console.ReadLine());

        double perimeter = 2 * (a + b);
        Console.WriteLine($"Периметр прямоугольника: {perimeter}");

        double diagonal = Math.Sqrt(a * a + b * b);
        Console.WriteLine($"Длина диагонали прямоугольника: {diagonal}");
    }
}
