// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

void MultiplePairedElements (int[] array)
{
    int count =0;
    int mult = 0; 
    int endIndex = array.Length-1; 
    for (int startIndex = 0; startIndex < array.Length/2; startIndex++)
    {
        count++;
        mult = array[startIndex] * array[endIndex];
        endIndex--; 
        Console.WriteLine($"Произведение {count}-й пары - {mult}.");
    }
}

int [] list = {1,2,3,4,5,6};
MultiplePairedElements (list);
