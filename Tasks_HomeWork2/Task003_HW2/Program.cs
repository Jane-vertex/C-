/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет 
*/

/* 
Console.WriteLine("Введите число эквивалентное дню недели");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);

if (a <= 5)
{
    Console.WriteLine("Нет, сегодня рабочий день! ");
}


if (a > 5 && a < 8)
{
    Console.WriteLine("Да, сегодня выходной ");
}
if (a > 7)
{
    Console.WriteLine("Повторите ввод, введено неверное число! ");
} 
 */

Console.WriteLine("Введите число эквивалентное дню недели");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);

 if (a == 1)
{
    Console.WriteLine("Нет, понедельник рабочий день! ");
}
if (a == 2)
{
    Console.WriteLine("Нет, вторник - рабочий день! ");
}
if (a == 3)
{
    Console.WriteLine("Нет, среда - рабочий день! ");
}
if (a == 4)
{
    Console.WriteLine("Нет, четверг - рабочий день! ");
}
if (a == 5)
{
    Console.WriteLine("Нет, пятница - рабочий день! ");
}
if (a == 6)
{
    Console.WriteLine("Да, суббота - выходной день! ");
}
if (a == 7)
{
    Console.WriteLine("Да, воскресенье - выходной день! ");
}
if (a > 7)
{
    Console.WriteLine("Повторите ввод, введено неверное число! ");
}
