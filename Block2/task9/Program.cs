Console.Write("Ввдеите колтчество месяцев n: ");
int n = Convert.ToInt32(Console.ReadLine());

int x = (n % 12) + 1;
Console.WriteLine($"x = {x}");
