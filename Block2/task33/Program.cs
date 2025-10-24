using System;
class Program
{
    static void Main()
    {
        Console.Write("введиете число u 1 <= u <= 999,последняя цифра не равна 0:");
        int u = int.Parse(Console.ReadLine());
        if (u < 1 || u > 999 || u % 10 == 0)
        {
            Console.WriteLine("Ошибка число должно удоволетворять условиям и не равно 0");
            return;
        }
        int x = FindX(u);
        Console.WriteLine($"Число x = {x}");
        static int FindX(int u)
        {
            int hundreds = u / 100;
            int tens = (u / 10) % 10;
            int units = u % 10;
            int x = 10 * (10 * units + tens) + hundreds;
            return x;
        }
    }
}