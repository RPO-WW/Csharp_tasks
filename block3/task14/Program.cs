using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ВЫЧИСЛЕНИЕ ЗНАЧЕНИЙ ЛОГИЧЕСКИХ ВЫРАЖЕНИЙ");
        Console.WriteLine("=========================================\n");

        // Создаем таблицу истинности для всех комбинаций X и Y
        bool[] values = { false, true };

        Console.WriteLine("Таблица истинности:");
        Console.WriteLine("===================");
        Console.WriteLine("|  X  |  Y  | не (X или Y) | не X и Y | X и не Y |");
        Console.WriteLine("|-----|-----|--------------|----------|----------|");

        foreach (bool X in values)
        {
            foreach (bool Y in values)
            {
                // а) не (X или Y)
                bool result_a = !(X || Y);

                // б) не X и Y
                bool result_b = !X && Y;

                // в) X и не Y
                bool result_c = X && !Y;

                Console.WriteLine($"| {X,4} | {Y,4} | {result_a,12} | {result_b,8} | {result_c,8} |");
            }
        }

        // Подробный разбор для каждой комбинации
        Console.WriteLine("\nПОДРОБНЫЙ РАЗБОР:");
        Console.WriteLine("=================\n");

        int caseNumber = 1;
        foreach (bool X in values)
        {
            foreach (bool Y in values)
            {
                Console.WriteLine($"Случай {caseNumber}: X = {X}, Y = {Y}");
                Console.WriteLine("----------------------------------------");

                // а) не (X или Y)
                bool X_or_Y = X || Y;
                bool not_X_or_Y = !X_or_Y;
                Console.WriteLine($"а) не (X или Y):");
                Console.WriteLine($"   X или Y = {X} ИЛИ {Y} = {X_or_Y}");
                Console.WriteLine($"   не ({X_or_Y}) = {not_X_or_Y}");

                // б) не X и Y
                bool not_X = !X;
                bool not_X_and_Y = not_X && Y;
                Console.WriteLine($"б) не X и Y:");
                Console.WriteLine($"   не X = не {X} = {not_X}");
                Console.WriteLine($"   не X и Y = {not_X} И {Y} = {not_X_and_Y}");

                // в) X и не Y
                bool not_Y = !Y;
                bool X_and_not_Y = X && not_Y;
                Console.WriteLine($"в) X и не Y:");
                Console.WriteLine($"   не Y = не {Y} = {not_Y}");
                Console.WriteLine($"   X и не Y = {X} И {not_Y} = {X_and_not_Y}");

                Console.WriteLine();
                caseNumber++;
            }
        }

        // Анализ эквивалентности выражений
        Console.WriteLine("АНАЛИЗ ЭКВИВАЛЕНТНОСТИ:");
        Console.WriteLine("=======================");

        bool allEquivalent = true;
        foreach (bool X in values)
        {
            foreach (bool Y in values)
            {
                bool result_a = !(X || Y);
                bool result_b = !X && Y;
                bool result_c = X && !Y;

                // Проверяем, все ли выражения эквивалентны
                if (result_a != result_b || result_b != result_c)
                {
                    allEquivalent = false;
                }
            }
        }

        if (allEquivalent)
        {
            Console.WriteLine("Все три выражения эквивалентны для всех значений X и Y");
        }
        else
        {
            Console.WriteLine("Выражения не эквивалентны для всех значений X и Y");

            // Проверяем конкретные эквивалентности
            Console.WriteLine("\nПроверка законов де Моргана:");
            bool deMorganHolds = true;
            foreach (bool X in values)
            {
                foreach (bool Y in values)
                {
                    bool left = !(X || Y);
                    bool right = !X && !Y;  // Правильный закон де Моргана
                    if (left != right)
                    {
                        deMorganHolds = false;
                    }
                }
            }

            if (deMorganHolds)
            {
                Console.WriteLine("не (X или Y) ≡ не X и не Y - ВЕРНО (закон де Моргана)");
            }
        }
    }
}
