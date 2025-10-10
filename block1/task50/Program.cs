using System;

class TriangleCalculator
{
    static void Main()
    {
        Console.WriteLine("Введите координаты вершин треугольника:");
        
       
        Console.Write("Введите x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Введите y1: ");
        double y1 = double.Parse(Console.ReadLine());
        
        
        Console.Write("Введите x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Введите y2: ");
        double y2 = double.Parse(Console.ReadLine());
        
        
        Console.Write("Введите x3: ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("Введите y3: ");
        double y3 = double.Parse(Console.ReadLine());
        
        
        double a = Distance(x1, y1, x2, y2);
        double b = Distance(x2, y2, x3, y3);
        double c = Distance(x3, y3, x1, y1);
        
        
        if (IsTriangleValid(a, b, c))
        {
            
            double perimeter = CalculatePerimeter(a, b, c);
            double area = CalculateArea(a, b, c);
            
            
            Console.WriteLine($"\nРезультаты:");
            Console.WriteLine($"Сторона a = {a:F2}");
            Console.WriteLine($"Сторона b = {b:F2}");
            Console.WriteLine($"Сторона c = {c:F2}");
            Console.WriteLine($"Периметр = {perimeter:F2}");
            Console.WriteLine($"Площадь = {area:F2}");
        }
        else
        {
            Console.WriteLine("Треугольник с такими координатами не существует!");
        }
    }
    
   
    static double Distance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
    
    
    static bool IsTriangleValid(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a && a > 0 && b > 0 && c > 0;
    }
    
   
    static double CalculatePerimeter(double a, double b, double c)
    {
        return a + b + c;
    }
    
   
    static double CalculateArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2; 
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}