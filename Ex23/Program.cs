// Показать таблицу квадратов чисел от 1 до N 

int startNum = 1;
int lastNum = 5;

int[] list = new int[lastNum];
FillArray(list, startNum);
int[] newList = new int[lastNum];
FillNewArray(list, newList);
PrintArraysTable(list, newList);

void FillArray(int[] array, int startNum)
{
    int j = 1;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = j;
        j++;
    }
}

void FillNewArray(int[] array1, int[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array2[i] = array1[i] * array1[i];
    }
}

void PrintArraysTable(int[] array1, int[] array2)
{
    Console.WriteLine($"|  N  |   |  N2 |");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.WriteLine((array1[i] + "\t") + (array2[i] + "\t"));
    }
}