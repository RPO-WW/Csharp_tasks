using System;

public class RingAreaCalculator
{
    public static void Main(string[] args)
    {
        double outerRadius = 10.0;
        double innerRadius = 5.0;


        double ringArea = Math.PI * (Math.Pow(outerRadius, 2) - Math.Pow(innerRadius, 2));

        Console.WriteLine($"Площадь кольца: {ringArea}");
    }
}
