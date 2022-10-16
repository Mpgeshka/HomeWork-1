//Напишите программу, которая из массива случайных чисел. 
//Ищет второй максимум (число меньше максимального элемента, 
//но больше всех остальных). Постарайтесь сделать одним циклом


Print(Fill(10));

int[] Fill(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i <= array.Length - 1; i++)
    {
        int r = new Random().Next(-100, 0);
        array[i] = r;
        Console.Write($"{array[i]}\t");
    }
    return array;
}
void Print(int[] array)
{
    int max = array[0], second_max = 0;
    if (max > array[1])
    {
        second_max = array[1];
    }
    else
    {
        second_max = max;
        max = array[1];
    }
    for (int i = 2; i <= array.Length - 1; i++)
    {
        int arrItem = array[i];
        if (arrItem > max)
        {
            second_max = max;
            max = arrItem;
        }
        else if (arrItem > second_max && arrItem < max)
        {
            second_max = arrItem;
        }
    }
    Console.WriteLine($"Max Number:{max}, SecondMax Number: {second_max}");
}






