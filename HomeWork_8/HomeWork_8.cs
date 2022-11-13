
// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray ()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minVal, maxVal + 1);
    }

    return array;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void LineBubbleSortMaxMin (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int count = 0; count < array.GetLength(1); count++)
        {
            for(int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i,j] < array[i, j+1])
                {
                    int temp = array[i,j];
                    array[i,j] = array[i, j+1];
                    array[i, j+1] = temp;
                }
            }
        }
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
LineBubbleSortMaxMin(myArray);
Show2dArray(myArray);
*/


// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] CreateRandom2dArray ()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minVal, maxVal + 1);
    }

    return array;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void FindLineMinSum (int[,] array)
{
    
    int[] arraySumLine = new int[array.GetLength(0)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sumLine = 0;
        
        for(int j = 0; j < array.GetLength(1); j++)
            sumLine += array[i,j];
            
        arraySumLine[i] = sumLine;
    }

    int minSum = arraySumLine[0];
    int minSumLineIndex = 0;

    for(int i = 1; i < array.GetLength(0); i++)
    {
        if(arraySumLine[i] < minSum)
        {
            minSum = arraySumLine[i];
            minSumLineIndex = i;
        }
    }

    Console.WriteLine("Index of row with minimal sum of elements is " + minSumLineIndex);
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
FindLineMinSum(myArray);
*/


// Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray (int rows, int columns, int minVal, int maxVal)
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minVal, maxVal + 1);
    }

    return array;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int[,] MatrixProduct (int[,] array1, int[,] array2)
{
    int[,] matrixProd = new int[array1.GetLength(0), array2.GetLength(1)];

    for(int i = 0; i < matrixProd.GetLength(0); i++)
    {
        for(int j = 0; j < matrixProd.GetLength(1); j++)
        {
            matrixProd[i,j] = 0;

            for(int n = 0; n < array1.GetLength(0); n++)
                matrixProd[i,j] += array1[i,n]*array2[n,j];
        }
    }

    return matrixProd;
}

Console.Write("Input number of rows in the first matrix: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns in the first matrix: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of rows in the second matrix should be the same as number of columns in the first one");
int rows2 = columns1;
Console.Write("Input number of columns in the second matrix: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int minVal = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Matrix 1:");
int[,] matrix1 = CreateRandom2dArray(rows1, columns1, minVal, maxVal);
Show2dArray(matrix1);
Console.WriteLine();
Console.WriteLine("Matrix 2:");
int[,] matrix2 = CreateRandom2dArray(rows2, columns2, minVal, maxVal);
Show2dArray(matrix2);
Console.WriteLine();

int[,] matrixProduct = MatrixProduct(matrix1, matrix2);
Console.WriteLine("Product of matrix 1 and matrix 2 is: ");
Show2dArray(matrixProduct);
*/


//Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

bool CheckOriginalNumber (int[,,] array, int element)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                if(element == array[i,j,k])
                    return false;
            }
        }
    }

    return true;
}

int CreateOriginalElement (int[,,] array)
{
    int newElement = new Random().Next(10, 100);

    bool check = CheckOriginalNumber(array, newElement);

    if (check == false)
        newElement = CreateOriginalElement (array);
    
    return newElement;
}

int[,,] Create3dArray (int x, int y, int z)
{
    int[,,] d3array = new int[x, y, z];

    d3array[0,0,0] = new Random().Next(10, 100);

    for(int i = 0; i < x; i++)
    {
        for(int j = 0; j < y; j++)
        {
            int k = 0;
            while(k < z)
            {
                if(i == 0 && j == 0 && k == 0)
                    k++;
                else
                {
                    d3array[i,j,k] = CreateOriginalElement(d3array);
                    k++;
                }
            }    
        }    
    }

    return d3array;
}

void Show3dArray (int[,,] array)
{
    Console.WriteLine();

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i,j,k]} ({i},{j},{k})  ");

            Console.WriteLine();
        }
            
        Console.WriteLine();
    }
}

Console.Write("Input number of rows in the array: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns in the array: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third dimention of the array: ");
int thirdDim = Convert.ToInt32(Console.ReadLine());

if(rows * columns * thirdDim > 90)
        Console.WriteLine("Input smaller dimentions of array in order to have not repeatable numbers");
else
    {
        int[,,] myArray = Create3dArray(rows, columns, thirdDim);
        Show3dArray(myArray);
    }
 


//Задача 5. Напишите программу, которая заполнит спирально массив

/*
int[,] CreateSpiral2dArray (int rows, int columns)
{
    int[,] array = new int[rows, columns];

    int elementNumber = 1;
    int maxNum = rows * columns;
    int sideSpace = 0;

    while (elementNumber <= maxNum)
    {
        for(int i = sideSpace, j = sideSpace; j < array.GetLength(1) - sideSpace; j++)
        {
            if(elementNumber <= maxNum)
            {
                array[i,j] = elementNumber;
                elementNumber++;
            }
            else break;
        }

        for(int i = sideSpace + 1, j = array.GetLength(1) - 1 - sideSpace; i < array.GetLength(0) - sideSpace; i++)
        {
            if(elementNumber <= maxNum)
            {
                array[i,j] = elementNumber;
                elementNumber++;
            }
            else break;
        }        
    
        for(int i = array.GetLength(0) - 1 - sideSpace, j = array.GetLength(1) - 2 - sideSpace; j >= sideSpace; j--)
        {
            if(elementNumber <= maxNum)
            {
                array[i,j] = elementNumber;
                elementNumber++;
            }
            else break;
        }

        for(int i = array.GetLength(0) - 2 - sideSpace, j = sideSpace; i >= sideSpace + 1; i--)
        {
            if(elementNumber <= maxNum)
            {
                array[i,j] = elementNumber;
                elementNumber++;
            }
            else break;
        }

        sideSpace++;
    }
  
    return array;
}

void Show2dArray (int[,] array)
{
    Console.WriteLine();

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] < 10)
                Console.Write("0" + array[i,j] + " ");
            else
                Console.Write(array[i,j] + " ");
        }

        Console.WriteLine();
    }

    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] spiralFilledArray = CreateSpiral2dArray(row, column);
Show2dArray(spiralFilledArray);
*/
