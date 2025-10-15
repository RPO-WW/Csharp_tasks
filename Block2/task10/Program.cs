using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите двузначное число: ");
        int number = int.Parse(Console.ReadLine());
        
        if (number < 10 || number > 99)
        {
            Console.WriteLine("Ошибка! Введите двузначное число (10-99).");
            return;
        }
        
        int tens = number / 10;
        
        int units = number % 10;
        
        int sum = tens + units;
        
        int product = tens * units;
        
        Console.WriteLine($"Исходное число: {number}");
        Console.WriteLine($"а) Число десятков: {tens}");
        Console.WriteLine($"б) Число единиц: {units}");
        Console.WriteLine($"в) Сумма цифр: {sum}");
        Console.WriteLine($"г) Произведение цифр: {product}");
    }
}