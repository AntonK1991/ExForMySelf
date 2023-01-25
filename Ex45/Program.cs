// Показать числа Фибоначчи
// Fn = Fn − 1 + Fn − 2 

int Amount(string data)
{
    Console.WriteLine(data);
    return Convert.ToInt32(Console.ReadLine());
}

void FillFibArray(int[] array)
{
    array[0] = 0;
    array[1] = 1;
    int length = array.Length;
    for (int i = 2; i < length; i++)
    {
        array[i] = (array[i-1]) + (array[i-2]);
    }
}


int length = Amount("Сколько чисел Фибоначчи Вы хотите увидеть?");
int[] list = new int[length];
FillFibArray(list);
for (int i = 0; i < list.Length; i++)
{
    Console.WriteLine(list[i]);
}

