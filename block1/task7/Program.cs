try
{
    Console.Write("Введите нулевое число: ");
    int num0 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Введенное число: {num0}  {num1}  {num2}");
}
catch
{
    Console.WriteLine("ОШИБКА!!!");
}