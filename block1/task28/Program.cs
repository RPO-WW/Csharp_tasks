using System;

<<<<<<< HEAD
public class CompareDigits
{
    public static void Main(string[] args)
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        // Проверяем, что число трехзначное
        if (number < 100 || number > 999)
        {
            Console.WriteLine("Ошибка: Введите трехзначное число.");
            return;
        }

        // Получаем цифры числа
        int firstDigit = number / 100;         // Первая цифра (сотни)
        int secondDigit = (number / 10) % 10;  // Вторая цифра (десятки)
        int lastDigit = number % 10;           // Последняя цифра (единицы)

        // а) Сравниваем первую и последнюю цифру
        if (firstDigit > lastDigit)
        {
            Console.WriteLine("а) Первая цифра больше последней.");
        }
        else if (lastDigit > firstDigit)
        {
            Console.WriteLine("а) Последняя цифра больше первой.");
        }
        else
        {
            Console.WriteLine("а) Первая и последняя цифры равны.");
        }

        // б) Сравниваем первую и вторую цифру
        if (firstDigit > secondDigit)
        {
            Console.WriteLine("б) Первая цифра больше второй.");
        }
        else if (secondDigit > firstDigit)
        {
            Console.WriteLine("б) Вторая цифра больше первой.");
        }
        else
        {
            Console.WriteLine("б) Первая и вторая цифры равны.");
        }

        // в) Сравниваем вторую и последнюю цифру
        if (secondDigit > lastDigit)
        {
            Console.WriteLine("в) Вторая цифра больше последней.");
        }
        else if (lastDigit > secondDigit)
        {
            Console.WriteLine("в) Последняя цифра больше второй.");
        }
        else
        {
            Console.WriteLine("в) Вторая и последняя цифры равны.");
        }
=======
class Program
{
    static void Main()
    {
        Console.Write("Введите длину ребра куба: ");
        double edgeLenght = Convert.ToDouble(Console.ReadLine());

        double volume = Math.Pow(edgeLenght, 3);

        double lateralSurfaceArea = 4 * Math.Pow(edgeLenght, 2);

        Console.WriteLine($"Обьем куба: {volume:F2}");
        Console.WriteLine($"Площадь боковой поверхности: {lateralSurfaceArea}");
>>>>>>> 3c7e93fb573d02d87ae4eec4ab74c6ca21604e04
    }
}
