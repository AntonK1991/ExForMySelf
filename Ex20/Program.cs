// Задать номер четверти, показать диапазоны для возможных координат. 

int quadrantNum = 5;

string FindQouadrant(int num)
{
    if (num == 1) return ($"Диапазон координат: X >= 0, Y >= 0");
    else if (num == 2) return ($"Диапазон координат: X <= 0,  Y >= 0");
    else if (num == 3) return ($"Диапазон координат: X <= 0, Y <= 0");
    else if (num == 4) return ($"Диапазон координат: X >= 0, Y <= 0");
    else return ($"Такой четверти нет!");
}
System.Console.WriteLine(FindQouadrant(quadrantNum));