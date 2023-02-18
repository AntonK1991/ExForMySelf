// Задать двумерный массив следующим правилом: Aₘₙ = m+n

// int[,] list = new int[3, 3];

// Fill2DArray(list);
// Print2DArray(list);

// void Fill2DArray(int[,] array)
// {
//     int num = 1;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             Console.WriteLine($"Enter {num} element");
//             array[i, k] = Convert.ToInt32(Console.ReadLine());
//             num++;
//         }
//     }

// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             Console.Write(array[i, k] + "\t");
//         }
//         Console.WriteLine();
//     }

// }

int[,] a = new int[10, 10];
for (int i = 0; i < 10; i++)
    for (int j = 0; j < 10; j++)
        a[i, j] = (i + j) % 10 + 1;

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
        Console.Write(a[i, j] + " ");
    Console.WriteLine();
}
Console.ReadLine();