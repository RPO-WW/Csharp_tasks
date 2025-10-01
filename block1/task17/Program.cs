using System;

class Program
{
    static List<double> MyInput(string[] prompts)
    {
        List<double> values = new List<double>();
        foreach (string prompt in prompts)
        {
            while (true)
            {
                Console.Write($"Введите значение для {prompt}: ");
                String input = Console.ReadLine();
                if (double.TryParse(input, out double number))
                {
                    values.Add(number);
                    break;
                }
                else
                {
                    Console.WriteLine("Введите корректное число");
                }
            }
        }
        return values;
    }
    static void Main()
    {
        string[] variableNames = {
            "x1", "x2", "x3",
            "v0", "t", "a",
            "m", "g", "h",
            "R1", "R2",
            "R",
            "b", "c",
            "r",
            "I",
            "d",
            "y",
            "alpha", "x"
        };
        List<double> inputs = MyInput(variableNames);

        double x1 = inputs[0];
        double x2 = inputs[1];
        double x3 = inputs[2];
        double v0 = inputs[3];
        double t = inputs[4];
        double a = inputs[5];
        double m = inputs[6];
        double g = inputs[7];
        double h = inputs[8];
        double R1 = inputs[9];
        double R2 = inputs[10];
        double R = inputs[11];
        double b = inputs[12];
        double c = inputs[13];
        double r = inputs[14];
        double I = inputs[15];
        double d = inputs[16];
        double y = inputs[17];
        double alpha = inputs[18];
        double x = inputs[19];

        Console.WriteLine("\n--- Результаты вычислений ---\n");

        double primer1 = Math.Sqrt(x1 * x1 + x2 * x2);
        Console.WriteLine($"a) {primer1}");

        double primer2 = x1 * x2 + x1 * x3 + x2 * x3;
        Console.WriteLine($"б) {primer2}");

        double primer3 = v0 * t + (a * t * t) / 2;
        Console.WriteLine($"в) {primer3}");

        double v = v0;
        double primer4 = (m * v * v) / 2 + m * g * h;
        Console.WriteLine($"г) {primer4}");

        double primer5 = 1.0 / R1 + 1.0 / R2;
        Console.WriteLine($"д) {primer5}");

        double primer6 = m * g * Math.Cos(alpha);
        Console.WriteLine($"е) {primer6}");

        double primer7 = 2 * Math.PI * R;
        Console.WriteLine($"ж) {primer7}");

        double primer8 = b * b - 4 * a * c;
        Console.WriteLine($"з) {primer8}");

        double primer9 = y * (m * m) / (r * r);
        Console.WriteLine($"и) {primer9}");

        double primer10 = I * I * R;
        Console.WriteLine($"к) {primer10}");

        double primer11 = a * b * Math.Sin(c);
        Console.WriteLine($"л) {primer11}");

        double primer12 = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(c));
        Console.WriteLine($"м) {primer12}");

        double primer13 = (a * d + b * c) / (a * d);
        Console.WriteLine($"н) {primer13}");

        double primer14 = Math.Sqrt(1 - Math.Pow(Math.Sin(x), 2));
        Console.WriteLine($"о) {primer14}");

        double xForP = x1;
        double disc = a * xForP * xForP + b * xForP + c;
        if (disc > 0)
        {
            double primerdisc = 1.0 / Math.Sqrt(disc);
            Console.WriteLine($"п) {primerdisc}");
        }
        else
        {
            Console.WriteLine($"п) Ошибка");
        }

        double xForR = x1;
        if (xForR > 1)
        {
            double numerator = Math.Sqrt(xForR + 1) + Math.Sqrt(xForR - 1);
            double denominator = 2 * Math.Sqrt(xForR);
            double primer15;
            primer15 = numerator / denominator;
            Console.WriteLine($"р) {primer15}");
        }
        else
        {
            Console.WriteLine($"Ошибка");
        }

        double xForS = x1;
        double primer16 = Math.Abs(xForS) + Math.Abs(xForS + 1);
        Console.WriteLine($"с) {primer16}");

        double xForT = x1;
        double primer17 = Math.Abs(1 - Math.Abs(xForT));
        Console.WriteLine($"т) {primer17}");

        Console.WriteLine("\nВсе выражения вычислены. Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
}
