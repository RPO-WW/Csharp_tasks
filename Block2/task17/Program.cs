using System;

class Program
{
    static void Main()
    {
        double V1, V2, S;
        
        // Ввод данных
        Console.Write("Введите скорость первого автомобиля (км/ч): ");
        V1 = double.Parse(Console.ReadLine());
        
        Console.Write("Введите скорость второго автомобиля (км/ч): ");
        V2 = double.Parse(Console.ReadLine());
        
        Console.Write("Введите расстояние между автомобилями (км): ");
        S = double.Parse(Console.ReadLine());
        

        if (V1 <= 0 || V2 <= 0 || S <= 0)
        {
            Console.WriteLine("Ошибка: скорости и расстояние должны быть положительными числами!");
            return;
        }
        
       
        double relativeSpeed = V1 + V2; 
        double time = S / relativeSpeed; 
        
        
        Console.WriteLine($"Автомобили встретятся через {time:F2} часов");
        Console.WriteLine($"Или через {time * 60:F0} минут");
    }
}