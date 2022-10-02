// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());
int max = A;
if (max < B)
{
    max = B;
    
    if (max < C)
    {
        max = C;
        Console.WriteLine($"{C} максимальное число среди {A}, {B}, {C}.");
    }
    else 
    {
        Console.WriteLine($"{B} максимальное число среди {A}, {B}, {C}.");
    }
}
else if (max < C)
{
    max = C;
    Console.WriteLine($"{C} максимальное число среди {A}, {B}, {C}.");
}
else 
{
    Console.WriteLine($"{A} максимальное число среди {A}, {B}, {C}.");
}