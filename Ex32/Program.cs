// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FillArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(0,2); 
    }
}

void Print (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

int length = 8; 
int [] list = new int [length];
FillArray (list);
Print (list);