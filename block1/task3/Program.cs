Console.Write("Введите своё родное число: ");
String inputString = Console.ReadLine();
int myNumber;
Int32.TryParse(inputString, out myNumber);
Console.WriteLine("Вы ввели число: ");
Console.WriteLine(myNumber);