using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите расстояние между автомобилями (S в км): ");
        double S = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите скорость первого автомобиля (V1 в км/ч): ");
        double V1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите скорость второго автомобиля (V2 в км/ч): ");
        double V2 = Convert.ToDouble(Console.ReadLine());

        double time = S / (V1 + V2);

        Console.WriteLine($"Автомобили встретятся через {time} часов");
    }
}