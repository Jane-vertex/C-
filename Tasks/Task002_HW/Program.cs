/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);

Console.WriteLine("Введите второе число");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);

Console.WriteLine("Введите третье число");
string numberStr3 = Console.ReadLine();
int c = Convert.ToInt32(numberStr3);

int max = a;

if (a > max)
{
    max = a;
}

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.Write("max = ");
Console.WriteLine(max);
