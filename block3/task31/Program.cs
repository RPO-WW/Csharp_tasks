using System;

class Program
{
    static void Main()
    {
        // Заданные значения
        bool A = true;
        bool B = false;
        bool C = false;
        
        Console.WriteLine("Исходные значения:");
        Console.WriteLine($"A = {A}");
        Console.WriteLine($"B = {B}");
        Console.WriteLine($"C = {C}");
        Console.WriteLine();
        
        Console.WriteLine("Результаты вычислений:");
        Console.WriteLine("======================");
        
        // а) А или не (А и В) или С
        bool result_a = A || !(A && B) || C;
        Console.WriteLine("а) А или не (А и В) или С:");
        Console.WriteLine($"   Формула: A || !(A && B) || C");
        Console.WriteLine($"   Вычисление: {A} || !({A} && {B}) || {C}");
        Console.WriteLine($"   A && B = {A && B}");
        Console.WriteLine($"   !(A && B) = {!(A && B)}");
        Console.WriteLine($"   A || !(A && B) = {A || !(A && B)}");
        Console.WriteLine($"   Результат: {result_a}");
        Console.WriteLine();
        
        // б) не А или А и (В или С)
        bool result_b = !A || A && (B || C);
        Console.WriteLine("б) не А или А и (В или С):");
        Console.WriteLine($"   Формула: !A || A && (B || C)");
        Console.WriteLine($"   Вычисление: !{A} || {A} && ({B} || {C})");
        Console.WriteLine($"   !A = {!A}");
        Console.WriteLine($"   B || C = {B || C}");
        Console.WriteLine($"   A && (B || C) = {A && (B || C)}");
        Console.WriteLine($"   Результат: {result_b}");
        Console.WriteLine();
        
        // в) (А или В и не С) и С
        bool result_c = (A || B && !C) && C;
        Console.WriteLine("в) (А или В и не С) и С:");
        Console.WriteLine($"   Формула: (A || B && !C) && C");
        Console.WriteLine($"   Вычисление: ({A} || {B} && !{C}) && {C}");
        Console.WriteLine($"   !C = {!C}");
        Console.WriteLine($"   B && !C = {B && !C}");
        Console.WriteLine($"   A || (B && !C) = {A || (B && !C)}");
        Console.WriteLine($"   Результат: {result_c}");
        Console.WriteLine();
        
        // Итоговая таблица
        Console.WriteLine("Итоговые результаты:");
        Console.WriteLine("а) " + result_a);
        Console.WriteLine("б) " + result_b);
        Console.WriteLine("в) " + result_c);
    }
}
