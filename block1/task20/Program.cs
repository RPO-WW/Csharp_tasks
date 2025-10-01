try
{
    int s0 = 14;
    int k0 = -3;
    int d0 = s0 + 1;
    s0 = d0;
    k0 = 2 * s0;
    Console.WriteLine($"а) {s0} {k0} {d0}");

    int s1 = 0;
    int k1 = 30;
    int d1 = k1 - 5;
    k1 = 2 * d1;
    s1 = k1 - 100;
    Console.WriteLine($"б) {s1} {k1} {d1}");
}
catch
{
    Console.WriteLine("Ошибка");
}
