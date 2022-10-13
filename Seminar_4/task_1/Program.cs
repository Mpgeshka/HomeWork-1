//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). 
//возводит число A в натуральную степень B (и в нулевую степень).
//Использовать свои функции, не использовать Math.Pow
int Prompt(string message)
{
    Console.Write(message);
    string str = Console.ReadLine();
    return int.Parse(str);
}
int Pow(int A, int B)
{
    int res = 1;
    for (int i = 1; i < B; i++)
    {
        res *= A;
    }
    return res;
}

int A = Prompt("Введите число A:  ");
int B = Prompt("ВВедите число B:  ");
int result = Pow(A,B);
Console.WriteLine($"Число {A} в степени числа {B} равно {result}");