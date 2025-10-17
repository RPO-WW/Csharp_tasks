using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите массы в килограммах: ");
        double massKg = Convert.ToDouble(Console.ReadLine());

        int fullTons = (int)(massKg / 1000);

        Console.WriteLine($"Число полных тонн: {fullTons}");
    }
}