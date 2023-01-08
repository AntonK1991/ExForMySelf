// По заданному номеру дня недели вывести его название

string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
Console.WriteLine("Введите значение от 1 до 7: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a <= 0 || a > 7) System.Console.WriteLine("Значение должно быть больше 0 и меньше 7.");
else 
{
    int b = a-1;
    Console.WriteLine($"День недели - {weekDays[b]}.");
}
