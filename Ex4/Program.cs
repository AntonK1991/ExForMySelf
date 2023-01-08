// Найти максимальное из трех чисел. 

int a = 15;
int b = 38;
int c = 3;
int max = a;

int[] list = { a, b, c };
for (int i = 0; i < list.Length; i++)
{
    if (list[i] > max) max = list[i];
}
System.Console.WriteLine($"Наибольшее число - {max}.");