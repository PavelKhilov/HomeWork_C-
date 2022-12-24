// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2dArrayDouble() // int m, int n, int minValue, int maxValue
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

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.