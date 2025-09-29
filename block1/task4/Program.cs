Console.WriteLine("Введите число: ");
String inputString = Console.ReadLine();
int myNumber;
Int32.TryParse(inputString, out myNumber);
Console.WriteLine(myNumber);
Console.WriteLine("вот какое число.Вы ввели");