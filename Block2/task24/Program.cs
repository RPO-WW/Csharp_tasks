using System;
class Programm
{
    static void Main()
    {
        Console.WriteLine("введите массу в кг: ");
        double kg = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"полных центнеров {(int)(kg / 100)}");
    }
}
