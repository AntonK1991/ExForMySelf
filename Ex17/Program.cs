// По двум заданным числам проверять является ли одно квадратом другого. 

int a = 16;
int b = 4; 
Console.WriteLine(SqrtMethod (a,b));

string SqrtMethod( int a, int b)
{
    if (a==b*b) return ($"{a} является квадратом {b}"); 
    else return ($"{a} не является квадратом {b}");
}
