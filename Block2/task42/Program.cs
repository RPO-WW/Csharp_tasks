using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите часы (0 < h ≤ 12): ");
        int h = int.Parse(Console.ReadLine());
        
        Console.Write("Введите минуты (0 ≤ m ≤ 59): ");
        int m = int.Parse(Console.ReadLine());

        if (h <= 0 || h > 12 || m < 0 || m > 59)
        {
            Console.WriteLine("Ошибка: некорректный ввод времени!");
            return;
        }
        
        Console.WriteLine($"\nВремя: {h}:{m:D2}");

        double hourAngle = (h % 12) * 30 + m * 0.5;
        double minuteAngle = m * 6;

        double angleDiff = Math.Abs(hourAngle - minuteAngle);
        angleDiff = Math.Min(angleDiff, 360 - angleDiff);
        
        Console.WriteLine($"Угол часовой стрелки: {hourAngle:F2}°");
        Console.WriteLine($"Угол минутной стрелки: {minuteAngle:F2}°");
        Console.WriteLine($"Текущий угол между стрелками: {angleDiff:F2}°");

        double minutesToMatch = CalculateMinutesToMatch(h, m);
        Console.WriteLine($"\nа) До совпадения стрелок: {minutesToMatch:F2} минут");

        double minutesToPerpendicular = CalculateMinutesToPerpendicular(h, m);
        Console.WriteLine($"б) До перпендикулярного положения: {minutesToPerpendicular:F2} минут");
    }

    static double CalculateMinutesToMatch(int h, int m) {
        double numerator = 30 * (h % 12) - 5.5 * m;

        if(numerator < 0)
            numerator += 360;

        double minutes = numerator / 5.5;

        if(minutes > 60)
            minutes -= 60;

        return minutes;
    }

    static double CalculateMinutesToPerpendicular(int h, int m) { 
        double currentHourAngle = 30 * (h % 12) + 0.5 * m;
        double currentMinuteAngle = 6 * m;

        double targetAngle1 = currentHourAngle + 90;
        double targetAngle2 = currentHourAngle - 90;

        if(targetAngle2 < 0)
            targetAngle2 += 360;

        double minutes1 = (targetAngle1 - currentMinuteAngle) / (6 - 0.5);
        double minutes2 = (targetAngle2 - currentMinuteAngle) / (6 - 0.5);

        if(minutes1 < 0) minutes1 += 60;
        if(minutes2 < 0) minutes2 += 60;

        return Math.Min(minutes1, minutes2);
    }
}