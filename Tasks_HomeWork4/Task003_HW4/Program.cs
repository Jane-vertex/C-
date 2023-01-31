/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


//инициализируем массив
int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(1,33);
    }

    return arr;
}

//печатаем массив
/* void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //Console.Write($"{arr[i]}");
    }

    Console.WriteLine();
} */


//выводим массив
int[] array = InitArray(8);
Console.WriteLine($"[{String.Join(", " , array)}]");

//PrintArray(array);