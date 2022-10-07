
//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

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


