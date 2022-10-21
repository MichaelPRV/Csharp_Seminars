
//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int EvenNumQuant(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count++;

    return count;
}

int size = 10;
int min = 100;
int max = 999;

int[] myArray = CreateArray(size, min, max);
Console.WriteLine("Random array is: ");
ShowArray(myArray);
int evenNumQuant = EvenNumQuant(myArray);
Console.WriteLine("Quantity of even numbers in the array is " + evenNumQuant);
*/


//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOfOddIndexElem(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if((i % 2) != 0)
            sum += array[i];

    return sum;
}

int size = 10;
int min = -99;
int max = 99;

int[] myArray = CreateArray(size, min, max);
Console.WriteLine("Created array: ");
ShowArray(myArray);
int sumOddIndEl = SumOfOddIndexElem(myArray);
Console.WriteLine("Sum of elements with odd index is " + sumOddIndEl);
*/


//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();

    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double DifBetwMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];

    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
        else
            if(array[i] > max)
                max = array[i];
    }
        
    double dif = max - min;
    return dif;
}

Console.Write("input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 99;

double[] myArray = CreateArray(size, min, max);
Console.WriteLine("Created array: ");
ShowArray(myArray);
double difMaxMin = DifBetwMinMax(myArray);
Console.WriteLine("Difference between Min and Max number in the array is " + difMaxMin);
