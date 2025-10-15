using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        int number = int.Parse(Console.ReadLine());
        

        if (number < 1000 || number > 9999)
        {
            Console.WriteLine("Ошибка: число должно быть четырехзначным!");
            return;
        }
        

        int reversedNumber = ReverseNumber(number);
        Console.WriteLine($"а) Число справа налево: {reversedNumber}");
        

        int swappedPairs = SwapDigitPairs(number);
        Console.WriteLine($"б) Перестановка пар цифр: {swappedPairs}");
        

        int swappedMiddle = SwapMiddleDigits(number);
        Console.WriteLine($"в) Перестановка 2-й и 3-й цифр: {swappedMiddle}");
        

        int swappedGroups1 = SwapFirstAndLastGroupsMethod1(number);
        int swappedGroups2 = SwapFirstAndLastGroupsMethod2(number);
        Console.WriteLine($"г) Перестановка групп цифр (способ 1): {swappedGroups1}");
        Console.WriteLine($"г) Перестановка групп цифр (способ 2): {swappedGroups2}");
    }
    

    static int ReverseNumber(int num)
    {
        int result = 0;
        while (num > 0)
        {
            result = result * 10 + num % 10;
            num /= 10;
        }
        return result;
    }
    

    static int SwapDigitPairs(int num)
    {
        int digit1 = num / 1000;           // первая цифра
        int digit2 = (num / 100) % 10;     // вторая цифра
        int digit3 = (num / 10) % 10;      // третья цифра
        int digit4 = num % 10;             // четвертая цифра
        
        return digit2 * 1000 + digit1 * 100 + digit4 * 10 + digit3;
    }
    
    static int SwapMiddleDigits(int num)
    {
        int digit1 = num / 1000;          
        int digit2 = (num / 100) % 10;     
        int digit3 = (num / 10) % 10;      
        int digit4 = num % 10;             
        
        return digit1 * 1000 + digit3 * 100 + digit2 * 10 + digit4;
    }
    

    static int SwapFirstAndLastGroupsMethod1(int num)
    {
        int firstTwoDigits = num / 100;  
        int lastTwoDigits = num % 100;    
        
        return lastTwoDigits * 100 + firstTwoDigits;
    }
    

    static int SwapFirstAndLastGroupsMethod2(int num)
    {
        string numStr = num.ToString();
        

        string resultStr = numStr.Substring(2, 2) + numStr.Substring(0, 2);
        
        return int.Parse(resultStr);
    }
}