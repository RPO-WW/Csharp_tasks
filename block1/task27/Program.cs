using System;

class Program
{
    static void Main()
    {
<<<<<<< HEAD
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());
        
        if (number < 100 || number > 999)
        {
            Console.WriteLine("Ошибка! Число должно быть трехзначным.");
            return;
        }
        

        int firstDigit = number / 100;
        int lastDigit = number % 10;
        

        if (firstDigit == lastDigit)
        {
            Console.WriteLine($"Число {number} является палиндромом.");
        }
        else
        {
            Console.WriteLine($"Число {number} НЕ является палиндромом.");
        }
=======
        Console.WriteLine("Введите высоту над землей(в километрах):");
        double heightKm = double.Parse(Console.ReadLine());

        double distance = CalculateHorizonDistance(heightKm);
        Console.WriteLine($"расстояние до горизонта: {distance:F2} км");
    }

    static double CalculateHorizonDistance(double heightKm)
    {
        const double R = 6350.0;
        return Math.Sqrt(2 * R * heightKm + Math.Pow(heightKm, 2));
>>>>>>> 3c7e93fb573d02d87ae4eec4ab74c6ca21604e04
    }
}