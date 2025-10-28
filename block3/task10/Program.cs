using System;

class Program
{
    static void Main()
    {
        bool A = false;
        bool B = false;
        bool C = true;

        Console.WriteLine("Дано: A = false, B = false, C = true\n");


        bool resultA = (!A || !B) && !C;
        bool resultB = (!A || !B) && (A || B);
        bool resultC = A && B || A && C || !C;


        Console.WriteLine($"а) (не А или не В) и не С = {resultA}");
        Console.WriteLine($"б) (не А или не В) и (А или В) = {resultB}");
        Console.WriteLine($"в) А и В или А и С или не С = {resultC}");


        Console.WriteLine("\nПорядок вычислений:");
        Console.WriteLine("а) Эквивалентно: ((!A) || (!B)) && (!C)");
        Console.WriteLine("б) Эквивалентно: ((!A) || (!B)) && (A || B)");
        Console.WriteLine("в) Эквивалентно: ((A && B) || (A && C)) || (!C)");
    }
}
