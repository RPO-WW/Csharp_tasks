using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите температуру в градусах Цельсия: ");

        if (!double.TryParse(Console.ReadLine(), out double celsius))
        {
            Console.WriteLine("Ошибка: введено некорректное значение.");
            return;
        }

        double fahrenheit = celsius * 1.8 + 32;

        double kelvin = celsius + 273.15;

        Console.WriteLine($"Температура по шкале Фаренгейта: {fahrenheit}");
        Console.WriteLine($"Температура по шкале Кельвина: {kelvin}");
    }
}