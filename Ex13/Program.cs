// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int n = 2;
int m = 9; 
int x = m%n;
if (m%n==0) System.Console.WriteLine("Второе число кратно заданному.");
else System.Console.WriteLine($"Остаток от деления = {x}.");