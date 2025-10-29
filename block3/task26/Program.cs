using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Таблица истинности логических выражений");
        Console.WriteLine("X\tY\tZ\tа)\tб)\tв)");
        Console.WriteLine(new string('-', 50));
        
        bool[] values = { false, true };
        
        foreach (bool x in values)
        {
            foreach (bool y in values)
            {
                foreach (bool z in values)
                {
                    bool expr_a = !(x || y) && (!x || !z);
                    bool expr_b = !(!x && y) || (x && !z);
                    bool expr_c = x || !y && !(x || !z);
                    
                    Console.WriteLine($"{x}\t{y}\t{z}\t{expr_a}\t{expr_b}\t{expr_c}");
                }
            }
        }
        
        Console.WriteLine("\nУпрощенные формы:");
        Console.WriteLine("а) не(X или Y) и (неX или неZ) = неX и неY");
        Console.WriteLine("б) не(неX и Y) или (X и неZ) = X или неY");
        Console.WriteLine("в) X или неY и не(X или неZ) = X или (неX и неY и Z)");
        
        Console.WriteLine("\nПояснения:");
        Console.WriteLine("Выражение а) истинно только когда X=false и Y=false (не зависит от Z)");
        Console.WriteLine("Выражение б) истинно когда X=true или Y=false (не зависит от Z)");
        Console.WriteLine("Выражение в) истинно когда X=true или (X=false и Y=false и Z=true)");
    }
}