// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Input first number ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    Console.WriteLine("Maximum number is " + a);
    Console.WriteLine("Minimum number is " + b);
}
else
{
    Console.WriteLine("Maximum number is " + b);
    Console.WriteLine("Minimum number is " + a);
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if(num2 > max)
    max = num2;
if(num3 > max)
    max = num3;

Console.WriteLine("Maximum number is: " + max);
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
    Console.WriteLine("Even number");
else
    Console.WriteLine("Odd number");
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Inpute number N: ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 1;
while(current <= N)
{
    if(current% 2 == 0)
    {
        Console.WriteLine(" " + current);
    }    
    current++;
}
*/

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int SecondNum(int num)
{
    int two = num % 100;
    int second = two / 10;
    return second;
}
Console.WriteLine("Input number from 100 to 999");
int num = Convert.ToInt32(Console.ReadLine());

int result = SecondNum(num);
Console.WriteLine($"The second number in {num} is {result}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdNumber (int num)
{
    int three = num % 1000;
    int third = three / 100;
    return third;
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = ThirdNumber(num);

if (result != 0)
    Console.WriteLine($"The trird number in {num} is {result}");
else
    Console.WriteLine($"The number {num} doesn't have third number");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool WeekDay (int num)
{
    if (num == 6 || num == 7)
    return true;
    return false;
}

Console.WriteLine("Input number from 1 to 7");
int num = Convert.ToInt32(Console.ReadLine());

bool result = WeekDay (num);
if (result == true)
    Console.WriteLine("This is a holiday! :)");
else
    Console.WriteLine("This is a work day :("); 
*/

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palyndrome (int N)
{
    int count = N;
    int reverse = 0;
    while (count != 0)
    {
        reverse = reverse * 10 + count % 10;
        count = count / 10;
    }

    if ( N == reverse)
        return true;
    else
        return false;
}    
    
Console.WriteLine("Input number N: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = Palyndrome (num);
Console.WriteLine($"The number {num} is polyndrome - {result}.");
*/

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistance(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2)), 3);
    return distance;
}
Console.WriteLine("Input coordinate first point: xA= ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate first point: yA= ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate first point: zA= ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate second point: yB= ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate second point: yB= ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input coordinate second point: zB= ");
double zB = Convert.ToDouble(Console.ReadLine());

double dist = FindDistance(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Distance between A({xA},{yA},{zA}) and B({xB},{yB},{zB}) is {dist}.");
*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void CubePower(int N)
{
    int i = 1;

    while(i <= N)
    {
        Console.Write(Math.Pow(i, 3) + " ");
        i++;
    }    
}
Console.WriteLine("Input number N");
int N = Convert.ToInt32(Console.ReadLine());

CubePower(N);
*/

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double Degree (double A, int B)
{
    double result = 1;
    for (int i = B; i > 0; i--)
    {
        result = result * A;
    }
    return result;
}

Console.WriteLine("Input number A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input number B: ");
int B = Convert.ToInt32(Console.ReadLine());

double res = Degree(A, B);
Console.WriteLine($"The number {A} to the power of {B} = {res}");
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumNum (int A)
{
    int sum = 0;
    for (int i = A; i != 0; i = i / 10)
    {
        sum = sum + A % 10;
        A = A / 10;
    }
    return sum;
}

Console.WriteLine("Input number A: ");
int A = Convert.ToInt32(Console.ReadLine());
int res = SumNum(A);
Console.WriteLine($"The summ of numbers {A} = {res}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.