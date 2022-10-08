// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Prompt (string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int N = Prompt("Введите число N:  ");

for (int i = 1; i <= N; i++)
{
    Console.WriteLine(i*i*i);
}
