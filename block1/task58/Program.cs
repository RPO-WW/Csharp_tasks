using System;
class Program
{
    static void Main()
    {
        long population;
        double area;
        Console.Write("Введите количество жителей: ");
        while (!long.TryParse(Console.ReadLine(), out population) || population < 0)
        {
            Console.WriteLine("Введите число жителей неотрицательное: ");
        }
        Console.WriteLine("Введите площадь в кв км");
        while (!double.TryParse(Console.ReadLine(), out area) || area <= 0)
        {
            Console.WriteLine("Площадь должна быть больше нуля: ");
        }
        double populationDensity = population / area;
        Console.WriteLine($"Плотность населения на кв метр равна: {populationDensity} жителей на кв км");
    }
}
