using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Условия для целого числа A:\n");
        
        int[] testValues = { 6, 10, 15, 9, 20, 7, 30 };
        
        Console.WriteLine("Тестирование на различных значениях A:\n");
        
        Console.WriteLine("A\tКратно 2\tКратно 3\tа) Кратно 2 или 3\tНе кратно 3\tОканч. 0\tб) Не кратно 3 и оканч. 0");
        Console.WriteLine(new string('-', 110));
        
        foreach (int A in testValues)
        {
            bool multipleOf2 = A % 2 == 0;
            bool multipleOf3 = A % 3 == 0;
            bool conditionA = multipleOf2 || multipleOf3;
            bool notMultipleOf3 = A % 3 != 0;
            bool endsWithZero = A % 10 == 0;
            bool conditionB = notMultipleOf3 && endsWithZero;
            
            Console.WriteLine($"{A}\t{multipleOf2}\t\t{multipleOf3}\t\t{conditionA}\t\t{notMultipleOf3}\t\t{endsWithZero}\t\t{conditionB}");
        }
        
        Console.WriteLine("\n\nПодробный анализ условий:");
        AnalyzeConditions();
    }
    
    static void AnalyzeConditions()
    {
        Console.WriteLine("\nа) Целое А кратно двум или трем:");
        Console.WriteLine("   Условие: A % 2 == 0 || A % 3 == 0");
        Console.WriteLine("   Пояснение: Число делится на 2 ИЛИ на 3 без остатка");
        Console.WriteLine("   Примеры: 6 (кратно 2 и 3), 4 (кратно 2), 9 (кратно 3), 7 (не кратно)");
        
        Console.WriteLine("\nб) Целое А не кратно трем и оканчивается нулем:");
        Console.WriteLine("   Условие: A % 3 != 0 && A % 10 == 0");
        Console.WriteLine("   Пояснение: Число НЕ делится на 3 И последняя цифра равна 0");
        Console.WriteLine("   Примеры: 10 (не кратно 3, оканчивается 0), 20, 40, 50");
        Console.WriteLine("   Не подходят: 30 (кратно 3), 15 (не оканчивается 0), 7 (не оканчивается 0)");
    }
}