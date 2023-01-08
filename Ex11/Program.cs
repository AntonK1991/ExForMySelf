// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа/ 
int n = 88;

int m = n / 10;
int l = n % 10;
if (m > l) System.Console.WriteLine($"Наибольшая цифра числа - {m}.");
if (l > m) System.Console.WriteLine($"Наибольшая цифра числа - {l}.");
if (m == l) System.Console.WriteLine("Цифры заданного числа равны.");
