using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Пошаговое вычисление логических выражений\n");
        
        bool[] values = { false, true };
        
        foreach (bool a in values)
        {
            foreach (bool b in values)
            {
                Console.WriteLine($"\n=== A = {a}, B = {b} ===");
                
             
                Console.WriteLine("\nа) не(неА и неВ) и А:");
                bool notA = !a;
                bool notB = !b;
                bool notA_and_notB = notA && notB;
                bool not_notA_and_notB = !notA_and_notB;
                bool result_a = not_notA_and_notB && a;
                
                Console.WriteLine($"   неА = {notA}");
                Console.WriteLine($"   неВ = {notB}");
                Console.WriteLine($"   неА и неВ = {notA_and_notB}");
                Console.WriteLine($"   не(неА и неВ) = {not_notA_and_notB}");
                Console.WriteLine($"   не(неА и неВ) и А = {result_a}");
                
                
                Console.WriteLine("\nб) не(неА или неВ) или А:");
                bool notA_or_notB = notA || notB;
                bool not_notA_or_notB = !notA_or_notB;
                bool result_b = not_notA_or_notB || a;
                
                Console.WriteLine($"   неА или неВ = {notA_or_notB}");
                Console.WriteLine($"   не(неА или неВ) = {not_notA_or_notB}");
                Console.WriteLine($"   не(неА или неВ) или А = {result_b}");
                
              
                Console.WriteLine("\nв) не(неА или неВ) и В:");
                bool result_c = not_notA_or_notB && b;
                
                Console.WriteLine($"   не(неА или неВ) и В = {result_c}");
            }
        }
        
     
        PrintTruthTable();
    }
    
    static void PrintTruthTable()
    {
        Console.WriteLine("\n\n" + new string('=', 60));
        Console.WriteLine("ИТОГОВАЯ ТАБЛИЦА ИСТИННОСТИ");
        Console.WriteLine(new string('=', 60));
        
        Console.WriteLine("A\tB\tне(неА и неВ) и А\tне(неА или неВ) или А\tне(неА или неВ) и В");
        Console.WriteLine(new string('-', 80));
        
        bool[] values = { false, true };
        
        foreach (bool a in values)
        {
            foreach (bool b in values)
            {
                bool result1 = !(!a && !b) && a;
                bool result2 = !(!a || !b) || a;
                bool result3 = !(!a || !b) && b;
                
                Console.WriteLine($"{a}\t{b}\t{result1}\t\t\t{result2}\t\t\t{result3}");
            }
        }
    }
}