Console.Write("Введите число n (10 <= n <= 999, десятки ≠ 0): ");
int n = Convert.ToInt32(Console.ReadLine());

if(n < 10 || n > 999) {
    Console.WriteLine("Ошибка: n должно быть от 10 до 999.");
    return;
}

int n1 = n / 100;
int n2 = (n / 10) % 10;
int n3 = n % 10;

if(n2 == 0) {
    Console.WriteLine("Ошибка: цифра десятков в n не должна быть нулём.");
    return;
}

int x = 100 * n2 + 10 * n1 + n3;

Console.WriteLine($"Исходное число x: {x}");