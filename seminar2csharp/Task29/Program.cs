int[] CreateArray(int size)
{
    int[] array =  new int[8];
    Random rnd = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = rnd.Next(0,7); //(0, 2)
        
    }
return array;

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", "); //(0, 2)
        
    }
}

int[] arr = CreateArray(1);
PrintArray(arr);

