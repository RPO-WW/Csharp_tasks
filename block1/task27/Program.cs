using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());
        
        if (number < 100 || number > 999)
        {
            Console.WriteLine("Ошибка! Число должно быть трехзначным.");
            return;
        }
        

        int firstDigit = number / 100;
        int lastDigit = number % 10;
        

        if (firstDigit == lastDigit)
        {
            Console.WriteLine($"Число {number} является палиндромом.");
        }
        else
        {
            Console.WriteLine($"Число {number} НЕ является палиндромом.");
        }
    }
}