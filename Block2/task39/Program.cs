using System;

class Program
{
    static void Main()
    {
        // Ввод данных
        Console.Write("Введите часы (0 < h ≤ 23): ");
        int h = int.Parse(Console.ReadLine());
        
        Console.Write("Введите минуты (0 ≤ m ≤ 59): ");
        int m = int.Parse(Console.ReadLine());
        
        Console.Write("Введите секунды (0 ≤ s ≤ 59): ");
        int s = int.Parse(Console.ReadLine());
        

        if (h <= 0 || h > 23 || m < 0 || m > 59 || s < 0 || s > 59)
        {
            Console.WriteLine("Ошибка: некорректный ввод времени!");
            return;
        }
        

        int hours12 = h % 12;
        
     
        double angle = hours12 * 30 +     
                      m * 0.5 +         
                      s * (0.5 / 60);   
        
        
        angle %= 360;
        
        // Вывод результата
        Console.WriteLine($"Время: {h:00}:{m:00}:{s:00}");
        Console.WriteLine($"Угол часовой стрелки: {angle:F2}°");
        
        // Дополнительная информация
        Console.WriteLine($"\nДетали расчета:");
        Console.WriteLine($"Часы в 12-часовом формате: {hours12}");
        Console.WriteLine($"Градусы за часы: {hours12 * 30}°");
        Console.WriteLine($"Градусы за минуты: {m * 0.5:F2}°");
        Console.WriteLine($"Градусы за секунды: {s * (0.5 / 60):F4}°");
    }
}