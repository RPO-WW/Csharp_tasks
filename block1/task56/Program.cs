using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите скорость первого автомобиля V1 (км/ч):");
        double V1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите скорость второго автомобиля V2 (км/ч):");
        double V2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите начальное опережение S (км):");
        double S = double.Parse(Console.ReadLine());
        

        if (V1 <= V2)
        {
            Console.WriteLine("Ошибка: V1 должно быть больше V2");
            return;
        }
        

        double relativeSpeed = V1 - V2;
        

        double additionalDistance = relativeSpeed * 0.5;
        

        double finalDistance = S + additionalDistance;
        
        Console.WriteLine($"\nРезультаты расчета:");
        Console.WriteLine($"Относительная скорость: {relativeSpeed} км/ч");
        Console.WriteLine($"Дополнительное расстояние за 30 мин: {additionalDistance} км");
        Console.WriteLine($"Итоговое расстояние через 30 минут: {finalDistance} км");
    }
}