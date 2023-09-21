// // 11. Напишите программу, которая выводит случайное
// // трёхзначное число и удаляет вторую цифру этого
// // числа.
// // 456 -> 46
// // 782 -> 72
// // 918 -> 98
// int deleteSecondDigit(int num)
// {
//     int firstDigit = num / 100; // 78 / 10 = 7
//     int thirdDigit = num % 10; // 78 % 10 = 8
//     int result = firstDigit * 10 + thirdDigit;
//     return result;
// }
// int deleteSecondDigit = deleteSecondDigit(number);

// int number = new Random().Next(100, 1000);
// // Console.WriteLine($"Случайное число из отрезка [10, 99] -> {number}");
// // int firstDigit = number / 100;
// // int thirdDigit = number % 10;

// // int result = firstDigit * 10 + thirdDigit;
//Console.WriteLine($"{number} -> {deleteSecondDigit}");

int number = new Random().Next(100, 1000);

int deleteSecondDigit = DeleteSecondDigit(number);
Console.WriteLine($"{number} -> {deleteSecondDigit}");

int DeleteSecondDigit(int num)
{
  int firstDigit = num / 100;
  int lastDigit = num % 10;
  int numResult = firstDigit * 10 + lastDigit;
  return numResult;
}