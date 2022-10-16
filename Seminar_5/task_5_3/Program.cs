// 

// 

// 

int[] CreateArray(int len)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 50);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int Max(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
        {
            max = array[i];
        }
    return max;
}
int Min(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
        {
            min = array[i];
        }
    return min;
}
int DifferenceMaxMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    int diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
        diff = max - min;
    }
    return diff;
}


int[] arr = CreateArray(8);
PrintArray(arr);
int diff = DifferenceMaxMin(arr);
int max = Max(arr);
int min = Min(arr);
System.Console.WriteLine($"Максимальное значение {max}, минимальное {min}");

System.Console.WriteLine($"Разница между максимальным и минимальным числом в массиве равна {diff}");




