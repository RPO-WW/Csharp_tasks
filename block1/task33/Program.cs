using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main()
    {
    Console.Write("Введите количество жителей: ");
long population = long.Parse(Console.ReadLine());

    Console.Write("Введите площадь территории (км2): ");
double area = double.Parse(Console.ReadLine());

        double density = population / area;
    Console.WriteLine($"Плотность населения: {density:F2} чел/км2");
        }
}