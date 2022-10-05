
// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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

