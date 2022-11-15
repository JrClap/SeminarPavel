//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
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

void ReverseArray (int [] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array [j];
        array[j] = temp;
    }
}

Console.Write("Input a number of elemets: ");
int nsr = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min number of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max number of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreaterRandomArray(nsr, min, max);

ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/



//Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool Treygolnik (int a, int b, int c)
{
    if(a + b > c && b + c > a && c + a > b)
        return true;
    else
        return false;
}

Console.Write("Input a number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number c: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write(Treygolnik(a,b,c));
*/



//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
/*
int[] Fibo (int size, int a, int b)
{
    int[] array = new int[size];
    array[0] = a;
    array[1] = b;
    for (int i = 2; i < size; i++)
    {
        array[i] = array[i-1] + array[i-2];
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

Console.Write("Input a number N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number b: ");
int b = Convert.ToInt32(Console.ReadLine());

int [] myArray = Fibo(N, a, b);

ShowArray(myArray);
*/



//Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
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

int [] Copy (int [] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array [i];
    }
    return array;
}

Console.Write("Input a number of elemets: ");
int nsr = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min number of array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max number of array: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreaterRandomArray(nsr, min, max);

ShowArray(myArray);
ShowArray(Copy(myArray));
*/
