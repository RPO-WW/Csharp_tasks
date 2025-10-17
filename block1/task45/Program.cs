using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double sum = a + b;
        Console.WriteLine($"Сумма: {a} + {b} = {sum}");

        double difference = a - b;
        Console.WriteLine($"Разность: {a} - {b} = {difference}");

        double product = a * b;
        Console.WriteLine($"Произведение: {a} * {b} = {product}");

        if (b != 0)
        {
            double quotient = a / b;
            Console.WriteLine($"Частное: {a} : {b} = {quotient}");
        }
        else
        {
            Console.WriteLine("Ошибка: деление на ноль невозможно");
        }

        Console.ReadKey();
    }
}