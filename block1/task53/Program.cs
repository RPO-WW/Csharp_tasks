int monik = 15000;
int sistem = 60000;
int klava = 7000;
int mish = 5000;

int total = monik + sistem + klava + mish;

Console.WriteLine("Введите число:"); // 1. Запрашиваем ввод у пользователя
string? input = Console.ReadLine(); // 2. Считываем введенную строку

// 3. Пытаемся преобразовать строку в целое число
if (int.TryParse(input, out int number))
{
    Console.WriteLine($"Вот столько стоит {number} компьютера(ов): {total * number}"); // 4. Если успешно, выводим число
}
else
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число."); // 5. Если ошибка, сообщаем пользователю
}