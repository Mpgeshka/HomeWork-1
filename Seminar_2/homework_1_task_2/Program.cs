// Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета

int A = new Random().Next(100,999);
Console.WriteLine (A);
int result1 = A % 10;
int result = A / 100 % 10;
Console.Write(result);
Console.WriteLine(result1);