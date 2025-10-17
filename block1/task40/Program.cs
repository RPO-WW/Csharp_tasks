Console.Write("Ввдеите число a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Ввдеите число b: ");
double b = Convert.ToDouble(Console.ReadLine());

double x = Math.Round((2 / (Math.Pow(a, 2) + 25) + b) / (Math.Pow(b, 0.5) + ((a + b) / 2)), 2);
double y = Math.Round((Math.Abs(a) + 2 * Math.Sin(b)) / (5.5 * a), 2);
Console.WriteLine($"x = {x}, y = {y}");