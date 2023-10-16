// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackerman(m - 1, 1);
        }
        else
        {
            return Ackerman(m - 1, Ackerman(m, n - 1));
        }
    }

    
        Console.WriteLine("Введите значение m :");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение n :");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = Ackerman(m, n);

        Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен: {result}");
    

