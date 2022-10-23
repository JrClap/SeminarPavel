// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int CutNumber(int number)
{
    int ed = number % 10;
    int sot = number / 100;
    number = sot * 10 + ed;
    return number;
}

int num = new Random().Next(100,1000);

int result = CutNumber(num);

Console.WriteLine($"New version of a numbers {num} is {result}");
*/


//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
/*
int MaxNum (int randnum)
{
    int dec = randnum % 10;
    int ed = randnum / 10;
    if (dec>ed)
    {
        return dec;
    }
    else
    {
        return ed;
    }
}

int num = new Random ().Next(10, 100);

int result = MaxNum (num);

Console.WriteLine($"New version of a numbers {num} max number {result}");
*/


//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/*
bool KratNum (int a, int b)
{
    if (b % a == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

bool result = KratNum (a, b);

Console.WriteLine($"New version of a numbers a - {a} and b - {b} max number {result}");
*/


//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
/*
bool KvadNum (int a, int b)
{
    if (a == b * b || b == a * a)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

bool result = KvadNum (a, b);

Console.WriteLine(result);
*/