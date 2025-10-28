using System;

class Program
{
    static void Main()
    {

        bool A = true;
        bool B = false;
        bool C = false;

        Console.WriteLine("Дано: A = true, B = false, C = false");
        Console.WriteLine("=====================================");


        bool resultA = A || B && !C;
        Console.WriteLine($"а) А или В и не С = {resultA}");


        bool resultG = A && !B || C;
        Console.WriteLine($"г) А и не В или С = {resultG}");


        bool resultB = !A && !B;
        Console.WriteLine($"б) не А и не В = {resultB}");


        bool resultD = A && (!B || C);
        Console.WriteLine($"д) А и (не В или С) = {resultD}");


        bool resultV = !(A && C) || B;
        Console.WriteLine($"в) не (А и С) или В = {resultV}");


        bool resultE = A || !(B && C);
        Console.WriteLine($"е) А или (не (В и С)) = {resultE}");


        Console.WriteLine("\nПошаговые вычисления:");
        Console.WriteLine("======================");
        

        Console.WriteLine("\nа) А или В и не С:");
        bool step1a = !C;
        bool step2a = B && step1a;
        bool step3a = A || step2a;
        Console.WriteLine($"   !C = {step1a}");
        Console.WriteLine($"   B && !C = {step2a}");
        Console.WriteLine($"   A || (B && !C) = {step3a}");


        Console.WriteLine("\nб) не А и не В:");
        bool step1b = !A;
        bool step2b = !B;
        bool step3b = step1b && step2b;
        Console.WriteLine($"   !A = {step1b}");
        Console.WriteLine($"   !B = {step2b}");
        Console.WriteLine($"   !A && !B = {step3b}");
    }
}