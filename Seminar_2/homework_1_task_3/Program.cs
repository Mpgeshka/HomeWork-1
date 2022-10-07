// Напишите программу, 
// которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет. Не использовать строки для расчета.

Console.Write("Введи число: ");
int A = Convert.ToInt32(Console.ReadLine());
string Txt = Convert.ToString(A);
if (Txt.Length > 2)
{
    Console.WriteLine(Txt[2]);
}
else
{
    Console.WriteLine("В твоем числе третьей цифры нет");
}