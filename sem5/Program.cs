//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов.
/*
int [] CreaterRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    } 
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sum += array[i];
    return sum;
}

Console.Write("Input a number of elemets: ");
int nsr = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min number of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max number of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreaterRandomArray(nsr, min, max);
ShowArray(myArray);

int negativeSum = FindSum(myArray);
Console.WriteLine($"Sum of elements is " + negativeSum);
*/

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
int [] CreaterRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    } 
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

bool SearchNum (int [] array, int n)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(n == array [i])
            return true;
    }
    return false;
}

Console.Write("Input a number of elemets: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min number of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max number of array: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of searching: ");
int n = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreaterRandomArray(size, min, max);
ShowArray(myArray);
Console.Write(SearchNum(myArray, n));
*/

//Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
/*
int [] CreaterRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    } 
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SumNumbers (int [] array, int a, int b)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= a && array[i] <= b)
            count++;
    }
    return count;
}

Console.Write("Input a number of elemets: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min number of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max number of array: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number b: ");
int b = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreaterRandomArray(size, min, max);
ShowArray(myArray);
Console.Write(SumNumbers(myArray, a, b));
*/

//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int [] CreaterRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue +1);
    } 
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] Replace (int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array [i] = array [i] * -1;
    }
    return array;
}

Console.Write("Input a number of elemets: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min number of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max number of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreaterRandomArray(size, min, max);
ShowArray(myArray);
ShowArray(Replace(myArray));
*/