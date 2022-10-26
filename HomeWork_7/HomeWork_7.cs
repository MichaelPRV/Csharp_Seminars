
//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dDoubleArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
            array[i,j] = Math.Round(array[i,j],2);
        }    
    }

    return array;
}

void ShowArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

double[,] myArray = CreateRandom2dDoubleArray();
ShowArray(myArray);
*/


//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] Create2dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void ShowArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void FindElement (int[,] array, int nI, int nJ)
{
    int element = 0;

    if (nI < array.GetLength(0) && nJ < array.GetLength(1))
        {
        element = array[nI,nJ];
        Console.WriteLine($"Element with indexes {nI} (i) and {nJ} (j) is '{element}'");
        }
    else
        Console.WriteLine("Element with indicated indexes does not exist in the array");
}

int[,] myArray = Create2dArray();
Console.WriteLine();
ShowArray(myArray);
Console.WriteLine();

Console.Write("Input index i of element in the array: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input index j of element in the array: ");
int j = Convert.ToInt32(Console.ReadLine());

FindElement(myArray, i, j);
*/


//Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] Create2dArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void ShowArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "; ");
}

double[] FindColumnElArithMean (int[,] array)
{
    double[] arMean = new double[array.GetLength(1)];
    

    for (int j = 0, n = 0; j < array.GetLength(1); j++, n++)
    {
        double sum = 0;
        double arithMean = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        } 
        arithMean = sum / array.GetLength(0);
        arMean[n] = Math.Round(arithMean,2);
    }
    
    return arMean;
}

int[,] myArray = Create2dArray();
Console.WriteLine();
Show2dArray(myArray);
Console.WriteLine();

double[] ColumnElArithMean = FindColumnElArithMean(myArray);
Console.WriteLine("Arithmetic means of elements from every column: ");
ShowArray(ColumnElArithMean);
