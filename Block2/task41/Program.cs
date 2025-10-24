using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите угол часовой стрелки в радианах (0 < y ≤ 2π): ");
        double y = double.Parse(Console.ReadLine());
        
        if (y <= 0 || y > 2 * Math.PI)
        {
            Console.WriteLine("Ошибка: угол должен быть в диапазоне (0, 2π]!");
            return;
        }
        
        double totalHours = y / (Math.PI / 6);
        
        int hours = (int)totalHours;
        
        double fractionalHours = totalHours - hours;
        int minutes = (int)(fractionalHours * 60);
        
        double minuteAngle = (minutes * 2 * Math.PI) / 60;
        
        minuteAngle %= 2 * Math.PI;
        
        Console.WriteLine($"Угол часовой стрелки: {y:F4} рад");
        Console.WriteLine($"Угол минутной стрелки: {minuteAngle:F4} рад");
        Console.WriteLine($"Прошло полных часов: {hours}");
        Console.WriteLine($"Прошло полных минут: {minutes}");
        Console.WriteLine($"Время: {hours} часов {minutes} минут");
    }
}