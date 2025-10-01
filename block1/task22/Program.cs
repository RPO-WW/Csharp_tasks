using System;

class Program
{
    static void Main()
    {
        try
        {
            // Вычисление функции y = x² + 7x + 18
            Console.Write("Введите значение x для функции y: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Pow(x, 2) + 7 * x + 18;
            Console.WriteLine($"y = {x}² + 7*{x} + 18 = {y}");
            
            Console.WriteLine();
            
            // Вычисление функции x = a² + 12a + 112
            Console.Write("Введите значение a для функции x: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double resultX = Math.Pow(a, 2) + 12 * a + 112;
            Console.WriteLine($"x = {a}² + 12*{a} + 112 = {resultX}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}