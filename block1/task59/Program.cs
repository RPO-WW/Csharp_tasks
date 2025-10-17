using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = 20;
        
        Console.WriteLine($"До обмена: a = {a}, b = {b}");
        
        // Обмен значений
        int temp = a;
        a = b;
        b = temp;
        
        Console.WriteLine($"После обмена: a = {a}, b = {b}");
    }
}