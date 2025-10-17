using System;

class Program
{
    static void Main()
    {
        double a = 2.5;
        
        Console.WriteLine($"Исходное число a = {a}");
        Console.WriteLine();
        

        Console.WriteLine("а) 3a и 10a за четыре операции:");
        double a2 = a * a;
        double a3 = a2 * a;
        double a5 = a2 * a3;
        double a10 = a5 * a5;
        double result3a = a3;
        double result10a = a10;
        Console.WriteLine($"3a = {result3a}, 10a = {result10a}");
        

        Console.WriteLine("\nб) 4a и 20a за пять операций:");
        a2 = a * a;
        double a4 = a2 * a2;
        double a8 = a4 * a4;
        double a16 = a8 * a8;
        double a20 = a16 * a4;
        double result4a = a4;
        double result20a = a20;
        Console.WriteLine($"4a = {result4a}, 20a = {result20a}");
        
        Console.WriteLine("\nв) 5a и 13a за пять операций:");
        a2 = a * a;
        double a4_v = a2 * a2;
        double a5_v = a4_v * a;
        double a8_v = a4_v * a4_v;
        double a13 = a8_v * a5_v;
        double result5a = a5_v;
        double result13a = a13;
        Console.WriteLine($"5a = {result5a}, 13a = {result13a}");
        

        Console.WriteLine("\nг) 5a и 19a за пять операций:");
        a2 = a * a;
        double a4_g = a2 * a2;
        double a5_g = a4_g * a;
        double a10_g = a5_g * a5_g;
        double a19 = a10_g * a5_g * a4_g;
        double result5a_g = a5_g;
        double result19a = a19;
        Console.WriteLine($"5a = {result5a_g}, 19a = {result19a}");
        

        Console.WriteLine("\nд) 2a, 5a и 17a за шесть операций:");
        a2 = a * a;
        double a4_d = a2 * a2;
        double a5_d = a4_d * a;
        double a8_d = a4_d * a4_d;
        double a10_d = a5_d * a5_d;
        double a17 = a10_d * a5_d * a2;
        double result2a = a2;
        double result5a_d = a5_d;
        double result17a = a17;
        Console.WriteLine($"2a = {result2a}, 5a = {result5a_d}, 17a = {result17a}");
        

        Console.WriteLine("\nе) 4a, 12a и 28a за шесть операций:");
        a2 = a * a;
        double a4_e = a2 * a2;
        double a8_e = a4_e * a4_e;
        double a12 = a8_e * a4_e;
        double a16_e = a8_e * a8_e;
        double a28 = a16_e * a12;
        double result4a_e = a4_e;
        double result12a = a12;
        double result28a = a28;
        Console.WriteLine($"4a = {result4a_e}, 12a = {result12a}, 28a = {result28a}");
        

        Console.WriteLine("\n--- Проверка для a = 1 ---");
        a = 1;
        

        a2 = a * a;
        a3 = a2 * a;
        a5 = a2 * a3;
        a10 = a5 * a5;
        Console.WriteLine($"а) 3a = {a3}, 10a = {a10}");
        

        a2 = a * a;
        a4 = a2 * a2;
        a8 = a4 * a4;
        a16 = a8 * a8;
        a20 = a16 * a4;
        Console.WriteLine($"б) 4a = {a4}, 20a = {a20}");
        

        a2 = a * a;
        a4_v = a2 * a2;
        a5_v = a4_v * a;
        a8_v = a4_v * a4_v;
        a13 = a8_v * a5_v;
        Console.WriteLine($"в) 5a = {a5_v}, 13a = {a13}");
        

        a2 = a * a;
        a4_g = a2 * a2;
        a5_g = a4_g * a;
        a10_g = a5_g * a5_g;
        a19 = a10_g * a5_g * a4_g;
        Console.WriteLine($"г) 5a = {a5_g}, 19a = {a19}");
        
 
        a2 = a * a;
        a4_d = a2 * a2;
        a5_d = a4_d * a;
        a8_d = a4_d * a4_d;
        a10_d = a5_d * a5_d;
        a17 = a10_d * a5_d * a2;
        Console.WriteLine($"д) 2a = {a2}, 5a = {a5_d}, 17a = {a17}");
        

        a2 = a * a;
        a4_e = a2 * a2;
        a8_e = a4_e * a4_e;
        a12 = a8_e * a4_e;
        a16_e = a8_e * a8_e;
        a28 = a16_e * a12;
        Console.WriteLine($"е) 4a = {a4_e}, 12a = {a12}, 28a = {a28}");
    }
}