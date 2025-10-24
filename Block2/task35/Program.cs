using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a2 (десятки первого числа): ");
        int a2 = int.Parse(Console.ReadLine());
        Console.Write("Введите a1 (единицы первого числа): ");
        int a1 = int.Parse(Console.ReadLine());

        Console.Write("Введите b2 (десятки второго числа): ");
        int b2 = int.Parse(Console.ReadLine());
        Console.Write("Введите b1 (единицы второго числа): ");
        int b1 = int.Parse(Console.ReadLine());

        int s1 = (a1 + b1) % 10;
        int s2 = a2 + b2 + (a1 + b1) / 10;

        Console.WriteLine($"Цифры суммы: десятки = {s2}, единицы = {s1}");
    }
}