using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ВЫЧИСЛЕНИЕ ЗНАЧЕНИЙ ЛОГИЧЕСКИХ ВЫРАЖЕНИЙ");
        Console.WriteLine("=========================================\n");

        double x_a = 1, y_a = -1;
        bool result_a = Math.Pow(x_a, 2) + Math.Pow(y_a, 2) <= 4;
        Console.WriteLine($"а) x² + y² ≤ 4 при x = {x_a}, y = {y_a}");
        Console.WriteLine($"   {x_a}² + ({y_a})² = {Math.Pow(x_a, 2)} + {Math.Pow(y_a, 2)} = {Math.Pow(x_a, 2) + Math.Pow(y_a, 2)} ≤ 4 : {result_a}\n");

        double x_b = 1, y_b = 2;
        bool condition1_b = x_b >= 0;
        bool condition2_b = Math.Pow(y_b, 2) != 4;
        bool result_b = condition1_b || condition2_b;
        Console.WriteLine($"б) (x ≥ 0) или (y² ≠ 4) при x = {x_b}, y = {y_b}");
        Console.WriteLine($"   {x_b} ≥ 0 : {condition1_b}");
        Console.WriteLine($"   {y_b}² ≠ 4 : {Math.Pow(y_b, 2)} ≠ 4 : {condition2_b}");
        Console.WriteLine($"   {condition1_b} ИЛИ {condition2_b} : {result_b}\n");

        double x_c = 1, y_c = 2;
        bool condition1_c = x_c >= 0;
        bool condition2_c = Math.Pow(y_c, 2) != 4;
        bool result_c = condition1_c && condition2_c;
        Console.WriteLine($"в) (x ≥ 0) и (y² ≠ 4) при x = {x_c}, y = {y_c}");
        Console.WriteLine($"   {x_c} ≥ 0 : {condition1_c}");
        Console.WriteLine($"   {y_c}² ≠ 4 : {Math.Pow(y_c, 2)} ≠ 4 : {condition2_c}");
        Console.WriteLine($"   {condition1_c} И {condition2_c} : {result_c}\n");

        double x_d = 2, y_d = 1;
        bool condition1_d = x_d * y_d != 0;
        bool condition2_d = y_d > x_d;
        bool result_d = condition1_d && condition2_d;
        Console.WriteLine($"г) (x·y ≠ 0) и (y > x) при x = {x_d}, y = {y_d}");
        Console.WriteLine($"   {x_d}·{y_d} ≠ 0 : {x_d * y_d} ≠ 0 : {condition1_d}");
        Console.WriteLine($"   {y_d} > {x_d} : {condition2_d}");
        Console.WriteLine($"   {condition1_d} И {condition2_d} : {result_d}\n");

        double x_e = 2, y_e = 1;
        bool condition1_e = x_e * y_e != 0;
        bool condition2_e = y_e < x_e;
        bool result_e = condition1_e || condition2_e;
        Console.WriteLine($"д) (x·y ≠ 0) или (y < x) при x = {x_e}, y = {y_e}");
        Console.WriteLine($"   {x_e}·{y_e} ≠ 0 : {x_e * y_e} ≠ 0 : {condition1_e}");
        Console.WriteLine($"   {y_e} < {x_e} : {condition2_e}");
        Console.WriteLine($"   {condition1_e} ИЛИ {condition2_e} : {result_e}\n");

        double x_f = 2, y_f = 1;
        bool condition1_f = !(x_f * y_f < 0);
        bool condition2_f = y_f > x_f;
        bool result_f = condition1_f && condition2_f;
        Console.WriteLine($"е) (не (x·y < 0)) и (y > x) при x = {x_f}, y = {y_f}");
        Console.WriteLine($"   не({x_f}·{y_f} < 0) : не({x_f * y_f} < 0) : {condition1_f}");
        Console.WriteLine($"   {y_f} > {x_f} : {condition2_f}");
        Console.WriteLine($"   {condition1_f} И {condition2_f} : {result_f}\n");

        double x_g = 1, y_g = 2;
        bool condition1_g = !(x_g * y_g < 0);
        bool condition2_g = y_g > x_g;
        bool result_g = condition1_g || condition2_g;
        Console.WriteLine($"ж) (не (x·y < 0)) или (y > x) при x = {x_g}, y = {y_g}");
        Console.WriteLine($"   не({x_g}·{y_g} < 0) : не({x_g * y_g} < 0) : {condition1_g}");
        Console.WriteLine($"   {y_g} > {x_g} : {condition2_g}");
        Console.WriteLine($"   {condition1_g} ИЛИ {condition2_g} : {result_g}\n");

        Console.WriteLine("ИТОГОВЫЕ РЕЗУЛЬТАТЫ:");
        Console.WriteLine("====================");
        Console.WriteLine($"а) {result_a}");
        Console.WriteLine($"б) {result_b}");
        Console.WriteLine($"в) {result_c}");
        Console.WriteLine($"г) {result_d}");
        Console.WriteLine($"д) {result_e}");
        Console.WriteLine($"е) {result_f}");
        Console.WriteLine($"ж) {result_g}");
    }
}