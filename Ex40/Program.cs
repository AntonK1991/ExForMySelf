// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double FindMin(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]<max) max = array[i]; 
    }
    return max;
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]>max) max = array[i]; 
    }
    return max;
} 

double [] list = {0.2,1.3,-0.5,3.4,-5.4,-1.7};
double min = FindMin(list);
double max = FindMax(list);
Console.WriteLine($"min = {min}");
Console.WriteLine($"max = {max}");
double res = max - min;
Console.WriteLine($"Разница между минимальными и максимальным значением - {res}");