using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Таблица истинности для логических выражений\n");
        
        Console.WriteLine("X\tY\tZ\tне(X или неY и Z)\tY или (X и неY или Z)\tне(неX и Y или Z)");
        Console.WriteLine(new string('-', 100));
        
        bool[] values = { false, true };
        
        foreach (bool x in values)
        {
            foreach (bool y in values)
            {
                foreach (bool z in values)
                {
                    bool result1 = !(x || !y && z);
                    bool result2 = y || (x && !y || z);
                    bool result3 = !(!x && y || z);

                    Console.WriteLine($"{x}\t{y}\t{z}\t{result1}\t\t\t{result2}\t\t\t{result3}");
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
        Console.WriteLine("\nа) не(X или неY и Z)");
        Console.WriteLine("   Упрощение по законам де Моргана:");
        Console.WriteLine("   не(X или неY и Z) = неX и не(неY и Z)");
        Console.WriteLine("   = неX и (не(неY) или неZ)");
        Console.WriteLine("   = неX и (Y или неZ)");
        Console.WriteLine("   Итог: выражение равно неX и (Y или неZ)");
        
        Console.WriteLine("\nб) Y или (X и неY или Z)");
        Console.WriteLine("   Упрощение:");
        Console.WriteLine("   Y или (X и неY) или Z");
        Console.WriteLine("   = (Y или Z) или (X и неY)");
        Console.WriteLine("   = Y или Z или (X и неY)");
        Console.WriteLine("   Итог: выражение равно Y или Z или (X и неY)");
        
        Console.WriteLine("\nв) не(неX и Y или Z)");
        Console.WriteLine("   Упрощение по законам де Моргана:");
        Console.WriteLine("   не(неX и Y или Z) = не(неX и Y) и неZ");
        Console.WriteLine("   = (не(неX) или неY) и неZ");
        Console.WriteLine("   = (X или неY) и неZ");
        Console.WriteLine("   Итог: выражение равно (X или неY) и неZ");
    }
    
    static void StepByStepCalculation()
    {
        bool[] values = { false, true };
        int count = 0;
        
        foreach (bool x in values)
        {
            foreach (bool y in values)
            {
                foreach (bool z in values)
                {
                    if (count >= 4) return;
                    
                    Console.WriteLine($"\n=== X = {x}, Y = {y}, Z = {z} ===");
                    
                    // Выражение а) не(X или неY и Z)
                    Console.WriteLine("а) не(X или неY и Z):");
                    bool notY_a = !y;
                    bool notY_and_Z = notY_a && z;
                    bool X_or_notY_and_Z = x || notY_and_Z;
                    bool result_a = !X_or_notY_and_Z;
                    
                    Console.WriteLine($"   неY = {notY_a}");
                    Console.WriteLine($"   неY и Z = {notY_and_Z}");
                    Console.WriteLine($"   X или (неY и Z) = {X_or_notY_and_Z}");
                    Console.WriteLine($"   не(X или неY и Z) = {result_a}");
                    
                    // Выражение б) Y или (X и неY или Z)
                    Console.WriteLine("б) Y или (X и неY или Z):");
                    bool notY_b = !y;
                    bool X_and_notY = x && notY_b;
                    bool X_and_notY_or_Z = X_and_notY || z;
                    bool result_b = y || X_and_notY_or_Z;
                    
                    Console.WriteLine($"   неY = {notY_b}");
                    Console.WriteLine($"   X и неY = {X_and_notY}");
                    Console.WriteLine($"   X и неY или Z = {X_and_notY_or_Z}");
                    Console.WriteLine($"   Y или (X и неY или Z) = {result_b}");
                    
                    // Выражение в) не(неX и Y или Z)
                    Console.WriteLine("в) не(неX и Y или Z):");
                    bool notX_c = !x;
                    bool notX_and_Y = notX_c && y;
                    bool notX_and_Y_or_Z = notX_and_Y || z;
                    bool result_c = !notX_and_Y_or_Z;
                    
                    Console.WriteLine($"   неX = {notX_c}");
                    Console.WriteLine($"   неX и Y = {notX_and_Y}");
                    Console.WriteLine($"   неX и Y или Z = {notX_and_Y_or_Z}");
                    Console.WriteLine($"   не(неX и Y или Z) = {result_c}");
                    
                    count++;
                }
            }
        }
    }
}