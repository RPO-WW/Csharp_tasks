using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ТАБЛИЦА ИСТИННОСТИ ЛОГИЧЕСКИХ ВЫРАЖЕНИЙ");
        Console.WriteLine("=======================================\n");
        Console.WriteLine("|  A  |  B  | не А и не В или А | В или не А и не В | В и не (А и не В) |");
        Console.WriteLine("|-----|-----|-------------------|-------------------|-------------------|");
        

        bool[] boolValues = { false, true };
        
        foreach (bool A in boolValues)
        {
            foreach (bool B in boolValues)
            {

                bool expr1 = (!A && !B) || A;    
                bool expr2 = B || (!A && !B);     
                bool expr3 = B && !(A && !B);     
                

                Console.WriteLine($"| {A,5} | {B,5} | {expr1,17} | {expr2,17} | {expr3,17} |");
            }
        }
        

        Console.WriteLine("\nУПРОЩЕННЫЕ ФОРМЫ:");
        Console.WriteLine("а) не А и не В или А ≡ А или не В");
        Console.WriteLine("б) В или не А и не В ≡ не А или В");
        Console.WriteLine("в) В и не (А и не В) ≡ В");
    }
}