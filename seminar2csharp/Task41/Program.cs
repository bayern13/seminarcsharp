// // 41. Используем массив, сгачада польз вводит число сколько элем массива и это число передаем в метод


// // массив зап польз воодом arr[i] = Convert.ToInt32(Console.ReadLine());

// // 43 прировнять правую часть 1 ур с правой второго
// при вызове целые а в методе дабл
// прямые могут быть параллельными(не пересекаться)
// когда k1==k2

// double FindMax(double[] array, double max)
//     {     // Введите свое решение ниже
//     max = 0;
//       int i = 0;
//       for(i = 0; i < array.Length; i++)
//   {
    
//         if (array[i] < array[i + 1])
//             {
//               max = array[i + 1];
//             }
//   }

       
//     }

Console.Write("Введите количество элементов массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[numbers];

void mas(int numbers)
{
for (int i = 0; i < numbers; i++)
{
Console.WriteLine($"Введите {i+1} элемент массива ");
Array[i] = Convert.ToInt32(Console.ReadLine());
}
}

int kol(int[] Array)
{
int i=0;
int sum = 0;
while (i < Array.Length)
{
if(Array[i]>0)
sum = sum + 1;
i = i + 1;
}
return sum;
}

mas(numbers);
Console.Write($"\n Чисел больше нуля: {kol(Array)}");