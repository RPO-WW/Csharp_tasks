using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Таблица истинности логических выражений");
        Console.WriteLine("=======================================");
        
        // Заголовок таблицы
        Console.WriteLine("|  A  |  B  | не (А и В) | не А или В | А или не В |");
        Console.WriteLine("|-----|-----|------------|------------|------------|");
        
       
        bool[] values = { false, true };
        
        foreach (bool A in values)
        {
            foreach (bool B in values)
            {
                
                bool result_a = !(A && B);
                
                
                bool result_b = !A || B;
                
                
                bool result_c = A || !B;
                
                
                Console.WriteLine($"| {A,3} | {B,3} | {result_a,10} | {result_b,10} | {result_c,10} |");
            }
        }
        
        
        Console.WriteLine("\nАнализ выражений:");
        Console.WriteLine("а) не (А и В) - отрицание конъюнкции (штрих Шеффера)");
        Console.WriteLine("б) не А или В - импликация (A → B)");
        Console.WriteLine("в) А или не В - обратная импликация (B → A)");
    }
}