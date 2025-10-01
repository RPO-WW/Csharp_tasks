Console.Write("Введите значение a: ");
double a = Convert.ToDouble(Console.ReadLine());
double a_0 = Math.Pow(a, 2) + 1;
double task = (Math.Pow(a, 2) + 10) / Math.Pow(a_0, 0.5);
Console.WriteLine($"y = {Math.Round(task, 2)}");
