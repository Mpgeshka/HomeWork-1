
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateArray(int lenRows, int lenColumns)
{
    int[,] array = new int[lenRows, lenColumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-5, 6);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}
Random rnd = new Random();
int m = rnd.Next(1, 10);
int n = rnd.Next(1, 10);

int[,] array = CreateArray(m, n);

Console.WriteLine("Введите строку элемента: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец элемента: ");
int column = Convert.ToInt32(Console.ReadLine());
if (row < m+1 && column < n+1) 
{
    Console.WriteLine("Элемент массива с такими позициями существует: " + array[row, column]);
}
else 
{
    Console.WriteLine("Элемента массива с такими позициями не существует");
}

PrintArray(array);