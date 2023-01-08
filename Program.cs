// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива.
/*
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
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
/*
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

void FindMinSumRow(int[,] array)
{
    int minNum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sumMin = 0;
        int sumRow = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sumRow =+ array[i,j];
            sumMin =+ array[minNum,j];
        }
        if(sumRow < sumMin)
        {
            minNum = i;
        }
    }
    Console.WriteLine($"The number of row with minimum sum of elements is: {minNum}");
}

int[,] array = CreateRandom2dArray();
Show2dArray(array);
FindMinSumRow(array);
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] Multiplication2dArray(int[,] array1, int[,] array2)
{
    int[,] multArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for(int i = 0; i < multArray.GetLength(0); i++)
        for(int j = 0; j < multArray.GetLength(1); j++)
            for(int k = 0; k < array1.GetLength(1); k++)
                multArray[i,j] += array1[i,k] * array2[k,j];
    return multArray;
}

Console.WriteLine("Input parametrs Array1");
int[,] array1 = CreateRandom2dArray();
Console.WriteLine("Input parametrs Array2");
int[,] array2 = CreateRandom2dArray();
Console.WriteLine("Array1");
Show2dArray(array1);
Console.WriteLine("Array2");
Show2dArray(array2);

if(array1.GetLength(1) == array2.GetLength(0))
{
    int[,] multArray = Multiplication2dArray(array1, array2);
    Console.WriteLine("Multiplication Array1 and Array2");
    Show2dArray(multArray);
}
else
    Console.WriteLine("Multiplication Array1 and Array2 is impossible!");


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив: