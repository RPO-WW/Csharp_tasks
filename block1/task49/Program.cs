using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите длину большего основания а:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите длину меньшего основания b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите угол при большем основании (в градусах): ");
        double angleDegrees = Convert.ToDouble(Console.ReadLine());

        double angleRadians = angleDegrees * Math.PI / 180;

        double x = (a - b) / 2;

        double h = x * Math.Tan(angleRadians);

        double area = (a + b) / 2 * h;

        Console.WriteLine($"Площадь трапеции: {area}");
    }
}