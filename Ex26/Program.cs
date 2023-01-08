// Возведите число А в натуральную степень B используя цикл.

int DegreeMethod (int a, int b)
{
    int res = 1; 
    for (int i = 1; i <= b; i++)
    {
        res = res*a;
    }
    return res;
}

int A = 2;
int B = 3; 

int C = DegreeMethod (A,B);
Console.WriteLine(C);