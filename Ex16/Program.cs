// Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

string[] WeekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
int input = 7;
string output = FindWeekDay(WeekDays, input, 0);
if (input < 6) Console.WriteLine($"{output} - рабочий день.");
else Console.WriteLine($"{output} - выходной день");

string FindWeekDay(string[] array, int n, int i)
{
    string res = string.Empty;
    if (i == n - 1)
    {
        res = array[i];
        return res;
    }
    else return FindWeekDay(array, n, i + 1);
}
