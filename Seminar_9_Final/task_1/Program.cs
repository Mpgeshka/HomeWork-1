// Задайте значения M и N. 
// Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.

int Promt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}
void PrintNumbers(int m, int n)
{
    if (m >= n)
    {
        return;
    }
    if (n % 2 == 0)
    {
        PrintNumbers(m, n - 2);
    }
    else
    {
    PrintNumbers(m, n - 1);
    }
    if (n % 2 == 0)
    {
        System.Console.Write(n + " ");
    }
}


int n = Promt("Введите число N");
int m = Promt("Введите число M");
PrintNumbers(m, n);
