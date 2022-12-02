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
    