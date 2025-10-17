using System;

class Program
{

    static void Main()
    {
        try
        {
            Console.WriteLine("Введите массу тела (кг): ");
            double mass = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите обьема тела(м^2)");
            double volume = double.Parse(Console.ReadLine());

            if (mass <= 0 || volume <= 0)
            {
                Console.WriteLine("ой ой ой ошибка:масса и обьем должен быть положительным");
                return;
            }

            double density = mass / volume;

            Console.WriteLine($"плотность материала: {density:F2} кг/м^3");
        }
        catch (FormatException)
        {
            Console.WriteLine("ошибка не верное число значение");
        }
        catch (OverflowException)
        {
            Console.WriteLine("ошибка число большое или маленькое(не нужно шутить про половой орган пожалуйста)");
        }
    }
}

            