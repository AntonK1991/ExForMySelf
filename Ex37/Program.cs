// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void RandomFillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 200);
        Console.Write(array[i]+"  ");
    }
}

int FindAmountOfElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] < 99) count += 1;
    }
    return count;
}

int[] list = new int[123];
RandomFillArray(list);
int res = FindAmountOfElements(list);
Console.WriteLine($"Количество искомых элементов - {res}");