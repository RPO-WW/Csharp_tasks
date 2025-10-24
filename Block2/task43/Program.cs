using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число a: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Введите число b: ");
        int b = int.Parse(Console.ReadLine());


        
        bool divisible1 = (b != 0) && (a % b == 0);
        bool divisible2 = (a != 0) && (b % a == 0);
        bool zeroCase = (a == 0 && b != 0) || (b == 0 && a != 0);
        int result = Convert.ToInt32(divisible1 || divisible2 || zeroCase);
        
        Console.WriteLine($"Результат: {result}");
    }
}