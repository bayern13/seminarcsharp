﻿// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

string GetCoordinatesRange(int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0 && y < 0";
    if (num == 4) return "x > 0 && y < 0";
    return null;
}
Console.WriteLine("Введите номер четверти :");
int quarter = Convert.ToInt32(Console.ReadLine());


string getCoordinatesRange = GetCoordinatesRange(quarter);

string result = getCoordinatesRange != null ? $"Заданному номеру четверти соответствует  диапазон {getCoordinatesRange}"
                                         : "Введены неккоректные результаты";
 Console.WriteLine(result);