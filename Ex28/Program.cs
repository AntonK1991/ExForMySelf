// Подсчитать сумму цифр в числе

int FindDigitAmount(int a)
{
    int summ = 0;
    int res = 0;
    while (a > 0)
    {
        res = a % 10;
        summ = summ + res;
        a = a / 10;
    }
    return summ;
}

int a = 128;
int result = FindDigitAmount(a);
Console.WriteLine($"Сумма цифр в числе: {result}");