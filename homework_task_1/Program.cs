// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A < B)
{
    Console.WriteLine($"Минимальное число = {A}, максимальное = {B}.");
    
}
else
{
    Console.WriteLine($"Максимальное число = {A} минимальное = {B}.");
}