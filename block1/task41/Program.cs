Console.Write("Ввдеите число e: ");
double e = Convert.ToDouble(Console.ReadLine());

Console.Write("Ввдеите число f: ");
double f = Convert.ToDouble(Console.ReadLine());

Console.Write("Ввдеите число g: ");
double g = Convert.ToDouble(Console.ReadLine());

Console.Write("Ввдеите число h: ");
double h = Convert.ToDouble(Console.ReadLine());

double a = Math.Round(Math.Pow(Math.Abs(e - (3 / f)), 0.33) + g, 2);
double b = Math.Round(Math.Sin(e) + Math.Pow(Math.Cos(h), 2), 2);
double c = Math.Round((33 * g) / (e * f - 3), 2);
Console.WriteLine($"a = {a}, b = {b}, c = {c}");
