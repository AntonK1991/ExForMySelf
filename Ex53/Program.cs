// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

int x = 5;
int n = 3;
int m = 3;
int[,] list = new int[n, m];
int firstElement = 1;
Fill2DArray(list, firstElement);
FindElementIndex(list, x);

void Fill2DArray(int[,] array, int startNum)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            array[i, k] = startNum;
            startNum++;
        }
    }
}

void FindElementIndex(int[,] array, int findNum)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            if (array[i, k] == findNum)
            {
                Console.WriteLine($"Индексы искомого элемента [{i},{k}]");
                count ++; 
            }
        }
    }
    if (count == 0) Console.WriteLine("Искомого элемента нет");;
}