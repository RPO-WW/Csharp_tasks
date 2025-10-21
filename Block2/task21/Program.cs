Console.Write("Введите натуральное число n (n > 9): ");
int n = Convert.ToInt32(Console.ReadLine());
int ed = n % 10;
int des = (n / 10) % 10;
Console.WriteLine($"а) Число единиц: {ed}");
Console.WriteLine($"б) Число десятков: {des}");
