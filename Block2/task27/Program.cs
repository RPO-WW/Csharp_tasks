Console.Write("Введите число n (100 <= n <= 999, десятки не равны 0): ");
int n = Convert.ToInt32(Console.ReadLine());


for (int a = 1; a <= 9; a++)
{
    int remainder = n - a;
    if (remainder % 10 == 0)
    {
        int b = remainder / 10;
        if (b >= 0 && b <= 99)
        {
            int x = 100 * a + b;
            Console.WriteLine($"Найдено число x: {x}");
            Console.WriteLine($"Проверка: зачеркнули первую цифру → {b}, умножили на 10 → {b * 10}, прибавили {a} → {b * 10 + a}");
            return;
        }
    }
}

Console.WriteLine("Решение не найдено.");