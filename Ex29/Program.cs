// Написать программу вычисления произведения чисел от 1 до N

int start = 1;
Console.Write("Введите конечное значение диапазона чисел: ");
int end = Convert.ToInt32(Console.ReadLine ());
int [] list = new int [end];
FillArray (start, list);
int result = FindMult(list);
Console.WriteLine($"Произведение чисел от {start} до {end}: {result}");

int [] FillArray (int start, int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= start;
        start++;
    }
    return array;
}

int FindMult (int [] array)
{
    int res = 1; 
    for (int i = 0; i < array.Length; i++)
    {
        res = res * array[i];
    }
    return res;
}

