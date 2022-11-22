// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
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
*/



// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
/*
int[,] CreaterRandom2Array (int rows, int columns)
{
    int[,] array = new int [rows, columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
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

int[,] myArray = CreaterRandom2Array (r, c);

Show2Array(myArray);
*/



// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
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

void SquaringArray (int[,] array)
{   
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] *= array[i, j]; 
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
SquaringArray(myArray);
Show2Array(myArray);
*/



// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
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

int FindSum(int[,] array) //метод более долгий 
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            if(i == j ) sum += array[i, j];
        }
    }

    return sum;
} 

int FindSum(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i ++)
        sum += array[i,i];

    return sum;
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

int result = FindSum (myArray);
Console.Write($"Сумма чисел по диагонали равна: {result}");
*/