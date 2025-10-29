using System.Numerics;

Console.Write("Введите координату x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату y: ");
double y = Convert.ToDouble(Console.ReadLine());

if(x < -1 && y < -2)
{
    Console.WriteLine("а) true");
}
else
{
    Console.WriteLine("а) false");
}

if (y > 1 && y < -3)
{
    Console.WriteLine("б) true");
}
else
{
    Console.WriteLine("б) false");
}

if (y > 1 && y < -3 && y > -4)
{
    Console.WriteLine("в) true");
}
else
{
    Console.WriteLine("в) false");
}

if (x < 1.5 && x > -1 && y < 1.5 && y > -0.5)
{
    Console.WriteLine("г) true");
}
else
{
    Console.WriteLine("г) false");
}

if (x < 4 && x > 2 && y < 4 && y > 2)
{
    Console.WriteLine("д) true");
}
else
{
    Console.WriteLine("д) false");
}

if (x < -1 && x > 2 && y > 1)
{
    Console.WriteLine("е) true");
}
else
{
    Console.WriteLine("е) false");
}

if (x > 1 && x < 3 && y < 1 && y > -3)
{
    Console.WriteLine("ж) true");
}
else
{
    Console.WriteLine("ж) false");
}

if (y > 1.5)
{
    Console.WriteLine("з) true");
}
else if(x > 1 && x < 2.5 && y > -2)
{
    Console.WriteLine("з) true");
}
else
{
    Console.WriteLine("з) false");
}