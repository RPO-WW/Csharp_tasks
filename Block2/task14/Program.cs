using System;

int x = 24;
int y = 224;
int n = 443;
int a = 35;
int b = 3633;



static long FactorialWithRecursion(int n)
{
    if (n < 0)
    {
        throw new ArgumentException("Факториал не определен для отрицательных чисел.");
    }

    if (n == 0 || n == 1)
    {
        return 1; // Базовый случай
    }
    else
    {
        return n * FactorialWithRecursion(n - 1); // Рекурсивный вызов
    }
}

Console.WriteLine($"2 * x: {2 * x}");
Console.WriteLine($"Math.Sin(x): {Math.Sin(x)}");
Console.WriteLine($"Math.Pow(2, a): {Math.Pow(2, a)}");
Console.WriteLine($"Math.Sqrt(x): {Math.Sqrt(x)}");
Console.WriteLine($"|n| : {n}");
Console.WriteLine($"5 * Math.Cos(y): {5 * Math.Cos(y)}");
Console.WriteLine($"Math.Pow(2, 7.5 * a): {Math.Pow(2, 7.5 * a)}");
Console.WriteLine($"Math.Pow(x, 1.0 / 3.0) {Math.Pow(x, 1.0 / 3.0)}");
Console.WriteLine($"Math.Sin(Math.Cos(Math.Cos(Math.Sin(x)))): {Math.Sin(Math.Cos(Math.Cos(Math.Sin(x))))}");
Console.WriteLine($"Math.Pow(a, 2 * b): {Math.Pow(a, 2 * b)}");
Console.WriteLine($"3 * Math.Pow(Math.Sin(x), 2) * Math.Pow(Math.Cos(y), 3): {3 * Math.Pow(Math.Sin(x), 2) * Math.Pow(Math.Cos(y), 3)}");
Console.WriteLine($"5 * Math.Sqrt(x * y): {5 * Math.Sqrt(x * y)}");