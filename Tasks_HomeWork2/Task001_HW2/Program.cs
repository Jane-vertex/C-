﻿/*Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int a = Convert.ToInt32(number);
int b = (a%100)/10;
Console.Write(b);