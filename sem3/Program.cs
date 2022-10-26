// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)
/*
void ShowRange(int quart)
{
    if(quart == 1)
    
        Console.WriteLine("x > 0 and y > 0");
    
    else if(quart == 2)
    
        Console.WriteLine("x < 0 and y > 0");
    
    else if(quart == 3)
    
        Console.WriteLine("x < 0 and y < 0");
    
    else if(quart == 4)
    
        Console.WriteLine("x > 0 and y < 0");
    
    else
    
        Console.WriteLine("Wrong number!");
    
}

Console.Write("Input number of a quart: ");
int quartNum = Convert.ToInt32(Console.ReadLine());

ShowRange(quartNum);
*/

// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int Quart (int numX, int numY)
{
    int qua = 0;
    if(numX > 0 && numY > 0)
     qua = 1;
    else if(numX < 0 && numY > 0)
     qua = 2;
    else if(numX < 0 && numY < 0)
     qua = 3;
    else if(numX > 0 && numY < 0)
     qua = 4;
    return qua;
}

Console.Write("Input X: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

int result = Quart(X, Y);

if(result == 0)
{
    Console.Write("Error");
}
else
{
    Console.Write($"Answer: {result}");
}
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double Pifagor (double x1, double y1, double x2, double y2)
{
    double x = x2 - x1;
    double y = y2 - y1;
    x = Math.Pow(x, 2);
    y = Math.Pow(y, 2);
    double Gipotenyza = x + y;
    Gipotenyza = Math.Sqrt(Gipotenyza);
    return Gipotenyza;
}

Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Pifagor(x1, y1, x2, y2);
Console.WriteLine($"Расстояние между точками {result}");
*/

// Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.
/*
void Suaqd (int N)
{
    int count = 1;
    while(count <= N)
    {
        Console.Write(Math.Pow(count, 2) + " ");
        count++; 
    }
}

Console.Write("Введите число N - ");
int N = Convert.ToInt32(Console.ReadLine());

Suaqd(N);
*/