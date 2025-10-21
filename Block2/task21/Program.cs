using System;
public class NumberParts
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число n (n > 9):");
        int n = int.Parse(Console.ReadLine());

        int units = n % 10;
        Console.WriteLine($"а) Число единиц: {units}");

  
        int tens = (n / 10) % 10;
        Console.WriteLine($"б) Число десятков: {tens}");
    }
}