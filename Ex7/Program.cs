// Показать числа от -N до N

int CountElements (int n, int m)
{
    int count=0;
    for (int i = n; i < m+1; i++)
    {
        count++;
    }
    return count;
}

int [] FillArray (int[] array, int n, int m, int l)
{
    array[l] = n; 
    if (n == m) return array; 
    else return FillArray(array, n+1, m, l+1); 
}

System.Console.WriteLine("Введите начальное значение.");
int startNum = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("Введите конечное значение.");
int endNum = Convert.ToInt32(Console.ReadLine()); 
int [] list = new int [CountElements(startNum, endNum)]; 
FillArray(list, startNum, endNum, 0);
System.Console.WriteLine("Числа в заданном диапазоне.");

for (int i = 0; i < list.Length; i++)
{
    System.Console.Write($" {list[i]} ");
}
System.Console.WriteLine();