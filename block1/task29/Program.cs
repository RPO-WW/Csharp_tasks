using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите радиус окружности: ");

        if (double.TryParse(Console.ReadLine(), out double radius))
        {
            if (radius < 0)
            {
                Console.WriteLine("Радиус не может быть отрицательным");
                return;
            }

            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;

            Console.WriteLine($"Длина окружности: {circumference}");
            Console.WriteLine($"Площадь круга: {area}");
        }
        else
        {
            Console.WriteLine("Неккоректный ввод. Пожалуйста , введите число");
        }
    }
}
