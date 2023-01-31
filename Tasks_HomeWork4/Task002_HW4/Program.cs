/* 
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 
*/

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);

int sum = 0;
while (a != 0)
{
    int res = 0;
    res = a % 10;
    a /= 10;
    sum = sum + res;


   // Console.WriteLine(res);
}

Console.WriteLine($"Сумма цифр числа {number} = {sum}");

