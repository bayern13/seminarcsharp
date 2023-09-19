Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int even = 2;

while (number >= even)
{
    Console.Write(even + " ");
    even = even + 2;
}