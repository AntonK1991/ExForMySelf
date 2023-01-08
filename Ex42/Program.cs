// Определить сколько чисел больше 0 введено с клавиатуры

// Console.WriteLine("Ведите числа через пробел");
// string str = Console.ReadLine();
// char[] input = str.ToCharArray();
//     for (int i = 0; i < input.Length; i++)
//     {
//         Console.WriteLine($"/{input[i]}");
//     }
// // int count = 0;
// int index = 0;
// int [] array = new int [input.Length];
// for (int i = 0; i < input.Length; i++)
// {

//     if (input[i] >=0||input[i]<=0) array[i] = Convert.ToInt32(input[i]);
//     else array[i] = 0;
//     System.Console.WriteLine(array[i]);
// }

// Console.WriteLine($"/{input[i]}");
// input[i] == "-,1,2,3,4,5,6,7,8,9,0"

Console.Write("Введите элементы(через пробел): ");
if (Console.ReadLine() == string.Empty) System.Console.WriteLine("Значения не заданы. Начните сначала");
else
{
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }

    Console.WriteLine($"Кол-во элементов > 0: {count}");
}