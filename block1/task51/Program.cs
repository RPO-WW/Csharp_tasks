using System;

public class Program
{

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    

    public static double TriangleArea(Point A, Point B, Point C)
    {

        return Math.Abs((B.X - A.X) * (C.Y - A.Y) - (C.X - A.X) * (B.Y - A.Y)) / 2.0;
    }
    

    public static double QuadrilateralArea(Point A, Point B, Point C, Point D)
    {

        double area1 = TriangleArea(A, B, C);
        double area2 = TriangleArea(A, C, D);
        

        return area1 + area2;
    }
    
    public static void Main()
    {

        Point A = new Point(0, 0);
        Point B = new Point(4, 0);
        Point C = new Point(5, 3);
        Point D = new Point(1, 4);
        
        double area = QuadrilateralArea(A, B, C, D);
        Console.WriteLine($"Площадь четырехугольника: {area:F2}");
        

        Point A2 = new Point(0, 0);
        Point B2 = new Point(2, 0);
        Point C2 = new Point(2, 2);
        Point D2 = new Point(0, 2);
        
        double area2 = QuadrilateralArea(A2, B2, C2, D2);
        Console.WriteLine($"Площадь квадрата: {area2:F2}");
    }
}