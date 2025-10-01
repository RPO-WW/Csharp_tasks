try
{
    Console.Write("Введите число k: ");
    double k = Convert.ToDouble(Console.ReadLine());

    int x0 = 10;
    x0 = -10;
    Console.WriteLine($"а) {x0}");

    double x1 = 17.5;
    x1 = -2 * x1;
    Console.WriteLine($"б) {x1}");

    double x2 = 60;
    x2 = x2 - 1;
    x2 = 0;
    Console.WriteLine($"в) {x2}");

    double x3 = -50;
    x3 = -25;
    x3 = x3 + k;
    Console.WriteLine($"г) {x3}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
