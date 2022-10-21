
// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// (не использовать массивы)
/*
int CountPositiveNum (int amount)
{
    int count = 0;

    for (int i = 0; i < amount; i++)
    {
        Console.Write("Input number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num > 0)
            count++;
    }
    
    return count;   
}

Console.Write("Input quantity M of numbers: ");
int m = Convert.ToInt32(Console.ReadLine());
int posNumQuant = CountPositiveNum(m);
Console.WriteLine($"User input {posNumQuant} positive numbers");
*/


//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void CrossPoint (double nb1, double nk1, double nb2, double nk2)
{
    double pointY = (nk1*nb2 - nk2*nb1) / (nk1 - nk2);
    double pointX = (pointY - nb1) / nk1;
    Console.WriteLine($"Cross point has the folloing coordinates: X ({pointX}) and Y ({pointY})");
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"First equation has the form: y = {k1} * x + {b1}");
Console.WriteLine($"Second equation has the form: y = {k2} * x + {b2}");

if (k1 == k2)
    Console.WriteLine("The straight lines does not intersect");
else
    CrossPoint(b1, k1, b2, k2);
