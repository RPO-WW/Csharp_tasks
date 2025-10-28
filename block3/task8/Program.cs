using System;

class Program
{
    static void Main()
    {
        bool X = false;
        bool Y = true;
        bool Z = false;

        Console.WriteLine("Дано: X = false, Y = true, Z = false");
        Console.WriteLine("=====================================\n");

        Console.WriteLine("а) X и не (Z или Y) или не Z:");
        bool step1a = Z || Y;
        bool step2a = !step1a;
        bool step3a = X && step2a;
        bool step4a = !Z;
        bool resultA = step3a || step4a;
        Console.WriteLine($"   Z || Y = {step1a}");
        Console.WriteLine($"   !(Z || Y) = {step2a}");
        Console.WriteLine($"   X && !(Z || Y) = {step3a}");
        Console.WriteLine($"   !Z = {step4a}");
        Console.WriteLine($"   (X && !(Z || Y)) || !Z = {resultA}");
        Console.WriteLine($"   Результат: {resultA}\n");

        Console.WriteLine("б) не X или X и (Y или Z):");
        bool step1b = !X;
        bool step2b = Y || Z;
        bool step3b = X && step2b;
        bool resultB = step1b || step3b;
        Console.WriteLine($"   !X = {step1b}");
        Console.WriteLine($"   Y || Z = {step2b}");
        Console.WriteLine($"   X && (Y || Z) = {step3b}");
        Console.WriteLine($"   !X || (X && (Y || Z)) = {resultB}");
        Console.WriteLine($"   Результат: {resultB}\n");

        Console.WriteLine("в) (X или Y и не Z) и Z:");
        bool step1c = !Z;
        bool step2c = Y && step1c;
        bool step3c = X || step2c;
        bool resultC = step3c && Z;
        Console.WriteLine($"   !Z = {step1c}");
        Console.WriteLine($"   Y && !Z = {step2c}");
        Console.WriteLine($"   X || (Y && !Z) = {step3c}");
        Console.WriteLine($"   (X || (Y && !Z)) && Z = {resultC}");
        Console.WriteLine($"   Результат: {resultC}\n");

        Console.WriteLine("Итоговые результаты:");
        Console.WriteLine("====================");
        Console.WriteLine($"а) {resultA}");
        Console.WriteLine($"б) {resultB}");
        Console.WriteLine($"в) {resultC}");
    }
}