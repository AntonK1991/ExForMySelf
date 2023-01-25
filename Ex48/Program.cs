// Показать двумерный массив размером m×n заполненный целыми числами


void RandomFill2DArray(int[,] array)
{
    // int length= array.GetLength(0)*array.GetLength(1); 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }

    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("\t{0}", array[i, j]);
        }
        Console.WriteLine();
    }
}

int m = 3;
int n = 3;
int[,] list = new int[m, n];
RandomFill2DArray(list);
PrintArray(list);