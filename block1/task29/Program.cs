<<<<<<< HEAD
﻿int number = 123;
int digit1 = number / 100;
int digit2 = (number / 10) % 10;
int digit3 = number % 10;

long square = (long)number * number; 
long sumOfCubes = (long)Math.Pow(digit1, 3) + Math.Pow(digit2, 3) + Math.Pow(digit3, 3);

if (square == sumOfCubes)
{
    Console.WriteLine($"Квадрат числа {number} равен сумме кубов его цифр.");
}
else
{
    Console.WriteLine($"Квадрат числа {number} НЕ равен сумме кубов его цифр.");
=======
﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите радиус окружности: ");

        if (double.TryParse(Console.ReadLine(), out double radius))
        {
            if (radius < 0)
            {
                Console.WriteLine("Радиус не может быть отрицательным");
                return;
            }

            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;

            Console.WriteLine($"Длина окружности: {circumference}");
            Console.WriteLine($"Площадь круга: {area}");
        }
        else
        {
            Console.WriteLine("Неккоректный ввод. Пожалуйста , введите число");
        }
    }
>>>>>>> 3c7e93fb573d02d87ae4eec4ab74c6ca21604e04
}
