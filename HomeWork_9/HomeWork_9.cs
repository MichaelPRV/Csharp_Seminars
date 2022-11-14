
// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
/*
void ShowMumsFromNto1 (int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowMumsFromNto1(n - 1);
}

Console.WriteLine("Input number N: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowMumsFromNto1(num);
Console.WriteLine();
*/


// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumOfELementsMn (int m, int n)
{
    if(m >= n) return m + SumOfELementsMn(m-1, n);
    else return 0;
}

int SumOfELementsNm (int m, int n)
{
    if(n >= m) return n + SumOfELementsNm(m, n-1);
    else return 0;
}


Console.Write("Input number M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int result = 0;

if(numM > numN) result = SumOfELementsMn(numM, numN);
if(numN > numM) result = SumOfELementsNm(numM, numN);

Console.WriteLine("Sum of elements between M and N is " + result);
*/


// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int FunctionAkkerman (int m, int n)
{
    if (m == 0)  return n + 1;
    else
        if(m != 0  &&  n == 0) return FunctionAkkerman(m-1, 1);
        else return FunctionAkkerman(m-1, FunctionAkkerman(m, n-1));
}

Console.Write("Input number M (0 <= M <= 2): ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number N (0 <= M <= 2): ");
int numN = Convert.ToInt32(Console.ReadLine());

if (numM >= 0  &&  numM <= 2  && numN >= 0  &&  numN <= 2)
{
    int result;
    result = FunctionAkkerman(numM, numN);
    Console.WriteLine("Akkerman function value is " + result);
}

else Console.WriteLine("Calculation is not possible. Input correct numbers M and N");
