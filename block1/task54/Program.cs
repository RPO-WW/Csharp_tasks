using Microsoft.Win32.SafeHandles;

Console.Write("Введите возраст мальчика: ");
int age_boy = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите возраст девочки: ");
int age_girl = Convert.ToInt32(Console.ReadLine());

int sr = (age_boy + age_girl) / 2;
int sr_age_boy = Math.Abs(sr - age_boy);
int sr_age_girl = Math.Abs(sr - age_girl);

Console.WriteLine($"Средний возраст: {sr}");
Console.WriteLine($"Отличие от среднего возраста мальчика: {sr_age_boy}");
Console.WriteLine($"Отличие от среднего возраста девочки: {sr_age_girl}");
