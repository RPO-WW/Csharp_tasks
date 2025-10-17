using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество секунд, прошедших с начала суток: ");
        int n = int.Parse(Console.ReadLine());
        

        int hours = n / 3600;
        

        int minutes = (n % 3600) / 60;
        

        int seconds = n % 60; 
        
        Console.WriteLine($"а) Полных часов: {hours}");
        Console.WriteLine($"б) Полных минут с начала часа: {minutes}");
        Console.WriteLine($"в) Полных секунд с начала минуты: {seconds}");
        

        Console.WriteLine($"Время: {hours:00}:{minutes:00}:{seconds:00}");
    }
}