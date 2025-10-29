using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Таблица истинности для логических выражений\n");
        
        Console.WriteLine("A\tB\tC\tне(A или неB и C)\tA и не(B или неC)\tне(неA или B и C)");
        Console.WriteLine(new string('-', 100));
        
        bool[] values = { false, true };
        
        foreach (bool a in values)
        {
            foreach (bool b in values)
            {
                foreach (bool c in values)
                {
                    bool result1 = !(a || !b && c);
                    bool result2 = a && !(b || !c);
                    bool result3 = !(!a || b && c);
                    
                    Console.WriteLine($"{a}\t{b}\t{c}\t{result1}\t\t\t{result2}\t\t\t{result3}");
                }
            }
        }
        
        Console.WriteLine("\n\nАнализ и упрощение выражений:");
        AnalyzeExpressions();
        
        Console.WriteLine("\n\nПошаговое вычисление для нескольких комбинаций:");
        StepByStepCalculation();
    }
    
    static void AnalyzeExpressions()
    {
        Console.WriteLine("\nа) не(A или неB и C)");
        Console.WriteLine("   Упрощение по законам де Моргана:");
        Console.WriteLine("   не(A или неB и C) = неA и не(неB и C)");
        Console.WriteLine("   = неA и (не(неB) или неC)");
        Console.WriteLine("   = неA и (B или неC)");
        Console.WriteLine("   Итог: выражение равно неA и (B или неC)");
        
        Console.WriteLine("\nб) A и не(B или неC)");
        Console.WriteLine("   Упрощение по законам де Моргана:");
        Console.WriteLine("   не(B или неC) = неB и не(неC)");
        Console.WriteLine("   = неB и C");
        Console.WriteLine("   A и (неB и C) = A и неB и C");
        Console.WriteLine("   Итог: выражение равно A и неB и C");
        
        Console.WriteLine("\nв) не(неA или B и C)");
        Console.WriteLine("   Упрощение по законам де Моргана:");
        Console.WriteLine("   не(неA или B и C) = не(неA) и не(B и C)");
        Console.WriteLine("   = A и (неB или неC)");
        Console.WriteLine("   Итог: выражение равно A и (неB или неC)");
    }
    
    static void StepByStepCalculation()
    {
        bool[] values = { false, true };
        int count = 0;
        
        foreach (bool a in values)
        {
            foreach (bool b in values)
            {
                foreach (bool c in values)
                {
                    if (count >= 4) return;
                    
                    Console.WriteLine($"\n=== A = {a}, B = {b}, C = {c} ===");
                    
                    Console.WriteLine("а) не(A или неB и C):");
                    bool notB_a = !b;
                    bool notB_and_C = notB_a && c;
                    bool A_or_notB_and_C = a || notB_and_C;
                    bool result_a = !A_or_notB_and_C;
                    
                    Console.WriteLine($"   неB = {notB_a}");
                    Console.WriteLine($"   неB и C = {notB_and_C}");
                    Console.WriteLine($"   A или (неB и C) = {A_or_notB_and_C}");
                    Console.WriteLine($"   не(A или неB и C) = {result_a}");
                    
                    Console.WriteLine("б) A и не(B или неC):");
                    bool notC_b = !c;
                    bool B_or_notC = b || notC_b;
                    bool not_B_or_notC = !B_or_notC;
                    bool result_b = a && not_B_or_notC;
                    
                    Console.WriteLine($"   неC = {notC_b}");
                    Console.WriteLine($"   B или неC = {B_or_notC}");
                    Console.WriteLine($"   не(B или неC) = {not_B_or_notC}");
                    Console.WriteLine($"   A и не(B или неC) = {result_b}");
                    
                    Console.WriteLine("в) не(неA или B и C):");
                    bool notA_c = !a;
                    bool B_and_C = b && c;
                    bool notA_or_B_and_C = notA_c || B_and_C;
                    bool result_c = !notA_or_B_and_C;
                    
                    Console.WriteLine($"   неA = {notA_c}");
                    Console.WriteLine($"   B и C = {B_and_C}");
                    Console.WriteLine($"   неA или (B и C) = {notA_or_B_and_C}");
                    Console.WriteLine($"   не(неA или B и C) = {result_c}");
                    
                    count++;
                }
            }
        }
    }
}