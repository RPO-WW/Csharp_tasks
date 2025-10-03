using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину ребра куба: ");
        double edgeLenght = Convert.ToDouble(Console.ReadLine());

        double volume = Math.Pow(edgeLenght, 3);

        double lateralSurfaceArea = 4 * Math.Pow(edgeLenght, 2);

        Console.WriteLine($"Обьем куба: {volume:F2}");
        Console.WriteLine($"Площадь боковой поверхности: {lateralSurfaceArea}");
    }
}
