// Написать программу преобразования десятичного числа в двоичное

int Input(string data)
{
    Console.WriteLine(data);
    int result = Convert.ToInt32(Console.ReadLine());
    if (result >= 0) return result;
    else return Input("Значение должно быть равным или больше 0");
}

int CountNum(int num)
{
    int count = 1;
    while (num / 2 > 0)
    {
        num = num / 2;
        count++;
        if (num / 2 == 0)
        {
            break;
            count = count + 1;
        }
    }
    return count;
}

int[] ConvertNum(int[] array, int num, int count)
{
    for (int i = count; i >= 0; i--)
    {
        if (num % 2 == 0) array[i] = 0;
        else array[i] = 1;
        num = num / 2;
    }
    return array;
}

int num1 = Input("Введите число в десятичной системе:");
int length = CountNum(num1);
int[] list = new int[length];
ConvertNum(list, num1, length - 1);
Console.WriteLine("Заданное число в двоичной системе:");
for (int i = 0; i < list.Length; i++)
{
    Console.Write($"{list[i]} ");
}