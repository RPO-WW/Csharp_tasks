using system;

class Program
{
    static void main()
    {
        Console.Write("Введите число n (10 <= n <= 999, десятки не равны 0): ");
        int n = int.Parse(Console.ReadLine());

        if (n < 10 || n > 999)
        {
            Console.WriteLine("Ошибка: n должно быть в диапазоне от 10 до 999");
            return;
        }









    }
}