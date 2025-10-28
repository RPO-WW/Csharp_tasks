using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ВЫЧИСЛЕНИЕ ЗНАЧЕНИЙ ЛОГИЧЕСКИХ ВЫРАЖЕНИЙ");
        Console.WriteLine("=========================================\n");
        
        bool[] values = { false, true };
        
        Console.WriteLine("Таблица истинности:");
        Console.WriteLine("===================");
        Console.WriteLine("|  A  |  B  | не A или не B | A и (A или не B) | (не A или B) и B |");
        Console.WriteLine("|-----|-----|---------------|------------------|------------------|");
        
        foreach (bool A in values)
        {
            foreach (bool B in values)
            {
                bool result_a = !A || !B;
                
                bool result_b = A && (A || !B);
                
                bool result_c = (!A || B) && B;
                
                Console.WriteLine($"| {A,4} | {B,4} | {result_a,13} | {result_b,16} | {result_c,16} |");
            }
        }
        
        Console.WriteLine("\nПОДРОБНЫЙ РАЗБОР:");
        Console.WriteLine("=================\n");
        
        int caseNumber = 1;
        foreach (bool A in values)
        {
            foreach (bool B in values)
            {
                Console.WriteLine($"Случай {caseNumber}: A = {A}, B = {B}");
                Console.WriteLine("----------------------------------------");
                
                bool not_A = !A;
                bool not_B = !B;
                bool not_A_or_not_B = not_A || not_B;
                Console.WriteLine($"а) не А или не В:");
                Console.WriteLine($"   не А = не {A} = {not_A}");
                Console.WriteLine($"   не В = не {B} = {not_B}");
                Console.WriteLine($"   не А или не В = {not_A} ИЛИ {not_B} = {not_A_or_not_B}");
                
                bool A_or_not_B = A || not_B;
                bool A_and_A_or_not_B = A && A_or_not_B;
                Console.WriteLine($"б) А и (А или не В):");
                Console.WriteLine($"   А или не В = {A} ИЛИ {not_B} = {A_or_not_B}");
                Console.WriteLine($"   А и (А или не В) = {A} И {A_or_not_B} = {A_and_A_or_not_B}");
                
                bool not_A_or_B = not_A || B;
                bool not_A_or_B_and_B = not_A_or_B && B;
                Console.WriteLine($"в) (не А или В) и В:");
                Console.WriteLine($"   не А или В = {not_A} ИЛИ {B} = {not_A_or_B}");
                Console.WriteLine($"   (не А или В) и В = {not_A_or_B} И {B} = {not_A_or_B_and_B}");
                
                Console.WriteLine();
                caseNumber++;
            }
        }
        
        Console.WriteLine("АНАЛИЗ И УПРОЩЕНИЯ:");
        Console.WriteLine("===================");
        
        Console.WriteLine("Упрощение выражений:");
        Console.WriteLine("а) не А или не В ≡ не (А и В) - закон де Моргана");
        Console.WriteLine("б) А и (А или не В) ≡ А - закон поглощения");
        Console.WriteLine("в) (не А или В) и В ≡ В - упрощение");
        
        bool simplificationCorrect = true;
        foreach (bool A in values)
        {
            foreach (bool B in values)
            {
                bool result_a = !A || !B;
                bool simplified_a = !(A && B);
                
                bool result_b = A && (A || !B);
                bool simplified_b = A;
                
                bool result_c = (!A || B) && B;
                bool simplified_c = B;
                
                if (result_a != simplified_a || result_b != simplified_b || result_c != simplified_c)
                {
                    simplificationCorrect = false;
                }
            }
        }
        
        if (simplificationCorrect)
        {
            Console.WriteLine("\nВсе упрощения ВЕРНЫ для всех значений A и B!");
        }
    }
}