using System;

class Program
{
    static void Main()
    {
        // Объявляем переменные (добавим недостающие)
        double x = 5.0;
        double y = 3.0;
        double a = 2.0;
        double b = 4.0;
        double c = 1.0;  // Добавлена переменная c
        double n = -7.5;
        double m = 2.0;  // Добавлена переменная m
        double alpha = Math.PI / 4;
        double beta = Math.PI / 6;

        // a) -1 / x²
        double resultA = -1 / Math.Pow(x, 2);
        Console.WriteLine($"a) -1 / x² = {Math.Round(resultA, 2)}");

        // б) a / (b * c)
        double resultB = a / (b * c);
        Console.WriteLine($"б) a / (b * c) = {Math.Round(resultB, 2)}");

        // в) (a / b) * c
        double resultC = (a / b) * c;
        Console.WriteLine($"в) (a / b) * c = {Math.Round(resultC, 2)}");

        // г) (a + b) / 2
        double resultD = (a + b) / 2;
        Console.WriteLine($"г) (a + b) / 2 = {Math.Round(resultD, 2)}");

        // д) 5.45 * ((a + 2b) / (2 - a))
        double resultE = 5.45 * ((a + 2 * b) / (2 - a));
        Console.WriteLine($"д) 5.45 * ((a + 2b) / (2 - a)) = {Math.Round(resultE, 2)}");

        // е) (-b + √(b² - 4ac)) / (2a)
        double discriminant = Math.Pow(b, 2) - 4 * a * c;
        double resultF = (-b + Math.Sqrt(discriminant)) / (2 * a);
        Console.WriteLine($"е) (-b + √(b² - 4ac)) / (2a) = {Math.Round(resultF, 2)}");

        // ж) (-b + (1 / a)) / (2 / c)
        double resultG = (-b + (1 / a)) / (2 / c);
        Console.WriteLine($"ж) (-b + (1 / a)) / (2 / c) = {Math.Round(resultG, 2)}");

        // з) 1 / (1 + ((a + b) / 2))
        double resultH = 1 / (1 + ((a + b) / 2));
        Console.WriteLine($"з) 1 / (1 + ((a + b) / 2)) = {Math.Round(resultH, 2)}");

        // и) 1 / (1 + (1 / (2 + (1 / (2 + (3 / 5))))))
        double resultI = 1 / (1 + (1 / (2 + (1 / (2 + (3.0 / 5))))));
        Console.WriteLine($"и) 1 / (1 + (1 / (2 + (1 / (2 + (3 / 5)))))) = {Math.Round(resultI, 2)}");

        // к) 2^(m^n)
        double resultJ = Math.Pow(2, Math.Pow(m, n));
        Console.WriteLine($"к) 2^(m^n) = {Math.Round(resultJ, 2)}");
    }
}