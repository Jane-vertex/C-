/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


//получаем число с консоли
int GetNumber(string message)
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

//инициализируем матрицу
int[,] InitMatrix(int rows, int columns)
{

    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);

        }
    }

    return matrix;
}

//печатаем матрицу
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

}

int FindMinSumOfRow(int[,] matrix, int countOfRows, int countOfColumns)
{
    int minSumRow = 0;
    int minRow = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minRow += matrix[0, j];//условно минимальная сумма строки
    }


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        Console.WriteLine($"сумма строки {i + 1} = {sumRow + " "} ");

        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
    }
    Console.WriteLine();
    Console.Write($"Наименьшая сумма элементов в {minSumRow + 1} строке ");

    return minSumRow;
}



int countOfRows = GetNumber("Введите кол-во строк:");
int countOfColumns = GetNumber("Введите кол-во столбцов:");

int[,] matrix = InitMatrix(countOfRows, countOfColumns);
PrintMatrix(matrix);

Console.WriteLine();


int sumOfRow = FindMinSumOfRow(matrix, countOfRows, countOfColumns);
