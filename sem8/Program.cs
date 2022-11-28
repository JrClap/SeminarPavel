// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
int[,] CreaterRandom2Array (int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2Array (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ChangeRows (int[,] array, int rows1, int rows2)
{
    if(rows1 >= 0 && rows1 < array.GetLength(0) &&
       rows2 >= 0 && rows2 < array.GetLength(0) &&
       rows1 != rows2)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[rows1, j];
            array[rows1, j] = array[rows2, j];
            array[rows2, j] = temp;
        }
    }
    else
        Console.Write("Ошибка. Введите другие значения");
}

Console.Write("Введите число строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreaterRandom2Array (r, c, min, max);

Show2Array(myArray);

Console.Write("Введите номер строки под замену: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер строки на которую хотите поменять: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(myArray, r1, r2);
Show2Array(myArray);
*/




// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
int[,] CreaterRandom2Array (int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2Array (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ReversalArray (int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 1 + i; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }
}

Console.Write("Введите число строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreaterRandom2Array (r, c, min, max);

Show2Array(myArray);
Console.WriteLine();
ReversalArray(myArray);
Show2Array(myArray);
*/




// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] CreaterRandom2Array (int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int [rows, columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return array;
}

void Show2Array (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreaterRandom2Array (r, c, min, max);

Show2Array(myArray);

int[,] DeleteRowsColums (int[,] array)
{
    int posi = 0;
    int posj = 0;
    int min = array[posi, posj];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < array[posi, posj])
            {
                min = array[i, j];
                posi = i;
                posj = j;
            }
        }
    }
    int[,] newarr = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    
    for (int i = 0, x = 0; i < array.GetLength(0); i++, x++)
    {
        if (i != posi)
        {
            for (int j = 0, y = 0; j < array.GetLength(1); j++, y++)
            {
                if (j != posj)
                {
                    newarr[x, y] = array[i, j];
                }
                else y--;
            }
        }
        else x--;
    }
    return newarr;
}

int[,] arr = DeleteRowsColums(myArray);
Console.WriteLine();
Show2Array(arr);
