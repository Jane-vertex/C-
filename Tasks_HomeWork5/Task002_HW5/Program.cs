/* Задача 36: Задайте одномерный массив, 
заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 
*/

//инициализируем массив
int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(-9, 99);
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


//сумма нечетных элементов массива
int GetSumOddElements(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i = i + 2)
    {
        if (array[i] > 0)
            sum += array[i];
    }
    return sum;
}

int[] array = InitArray(4);
PrintArray(array);
int sum = GetSumOddElements(array);

Console.WriteLine($"Сумма элементов массива [{String.Join(", ", array)}], стоящих на нечетных позициях = {sum}");