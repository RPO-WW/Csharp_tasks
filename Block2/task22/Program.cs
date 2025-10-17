using System;

public class NumberParts
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число n (n > 99):");
        int n = int.Parse(Console.ReadLine());

        if (n > 99)
    {
        int units = n / 10;
        Console.WriteLine($"а) Число десятков: {units}");


        int tens = n / 100;
        Console.WriteLine($"б) Число сотен: {tens}");
    }
    else
    {
        Console.WriteLine("Число должно быть больше 99");
    }
    }
}
