/* Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 

*/

//инициализируем массив
int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(100, 999);
    }
    return arr;
}

//печатаем массив
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //Console.Write($"{arr[i]} ");
    }
    Console.Write($"[{String.Join(", ", arr)}]");
    Console.WriteLine();
}


//кол-во четных чисел в массиве
int GetEvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count += 1;
    }

    return count;
}

int[] array = InitArray(4);
PrintArray(array);
int count = GetEvenNumbers(array);

Console.WriteLine($"Количество четных чисел в массиве [{String.Join(", ", array)}] = {count}");