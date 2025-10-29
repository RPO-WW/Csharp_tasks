using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Таблица истинности для логических выражений\n");
        
        // Заголовок таблицы
        Console.WriteLine("X\tY\tZ\tне(Y или неX и Z) или Z\tX и не(неY или Z) или Y\tне(X или Y и Z) или неX");
        Console.WriteLine(new string('-', 120));
        
        // Перебираем все возможные значения X, Y и Z
        bool[] values = { false, true };
        
        foreach (bool x in values)
        {
            foreach (bool y in values)
            {
                foreach (bool z in values)
                {
                    // Вычисляем выражения
                    bool result1 = !(y || !x && z) || z;      // а) не(Y или неX и Z) или Z
                    bool result2 = x && !(!y || z) || y;      // б) X и не(неY или Z) или Y
                    bool result3 = !(x || y && z) || !x;      // в) не(X или Y и Z) или неX
                    
                    // Выводим результаты
                    Console.WriteLine($"{x}\t{y}\t{z}\t{result1}\t\t\t{result2}\t\t\t{result3}");
                }
            }
        }
        
        // Анализ и упрощение выражений
        Console.WriteLine("\n\nАнализ и упрощение выражений:");
        AnalyzeExpressions();
        
        // Пошаговое вычисление для наглядности
        Console.WriteLine("\n\nПошаговое вычисление для нескольких комбинаций:");
        StepByStepCalculation();
    }
    
    static void AnalyzeExpressions()
    {
        Console.WriteLine("\nа) не(Y или неX и Z) или Z");
        Console.WriteLine("   Упрощение по законам де Моргана:");
        Console.WriteLine("   не(Y или неX и Z) = неY и не(неX и Z)");
        Console.WriteLine("   = неY и (не(неX) или неZ)");
        Console.WriteLine("   = неY и (X или неZ)");
        Console.WriteLine("   (неY и (X или неZ)) или Z");
        Console.WriteLine("   = (неY и X) или (неY и неZ) или Z");
        Console.WriteLine("   = (неY и X) или Z или (неY и неZ)");
        Console.WriteLine("   = (неY и X) или Z (поскольку Z поглощает неY и неZ)");
        Console.WriteLine("   Итог: выражение равно (неY и X) или Z");
        
        Console.WriteLine("\nб) X и не(неY или Z) или Y");
        Console.WriteLine("   Упрощение по законам де Моргана:");
        Console.WriteLine("   не(неY или Z) = не(неY) и неZ");
        Console.WriteLine("   = Y и неZ");
        Console.WriteLine("   X и (Y и неZ) или Y");
        Console.WriteLine("   = (X и Y и неZ) или Y");
        Console.WriteLine("   = Y (по закону поглощения)");
        Console.WriteLine("   Итог: выражение равно Y");
        
        Console.WriteLine("\nв) не(X или Y и Z) или неX");
        Console.WriteLine("   Упрощение по законам де Моргана:");
        Console.WriteLine("   не(X или Y и Z) = неX и не(Y и Z)");
        Console.WriteLine("   = неX и (неY или неZ)");
        Console.WriteLine("   (неX и (неY или неZ)) или неX");
        Console.WriteLine("   = неX (по закону поглощения)");
        Console.WriteLine("   Итог: выражение равно неX");
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
                    if (count >= 4) return; // Покажем только 4 комбинации
                    
                    Console.WriteLine($"\n=== X = {x}, Y = {y}, Z = {z} ===");
                    
                    // Выражение а) не(Y или неX и Z) или Z
                    Console.WriteLine("а) не(Y или неX и Z) или Z:");
                    bool notX_a = !x;
                    bool notX_and_Z = notX_a && z;
                    bool Y_or_notX_and_Z = y || notX_and_Z;
                    bool not_Y_or_notX_and_Z = !Y_or_notX_and_Z;
                    bool result_a = not_Y_or_notX_and_Z || z;
                    
                    Console.WriteLine($"   неX = {notX_a}");
                    Console.WriteLine($"   неX и Z = {notX_and_Z}");
                    Console.WriteLine($"   Y или (неX и Z) = {Y_or_notX_and_Z}");
                    Console.WriteLine($"   не(Y или неX и Z) = {not_Y_or_notX_and_Z}");
                    Console.WriteLine($"   не(Y или неX и Z) или Z = {result_a}");
                    
                    // Выражение б) X и не(неY или Z) или Y
                    Console.WriteLine("б) X и не(неY или Z) или Y:");
                    bool notY_b = !y;
                    bool notY_or_Z = notY_b || z;
                    bool not_notY_or_Z = !notY_or_Z;
                    bool X_and_not_notY_or_Z = x && not_notY_or_Z;
                    bool result_b = X_and_not_notY_or_Z || y;
                    
                    Console.WriteLine($"   неY = {notY_b}");
                    Console.WriteLine($"   неY или Z = {notY_or_Z}");
                    Console.WriteLine($"   не(неY или Z) = {not_notY_or_Z}");
                    Console.WriteLine($"   X и не(неY или Z) = {X_and_not_notY_or_Z}");
                    Console.WriteLine($"   X и не(неY или Z) или Y = {result_b}");
                    
                    // Выражение в) не(X или Y и Z) или неX
                    Console.WriteLine("в) не(X или Y и Z) или неX:");
                    bool Y_and_Z = y && z;
                    bool X_or_Y_and_Z = x || Y_and_Z;
                    bool not_X_or_Y_and_Z = !X_or_Y_and_Z;
                    bool notX_c = !x;
                    bool result_c = not_X_or_Y_and_Z || notX_c;
                    
                    Console.WriteLine($"   Y и Z = {Y_and_Z}");
                    Console.WriteLine($"   X или (Y и Z) = {X_or_Y_and_Z}");
                    Console.WriteLine($"   не(X или Y и Z) = {not_X_or_Y_and_Z}");
                    Console.WriteLine($"   неX = {notX_c}");
                    Console.WriteLine($"   не(X или Y и Z) или неX = {result_c}");
                    
                    count++;
                }
            }
        }
    }
}
