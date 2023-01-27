/*
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет

12821 -> да

23432 -> да
*/

Console.Write("Введите число: ");
int num = Int32.Parse(Console.ReadLine());

int ReversalNum(int numb)
{
    int number = numb;
    int result = 0;

    while (number > 0)
    {
        result = result * 10; //или result * = 10;
        result += number % 10; // или result = result + number % 10;
        number /= 10; // number = number /
    }
    return result;
}

int result;
result = ReversalNum(num);


if (num == result && num < 99999 && num > 9999)
{
    Console.WriteLine($"Число {num} является палиндромом");
}


if (num != result && num < 99999 && num > 9999)
{
    Console.WriteLine($"Число {num} НЕ является палиндромом");
}


if (num > 99999 ^ num < 10000)
{
    Console.WriteLine($"Число {num} НЕ пятизначное, повторите ввод");
}