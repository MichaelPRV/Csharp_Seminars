
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
