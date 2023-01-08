// Программа проверяет пятизначное число на палиндромом. 

string FindPolindrom (int num)
{
    if (num/10000 == num%10 & (num/1000)%10 == (num/10)%10) return ("Зажанное число является полиндромом.");
    else return ("Заданное число не является полиндромом.");
}

int num = 22321;

Console.WriteLine(FindPolindrom(num));