Console.Write("Ввдеите трёхзначное число: ");
int originalNumber = Convert.ToInt32(Console.ReadLine());

int lastDigit = originalNumber % 10;
int firstDigit = originalNumber / 100;
int middleDigit = (originalNumber / 10) % 10;

int newNumber = lastDigit * 100 + firstDigit * 10 + middleDigit; 

Console.WriteLine($"Исходное число: {originalNumber}");
Console.WriteLine($"Полученное число: {newNumber}"); 
