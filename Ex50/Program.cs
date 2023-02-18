// В двумерном массиве n×k заменить четные элементы на противоположные


void Fill2DArray(int[,] array, int startNum)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            array[i, k] = startNum;
            startNum++;
        }
    }
}

void ChangeElements(int[,] array)
{
    int length = array.GetLength(0) * array.GetLength(1);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            if (array[i, k] % 2 == 0) array[i, k] *= -1;
        }
    }
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write(array[i, k] + "\t");
        }
        Console.WriteLine();
    }

}


int n = 3;
int k = 3;
int[,] list = new int[n, k];
Fill2DArray(list, 1);
ChangeElements(list);
Print2DArray(list);