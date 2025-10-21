using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите день года k (1-365): ");
        int k = int.Parse(Console.ReadLine());
        if (k < 1 || k > 365)
        {
            Console.WriteLine("Ошибка: k должно быть в диапазоне 1-365");
            return;
        }
        
        Console.WriteLine("\nа) Если 1 января - понедельник:");
        int n1 = CalculateDayOfWeek(k, 1);
        Console.WriteLine($"n = {n1} ({GetDayName(n1)})");
        
        Console.WriteLine("\nб) Если 1 января - вторник:");
        int n2 = CalculateDayOfWeek(k, 2);
        Console.WriteLine($"n = {n2} ({GetDayName(n2)})");
        
        Console.Write("\nв) Введите номер дня недели 1 января (1-7): ");
        int d = int.Parse(Console.ReadLine());
        
        if (d < 1 || d > 7)
        {
            Console.WriteLine("Ошибка: d должно быть в диапазоне 1-7");
            return;
        }
        
        int n3 = CalculateDayOfWeek(k, d);
        Console.WriteLine($"n = {n3} ({GetDayName(n3)})");
    }
    
    static int CalculateDayOfWeek(int k, int firstDay)
    {
        int offset = (k - 1) % 7;
        int dayOfWeek = (firstDay - 1 + offset) % 7;
        return dayOfWeek;
    }
    
    static string GetDayName(int dayCode)
    {
        return dayCode switch
        {
            1 => "понедельник",
            2 => "вторник", 
            3 => "среда",
            4 => "четверг",
            5 => "пятница",
            6 => "суббота",
            0 => "воскресенье",
            _ => "неизвестный день"
        };
    }
}