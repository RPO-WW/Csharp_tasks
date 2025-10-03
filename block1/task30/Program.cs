Console.WriteLine("Введите сторону x: ");
double x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите сторону y: ");
double y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите сторону a: ");
double a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите сторону b: ");
double b = Convert.ToInt32(Console.ReadLine());
double z = Math.Pow(x, 3) - (2.5 * x * y) + (1.78 * Math.Pow(x, 2)) - (2.5 * y) + 1;
Console.WriteLine(Math.Round(z, 2));
double x1 = Math.Pow((3.56 * a + b), 3) - (5.8 * Math.Pow(b, 2)) + (3.8 * a) - 1.5;
Console.WriteLine(Math.Round(x1, 2));
