using System;

public class ChessSafety
{
    // Базовые методы для проверки угроз
    public static bool RookThreatens(int a, int b, int c, int d)
    {
        return (a == c || b == d) && !(a == c && b == d);
    }
    
    public static bool BishopThreatens(int a, int b, int c, int d)
    {
        return Math.Abs(a - c) == Math.Abs(b - d) && !(a == c && b == d);
    }
    
    public static bool QueenThreatens(int a, int b, int c, int d)
    {
        return (RookThreatens(a, b, c, d) || BishopThreatens(a, b, c, d)) && !(a == c && b == d);
    }
    
    public static bool KnightThreatens(int a, int b, int c, int d)
    {
        int dx = Math.Abs(a - c);
        int dy = Math.Abs(b - d);
        return (dx == 1 && dy == 2) || (dx == 2 && dy == 1);
    }
    
    public static bool KingThreatens(int a, int b, int c, int d)
    {
        return Math.Abs(a - c) <= 1 && Math.Abs(b - d) <= 1 && !(a == c && b == d);
    }
    
    // Методы для проверки ходов белых фигур
    public static bool WhiteRookCanMove(int a, int b, int e, int f)
    {
        return RookThreatens(a, b, e, f);
    }
    
    public static bool WhiteBishopCanMove(int a, int b, int e, int f)
    {
        return BishopThreatens(a, b, e, f);
    }
    
    public static bool WhiteQueenCanMove(int a, int b, int e, int f)
    {
        return QueenThreatens(a, b, e, f);
    }
    
    public static bool WhiteKnightCanMove(int a, int b, int e, int f)
    {
        return KnightThreatens(a, b, e, f);
    }
    
    public static bool WhiteKingCanMove(int a, int b, int e, int f)
    {
        return KingThreatens(a, b, e, f);
    }
    
    // Основной метод проверки безопасного хода
    public static bool CanMoveSafely(int a, int b, int e, int f, int c, int d, 
                                    Func<int, int, int, int, bool> whiteMoveCheck,
                                    Func<int, int, int, int, bool> blackThreatCheck)
    {
        // Белая фигура может пойти на поле (e,f) И черная фигура не угрожает полю (e,f)
        return whiteMoveCheck(a, b, e, f) && !blackThreatCheck(c, d, e, f);
    }
    
    // Методы для конкретных комбинаций фигур
    public static bool RookVsRook(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteRookCanMove, RookThreatens);
    }
    
    public static bool RookVsQueen(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteRookCanMove, QueenThreatens);
    }
    
    public static bool RookVsKnight(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteRookCanMove, KnightThreatens);
    }
    
    public static bool RookVsBishop(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteRookCanMove, BishopThreatens);
    }
    
    public static bool QueenVsQueen(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteQueenCanMove, QueenThreatens);
    }
    
    public static bool QueenVsRook(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteQueenCanMove, RookThreatens);
    }
    
    public static bool QueenVsKnight(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteQueenCanMove, KnightThreatens);
    }
    
    public static bool QueenVsBishop(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteQueenCanMove, BishopThreatens);
    }
    
    public static bool KnightVsKnight(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteKnightCanMove, KnightThreatens);
    }
    
    public static bool KnightVsRook(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteKnightCanMove, RookThreatens);
    }
    
    public static bool KnightVsQueen(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteKnightCanMove, QueenThreatens);
    }
    
    public static bool KnightVsBishop(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteKnightCanMove, BishopThreatens);
    }
    
    public static bool BishopVsBishop(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteBishopCanMove, BishopThreatens);
    }
    
    public static bool BishopVsQueen(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteBishopCanMove, QueenThreatens);
    }
    
    public static bool BishopVsKnight(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteBishopCanMove, KnightThreatens);
    }
    
    public static bool BishopVsRook(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteBishopCanMove, RookThreatens);
    }
    
    public static bool KingVsBishop(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteKingCanMove, BishopThreatens);
    }
    
    public static bool KingVsQueen(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteKingCanMove, QueenThreatens);
    }
    
    public static bool KingVsKnight(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteKingCanMove, KnightThreatens);
    }
    
    public static bool KingVsRook(int a, int b, int e, int f, int c, int d)
    {
        return CanMoveSafely(a, b, e, f, c, d, WhiteKingCanMove, RookThreatens);
    }
}

// Пример использования
public class Program
{
    public static void Main()
    {
        int a = 1, b = 1;
        int c = 3, d = 3;
        int e = 1, f = 4;
        
        Console.WriteLine("Безопасные ходы:");
        Console.WriteLine($"a) Ладья vs Ладья: {ChessSafety.RookVsRook(a, b, e, f, c, d)}");
        Console.WriteLine($"б) Ладья vs Ферзь: {ChessSafety.RookVsQueen(a, b, e, f, c, d)}");
        Console.WriteLine($"в) Ладья vs Конь: {ChessSafety.RookVsKnight(a, b, e, f, c, d)}");
        Console.WriteLine($"г) Ладья vs Слон: {ChessSafety.RookVsBishop(a, b, e, f, c, d)}");
        Console.WriteLine($"д) Ферзь vs Ферзь: {ChessSafety.QueenVsQueen(a, b, e, f, c, d)}");
        Console.WriteLine($"е) Ферзь vs Ладья: {ChessSafety.QueenVsRook(a, b, e, f, c, d)}");
        Console.WriteLine($"ж) Ферзь vs Конь: {ChessSafety.QueenVsKnight(a, b, e, f, c, d)}");
        Console.WriteLine($"з) Ферзь vs Слон: {ChessSafety.QueenVsBishop(a, b, e, f, c, d)}");
        Console.WriteLine($"и) Конь vs Конь: {ChessSafety.KnightVsKnight(a, b, e, f, c, d)}");
        Console.WriteLine($"к) Конь vs Ладья: {ChessSafety.KnightVsRook(a, b, e, f, c, d)}");
        Console.WriteLine($"л) Конь vs Ферзь: {ChessSafety.KnightVsQueen(a, b, e, f, c, d)}");
        Console.WriteLine($"м) Конь vs Слон: {ChessSafety.KnightVsBishop(a, b, e, f, c, d)}");
        Console.WriteLine($"н) Слон vs Слон: {ChessSafety.BishopVsBishop(a, b, e, f, c, d)}");
        Console.WriteLine($"о) Слон vs Ферзь: {ChessSafety.BishopVsQueen(a, b, e, f, c, d)}");
        Console.WriteLine($"п) Слон vs Конь: {ChessSafety.BishopVsKnight(a, b, e, f, c, d)}");
        Console.WriteLine($"р) Слон vs Ладья: {ChessSafety.BishopVsRook(a, b, e, f, c, d)}");
        Console.WriteLine($"с) Король vs Слон: {ChessSafety.KingVsBishop(a, b, e, f, c, d)}");
        Console.WriteLine($"т) Король vs Ферзь: {ChessSafety.KingVsQueen(a, b, e, f, c, d)}");
        Console.WriteLine($"у) Король vs Конь: {ChessSafety.KingVsKnight(a, b, e, f, c, d)}");
        Console.WriteLine($"ф) Король vs Ладья: {ChessSafety.KingVsRook(a, b, e, f, c, d)}");
    }
}