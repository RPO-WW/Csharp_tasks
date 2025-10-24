using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите k (1 <= k <= 150): ");
        int k = int.Parse(Console.ReadLine());
        
        if (k < 1 || k > 150)
        {
            Console.WriteLine("Ошибка: k должно быть в диапазоне от 1 до 150");
            return;
        }
        


        int numberIndex = (k - 1) / 3;
        int digitPosition = (k - 1) % 3;
        
        int number = 101 + numberIndex;
        

        int digit;
        switch (digitPosition)
        {
            case 0:
                digit = number / 100;
                break;
            case 1:
                digit = (number / 10) % 10;
                break;
            case 2:
                digit = number % 10;
                break;
            default:
                digit = 0;
                break;
        }
        
        Console.WriteLine($"k-я цифра: {digit}");
        Console.WriteLine($"Эта цифра находится в числе {number} на позиции {digitPosition + 1}");
        
        Console.WriteLine("\nДополнительная информация:");
        if (k % 3 == 0)
            Console.WriteLine($"k = {k} кратно трем - это последняя цифра числа");
        else if (k % 3 == 1)
            Console.WriteLine($"k = {k} дает остаток 1 при делении на 3 - это первая цифра числа");
        else
            Console.WriteLine($"k = {k} дает остаток 2 при делении на 3 - это вторая цифра числа");
    }
}