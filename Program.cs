// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1)
        ShowNums(num - 1);
}

Console.Write("Input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);
*/
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNums(int m, int n)
{
    if(m > n) 
        return m + SumNums(m - 1, n);
    if(m < n)
        return m + SumNums(m + 1, n);
    return m;
}

Console.Write("Input a number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = SumNums(m,n);
Console.WriteLine($"Sum between numbers M and N: {sum}");
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if(m == 0)
        return n + 1;
    if(m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    if(m > 0 && n > 0)
        return Akkerman(m - 1, Akkerman(m, n - 1));
    return n + 1;
}

Console.Write("Input a number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number n: ");
int n = Convert.ToInt32(Console.ReadLine());
if(m >= 0 && n >= 0)
{
    int akker = Akkerman(m,n);
    Console.WriteLine($"Akkerman function: {akker}");
}
else
    Console.WriteLine($"The numbers {m} and {n} isn't correct for Akkerman function!");