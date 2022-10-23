// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


double[,] CreateArray(int lenRows, int lenColumns)
{
    double[,] array = new double[lenRows, lenColumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble()*100;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write( String.Format("{0:F}",array[i, j]) +"    ");
        }
        System.Console.WriteLine();
    }
}

double[,] array = CreateArray(3, 4);
PrintArray(array);