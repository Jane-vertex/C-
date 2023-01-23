/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
*/

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);
if (999 >= a && a >= 100)
{
    int b = (a % 10);
    Console.WriteLine($"Третья цифра введенного числа = {b}");
}

while (a > 999)
{
    int i = 0;
    a = a / 10;
    i++;

    if (a > 99 && a < 999)
    {
        int b = (a % 10);

        Console.WriteLine($"Третья цифра введенного числа = {b}");
    }
}

while (a <= 99)
{
    Console.WriteLine("Третьей цифры нет");
    break;
}
