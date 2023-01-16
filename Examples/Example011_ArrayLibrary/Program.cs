void FillArray(int[] collection) //collection-просто назвали так аргумент
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col) //делаем метод void, который будет печатать массив
{
    int count = col.Length;
    int position = 0; //обозначили текущую позицию не через индекс, а через position
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //-1 вылезет если не будет нужного элемента


    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int[] array = new int[10]; //new int[10]-означает создай новый массив, 
                           //в кот-ом будет 10 эл-ов (по умолчанию будет заполнен нулями,
                           //но чтобы заполнить его другими случайными числами, мы воспользуемся методом, который опишем-FillArray)
FillArray(array); //метод заполнил нам массив
array[4] = 4; //принудительно добавили четверки
array[6] = 4; //принудительно добавили четверки
PrintArray(array);//метод распечатал нам массив
Console.WriteLine();

int pos = IndexOf(array, 4);// определили переменную pos и положили туда результат работы метода IndexOf
Console.WriteLine(pos);

