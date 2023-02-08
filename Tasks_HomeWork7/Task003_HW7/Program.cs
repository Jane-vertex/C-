/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

//метод получения числа с консоли
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
            Console.WriteLine("Ввели не корректное число. Повторите ввод.");
        }
    }

    return result;
}

//метод, инициализирующий матрицу
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

//метод, распечатывающий матрицу
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


double GetMeanSum(int[,] matrix, int countOfRows, int countOfColumns)
{
    double meanSum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {   //double mean =  meanSum;

        double Sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Sum = Sum + matrix[i, j];
        }
        //Console.WriteLine($"сумма столбца {Sum + " "} ");
        meanSum = Math.Round(Sum / matrix.GetLength(0), 1, MidpointRounding.AwayFromZero);
        Console.Write(meanSum + "; ");

    }
    return meanSum;

}




int countOfRows = GetNumber("Введите кол-во строк:");
int countOfColumns = GetNumber("Введите кол-во столбцов:");

int[,] matrix = InitMatrix(countOfRows, countOfColumns);
PrintMatrix(matrix);

Console.WriteLine(string.Empty);

Console.WriteLine("Среднее арифметическое каждого столбца: ");
double meanSum = GetMeanSum(matrix, countOfRows, countOfColumns);



//Console.WriteLine($"Среднее арифметическое столбца  {meanSum + " "} ");
//Console.WriteLine($"{Math.Round(Sum/matrix.GetLength(0), 1, MidpointRounding.AwayFromZero) + " "} ");



