using System;

class Program
{
    static void Main()
    {
        for (int x = 100; x <= 999; x++)
        {
            int a = x / 100;
            int b = (x / 10) % 10;
            int c = x % 10;

            int result = (10 * a + c) * 10 + b;

            if (result == 456)
            {
                Console.WriteLine($"Искомое число x = {x}");
                break;
            }
        }
    }
}