using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите высоту над землей(в километрах):");
        double heightKm = double.Parse(Console.ReadLine());

        double distance = CalculateHorizonDistance(heightKm);
        Console.WriteLine($"расстояние до горизонта: {distance:F2} км");
    }

    static double CalculateHorizonDistance(double heightKm)
    {
        const double R = 6350.0;
        return Math.Sqrt(2 * R * heightKm + Math.Pow(heightKm, 2));
    }
}