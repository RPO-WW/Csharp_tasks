public class PointChecker
{
    public static bool IsInRectangle(double x, double y, 
                                   double x1, double y1, double x2, double y2)
    {
        return x >= Math.Min(x1, x2) && x <= Math.Max(x1, x2) &&
               y >= Math.Min(y1, y2) && y <= Math.Max(y1, y2);
    }
    
    public static bool IsInCircle(double x, double y, 
                                 double centerX, double centerY, double radius)
    {
        double distance = Math.Sqrt(Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2));
        return distance <= radius;
    }
    
    public static bool IsInRing(double x, double y, 
                               double centerX, double centerY, 
                               double innerRadius, double outerRadius)
    {
        double distance = Math.Sqrt(Math.Pow(x - centerX, 2) + Math.Pow(y - centerY, 2));
        return distance >= innerRadius && distance <= outerRadius;
    }
    
    public static bool IsInTriangle(double x, double y,
                                   double x1, double y1,
                                   double x2, double y2,
                                   double x3, double y3)
    {
        double area = 0.5 * (-y2 * x3 + y1 * (-x2 + x3) + x1 * (y2 - y3) + x2 * y3);
        double s = 1 / (2 * area) * (y1 * x3 - x1 * y3 + (y3 - y1) * x + (x1 - x3) * y);
        double t = 1 / (2 * area) * (x1 * y2 - y1 * x2 + (y1 - y2) * x + (x2 - x1) * y);
        
        return s >= 0 && t >= 0 && (s + t) <= 1;
    }
}