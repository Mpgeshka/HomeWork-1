// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.


const int X = 0;
const int Y = 1;
const int Z = 2;

int Prompt (string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int [] InputPoint(int point)
{
    int [] result = new int [3];
    result[X] = Prompt($"Введите x {point}:  ");
    result[Y] = Prompt($"Введите y {point}:  ");
    result[Z] = Prompt($"Введите z {point}:  ");
    return result;
}
int Power2(int arg)
{
    return arg*arg;
}
int [] p1 = InputPoint(1);
int [] p2 = InputPoint(2);

double leight = Math.Sqrt(Power2(p2[X]-p1[X])+Power2(p2[Y]-p1[Y])+Power2(p2[Z]-p1[Z]));

System.Console.WriteLine(leight);