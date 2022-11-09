//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int Sum (int number)
{
    int sum = 0;

    for(int current = 1; current <= number; current++)
    sum += current;

    return sum;
}

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of numbers between 1 and {a} is {Sum(a)}");
*/

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int Find (int number)
{
    int ilosh = 0;
    while (number != 0)
    {
        number = number / 10;
        ilosh++;
    }
    return ilosh;
}

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write($"Количсетво цифр в числе {a} составляет {Find(a)}");
*/

//Написать программу, которая определит произведение чисел от 1 до N
/*
int Find (int number)
{
    int sum = 1;
    
    for (int current = 1; current <= number; current++)
    {
        sum = sum * current;
    }
    return sum;
}

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write($"Произведение числе от 1 до {a} равно: {Find(a)}");
*/