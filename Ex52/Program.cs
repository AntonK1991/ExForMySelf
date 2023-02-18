// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            if (i % 2 == 0 & k % 2 == 0) array [i,k] *= array[i,k];
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
int firstElement = 1;
Fill2DArray (list, firstElement); 
ChangeElements (list); 
Print2DArray (list); 
