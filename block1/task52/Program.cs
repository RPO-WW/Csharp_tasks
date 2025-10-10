using system;


class Program
{
    static void Main()
    {
        Console.WriteLine("Введите стоимость 1 кг конфет: ");
        double candyPrice = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите стоимость 1 кг печенья: ");
        double cookiePrice = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите стоимость 1 кг яблок: ");
        double applePrice = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество кг конфет: ");
        double candyWeight = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество кг печенья: ");
        double cookieWeight = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите количество кг яблок: ");
        double appleWeight = double.Parse(Console.ReadLine());

        double totalCost = (candyPrice * candyWeight) + (cookiePrice * CookieWeight) + (applePrice * applePriceWeight);

        Console.WriteLine($"Общая стоимость покупки: {totalCost:F2} руб.");

    }

}