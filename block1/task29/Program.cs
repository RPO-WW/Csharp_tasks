int number = 123;
int digit1 = number / 100;
int digit2 = (number / 10) % 10;
int digit3 = number % 10;

long square = (long)number * number; 
long sumOfCubes = (long)Math.Pow(digit1, 3) + Math.Pow(digit2, 3) + Math.Pow(digit3, 3);

if (square == sumOfCubes)
{
    Console.WriteLine($"Квадрат числа {number} равен сумме кубов его цифр.");
}
else
{
    Console.WriteLine($"Квадрат числа {number} НЕ равен сумме кубов его цифр.");
}
