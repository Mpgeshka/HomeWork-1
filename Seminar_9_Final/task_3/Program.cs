// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Promt(string msg)
{
    System.Console.Write(msg + " > ");
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)

{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n));
}
int n = Promt("Введите число N");
int m = Promt("Введите число M");
AkkermanFunction(m, n);