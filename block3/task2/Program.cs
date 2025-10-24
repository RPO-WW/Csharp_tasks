using System;

class Program
{
    static void Main()
    {
        // Заданные значения
        bool X = false;
        bool Y = true;
        bool Z = false;

        Console.WriteLine("Дано:");
        Console.WriteLine($"X = {X}");
        Console.WriteLine($"Y = {Y}");
        Console.WriteLine($"Z = {Z}");
        Console.WriteLine();

        // а) X или Z
        bool resultA = X || Z;
        Console.WriteLine($"а) X или Z = {X} || {Z} = {resultA}");

        // б) X и Y
        bool resultB = X && Y;
        Console.WriteLine($"б) X и Y = {X} && {Y} = {resultB}");

        // в) X и Z
        bool resultC = X && Z;
        Console.WriteLine($"в) X и Z = {X} && {Z} = {resultC}");
    }
}

