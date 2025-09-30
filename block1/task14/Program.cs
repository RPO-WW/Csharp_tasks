using System;

class Program
{
    static void Main()
    {
        // Объявляем переменные (предположим некоторые значения)
        double x = 5.0;
        double y = 3.0;
        double a = 2.0;
        double b = 4.0;
        double n = -7.5;
        double alpha = Math.PI / 4;  // 45 градусов
        double beta = Math.PI / 6;   // 30 градусов

        // a) 2x
        double resultA = 2 * x;
        Console.WriteLine($"a) 2x = {resultA}");

        // б) sin x
        double resultB = Math.Sin(x);
        Console.WriteLine($"б) sin x = {resultB}");

        // в) a²
        double resultC = Math.Pow(a, 2);
        Console.WriteLine($"в) a² = {resultC}");

        // г) √x
        double resultD = Math.Sqrt(x);
        Console.WriteLine($"г) √x = {resultD}");

        // д) |n|
        double resultE = Math.Abs(n);
        Console.WriteLine($"д) |n| = {resultE}");

        // е) 5cos y
        double resultF = 5 * Math.Cos(y);
        Console.WriteLine($"е) 5cos y = {resultF}");

        // ж) -7,5a²
        double resultG = -7.5 * Math.Pow(a, 2);
        Console.WriteLine($"ж) -7,5a² = {resultG}");

        // з) 3√x
        double resultH = 3 * Math.Sqrt(x);
        Console.WriteLine($"з) 3√x = {resultH}");

        // и) sinαcosβ + cosαsinβ
        double resultI = Math.Sin(alpha) * Math.Cos(beta) + Math.Cos(alpha) * Math.Sin(beta);
        Console.WriteLine($"и) sinαcosβ + cosαsinβ = {resultI}");

        // к) a√(2b)
        double resultJ = a * Math.Sqrt(2 * b);
        Console.WriteLine($"к) a√(2b) = {resultJ}");

        // л) 3sin2αcos3β
        double resultK = 3 * Math.Sin(2 * alpha) * Math.Cos(3 * beta);
        Console.WriteLine($"л) 3sin2αcos3β = {resultK}");

        // м) -5√x + √y
        double resultL = -5 * Math.Sqrt(x) + Math.Sqrt(y);
        Console.WriteLine($"м) -5√x + √y = {resultL}");
    }
}
    

