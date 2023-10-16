// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.


int SumOfNaturalNumbers(int m, int n)
{
    if (m == n) return m;
    return m + SumOfNaturalNumbers(m + 1, n);

}
Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());


Console.WriteLine(SumOfNaturalNumbers(m, n));
