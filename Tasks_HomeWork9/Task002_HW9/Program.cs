/* Задача 66: Задайте значения m и n. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от m до n.

m = 1; n = 15 -> 120
m = 4; n = 8. -> 30

 */

//получаем число с консоли
int Getnumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }

    return result;
}

//сумма от m до n
int Sumnumbers(int m, int n)
{
    {
        if (m == 0) return (n * (n + 1)) / 2;            // Если m равно нулю
        else if (n == 0) return (m * (m + 1)) / 2;       // Если n равно нулю
        else if (m == n) return m;                       // Если m=n
        else if (m < n) return n + Sumnumbers(m, n - 1); // Если m<n
        else return n + Sumnumbers(m, n + 1);            // Если m>n
        
    }
    
}


int m = Getnumber("Введите первое число: ");
int n = Getnumber("Введите второе число: ");
int sum = Sumnumbers(m, n);
Console.WriteLine($"Сумма = {Sumnumbers(m, n)}");
