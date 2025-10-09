using System.Security.Cryptography;

Console.WriteLine("Ввдеите одно основание: ");
int osn1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввдеите второе основание: ");
int osn2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввдеите высоту: ");
int h = Convert.ToInt32(Console.ReadLine());


double c = Math.Pow(Math.Pow(h, 2) + Math.Pow((osn1 - osn2) / 2, 2), 0.5);
double p = osn1 + osn2 + 2 * c;

Console.WriteLine($"Периметр: {p}");