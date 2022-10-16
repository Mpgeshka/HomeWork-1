//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
//Функция должна на вход принимать число, 
//а выдавать сумму его цифр


int Prompt(string message)
{
    Console.Write(message);
    string str = Console.ReadLine();
    return int.Parse(str);
}

int Absolute(int number)
{
    if(number < 0)
    {
        number = - number;
    }
    return number;
}

int SumNumbers(int number)
{
    number = Absolute(number);
    int sum = 0;
    while (number > 0)
    {
        int dig = number % 10;
        sum = sum + dig;
        number = number / 10;
    }
    return sum;
}
bool ValidateNumber(int number)
{
    if (number < 10 && number > -10)
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