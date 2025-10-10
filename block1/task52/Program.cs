using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите стоимость 1 кг конфет: ");
        double candyPrice = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите стоимость 1 кг печенья: ");
        double cookiePrice = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите стоимость 1 кг яблок: ");
        double applePrice = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите количество кг конфет: ");
        double x = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите количество кг печенья: ");
        double y = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите количество кг яблок: ");
        double z = double.Parse(Console.ReadLine());
        

        double totalCost = (candyPrice * x) + (cookiePrice * y) + (applePrice * z);
        
        Console.WriteLine("\n=== ЧЕК ПОКУПКИ ===");
        Console.WriteLine($"Конфеты: {x} кг × {candyPrice:F2} руб = {candyPrice * x:F2} руб");
        Console.WriteLine($"Печенье: {y} кг × {cookiePrice:F2} руб = {cookiePrice * y:F2} руб");
        Console.WriteLine($"Яблоки:  {z} кг × {applePrice:F2} руб = {applePrice * z:F2} руб");
        Console.WriteLine("-------------------");
        Console.WriteLine($"ОБЩАЯ СТОИМОСТЬ: {totalCost:F2} руб");
    }
}