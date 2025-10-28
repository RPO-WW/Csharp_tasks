using System;

class Program
{
    static void Main()
    {
        bool A = true;
        bool B = false;
        bool C = false;

        Console.WriteLine("Дано: A = true, B = false, C = false\n");

        // Вычисление всех выражений
        bool resultA = A || !(A && B) || C;
        bool resultB = !A || A && (B || C);
        bool resultC = (A || B && !C) && C;

        // Вывод результатов
        Console.WriteLine($"а) А или не (А и В) или С = {resultA}");
        Console.WriteLine($"б) не А или А и (В или С) = {resultB}");
        Console.WriteLine($"в) (А или В и не С) и С = {resultC}");

        // Дополнительная проверка приоритетов операций
        Console.WriteLine("\nПроверка приоритетов операций:");
        Console.WriteLine("а) Эквивалентно: A || (!(A && B)) || C");
        Console.WriteLine("б) Эквивалентно: (!A) || (A && (B || C))");
        Console.WriteLine("в) Эквивалентно: (A || (B && (!C))) && C");
    }
}
