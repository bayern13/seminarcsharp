﻿

Console.WriteLine("Введите первое число : ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число : ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3)
    Console.Write($"max = {number1}");
else if (number2 > number1 && number2 > number3)
Console.Write($"max = {number2}");
else 
Console.Write($"max = {number3}");