
//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double RaiseToDegree(int n1, int n2)
{
    double result = Math.Pow(n1,n2);
    return result;
}

Console.Write("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());

double toDegree = RaiseToDegree(a,b);
Console.WriteLine($"{a} to the {b} degree is {toDegree}");
*/


//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int DigitsSum(int num)
{
    int sum = 0;
    int curDigit = num % 10;

    while(num > 0)
    {
        sum += (num % 10);
        num /= 10;
    }

    return sum;
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

int sumOfDigits = DigitsSum(n); 
Console.WriteLine($"The sum of number {n} digits is {sumOfDigits}");
*/


//Задача 3: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input number m: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 9;

int[] mArray = CreateRandomArray(size, min, max);
ShowArray(mArray);
