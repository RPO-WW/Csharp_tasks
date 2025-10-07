 using System; 
class New_Project  
{ public static void Main()  
{ double a, b, c; Console.Write("a b: "); 
  var line = Console.ReadLine().Split(" "); 
  a = double.Parse(line[0]); b = double.Parse(line[1]); 
  c = Math.Sqrt(a * a + b * b); 
  Console.WriteLine("Гипотенуза: " + c); 
  Console.WriteLine("Периметр:   " + (a + b + c)); } } 