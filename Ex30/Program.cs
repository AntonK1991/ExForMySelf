// Показать кубы чисел, заканчивающихся на четную цифру

int start = 2;
int end = 12;
int step = 3;
int[] list = new int[end-start+1];
FillArray(start, list); 
FindCube(list, start, step);

int [] FillArray(int start, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = start;
        start++;
    }
    return array;
}

void FindCube(int []array, int startNum, int stepen)
{
    for (int i = 0; i < array.Length; i++)
    {
        if ((array [i]%10)%2 == 0) 
        Console.WriteLine($"{array[i]} в степени {stepen} - {Convert.ToInt32(Math.Pow(array [i], stepen))}"); 
    }
}

