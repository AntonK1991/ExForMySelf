// Дано число. Проверить кратно ли оно 7 и 23

string Method(int a, int b)
{
    if (a % b == 0) return ($"{a} кратно {b}.");
    else return ($"{a} не кратно {b}.");
}

int a = 14;
int b = 7; 
int c = 23; 
Console.WriteLine(Method(a,b));
Console.WriteLine(Method(a,c));