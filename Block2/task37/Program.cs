Console.Write("Введите k (1 <= k <= 180): ");
int k = int.Parse(Console.ReadLine());
int pairNumber = FindPairNumber(k);
Console.WriteLine($"а) Номер пары цифр: {pairNumber}");
int twoDigitNumber = FindTwoDigitNumber(k);
Console.WriteLine($"б) Двузначное число: {twoDigitNumber}");

Console.WriteLine($"в) k-я цифра:");
Console.WriteLine($"   Если k четное: {FindKthDigitEven(k)}");
Console.WriteLine($"   Если k нечетное: {FindKthDigitOdd(k)}");

    static int FindPairNumber(int k)
    {
        return (k + 1) / 2;
    }
    static int FindTwoDigitNumber(int k)
    {
        int pairNumber = FindPairNumber(k);
        return 9 + pairNumber;
    }
    static int FindKthDigitEven(int k)
    {
        int twoDigitNumber = FindTwoDigitNumber(k);
        return twoDigitNumber % 10;
    }
    static int FindKthDigitOdd(int k)
    {
        int twoDigitNumber = FindTwoDigitNumber(k);
        return twoDigitNumber / 10;
    }