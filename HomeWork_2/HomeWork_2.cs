
//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int TakeSecondDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = (num / 10) - firstDigit*10;

    return secondDigit;
}

Console.Write("Input 3-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int digit2 = TakeSecondDigit(num);
    Console.WriteLine($"Second digit is {digit2}");
}
else
{
    Console.WriteLine("Number is not correct. Please input 3-digit number");
}
*/


// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int TakeThirdDigit(int num)
{
    if (num >= 100 && num <= 999)
    {
        int digit3 = num % 10;
        return digit3;
    }  
    else
    {
        while (num > 999)
        {
            num = num / 10;
        }
        int digit3 = num % 10;
        return digit3;
    }   
}


Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("There is no third digit");
} 
else
{
    int thirdDigit = TakeThirdDigit(number);
    Console.WriteLine($"Third digit is {thirdDigit}");
}
*/


// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool IdentifyWeekDay(int day)
{
    bool check;

    if (day < 6)
        check = false;
    else
        check = true;

    return check;
}

Console.Write("Input week day: ");
int day = Convert.ToInt32(Console.ReadLine());

bool check = IdentifyWeekDay(day);

if (day > 0 && day < 8)
{
    if (check == true)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}
else
    Console.WriteLine("Please input correct week day");
