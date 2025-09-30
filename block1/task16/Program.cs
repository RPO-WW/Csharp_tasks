Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число R: ");
int R = Convert.ToInt32(Console.ReadLine());

int result_0 = a / b / c;
Console.Write($"{result_0}\n");

int result_1 = a * b / c;
Console.Write($"{result_1}\n");

int result_2 = a / b * c;
Console.Write($"{result_2}\n");

int result_3 = a + b / c;
Console.Write($"{result_3}\n");

int result_4 = (a + b) / c;
Console.Write($"{result_4}\n");

int result_5 = a + (b / b) + c;
Console.Write($"{result_5}\n");

int result_6 = (a + b) / (b + c);
Console.Write($"{result_6}\n");

double result_7 = a / Math.Sin(b);
Console.Write($"{Math.Round(result_7, 2)}\n");

double result_8 = (((1 / 2) * a) * b) * Math.Sin(x);
Console.Write($"{result_8}\n");

double result_9 = 2 * b * c * Math.Cos(a / 2) / b + c;
Console.Write($"{result_9}\n");

double result_10 = 4 * R * Math.Sin(a / 2) * Math.Sin(b / 2) * Math.Sin(c / 2);
Console.Write($"{result_10}\n");

int result_11 = (a * x + b) / (c * x + b);
Console.Write($"{result_11}\n");

double result_12 = 2 * Math.Sin(a + b / 2) * Math.Cos(a - b / 2);
Console.Write($"{Math.Round(result_12, 2)}\n");

double result_13 = Math.Abs(2) * Math.Sin(-3 * Math.Abs(x / 2));
Console.Write($"{result_13}\n");
