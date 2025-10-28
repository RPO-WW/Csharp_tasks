using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("РЕЗУЛЬТАТЫ ЛОГИЧЕСКИХ ВЫРАЖЕНИЙ:\n");

        // а)
        double x = 1, y = -1;
        bool a = Math.Pow(x, 2) - Math.Pow(y, 2) <= 0;
        Console.WriteLine($"а) x² - y² ≤ 0 при (1, -1): {a}");

        // б)
        x = 2; y = -2;
        bool b = (x >= 2) || (Math.Pow(y, 2) != 4);
        Console.WriteLine($"б) (x ≥ 2) или (y² ≠ 4) при (2, -2): {b}");

        // в)
        x = 2; y = 2;
        bool c = (x >= 0) && (Math.Pow(y, 2) > 4);
        Console.WriteLine($"в) (x ≥ 0) и (y² > 4) при (2, 2): {c}");

        // г)
        x = 1; y = 2;
        bool d = (x * y != 4) && (y > x);
        Console.WriteLine($"г) (x·y ≠ 4) и (y > x) при (1, 2): {d}");

        // д)
        x = 2; y = 1;
        bool e = (x * y != 0) || (y < x);
        Console.WriteLine($"д) (x·y ≠ 0) или (y < x) при (2, 1): {e}");

        // е)
        x = 1; y = 2;
        bool f = !(x * y < 1) && (y > x);
        Console.WriteLine($"е) не(x·y < 1) и (y > x) при (1, 2): {f}");

        // ж)
        x = 2; y = 1;
        bool g = !(x * y < 0) || (y > x);
        Console.WriteLine($"ж) не(x·y < 0) или (y > x) при (2, 1): {g}");
    }
}