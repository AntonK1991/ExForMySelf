// Показать двумерный массив размером m×n заполненный вещественными числами

void RandomFill2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) + new Random().NextDouble();
        }
    }
}

void PrintArray(double[,] array)
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
double[,] list = new double[m, n];
RandomFill2DArray(list);
PrintArray(list);