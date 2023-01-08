﻿// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// Если у точки обе координаты (x и y) положительны, то она принадлежит первой четверти.
// Если координата x отрицательна, а y положительна, то точка находится во второй четверти.
// Если обе координаты отрицательны, то точка принадлежит третьей координатной четверти.
// Если x положительна, а y отрицательна, то точка находится в IV четверти.

void FindQuadrant(double x, double y)
{
    if (x > 0 & y > 0) System.Console.WriteLine("Точка находится в первой четверти.");
    else if (x < 0 & y > 0) System.Console.WriteLine("Точка находится во второй четверти.");
    else if (x < 0 & y < 0) System.Console.WriteLine("Точка находится в третьей четверти.");
    else if (x > 0 & y < 0) System.Console.WriteLine("Точка находится в четвертой четверти.");
}

double x = -1.5;
double y = -1.5;
FindQuadrant(x, y);

// string FindQuadrant(double x, double y)
// {
//     if (x > 0 | y > 0) return "Точка находится в первой четверти.";
//     if (x < 0 | y > 0) return "Точка находится во второй четверти.";
//     if (x < 0 | y < 0) return "Точка находится в третьей четверти.";
//     if (x > 0 | y < 0) return "Точка находится в четвертой четверти.";
// }

// double x = 1.5;
// double y = 1.5;
// System.Console.WriteLine(FindQuadrant(x, y));