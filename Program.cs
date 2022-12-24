// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArrayDouble()
{
    Console.Write("Input a number of rows: m = ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: n = ");
    int n = Convert.ToInt32(Console.ReadLine());    
    Console.Write("Input a minimum possible value: min = ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maximum possible value: max = ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m, n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
            array[i,j] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    return array;
}

void Show2dArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i,j], 2) + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] arrayDouble = CreateRandom2dArrayDouble();
Console.WriteLine();
Show2dArrayDouble(arrayDouble);
*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns = ");
    int columns = Convert.ToInt32(Console.ReadLine());    
    Console.Write("Input a minimum possible value = ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maximum possible value = ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

bool FundElement2dArray(int[,] array, int row, int column) // Номера строки и столбца для элемента определеяются из удобства для пользоватетеля
{
    if (row - 1 < array.GetLength(0) && column -1 < array.GetLength(1))
        return true;
    else   
        return false;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
Console.WriteLine();
Console.Write("Input element row number: row = ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input element column number: column = ");
int column = Convert.ToInt32(Console.ReadLine());
if(FundElement2dArray(newArray, row, column))
    Console.WriteLine($"The element of array on position {row}:{column} is number = {newArray[row -1 ,column - 1]}.");
else
    Console.WriteLine($"The sise of find row = {row} or column = {column} is to big for this array!");
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows = ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns = ");
    int columns = Convert.ToInt32(Console.ReadLine());    
    Console.Write("Input a minimum possible value = ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maximum possible value = ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        Console.Write(array[i] + "\t");
    Console.WriteLine();
}

double[] AverageColumns2dArray (int[,] array)
{
    double[] averageCulumns = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        averageCulumns[j] = Math.Round(sum / array.GetLength(0), 2);
    }
    return averageCulumns;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
double[] avgArray = AverageColumns2dArray(myArray);
ShowArray(avgArray);
