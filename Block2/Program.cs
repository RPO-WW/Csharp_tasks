using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Нахождение числа единиц и десятков в натуральном числе");

        Console.Write("Введите натуральное число (n > 9): ");

        int n = Convert.Toint32(Console.ReadLine());

        if (n <= 9)
        {
            Console.Writeline("Ошибка! Число должно быть больше 9.");
            return;
        }

        int units = n % 10;



        int tens = (n / 10) % 10;

        Console.Writeline($"\nЧисло: {n}");

        Console.Writeline($"a) Число единиц: {units}");

        Console.WriteLine($"б) Число десятков: {tens}");
    }
}
