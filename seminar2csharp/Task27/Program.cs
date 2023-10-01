int Length(int num)
{   
    int index = 0;
    while (num > 0)
    {
        num /= 10;
        index++;
    }
    return index;
    
}

int SumDigits(int num, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += num%10;
        num /= 10;
    }
    return sum;
}


Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
int len = Length(number); 
Console.WriteLine($"Сумма цифр числа{number} -> {SumDigits(number,len)}");