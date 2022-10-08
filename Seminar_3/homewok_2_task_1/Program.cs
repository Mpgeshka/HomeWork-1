//Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
int Prompt (string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void CheckPalindromicNumber(int A)
{
    if (A > 9999 && A < 100000)
    {
        int a = A / 10000;
        int b = A % 10;

        if (a == b)
        {
            A = A / 10;
            int c = (A / 100) % 10;
            int d = A % 10;
            if (c == d)
                Console.WriteLine($"Число {A} является палиндромом");
        }
        else
            Console.WriteLine($"Число {A} не является палиндромом");
    }
    else
        Console.WriteLine("Некорректное число!");
}

int A = Prompt("Введите пятизначное число: ");
CheckPalindromicNumber(A);