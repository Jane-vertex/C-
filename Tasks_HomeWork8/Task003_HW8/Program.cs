/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] CreateMultiplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] thirdMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
    {
        for (int i = 0; i < thirdMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < thirdMatrix.GetLength(1); j++)
            {
                thirdMatrix[i, j] = 0;
                for (int n = 0; n < firstMatrix.GetLength(1); n++)
                {
                    thirdMatrix[i, j] += firstMatrix[i, n] * secondMatrix[n, j];
                }
            }
        }
    }
    else Console.WriteLine("Невозможно перемножить матрицы. Кол-во столбцов firstMatrix != кол-ву строк secondMatrix ");


    return thirdMatrix;

}



int countOfRows = GetNumber("Введите кол-во строк:");
int countOfColumns = GetNumber("Введите кол-во столбцов:");
int[,] firstMatrix = InitMatrix(countOfRows, countOfColumns);
PrintMatrix(firstMatrix);
Console.WriteLine();


int countOfRows2 = GetNumber("Введите кол-во строк:");
int countOfColumns2 = GetNumber("Введите кол-во столбцов:");
int[,] secondMatrix = InitMatrix(countOfRows2, countOfColumns2);
PrintMatrix(secondMatrix);
Console.WriteLine();


int[,] thirdMatrix = CreateMultiplicationMatrix(firstMatrix, secondMatrix);
PrintMatrix(thirdMatrix);
