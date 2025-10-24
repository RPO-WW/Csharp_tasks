using System;

class Program
{
    static void Main()
    {
        bool A = true;
        bool B = false;
        bool C = false;
        
        Console.WriteLine("Дано:");
        Console.WriteLine($"A = {A}");
        Console.WriteLine($"B = {B}");
        Console.WriteLine($"C = {C}");
        Console.WriteLine();
        
        bool resultA = !A && B;
        Console.WriteLine($"а) не А и В = !{A} && {B} = {resultA}");
        
        bool resultB = A || !B;
        Console.WriteLine($"б) А или не В = {A} || !{B} = {resultB}");
        
        bool resultC = A && B || C;
        Console.WriteLine($"в) А и В или С = {A} && {B} || {C} = {resultC}");
    }
}