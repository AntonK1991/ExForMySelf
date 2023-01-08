// Задать массив из 8 элементов и вывести их на экран 

int  [] array = {8,13,15,56,845,84,46,45};
int start = 0;
Print (array, start);

int Print (int [] array, int startNum)
{
    if (startNum > array.Length-1) return 0;
    else Console.WriteLine(array [startNum]);
    return Print (array, startNum+1);
}