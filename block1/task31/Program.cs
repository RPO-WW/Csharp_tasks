Console.WriteLine("Введите число num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

double everage = (num1 + num2) / 2;
Console.WriteLine($"Средняя арифметическая: {Math.Round(everage, 2)}");

double geometric_mean = Math.Pow(num1 * num2, 0.5);
Console.WriteLine($"Средняя геометрическая: {Math.Round(geometric_mean, 2)}");
