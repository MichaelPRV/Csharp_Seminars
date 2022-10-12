
// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palindrome(int n)
{
    int digit1 = n / 10000;
    int digit5 = n % 10;
    int digit2 = (n / 1000) % 10;
    int digit4 = (n % 100) / 10; 

    bool check;

    if (digit1 == digit5 && digit2 == digit4)
        check = true;
    else
        check = false;

    return check;
}

Console.Write("Input 5-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

bool check = Palindrome(n);

if (n > 9999 && n < 100000)
    {
        if (check == true)
            Console.WriteLine("The number is palindrome");
        else
            Console.WriteLine("The number is NOT palindrome");
    }
else
    Console.WriteLine("Input correct (5-digit) number");
*/

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distance(double xa, double ya, double za, double xb, double yb, double zb)
{
    double x = xa - xb;
    double y = ya - yb;
    double z = za - zb;

    double distance = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2) + Math.Pow(z,2));
    return distance;
}

Console.Write("Input Xa: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Ya: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Za: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Xb: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Yb: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Zb: ");
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distance is {Distance(xa,ya,za,xb,yb,zb)}");
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cube(int n)
{
    int num = 1;

    while (num < (n + 1))
    {
        Console.Write($"{Math.Pow(num,3)}; ");
        num = num + 1;
    }
}

Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 1)
    Cube(n);
else
    Console.WriteLine("Input correct number (N>1)");
*/
