Console.Write("Ввдеите число e: ");
double e = Convert.ToDouble(Console.ReadLine());

Console.Write("Ввдеите число f: ");
double f = Convert.ToDouble(Console.ReadLine());

Console.Write("Ввдеите число g: ");
double g = Convert.ToDouble(Console.ReadLine());

Console.Write("Ввдеите число h: ");
double h = Convert.ToDouble(Console.ReadLine());

double a = Math.Round((e + (f / 2)) / 3, 2);
double b = Math.Round(Math.Abs(Math.Pow(h, 2) - g), 2);
double c = Math.Round(Math.Pow(Math.Pow(g - h, 2) - 3 * Math.Sin(e), 0.5), 2);
Console.WriteLine($"a = {a}, b = {b}, c = {c}");
