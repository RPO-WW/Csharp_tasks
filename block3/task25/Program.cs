using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Таблица истинности для логических выражений\n");
        

        Console.WriteLine("A\tB\tC\tне(A и B) и (неA или неC)\tне(A и неB) или (A или неC)\tA и неB или не(A или неC)");
        Console.WriteLine(new string('-', 120));
        

        bool[] values = { false, true };
        
        foreach (bool a in values)
        {
            foreach (bool b in values)
            {
                foreach (bool c in values)
                {

                    bool result1 = !(a && b) && (!a || !c);  
                    bool result2 = !(a && !b) || (a || !c);     
                    bool result3 = a && !b || !(a || !c);      
                    

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
        Console.WriteLine("\nа) не(A и B) и (неA или неC)");
        Console.WriteLine("   Упрощение по законам де Моргана:");
        Console.WriteLine("   не(A и B) = неA или неB");
        Console.WriteLine("   (неA или неB) и (неA или неC)");
        Console.WriteLine("   = неA или (неB и неC) (дистрибутивный закон)");
        Console.WriteLine("   Итог: выражение равно неA или (неB и неC)");
        
        Console.WriteLine("\nб) не(A и неB) или (A или неC)");
        Console.WriteLine("   Упрощение по законам де Моргана:");
        Console.WriteLine("   не(A и неB) = неA или не(неB) = неA или B");
        Console.WriteLine("   (неA или B) или (A или неC)");
        Console.WriteLine("   = неA или B или A или неC");
        Console.WriteLine("   = (неA или A) или B или неC");
        Console.WriteLine("   = True или B или неC");
        Console.WriteLine("   = True");
        Console.WriteLine("   Итог: выражение равно True");
        
        Console.WriteLine("\nв) A и неB или не(A или неC)");
        Console.WriteLine("   Упрощение по законам де Моргана:");
        Console.WriteLine("   не(A или неC) = неA и не(неC) = неA и C");
        Console.WriteLine("   A и неB или (неA и C)");
        Console.WriteLine("   Итог: выражение равно A и неB или (неA и C)");
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
                    

                    Console.WriteLine("а) не(A и B) и (неA или неC):");
                    bool A_and_B = a && b;
                    bool not_A_and_B = !A_and_B;
                    bool notA = !a;
                    bool notC = !c;
                    bool notA_or_notC = notA || notC;
                    bool result_a = not_A_and_B && notA_or_notC;
                    
                    Console.WriteLine($"   A и B = {A_and_B}");
                    Console.WriteLine($"   не(A и B) = {not_A_and_B}");
                    Console.WriteLine($"   неA = {notA}, неC = {notC}");
                    Console.WriteLine($"   неA или неC = {notA_or_notC}");
                    Console.WriteLine($"   не(A и B) и (неA или неC) = {result_a}");

                    Console.WriteLine("б) не(A и неB) или (A или неC):");
                    bool notB = !b;
                    bool A_and_notB = a && notB;
                    bool not_A_and_notB = !A_and_notB;
                    bool A_or_notC = a || notC;
                    bool result_b = not_A_and_notB || A_or_notC;
                    
                    Console.WriteLine($"   неB = {notB}");
                    Console.WriteLine($"   A и неB = {A_and_notB}");
                    Console.WriteLine($"   не(A и неB) = {not_A_and_notB}");
                    Console.WriteLine($"   A или неC = {A_or_notC}");
                    Console.WriteLine($"   не(A и неB) или (A или неC) = {result_b}");
                    
                    Console.WriteLine("в) A и неB или не(A или неC):");
                    bool A_or_notC_c = a || notC;
                    bool not_A_or_notC = !A_or_notC_c;
                    bool A_and_notB_c = a && notB;
                    bool result_c = A_and_notB_c || not_A_or_notC;
                    
                    Console.WriteLine($"   A или неC = {A_or_notC_c}");
                    Console.WriteLine($"   не(A или неC) = {not_A_or_notC}");
                    Console.WriteLine($"   A и неB = {A_and_notB_c}");
                    Console.WriteLine($"   A и неB или не(A или неC) = {result_c}");
                    
                    count++;
                }
            }
        }
    }
}