using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите n (100 ≤ n ≤ 999): ");
        int n = int.Parse(Console.ReadLine());
        if (n < 100 || n > 999)
        {
            Console.WriteLine("Ошибка: n должно быть трёхзначным числом.");
            return;
        }

        int a = n / 100;
        int c = (n / 10) % 10;
        int b = n % 10;

        int x = 100 * a + 10 * b + c;

        Console.WriteLine($"Исходное число x: {x}");
    }
}