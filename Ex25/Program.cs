// Найти сумму чисел от 1 до А. 

int startNum = 1; 
int A = 15; 
int [] list = new int [A];
int startSumm = 0;
int startCount = 0; 
FillArray(list, startNum);
Console.WriteLine(SummElements(list, startSumm, startCount));


void FillArray (int [] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=num;
        num++; 
    }
}

int SummElements (int [] array, int summ, int i)
{
    if (i == array.Length) return summ; 
    else
    {
        summ = summ + array [i];
        return SummElements(array, summ, i+1);
    }
}