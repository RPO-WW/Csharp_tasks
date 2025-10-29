using System;

public class ChessThreats
{
   
    public static bool RookThreatens(int a, int b, int c, int d)
    {
        
        return (a == c || b == d) && !(a == c && b == d);
    }
    
   
    public static bool BishopThreatens(int a, int b, int c, int d)
    {
      
        return Math.Abs(a - c) == Math.Abs(b - d) && !(a == c && b == d);
    }
    
  
    public static bool KingCanMove(int a, int b, int c, int d)
    {
        
        return Math.Abs(a - c) <= 1 && Math.Abs(b - d) <= 1 && !(a == c && b == d);
    }
    

    public static bool QueenThreatens(int a, int b, int c, int d)
    {
     
        return (RookThreatens(a, b, c, d) || BishopThreatens(a, b, c, d)) && !(a == c && b == d);
    }
    
    
    public static bool WhitePawnCanMove(int a, int b, int c, int d)
    {
     
        bool normalMove = (a == c) && (d == b + 1);
        
        
        bool doubleMove = (a == c) && (b == 2) && (d == 4);
        
      
        bool captureMove = (Math.Abs(a - c) == 1) && (d == b + 1);
        
        return (normalMove || doubleMove || captureMove) && !(a == c && b == d);
    }
    
 
    public static bool WhitePawnNormalMove(int a, int b, int c, int d)
    {
       
        return (a == c) && (d == b + 1);
    }
    
    public static bool WhitePawnDoubleMove(int a, int b, int c, int d)
    {
       
        return (a == c) && (b == 2) && (d == 4);
    }
    
    public static bool WhitePawnCaptureMove(int a, int b, int c, int d)
    {

        return (Math.Abs(a - c) == 1) && (d == b + 1);
    }
}


public class Program
{
    public static void Main()
    {
        int a = 2, b = 2; 
        int c = 2, d = 4;
        
        Console.WriteLine($"Ладья с ({a},{b}) угрожает ({c},{d}): {ChessThreats.RookThreatens(a, b, c, d)}");
        Console.WriteLine($"Слон с ({a},{b}) угрожает ({c},{d}): {ChessThreats.BishopThreatens(a, b, c, d)}");
        Console.WriteLine($"Король с ({a},{b}) может пойти на ({c},{d}): {ChessThreats.KingCanMove(a, b, c, d)}");
        Console.WriteLine($"Ферзь с ({a},{b}) угрожает ({c},{d}): {ChessThreats.QueenThreatens(a, b, c, d)}");
        Console.WriteLine($"Белая пешка с ({a},{b}) может пойти на ({c},{d}): {ChessThreats.WhitePawnCanMove(a, b, c, d)}");
        

        Console.WriteLine($"Обычный ход пешки: {ChessThreats.WhitePawnNormalMove(a, b, c, d)}");
        Console.WriteLine($"Двойной ход пешки: {ChessThreats.WhitePawnDoubleMove(a, b, c, d)}");
        Console.WriteLine($"Взятие пешкой: {ChessThreats.WhitePawnCaptureMove(a, b, c, d)}");
    }
}