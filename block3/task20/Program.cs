using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Таблица истинности для логических выражений\n");
        

        Console.WriteLine("X\tY\tне(неX или Y) или неX\tне(неX и неY) и X\tне(X или неY) или неY");
        Console.WriteLine(new string('-', 90));
        
       
        bool[] values = { false, true };
        
        foreach (bool x in values)
        {
            foreach (bool y in values)
            {
                
                bool result1 = !(!x || y) || !x;    
                bool result2 = !(!x && !y) && x;   
                bool result3 = !(x || !y) || !y;   
                
               
                Console.WriteLine($"{x}\t{y}\t{result1}\t\t\t{result2}\t\t\t{result3}");
            }
        }
        
       
        Console.WriteLine("\n\nАнализ и упрощение выражений:");
        AnalyzeExpressions();
        
       
        Console.WriteLine("\n\nПошаговое вычисление:");
        StepByStepCalculation();
    }
    
    static void AnalyzeExpressions()
    {
        Console.WriteLine("\nа) не(неX или Y) или неX");
        Console.WriteLine("   Упрощение по законам де Моргана:");
        Console.WriteLine("   не(неX или Y) = не(неX) и неY = X и неY");
        Console.WriteLine("   (X и неY) или неX = неX или (X и неY)");
        Console.WriteLine("   По distributive law: (неX или X) и (неX или неY) = True и (неX или неY)");
        Console.WriteLine("   Итог: выражение равно неX или неY");
        
        Console.WriteLine("\nб) не(неX и неY) и X");
        Console.WriteLine("   Упрощение по законам де Моргана:");
        Console.WriteLine("   не(неX и неY) = не(неX) или не(неY) = X или Y");
        Console.WriteLine("   (X или Y) и X = X (по закону поглощения)");
        Console.WriteLine("   Итог: выражение равно X");
        
        Console.WriteLine("\nв) не(X или неY) или неY");
        Console.WriteLine("   Упрощение по законам де Моргана:");
        Console.WriteLine("   не(X или неY) = неX и не(неY) = неX и Y");
        Console.WriteLine("   (неX и Y) или неY = неY или (неX и Y)");
        Console.WriteLine("   По distributive law: (неY или неX) и (неY или Y) = (неX или неY) и True");
        Console.WriteLine("   Итог: выражение равно неX или неY");
    }
    
    static void StepByStepCalculation()
    {
        Console.WriteLine("\nПодробное пошаговое вычисление для всех комбинаций:");
        
        bool[] values = { false, true };
        
        foreach (bool x in values)
        {
            foreach (bool y in values)
            {
                Console.WriteLine($"\n=== X = {x}, Y = {y} ===");
                
                
                Console.WriteLine("а) не(неX или Y) или неX:");
                bool notX_a = !x;
                bool step1_a = notX_a || y;
                bool step2_a = !step1_a;
                bool result_a = step2_a || notX_a;
                Console.WriteLine($"   неX = {notX_a}");
                Console.WriteLine($"   неX или Y = {step1_a}");
                Console.WriteLine($"   не(неX или Y) = {step2_a}");
                Console.WriteLine($"   не(неX или Y) или неX = {result_a}");
                
                
                Console.WriteLine("б) не(неX и неY) и X:");
                bool notX_b = !x;
                bool notY_b = !y;
                bool step1_b = notX_b && notY_b;
                bool step2_b = !step1_b;
                bool result_b = step2_b && x;
                Console.WriteLine($"   неX = {notX_b}, неY = {notY_b}");
                Console.WriteLine($"   неX и неY = {step1_b}");
                Console.WriteLine($"   не(неX и неY) = {step2_b}");
                Console.WriteLine($"   не(неX и неY) и X = {result_b}");
                
               
                Console.WriteLine("в) не(X или неY) или неY:");
                bool notY_c = !y;
                bool step1_c = x || notY_c;
                bool step2_c = !step1_c;
                bool result_c = step2_c || notY_c;
                Console.WriteLine($"   неY = {notY_c}");
                Console.WriteLine($"   X или неY = {step1_c}");
                Console.WriteLine($"   не(X или неY) = {step2_c}");
                Console.WriteLine($"   не(X или неY) или неY = {result_c}");
            }
        }
    }
}