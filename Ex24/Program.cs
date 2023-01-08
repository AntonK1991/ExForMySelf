// Найти кубы чисел от 1 до N



void FillArray (int [] array, int start) 
{ 
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = start; 
        Console.Write($" {array[i]}");
        start+=1;
    }
}

int FindCube (int [] array, int start)
{
    
    if (start == array.Length) return 0; 
    else 
    {
        Console.Write($" {array[start]*array[start]*array[start]}");
        return FindCube (array, start+1);
    }
} 

int startNum = 1;
int length = 5;

int[] list = new int[length];
Console.Write("Заданы nums:");
FillArray (list, startNum);
Console.WriteLine();
Console.Write("Кубы чисел:");
FindCube (list, 0);
