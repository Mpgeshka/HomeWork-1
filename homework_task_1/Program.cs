// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A < B)
{
    Console.WriteLine($"Число {A} меньше числа {B}. Число {B} больше числа {A}.");
    
}
else
{
    Console.WriteLine($"Число {A} больше числа {B}. Число {B} меньше числа {A}.");
}