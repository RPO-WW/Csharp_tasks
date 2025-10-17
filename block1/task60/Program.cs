using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите значение b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите значение c: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nИсходные значения: a = {a}, b = {b}, c = {c}");

        int originalA = a, originalB = b, originalC = c;

        Console.WriteLine("\n--- Схема а) ---");
        int temp = a;
        a = b;
        b = c;
        c = temp;

        Console.WriteLine($"После обмена по схеме а): a = {a}, b = {b}, c = {c}");

        a = originalA;
        b = originalB;
        c = originalC;

        Console.WriteLine("\n--- Схема б) ---");

        int newB = a;
        int newC = b;
        int newA = c;

        a = newA;
        b = newB;
        c = newC;

        Console.WriteLine($"После обмена по схеме б): a = {a}, b = {b}, c = {c}");

        Console.ReadKey();
    }
}