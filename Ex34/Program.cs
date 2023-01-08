// Написать программу замену элементов массива на противоположные

void ElementChange(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}

int[] list = { 0, 1, 2, 3, -2, -3, -4 };
ElementChange(list);
for (int i = 0; i < list.Length; i++)
{
    Console.WriteLine(list[i]);
}