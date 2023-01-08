// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

void FillArrayByUser(int[] array, string data)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(data);
        int input = Convert.ToInt32(Console.ReadLine());
        if (input < 0 || input > 9)
        {
            Console.WriteLine("Значение должно быть от 0 до 9. Повторите ввод!");
            i--;
        }
        else array[i] = input;
    }
}

int FindSumm(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        summ = summ + array[i];
    }
    return summ;
}

int length = 12;
int[] list = new int[length];
FillArrayByUser(list, $"Введите элемент массива");
int res = FindSumm(list);
Console.WriteLine($"Сумма элементов массива: {res}");
