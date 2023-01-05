// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a numbers of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SortRows2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i,k] > array[i,j])
                {
                    int temp = array[i,k];
                    array[i,k] = array[i,j];
                    array[i,j] = temp;
                }
            }
        }
    }
    return array;
}

int[,] array = CreateRandom2dArray();
Show2dArray(array);
Console.WriteLine();
int[,] sortArray = SortRows2dArray(array);
Show2dArray(sortArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив: