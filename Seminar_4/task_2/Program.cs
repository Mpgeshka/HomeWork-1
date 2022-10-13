//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
//Функция должна на вход принимать число, 
//а выдавать сумму его цифр


int Prompt(string message)
{
    Console.Write(message);
    string str = Console.ReadLine();
    return int.Parse(str);
}
int SumNumbers(int number)
{
    int sum = 0;
    if (number > 9 && number < 1000000)
    {
        int a = number % 10;
        int b = number / 10 % 10;
        int c = number / 100 % 10;
        int d = number / 1000 % 10;
        int e = number / 10000 % 10;
        int f = number / 100000 % 10;
        sum = sum + a + b + c + d + e + f;
    }
    return sum;
}
bool ValidateNumber(int number)
{
    if (number < 10)
    {
        int result2 = number;
        Console.WriteLine($"Число однозначное, сумма цифр числа равна самому числу {number}!");
        return false;
    }
    else if (number > 1000000)
    {
        Console.WriteLine("Число, которое вы ввели, больше разряности вызможной для подсчета, попробуйте снова!");
        return false;
    }
    return true;
}
int n = Prompt("Введите число n:  ");
if (ValidateNumber(n))
{
    int result = SumNumbers(n);
    Console.WriteLine($"Сумма цифр числа {n} равна {result}");
}