//Напишите программу, которая из массива случайных чисел. 
//Ищет второй максимум (число меньше максимального элемента, 
//но больше всех остальных). Постарайтесь сделать одним циклом


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
    int max = 0, second_max = 0;
    for (int i = 0; i <= array.Length - 1; i++)
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
        Console.Write($"{array[i]}\t");
    }

    Console.WriteLine($"Max Number:{max}, SecondMax Number: {second_max}");
}






