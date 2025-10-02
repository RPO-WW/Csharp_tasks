using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите функцию для вычисления:");
        Console.WriteLine("1. x = (2a + sin|3a|) / 3.56");
        Console.WriteLine("2. y = sin((3.2 + sqrt(1 + x)) / |5x|)");
        Console.Write("Введите номер функции (1 или 2): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Введите значение a: ");
                double a = Convert.ToDouble(Console.ReadLine());
                double x = (2 * a + Math.Sin(Math.Abs(3 * a))) / 3.56;
                Console.WriteLine($"Значение функции x: {x}");
                break;
            case 2:
                Console.Write("Введите значение x: ");
                double xInput = Convert.ToDouble(Console.ReadLine());
                double y = Math.Sin((3.2 + Math.Sqrt(1 + xInput)) / Math.Abs(5 * xInput));
                Console.WriteLine($"Значение функции y: {y}");
                break;
            default:
                Console.WriteLine("Неверный выбор функции.");
                break;
        }
    }
}
