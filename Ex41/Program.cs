// Выяснить являются ли три числа сторонами треугольника

bool Triangle(int a, int b, int c)
{
    bool Result = true;
    if (a + b < c && Result) Result = false;
    if (b + c < a && Result) Result = false;
    if (a + c < b && Result) Result = false;
    return Result;
}

bool res = Triangle(2, 4, 5);
if (res == true) Console.WriteLine("Числа являются сторонами треугольника");
else Console.WriteLine("Числа не являются сторонами треугольника");