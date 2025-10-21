Console.WriteLine("Введите натуральное число n (n > 999):");
int n = int.Parse(Console.ReadLine());

if (n > 999) {
    int sto = n / 100;
    Console.WriteLine($"а) Число сотен: {sto}");
    int tys = n / 1000;
    Console.WriteLine($"б) Число тысяч: {tys}");
}
else{
    Console.WriteLine("Число должно быть больше 999");
}