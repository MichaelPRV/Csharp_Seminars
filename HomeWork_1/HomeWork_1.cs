
// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input first number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.WriteLine($"The numbers are equal");
}
else
{
    if (a > b)
    {
    Console.WriteLine($"Max is {a}");
    }
    else
    {
    Console.WriteLine($"Max is {b}");
    }
}
*/

// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input first number: ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int N2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number: ");
int N3 = Convert.ToInt32(Console.ReadLine());

int Max = N1;

if (N2 > Max) Max = N2;
if (N3 > Max) Max = N3;

Console.WriteLine($"Max is {Max}");
*/

// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input number: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = N % 2;

if (result == 0)
{
    Console.WriteLine($"The number is even");
}
else
{
    Console.WriteLine($"The number is odd");
}
*/

//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input positive number N (N>1): ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 1)
{
    int current = 2;

    if (current != N)
    {
        while(current < N)
        {
            Console.Write(current + " ");
            current += 2;
        }
    }
    else
    {
        Console.WriteLine("There is no any even numbers between 1 and 2");
    }
}
else
{
    Console.WriteLine("Please input correct number (N>1)");
}
