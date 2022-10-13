//Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран



Print(Fill(8));

int[] Fill(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        int r = new Random().Next(0, 100);
        array[i] = r;
    }
    return array;
}
void Print(int[] array)
{
    for (int i = 0; i <= array.Length - 1; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}
