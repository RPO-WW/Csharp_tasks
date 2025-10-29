using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Логические выражения для указанных условий:\n");
        
       
        int x = 4, y = 3;
        
        Console.WriteLine($"Тестовые значения: x = {x}, y = {y}\n");
        
       
        bool a = x > 2 && y > 3;
        Console.WriteLine($"а) х > 2 и у > 3: {x} > 2 && {y} > 3 = {a}");
        
        
        bool b = x > 1 || y > 2;
        Console.WriteLine($"б) х > 1 или y > 2: {x} > 1 || {y} > 2 = {b}");
        
        
        bool c = x > 0 && y < 5;
        Console.WriteLine($"в) х > 0 и у < 5: {x} > 0 && {y} < 5 = {c}");
        
      
        bool d = x > 3 || x < 1;
        Console.WriteLine($"г) х > 3 или x < 1: {x} > 3 || {x} < 1 = {d}");
        
        
        bool e = x > 3 && x < 10;
        Console.WriteLine($"д) х > 3 и x < 10: {x} > 3 && {x} < 10 = {e}");
        
        
        bool f = !(x > 2);
        Console.WriteLine($"е) неверно, что х > 2: !({x} > 2) = {f}");
        
        
        bool g = !(x > 0 && x < 5);
        Console.WriteLine($"ж) неверно, что х > 0 и х < 5: !({x} > 0 && {x} < 5) = {g}");
        
       
        bool h = x > 10 && x < 20;
        Console.WriteLine($"з) 10 < x < 20: {x} > 10 && {x} < 20 = {h}");
        
        
        bool i = y > 0 && y < 4 && x < 5;
        Console.WriteLine($"и) 0 < y < 4 и x < 5: {y} > 0 && {y} < 4 && {x} < 5 = {i}");
        
        
        Console.WriteLine("\n" + new string('=', 50));
        Console.WriteLine("Демонстрация с различными значениями:");
        DemonstrateWithDifferentValues();
    }
    
    static void DemonstrateWithDifferentValues()
    {
        int[,] testCases = {
            {4, 3},  
            {1, 2},  
            {5, 4}, 
            {15, 2}, 
            {3, 1}  
        };
        
        Console.WriteLine("\nx\ty\tа)\tб)\tв)\tг)\tд)\tе)\tж)\tз)\tи)");
        Console.WriteLine(new string('-', 80));
        
        for (int i = 0; i < testCases.GetLength(0); i++)
        {
            int x = testCases[i, 0];
            int y = testCases[i, 1];
            
            bool a = x > 2 && y > 3;
            bool b = x > 1 || y > 2;
            bool c = x > 0 && y < 5;
            bool d = x > 3 || x < 1;
            bool e = x > 3 && x < 10;
            bool f = !(x > 2);
            bool g = !(x > 0 && x < 5);
            bool h = x > 10 && x < 20;
            bool j = y > 0 && y < 4 && x < 5;
            
            Console.WriteLine($"{x}\t{y}\t{a}\t{b}\t{c}\t{d}\t{e}\t{f}\t{g}\t{h}\t{j}");
        }
    }
}