try
{
    // а)
    double a = 5.8;
    double b = -7.9;
    b = a;
    a = b;
    Console.WriteLine($"а) a = {a}, b = {b}");

    // б)
    double a1 = 0;
    double b1 = -9.99;
    b1 = a1;
    a1 = b1;
    Console.WriteLine($"б) a1 = {a1}, b1 = {b1}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}