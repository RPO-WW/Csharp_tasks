using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите цифры трёхзначного числа (a3 a2 a1): ");
        string[] inputA = Console.ReadLine().Split();
        int a3 = Convert.ToInt32(inputA[0]);
        int a2 = Convert.ToInt32(inputA[1]);
        int a1 = Convert.ToInt32(inputA[2]);
        
        Console.Write("Введите цифры двузначного числа (b2 b1): ");
        string[] inputB = Console.ReadLine().Split();
        int b2 = Convert.ToInt32(inputB[0]);
        int b1 = Convert.ToInt32(inputB[1]);

        int sum1 = a1 + b1;
        int s1 = sum1 % 10;
        int carry1 = sum1 / 10;


        int sum2 = a2 + b2 + carry1;
        int s2 = sum2 % 10;
        int carry2 = sum2 / 10;


        int s3 = a3 + carry2;


        Console.WriteLine($"Цифры суммы (s3 s2 s1): {s3} {s2} {s1}");
    }
}