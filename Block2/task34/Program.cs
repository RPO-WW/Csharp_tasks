using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите n (1 ≤ n ≤ 999, последняя цифра ≠ 0): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1 || n > 999)
        {
            Console.WriteLine("Ошибка: n должно быть целым числом от 1 до 999.");
            return;
        }

        int lastDigit = n % 10;
        if (lastDigit == 0)
        {
            Console.WriteLine("Ошибка: последняя цифра числа n не должна быть 0.");
            return;
        }

        // Извлекаем цифры из n = 100*c + 10*b + a
        int c = n / 100;           // сотни → это последняя цифра x
        int b = (n / 10) % 10;     // десятки → это средняя цифра x
        int a = n % 10;            // единицы → это первая цифра x

        // Собираем исходное число x = 100*a + 10*b + c
        int x = 100 * a + 10 * b + c;

        // Дополнительная проверка: x должно быть трёхзначным (100–999)
        if (x < 100 || x > 999)
        {
            Console.WriteLine("Ошибка: невозможно восстановить корректное трёхзначное число x.");
            return;
        }

        Console.WriteLine($"Исходное число x: {x}");
    }
}
