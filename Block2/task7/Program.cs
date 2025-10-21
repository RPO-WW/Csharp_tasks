using System;

public class SquareCutting
{
    public static void Main(string[] args)
    {
        int rectangleLength = 543;
        int rectangleWidth = 130;
        int squareSide = 130;

        int squaresByLength = rectangleLength / squareSide;
        int squaresByWidth = rectangleWidth / squareSide;

        int totalSquares = squaresByLength * squaresByWidth;

        Console.WriteLine($"От прямоугольника размером {rectangleLength}x{rectangleWidth} мм можно отрезать {totalSquares} квадратов со стороной {squareSide} мм.");
    }
}
