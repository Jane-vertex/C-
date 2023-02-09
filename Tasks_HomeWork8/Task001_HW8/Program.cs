﻿/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void SelectionSort(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1) +1 ; j++)
        {
            int max = j;

            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, max])
                    max = k;
            }
            if (max != j)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, max];
                matrix[i, max] = temp;
            }
        }
    }
}


int countOfRows = GetNumber("Введите кол-во строк:");
int countOfColumns = GetNumber("Введите кол-во столбцов:");

int[,] matrix = InitMatrix(countOfRows, countOfColumns);
PrintMatrix(matrix);

Console.WriteLine();

SelectionSort(matrix);
PrintMatrix(matrix);