using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());
        
        if (number < 100 || number > 999)
        {
            Console.WriteLine("Ошибка! Введено не трехзначное число.");
            return;
        }
        

        int[] digits = number.ToString()
                           .Select(c => int.Parse(c.ToString()))
                           .ToArray();
        
        int units = digits[2];
        int tens = digits[1];
        int hundreds = digits[0];
        
        int sum = digits.Sum();
        int product = digits.Aggregate(1, (acc, digit) => acc * digit);
        

        Console.WriteLine($"Исходное число: {number}");
        Console.WriteLine($"а) Число единиц: {units}");
        Console.WriteLine($"б) Число десятков: {tens}");
        Console.WriteLine($"в) Сумма цифр: {sum}");
        Console.WriteLine($"г) Произведение цифр: {product}");
    }
}