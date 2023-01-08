// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void RandomFillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i]+"  ");
    }
}

int OddCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0) count += 1;
    }
    return count;
}

int EvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count += 1;
    }
    return count;
}

int [] list = new int [6]; 
RandomFillArray (list); 
System.Console.WriteLine();
int odds = OddCount(list); 
int even = EvenCount(list); 
Console.WriteLine($"Количество нечетных элементов - {odds}");
Console.WriteLine($"Количество четных элементов - {even}");