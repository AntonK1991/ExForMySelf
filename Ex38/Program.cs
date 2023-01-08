// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int SummElements(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) summ = summ + array[i];
    }
    return summ;
}

int[] list = { 1, 3, 5, 3};
int res = SummElements(list);
Console.WriteLine($"Сумма элементов - {res}");