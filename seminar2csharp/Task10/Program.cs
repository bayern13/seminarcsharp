// Напишите программу, 
// которая принимает на вход 
// трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число : ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int deleteDigits = DeleteDigits(secondNumber);
Console.WriteLine($"{secondNumber} -> {deleteDigits}");

int DeleteDigits(int num)
{
    int findSecondDigit = num / 10;
    return findSecondDigit % 10;

}