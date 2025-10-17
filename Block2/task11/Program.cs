using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите двузначное число: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number >= 10 && number <= 99)
        {
            int firstDigit = number / 10;
            int secondDigit = number % 10;

            int swapped = secondDigit * 10 + firstDigit;

            Console.WriteLine($"Число после перестановки: {swapped}");
        }
        else
        {
            Console.WriteLine("Ошибка");
        }
    }
}