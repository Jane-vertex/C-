/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */



double GetRandomNumber(double minimum, double maximum)
{ 
    Random random = new Random();
    return random.NextDouble() * (maximum - minimum) + minimum;
}

//инициализируем массив
double[] InitArray(int dimension)
{
    double[] arr = new double[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = GetRandomNumber(1,99) ; //(где максимум и минимум вещественные числа в диапазоне которых будет генерироваться число);
    }

    return arr;
}

//печатаем массив
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        //Console.Write($"{arr[i]} ");

    }
    Console.Write($"[{String.Join(", ", arr)}]");
    Console.WriteLine();
}


//ищем макс элемент
double GetMaxElement(double[] array)
{
    double max = array[0];


    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }

    return max;


}


// ищем мин элемент
double GetMinElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;

}


double GetDifference(double min, double max)
{
    double dif = max - min;

    return dif;
}




double[] array = InitArray(4);
PrintArray(array);


double max = GetMaxElement(array);
Console.WriteLine($"Максимальный элемент массива [{String.Join(", ", array)}] = {max}");
Console.WriteLine();


double min = GetMinElement(array);
Console.WriteLine($"Минимальный элемент массива [{String.Join(", ", array)}] = {min}");
Console.WriteLine();


double dif = GetDifference(min, max);
Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами = {dif}");


