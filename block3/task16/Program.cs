using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ТАБЛИЦА ИСТИННОСТИ ЛОГИЧЕСКИХ ВЫРАЖЕНИЙ");
        Console.WriteLine("=======================================\n");
        

        Console.WriteLine("|  X  |  Y  | не X и не Y | X или (не X и Y) | (не X и Y) или Y |");
        Console.WriteLine("|-----|-----|-------------|------------------|------------------|");
        
        
        bool[] boolValues = { false, true };
        
        foreach (bool X in boolValues)
        {
            foreach (bool Y in boolValues)
            {

                bool expr1 = !X && !Y;
                bool expr2 = X || (!X && Y); 
                bool expr3 = (!X && Y) || Y;
                

                Console.WriteLine($"| {X,5} | {Y,5} | {expr1,11} | {expr2,16} | {expr3,16} |");
            }
        }
        

        Console.WriteLine("\nУПРОЩЕННЫЕ ФОРМЫ:");
        Console.WriteLine("а) не X и не Y ≡ не (X или Y)");
        Console.WriteLine("б) X или (не X и Y) ≡ X или Y");
        Console.WriteLine("в) (не X и Y) или Y ≡ Y");
    }
}