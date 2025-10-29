using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Условия, которые являются истинными:\n");
        
      
        int X = 15, Y = 25, Z = -10;
        
        Console.WriteLine($"Тестовые значения: X = {X}, Y = {Y}, Z = {Z}\n");
        
       
        bool conditionA = X % 2 != 0 && Y % 2 != 0;
        Console.WriteLine($"а) Каждое из чисел X и Y нечетное:");
        Console.WriteLine($"   Условие: X % 2 != 0 && Y % 2 != 0");
        Console.WriteLine($"   Проверка: {X} % 2 = {X % 2}, {Y} % 2 = {Y % 2}");
        Console.WriteLine($"   Результат: {conditionA}\n");
        
    
        bool conditionB = (X < 20) ^ (Y < 20);
        Console.WriteLine($"б) Только одно из чисел X и Y меньше 20:");
        Console.WriteLine($"   Условие: (X < 20) ^ (Y < 20)");
        Console.WriteLine($"   Проверка: {X} < 20 = {X < 20}, {Y} < 20 = {Y < 20}");
        Console.WriteLine($"   Результат: {conditionB}\n");
        
        
        bool conditionC = X == 0 || Y == 0;
        Console.WriteLine($"в) Хотя бы одно из чисел X и Y равно нулю:");
        Console.WriteLine($"   Условие: X == 0 || Y == 0");
        Console.WriteLine($"   Проверка: {X} == 0 = {X == 0}, {Y} == 0 = {Y == 0}");
        Console.WriteLine($"   Результат: {conditionC}\n");
        
      
        bool conditionD = X < 0 && Y < 0 && Z < 0;
        Console.WriteLine($"г) Каждое из чисел X, Y, Z отрицательное:");
        Console.WriteLine($"   Условие: X < 0 && Y < 0 && Z < 0");
        Console.WriteLine($"   Проверка: {X} < 0 = {X < 0}, {Y} < 0 = {Y < 0}, {Z} < 0 = {Z < 0}");
        Console.WriteLine($"   Результат: {conditionD}\n");
        
        
        int countMultipleOf5 = (X % 5 == 0 ? 1 : 0) + (Y % 5 == 0 ? 1 : 0) + (Z % 5 == 0 ? 1 : 0);
        bool conditionE = countMultipleOf5 == 1;
        Console.WriteLine($"д) Только одно из чисел X, Y и Z кратно пяти:");
        Console.WriteLine($"   Условие: счетчик кратных 5 == 1");
        Console.WriteLine($"   Проверка: {X} % 5 = {X % 5}, {Y} % 5 = {Y % 5}, {Z} % 5 = {Z % 5}");
        Console.WriteLine($"   Количество кратных 5: {countMultipleOf5}");
        Console.WriteLine($"   Результат: {conditionE}\n");
        
      
        bool conditionF = X > 100 || Y > 100 || Z > 100;
        Console.WriteLine($"е) Хотя бы одно из чисел X, Y, Z больше 100:");
        Console.WriteLine($"   Условие: X > 100 || Y > 100 || Z > 100");
        Console.WriteLine($"   Проверка: {X} > 100 = {X > 100}, {Y} > 100 = {Y > 100}, {Z} > 100 = {Z > 100}");
        Console.WriteLine($"   Результат: {conditionF}\n");
    }
}