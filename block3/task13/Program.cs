using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ТАБЛИЦА ИСТИННОСТИ ЛОГИЧЕСКИХ ВЫРАЖЕНИЙ");
        Console.WriteLine("=======================================\n");
        

        Console.WriteLine("|  A  |  B  | не (A и B) | не A или B | A или не B |");
        Console.WriteLine("|-----|-----|------------|------------|------------|");
        

        bool[] boolValues = { false, true };
        
        foreach (bool A in boolValues)
        {
            foreach (bool B in boolValues)
            {

                bool expr1 = !(A && B);
                bool expr2 = !A || B;    
                bool expr3 = A || !B;    
                

                Console.WriteLine($"| {A,5} | {B,5} | {expr1,10} | {expr2,10} | {expr3,10} |");
            }
        }
        

        Console.WriteLine("\nЗАКОНЫ ДЕ МОРГАНА:");
        Console.WriteLine("==================");
        Console.WriteLine("не (А и В) ≡ не А или не В");
        Console.WriteLine("не (А или В) ≡ не А и не В");
    }
}