using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите угол поворота часовой стрелки (0 ≤ y < 360): ");
        double y = double.Parse(Console.ReadLine());

        // Проверка корректности ввода
        if (y < 0 || y >= 360)
        {
            Console.WriteLine("Ошибка: угол должен быть в диапазоне [0, 360)!");
            return;
        }

        // Вычисление времени
        // Часовая стрелка делает полный оборот за 12 часов = 360°
        // Значит, 1 час = 30°, 1 минута = 0.5°

        // Вычисляем общее количество часов (в 12-часовом формате)
        double totalHours = y / 30.0;

        // Вычисляем целое количество часов
        int hours = (int)totalHours;

        // Вычисляем оставшиеся минуты
        double remainingDegrees = y - hours * 30.0;
        int minutes = (int)(remainingDegrees / 0.5);

        Console.WriteLine($"Угол поворота: {y}°");
        Console.WriteLine($"Прошло полных часов: {hours}");
        Console.WriteLine($"Прошло полных минут: {minutes}");
        Console.WriteLine($"Время: {hours} часов {minutes} минут");
    }
}

