//Определить, присутствует ли в заданном массиве, некоторое число 

bool FindNum(int[] array, int n, int startIndex)
{
    if (startIndex == array.Length) return false;
    if (array[startIndex] == n) return true;
    else
    {
        startIndex += 1;
        return FindNum(array, n, startIndex);
    }
}
    int[] list = { 1, 3, 5, 7, 9 };
    int num = 2;
    if (FindNum(list, num, 0)==true) Console.WriteLine("Заданное число встречается в массиве");
    else System.Console.WriteLine("Заданное число в массиве не встречается");
