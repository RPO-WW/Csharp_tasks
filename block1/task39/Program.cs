Console.Write("Ввдеите число x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Ввдеите число y: ");
double y = Convert.ToDouble(Console.ReadLine());

double z = Math.Round(x + (2 + y) / Math.Pow(x, 2) / (y + (1 / Math.Pow(Math.Pow(x, 2) + 10, 0.5))), 2);
double q = Math.Round(2.8 * Math.Sin(x) + Math.Abs(y), 2);
Console.WriteLine($"z = {z}, q = {q}");