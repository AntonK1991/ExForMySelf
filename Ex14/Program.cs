// Найти третью цифру числа или сообщить, что её нет. 

int n = -158;
if (n / 100 == 0) System.Console.WriteLine("Третьей цифры нет.");
else
{
    int count = FindDigitAmount(n);
    int result = FindThirdDigit(count, n);
    System.Console.WriteLine(result);
}

int FindDigitAmount(int n)
{
    int count = 0;
    while (n > 0)
    {
        n = n / 10;
        count++;
    }
    return count;
}
int FindThirdDigit(int count, int n)
{
    if (count == 3) return n % 10;
    if (count > 3)
    {
        for (int i = 0; i < count - 3; i++) n = n / 10;
    }
    return n % 10;
}
