try
{
    Console.Write("Введите число k: ");
    double k = Convert.ToInt32(Console.ReadLine());

    int s0 = 5;
    s0 = 57;
    Console.WriteLine($"а) {s0}");

    double s1 = 6;
    s1 = -5.2;
    s1 = 0;
    Console.WriteLine($"б) {s1}");

    double s2 = -7.5;
    s2 = 2 * s2;
    Console.WriteLine($"в) {s2}");

    int s3 = 45;
    s3 = 25;
    s3 = s3 + (int)k;
    Console.WriteLine($"г) {s3}");
}
catch
{
    Console.WriteLine("Ошибка");
}
