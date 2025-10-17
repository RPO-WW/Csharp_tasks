using System;
using System.Collections.Generic;
using System.Linq;

public class PermutationOfDigits
{
    public static void Main(string[] args)
    {
        // Заданное трехзначное число с различными цифрами
        int number = 123;

        // Преобразуем число в строку, чтобы получить доступ к цифрам
        string digits = number.ToString();

        // Извлекаем цифры в переменные
        char firstDigit = digits[0];
        char secondDigit = digits[1];
        char thirdDigit = digits[2];

        // Создаем список для хранения шести чисел
        List<int> permutations = new List<int>();

        // 1. Первая цифра - первая, вторая - вторая, третья - третья
        permutations.Add(int.Parse(firstDigit.ToString() + secondDigit.ToString() + thirdDigit.ToString()));

        // 2. Первая цифра - первая, вторая - третья, третья - вторая
        permutations.Add(int.Parse(firstDigit.ToString() + thirdDigit.ToString() + secondDigit.ToString()));

        // 3. Первая цифра - вторая, вторая - первая, третья - третья
        permutations.Add(int.Parse(secondDigit.ToString() + firstDigit.ToString() + thirdDigit.ToString()));

        // 4. Первая цифра - вторая, вторая - третья, третья - первая
        permutations.Add(int.Parse(secondDigit.ToString() + thirdDigit.ToString() + firstDigit.ToString()));

        // 5. Первая цифра - третья, вторая - первая, третья - вторая
        permutations.Add(int.Parse(thirdDigit.ToString() + firstDigit.ToString() + secondDigit.ToString()));

        // 6. Первая цифра - третья, вторая - вторая, третья - первая
        permutations.Add(int.Parse(thirdDigit.ToString() + secondDigit.ToString() + firstDigit.ToString()));

        // Выводим полученные числа
        Console.WriteLine($"Числа, образованные перестановкой цифр {number}:");
        foreach (int perm in permutations)
        {
            Console.WriteLine(perm);
        }
    }
}
