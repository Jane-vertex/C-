/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int num = Convert.ToInt32(number);

if (num % 2 == 0)
{
    Console.Write ("Число: " + num + " является четным");
}

else
{
    //Console.Write ("Число " + num + " является не четным");
    Console.Write ($"Число {num} является не четным");
}