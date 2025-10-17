using system;

class Program
{
    static void Main()
    {
        Console.Writeline("a) Вычисление функции z = x - 2,5xy + 1,78x^2 - 2,5y + 1");

        Console.Write("Введите значение x: ");

        double x = Convert.ToDouble(Console.Readline());

        Console.Write("Введите значение y: ");

        double y = Convert.ToDouble(Console.Readline());

        double z = x - 2.5 * x * y + 1.78 * x * x - 2.5 * y + 1;

        Console.WriteLine($"При x = {x}, y = {y}");

        Console.WriteLine($"z = {z:F4}");

        Console.WriteLine();


    }
}