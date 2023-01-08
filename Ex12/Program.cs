// Удалить вторую цифру трёхзначного числа

int n = 486; 
int m = n/100; 
int l = (n%100)%10; 

System.Console.WriteLine($"{m} {l}");