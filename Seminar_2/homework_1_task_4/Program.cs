// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Да, это выходной день!");
}
else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("А ты уверен, что это вообще день недели?!");
}
else
{
    Console.WriteLine("Увы, этот день рабочий.");
}