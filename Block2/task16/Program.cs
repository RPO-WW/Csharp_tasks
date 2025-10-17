using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите трехзначное число: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number) && input.Length == 3)
        {
            int hundreds = number / 100;
            int tens = (number / 10) % 10;
            int units = number % 10;
            int newNumberMath = tens * 100 + hundreds * 10 + units;
            Console.WriteLine($"Математический способ: {newNumberMath}");

            char[] digits = input.ToCharArray();
            char temp = digits[0];
            digits[0] = digits[1];
            digits[1] = temp;
            string newString = new string(digits);
            int newNumberString = int.Parse(newString);
            Console.WriteLine($"Способ со строками: {newNumberString}");
        }
        else
        {
            Console.WriteLine("Введено некорректное значение. Пожалуйста, введите трехзначное число.");
        }
    }
}
