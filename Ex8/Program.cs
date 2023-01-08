// Показать четные числа от 1 до N
int m = 1; 
int N = 15;
int[] list = new int[N];
for (int i = 0; i < list.Length; i++)
{
    list[i] = m;
    if (list[i] % 2 != 0) Console.Write($"{list[i]} ");
    m++;
}
System.Console.WriteLine();