//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа. Не использовать строки для расчета.

System.Console.Write("Введите трехзначное число: ");
int A = Convert.ToInt32(Console.ReadLine());
if (A > 99 & A < 1000)
{
    int result1 = A / 10 % 10;
    Console.Write(result1);
}
else 
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}