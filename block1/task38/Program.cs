using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину большой основание трапеции: ");
        double base1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите длину маленькой основание трапеции: ");
        double base2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите высоту трапеции: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double leg = Math.Sqrt(Math.Pow((base1 - base2) / 2, 2) + Math.Pow(height, 2));

        double perimeter = base1 + base2 + 2 * leg;

        Console.WriteLine($"периметр трапеции: {perimeter:F2}");
    }
}